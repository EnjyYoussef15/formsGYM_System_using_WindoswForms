using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinGYM
{
    public partial class TraineeDeleteForm : Form

    {
        Trainee train = new Trainee();
        Datacontext datacontext = new Datacontext();
        public TraineeDeleteForm()
        {
            InitializeComponent();
        }
        void loadd()
        {
            grdDeleteTrainee.DataSource = datacontext.Trainees.ToList();
        }
        private void btnDeleteTrainee_Click(object sender, EventArgs e)
        {
            int number;
            if (txtTraineeDelete.Text == "" || !int.TryParse(txtTraineeDelete.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Trainee ID";
                lblErrorMsg.Visible = true;
            }
            else
            {
                string messa = "Are you Sure ?";
                string title = "Close Window";
                MessageBoxButtons bb = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show(messa, title, bb);
                if (res == DialogResult.Yes)
                {
                    var objects = datacontext.Trainees.Select(d => d.ID).ToList();

                    if (objects.Contains(int.Parse(txtTraineeDelete.Text)))
                    {
                        var cc = int.Parse(txtTraineeDelete.Text);
                        train = datacontext.Trainees.Where(c => c.ID == cc).FirstOrDefault();
                        datacontext.Trainees.Remove(train);
                        datacontext.SaveChanges();
                        loadd();
                        txtTraineeDelete.Text = "";
                        MessageBox.Show("Trainee Deleted successufly");
                    }
                    else
                    {
                        MessageBox.Show($"There is no Trainee with {txtTraineeDelete.Text} ID ");

                    }

                }
            }

           
        }

        private void btnBask_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TraineeDeleteForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtTraineeDelete;
            loadd();
        }

        private void grdDeleteTrainee_DoubleClick(object sender, EventArgs e)
        {
            if (grdDeleteTrainee.CurrentRow.Index != -1)
            {
                var cc = Convert.ToInt32(grdDeleteTrainee.CurrentRow.Cells["grdTraineeID"].Value);
                train = datacontext.Trainees.Where(c => c.ID == cc).FirstOrDefault();
                txtTraineeDelete.Text = cc.ToString();

            }
        }
    }
}

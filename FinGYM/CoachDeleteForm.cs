
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
    public partial class CoachDeleteForm : Form
    {
        Coach coch = new Coach();
        
        Datacontext datacontext = new Datacontext();    
        public CoachDeleteForm()
        {
            InitializeComponent();

        }
        void Loadd()
        {
            grdCoachDelete.DataSource = datacontext.Choachs.ToList();

        }

   

        private void btnDeleteAndUpdate_Delete_Click(object sender, EventArgs e)
        {
            int number;
           if (txtDeleteCaoch.Text=="" || !int.TryParse(txtDeleteCaoch.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Coach ID";
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
                    var objects = datacontext.Choachs.Select(d => d.ID).ToList();
                    if (objects.Contains(int.Parse(txtDeleteCaoch.Text)))
                    {
                        var cc = int.Parse(txtDeleteCaoch.Text);
                        coch = datacontext.Choachs.Where(c => c.ID == cc).FirstOrDefault();
                        datacontext.Choachs.Remove(coch);
                       
                        datacontext.SaveChanges();
                        Loadd();
                        txtDeleteCaoch.Text = "";
                        MessageBox.Show("Coach Deleted successufly");
                    }
                    else
                    {
                        MessageBox.Show($"There is no Coach with {txtDeleteCaoch.Text} ID ");

                    }
                }
            }

            
            
        }

        private void btnDeleteAndUpdate_Back_Click(object sender, EventArgs e)
        {
            Hide();
        }

      

        private void CoachDeleteForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtDeleteCaoch;
            Loadd();
            
        }

        private void grdCoachDelete_DoubleClick(object sender, EventArgs e)
        {
            if (grdCoachDelete.CurrentRow.Index != -1)
            {
                var cc = Convert.ToInt32(grdCoachDelete.CurrentRow.Cells["grdCoachID"].Value);
                coch = datacontext.Choachs.Where(c => c.ID == cc).FirstOrDefault();
                txtDeleteCaoch.Text = cc.ToString();

            }
        }
    }
}

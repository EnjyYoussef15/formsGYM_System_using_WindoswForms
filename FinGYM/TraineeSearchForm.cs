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
    public partial class TraineeSearchForm : Form
    {
        Trainee train = new Trainee();
        Datacontext datacontext = new Datacontext();
        public TraineeSearchForm()
        {
            InitializeComponent();
        }
        void loadd()
        {
            grdTraineeSearch.DataSource = datacontext.Trainees.ToList();
        }

        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSearchRe_Click(object sender, EventArgs e)
        {
            txtSearch_Search.Text = "";
            ActiveControl = txtSearch_Search;
            loadd();
            lblErrorMsg.Visible = false;
        }

        private void TraineeSearchForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtSearch_Search;
            loadd();
        }

        private void btnSearch_Search_Click(object sender, EventArgs e)

        {
            int number;
            if (txtSearch_Search.Text == "" || !int.TryParse(txtSearch_Search.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Traiee ID";
                lblErrorMsg.Visible = true;
            }
            else
            {
                var objects = datacontext.Trainees.Select(d => d.ID).ToList();
                if (objects.Contains(int.Parse(txtSearch_Search.Text)))
                {
                    var cc = int.Parse(txtSearch_Search.Text);
                    train = datacontext.Trainees.Where(c => c.ID == cc).FirstOrDefault();

                    grdTraineeSearch.DataSource = new List<Trainee> { train };
                    lblErrorMsg.Visible = false;

                }
                else
                {
                    MessageBox.Show($"There is no Trainee with {txtSearch_Search.Text} ID ");
                    loadd();
                    lblErrorMsg.Visible = false;

                }
            }
        }
    }
}

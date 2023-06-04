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
    public partial class CoachSearchForm : Form
    {
        Coach coch = new Coach();
        Datacontext datacontext = new Datacontext();

        public CoachSearchForm()
        {
            InitializeComponent();
        }
        void Loadd()
        {
            grdCoachSearch.DataSource = datacontext.Choachs.ToList();

        }

        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSearchRe_Click(object sender, EventArgs e)
        {
            txtCoach_Search.Text = "";
            ActiveControl = txtCoach_Search;
            Loadd();

        }

        private void CoachSearchForm_Load(object sender, EventArgs e)
        {
            txtCoach_Search.Text = "";
            ActiveControl = txtCoach_Search;
            Loadd();
            lblErrorMsg.Visible = false;
        }

        private void btnCoach_Search_Click(object sender, EventArgs e)
        {
            int number;
            if (txtCoach_Search.Text == "" || !int.TryParse(txtCoach_Search.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in CoachID";
                lblErrorMsg.Visible = true;
            }
            else {
                var objects = datacontext.Choachs.Select(d => d.ID).ToList();
                if (objects.Contains(int.Parse(txtCoach_Search.Text)))
                {
                    var cc = int.Parse(txtCoach_Search.Text);
                    coch = datacontext.Choachs.Where(c => c.ID == cc).FirstOrDefault();

                    grdCoachSearch.DataSource = new List<Coach> { coch };
                    lblErrorMsg.Visible = false;

                }
                else
                {
                    MessageBox.Show($"There is no Coach with {txtCoach_Search.Text} ID ");
                    Loadd();
                    lblErrorMsg.Visible = false;

                }
            }
           
        }

        
    }
}

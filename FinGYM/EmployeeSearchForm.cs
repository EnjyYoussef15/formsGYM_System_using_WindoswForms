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
    public partial class EmployeeSearchForm : Form
    {
        Employee emp = new Employee();
        Datacontext datacontext = new Datacontext();
        public EmployeeSearchForm()
        {
            InitializeComponent();
        }
        void Loadd()
        {
            grdEmpSearch.DataSource = datacontext.Employees.ToList();

        }
        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSearchRe_Click(object sender, EventArgs e)
        {
            txtEmployee_Search.Text= string.Empty;
            ActiveControl = txtEmployee_Search;
            Loadd();

        }

        private void EmployeeSearchForm_Load(object sender, EventArgs e)
        {
            txtEmployee_Search.Text = "";
            ActiveControl = txtEmployee_Search;
            Loadd();
            lblErrorMsg.Visible = false;
        }

        private void btnEmployee_Search_Click(object sender, EventArgs e)
        {
            int number;
            if (txtEmployee_Search.Text == "" || !int.TryParse(txtEmployee_Search.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Employee ID";
                lblErrorMsg.Visible = true;
            }
            else
            {
                var objects = datacontext.Employees.Select(d => d.ID).ToList();
                if (objects.Contains(int.Parse(txtEmployee_Search.Text)))
                {
                    var cc = int.Parse(txtEmployee_Search.Text);
                    emp = datacontext.Employees.Where(c => c.ID == cc).FirstOrDefault();

                    grdEmpSearch.DataSource = new List<Employee> { emp };
                    lblErrorMsg.Visible = false;
                }
                else
                {
                    MessageBox.Show($"There is no Employee with {txtEmployee_Search.Text} ID ");
                    Loadd();
                    lblErrorMsg.Visible = false;
                }
            }
            
        }
    }
}

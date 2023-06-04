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
    public partial class EmployeeDeleteForm : Form
    {
        Employee emp = new Employee();
        Datacontext datacontext = new Datacontext();
        public EmployeeDeleteForm()
        {
            InitializeComponent();
        }
        void Loadd()
        {
            grdDeleteEmployee.DataSource = datacontext.Employees.ToList();

        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int number;
            if (txtEmployeeDelete.Text == "" || !int.TryParse(txtEmployeeDelete.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Employee ID";
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
                    var objects = datacontext.Employees.Select(d => d.ID).ToList();
                    if (objects.Contains(int.Parse(txtEmployeeDelete.Text)))
                    {
                        var cc = int.Parse(txtEmployeeDelete.Text);
                        emp = datacontext.Employees.Where(c => c.ID == cc).FirstOrDefault();
                        datacontext.Employees.Remove(emp);
                        datacontext.SaveChanges();
                        Loadd();
                        txtEmployeeDelete.Text = "";
                        MessageBox.Show("Employee Deleted successufly");
                    }
                    else
                    {
                        MessageBox.Show($"There is no Employee with {txtEmployeeDelete.Text} ID ");

                    }
                }
            

            }
        }

        private void btnBask_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void grdDeleteEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (grdDeleteEmployee.CurrentRow.Index != -1)
            {
                var cc = Convert.ToInt32(grdDeleteEmployee.CurrentRow.Cells["grdEmpID"].Value);
                emp = datacontext.Employees.Where(c => c.ID == cc).FirstOrDefault();
                txtEmployeeDelete.Text = cc.ToString();

            }
        }

        private void EmployeeDeleteForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtEmployeeDelete;
            Loadd();
        }
    }
}

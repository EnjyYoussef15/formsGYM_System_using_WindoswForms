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
    public partial class EmployeeDelete_UpdateForm : Form
    {
        Employee emp= new Employee();
        Datacontext datacontext = new Datacontext();
        public EmployeeDelete_UpdateForm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtDUEmployeeAge.Text =
            txtDUEmployeeID.Text =
            txtDUEmployeeJob.Text =
            txtDUEmployeeName.Text =
            txtDUEmployeePhone.Text =
            txtDUEmployeeSalary.Text = "";
            radioTraineeFemale.Checked =
            radioTraineeMale.Checked =
            lblErrorMsg.Visible=
                false;

        }
        void Loadd()
        {
            grdUpdateEmployee.DataSource = datacontext.Employees.ToList();

        }

        private void btnDeleteAndUpdate_Back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDeleteAndUpdate_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void EmployeeDelete_UpdateForm_Load(object sender, EventArgs e)
        {
           
            ActiveControl = txtDUEmployeeName;
            Loadd();

        }

        private void btnDeleteAndUpdate_Update_Click(object sender, EventArgs e)
        {
            int number;
            double sala;

            if (txtDUEmployeeAge.Text == "" || 
                txtDUEmployeeJob.Text == "" || txtDUEmployeeName.Text == "" ||
                txtDUEmployeePhone.Text == "" || txtDUEmployeeSalary.Text == "")
            {
                MessageBox.Show("Please Enter All the Employee Information");
            }
            else if (int.TryParse(txtDUEmployeeName.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Name";
                lblErrorMsg.Visible = true;
            }

            else if (int.TryParse(txtDUEmployeeJob.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in JobTitle";
                lblErrorMsg.Visible = true;
            }

            else if (!int.TryParse(txtDUEmployeeAge.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Age";
                lblErrorMsg.Visible = true;
            }

            else if (!int.TryParse(txtDUEmployeePhone.Text, out number))

            {
                lblErrorMsg.Text = "Please enter Valid value in phone";
                lblErrorMsg.Visible = true;
            }
            else if (!double.TryParse(txtDUEmployeeSalary.Text, out sala))
            {
                lblErrorMsg.Text = "Please enter Valid value in Salary";
                lblErrorMsg.Visible = true;
            }
            else if (radioTraineeFemale.Checked == false && radioTraineeMale.Checked == false)
            {
                lblErrorMsg.Text = "Please choose gender";
                lblErrorMsg.Visible = true;
            }
            else if (EmployeeHireDate == null)
            {
                lblErrorMsg.Text = "Please enter Valid value Join date";
                lblErrorMsg.Visible = true;
            }
            ///////////////////////////////////////////////////
            else
            {
                string messa = "Are you Sure ?";
                string title = "Close Window";
                MessageBoxButtons bb = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show(messa, title, bb);
                if (res == DialogResult.Yes)
                {
                    emp.HireDate = EmployeeHireDate.Value;
                    emp.name = txtDUEmployeeName.Text;
                    emp.jobTitle = txtDUEmployeeJob.Text;
                    emp.Salary = double.Parse(txtDUEmployeeSalary.Text);
                    emp.Phone = txtDUEmployeePhone.Text;
                    emp.Age = int.Parse(txtDUEmployeeAge.Text);

                    if (radioTraineeFemale.Checked)
                        emp.Gender = radioTraineeFemale.Text;
                    else
                        emp.Gender = radioTraineeMale.Text;

                    emp.manager = emp.manager;
                    Loadd();
                    datacontext.SaveChanges();
                    clear();
                    MessageBox.Show("Emp Updated successufly");

                }
            }
            
        }

        private void grdUpdateEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (grdUpdateEmployee.CurrentRow.Index != -1)
            {
                var cc = Convert.ToInt32(grdUpdateEmployee.CurrentRow.Cells["grdEmpID"].Value);


                emp = datacontext.Employees.Where(c => c.ID == cc).FirstOrDefault();


                txtDUEmployeeID.Text = cc.ToString();
                txtDUEmployeeName.Text = emp.name;
                txtDUEmployeeAge.Text = emp.Age.ToString();
                txtDUEmployeeJob.Text = emp.jobTitle;
                txtDUEmployeePhone.Text = emp.Phone;
                txtDUEmployeeSalary.Text = emp.Salary.ToString();
                EmployeeHireDate.Value = emp.HireDate;
                if(emp.Gender == "Male")
                    radioTraineeMale.Checked = true;
                else
                    radioTraineeFemale.Checked = true;

               

            }
        }
    }
}

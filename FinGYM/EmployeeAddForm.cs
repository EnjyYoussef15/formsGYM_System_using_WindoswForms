
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinGYM
{
    public partial class EmployeeAddForm : Form
    {
        Employee emp = new Employee();
        Datacontext datacontext = new Datacontext();
        public EmployeeAddForm()
        {
            InitializeComponent();
        }

        void clear()
        {
           txtAddEmployeeAge.Text =
           txtAddEmployeeJob.Text =
          
           txtAddEmployeeName.Text =
           txtAddEmployeeSalary.Text =
           txtAddEmployeePhone.Text =
           ComboxEmpMAng.Text="";

           lblErrorMsg.Visible= false;
            radioTraineeFemale.Checked =
            radioTraineeMale.Checked =
                false;
        }
        bool flag = false;
        void addEmp()
        {
            int number;
            double sala;
         
            if (txtAddEmployeeAge.Text == "" || ComboxEmpMAng.Text== ""||
                txtAddEmployeeJob.Text == "" || txtAddEmployeeName.Text == "" ||
                txtAddEmployeePhone.Text == "" || txtAddEmployeeSalary.Text == "")
            {
                MessageBox.Show("Please Enter All the Employee Information");
            }
            else if (int.TryParse(txtAddEmployeeName.Text, out number))
                {
                    lblErrorMsg.Text = "Please enter Valid value in Name";
                    lblErrorMsg.Visible = true;
                }

            else if (int.TryParse(txtAddEmployeeJob.Text, out number))
                {
                    lblErrorMsg.Text = "Please enter Valid value in JobTitle";
                    lblErrorMsg.Visible = true;
                }

            else if (!int.TryParse(txtAddEmployeeAge.Text, out number))
                {
                    lblErrorMsg.Text = "Please enter Valid value in Age";
                    lblErrorMsg.Visible = true;
                }

            else if (txtAddEmployeePhone.Text.Length<11 || !int.TryParse(txtAddEmployeePhone.Text, out number))

                {
                    lblErrorMsg.Text = "Please enter 11 numbers in Phone";
                    lblErrorMsg.Visible = true;
                }
            else if (!double.TryParse(txtAddEmployeeSalary.Text, out sala))
                {
                    lblErrorMsg.Text = "Please enter Valid value in Salary";
                    lblErrorMsg.Visible = true;
                }
            else if (radioTraineeFemale.Checked == false && radioTraineeMale.Checked == false)
                {
                    lblErrorMsg.Text = "Please choose gender";
                    lblErrorMsg.Visible = true;
                }
            else if (EmployeeJoinDate == null)
                {
                    lblErrorMsg.Text = "Please enter Valid value Join date";
                    lblErrorMsg.Visible = true;
                }
            else
            {
                int managerID = (int)(ComboxEmpMAng.SelectedValue);
                emp.manager = datacontext.Mangers.FirstOrDefault(g => g.ID == managerID);

                emp.name = txtAddEmployeeName.Text;
                emp.jobTitle = txtAddEmployeeJob.Text;
                emp.Age = int.Parse(txtAddEmployeeAge.Text);
                emp.Salary = double.Parse(txtAddEmployeeSalary.Text);
                emp.HireDate = EmployeeJoinDate.Value;
                emp.Phone = txtAddEmployeePhone.Text;
                if (radioTraineeFemale.Checked)
                    emp.Gender = radioTraineeFemale.Text;
                else
                    emp.Gender = radioTraineeMale.Text;
                flag = true;
            }
               
        }
        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtAddEmployeeName;
            var CLassMAng = datacontext.Mangers.ToList();
            ComboxEmpMAng.DataSource = CLassMAng;
            ComboxEmpMAng.DisplayMember = "UserName";
            ComboxEmpMAng.ValueMember = "ID";
            CLassMAng = datacontext.Mangers.ToList();
        }

        private void btnTraineeBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnTraineeReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnTraineeSave_Click(object sender, EventArgs e)
        {
            addEmp();
            if (flag)
            {
                datacontext.Employees.Add(emp);
                datacontext.SaveChanges();
                MessageBox.Show("Saved new Employee!");
                clear();

            }
        }
    }
}

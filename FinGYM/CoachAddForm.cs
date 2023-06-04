using FinGYM.BuisnessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;

namespace FinGYM
{
    public partial class CoachAddForm : Form
    {
        Coach coch = new Coach();
        Classes cls = new Classes();
        Datacontext datacontext = new Datacontext();

        FirstTest testing = new FirstTest();
        public CoachAddForm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtAddCoachAge.Text =
            comboxCoachClass.Text=
            comboxCoachMAng.Text=
            txtAddCoachName.Text =
            txtAddCoachPhone.Text =
            txtAddCoachSalary.Text = "";
            lblErrorMsg.Visible = false;

            radioCoachFemale.Checked =
            radioCoachMale.Checked =
                false;
        }

        bool flag = false; 
        void addCoach()
        {
            int number;
            double sala;
            var objects = datacontext.Classes.Select(d => d.ID).ToList();
            
  


            if (txtAddCoachSalary.Text == "" || comboxCoachMAng.Text == "" ||
                txtAddCoachPhone.Text == "" || txtAddCoachName.Text == "" ||
                comboxCoachClass.Text == "" || txtAddCoachAge.Text == "")
            {
                MessageBox.Show("Please Enter All the Coach Information");
            }
            else if (int.TryParse(txtAddCoachName.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Name";
                lblErrorMsg.Visible = true;
            }

            else if (!int.TryParse(txtAddCoachAge.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Age";
                lblErrorMsg.Visible = true;
            }

            else if (txtAddCoachPhone.Text.Length < 11 || !int.TryParse(txtAddCoachPhone.Text, out number))

            {
                lblErrorMsg.Text = "Please enter 11 numbers in Phone";
                lblErrorMsg.Visible = true;
            }
            else if (!double.TryParse(txtAddCoachSalary.Text, out sala))
            {
                lblErrorMsg.Text = "Please enter Valid value in Salary";
                lblErrorMsg.Visible = true;
            }
            else if (radioCoachFemale.Checked == false && radioCoachMale.Checked == false)
            {
                lblErrorMsg.Text = "Please choose gender";
                lblErrorMsg.Visible = true;
            }
            else if (CoachHireDate == null)
            {
                lblErrorMsg.Text = "Please enter Valid value Join date";
                lblErrorMsg.Visible = true;
            }

            else
            {
                coch.name = txtAddCoachName.Text;
              
                coch.age = int.Parse(txtAddCoachAge.Text);
                coch.Salary = double.Parse(txtAddCoachSalary.Text);
                coch.HireDate = CoachHireDate.Value;
                coch.Phone = txtAddCoachPhone.Text;
                if (radioCoachFemale.Checked)
                    coch.gender = radioCoachFemale.Text;
                else
                    coch.gender = radioCoachMale.Text;

                int managerID = (int)(comboxCoachMAng.SelectedValue);
              

                int classID = (int)(comboxCoachClass.SelectedValue);
                coch.classs = datacontext.Classes.FirstOrDefault(g => g.ID == classID);

                //if (objects.Contains(int.Parse(txtAddCoachClass.Text)))
                //    coch.classId = int.Parse(txtAddCoachClass.Text);
                //else
                //{
                //    lblErrorMsg.Text = "Please enter an exist Class";
                //    lblErrorMsg.Visible = true;
                //}
                flag = true;
            }

        }


        private void btnTraineeBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnTraineeReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void CoachAddForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtAddCoachName;

            var CLassMAng = datacontext.Mangers.ToList();
            comboxCoachMAng.DataSource = CLassMAng;
            comboxCoachMAng.DisplayMember = "UserName";
            comboxCoachMAng.ValueMember = "ID";
            CLassMAng = datacontext.Mangers.ToList();

            var CoachClass = datacontext.Classes.ToList();
            comboxCoachClass.DataSource = CoachClass;
            comboxCoachClass.DisplayMember = "Name";
            comboxCoachClass.ValueMember = "ID";
            CoachClass = datacontext.Classes.ToList();
        }

        private void btnTraineeSave_Click(object sender, EventArgs e)
        {
            addCoach();
            if (flag)
            {
                datacontext.Choachs.Add(coch);
                datacontext.SaveChanges();
                MessageBox.Show("Saved new Coach!");
                clear();
            }
        }
    }
}

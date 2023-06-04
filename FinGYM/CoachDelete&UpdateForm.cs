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
    public partial class CoachDelete_UpdateForm : Form
    {

        Coach coch = new Coach();
        Datacontext datacontext = new Datacontext(); 
        public CoachDelete_UpdateForm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtDUCoachAge.Text =
            comboxCoachClass.Text =
            txtDUCoachID.Text =
            txtDUCoachName.Text =
            ttxtDUCoachSalry.Text =
           
            txtDUCoachPhone.Text = "";

            radCoachFemale.Checked =
            radCoachMale.Checked = 
            lblErrorMsg.Visible=
                false;

        }
        void Loadd()
        {
            grdCoachUpdate.DataSource = datacontext.Choachs.ToList();

        }
        private void btnDeleteAndUpdate_Back_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void btnDeleteAndUpdate_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void CoachDelete_UpdateForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtDUCoachName;
            Loadd();

            var CoachClass = datacontext.Classes.ToList();
            comboxCoachClass.DataSource = CoachClass;
            comboxCoachClass.DisplayMember = "Name";
            comboxCoachClass.ValueMember = "ID";
            CoachClass = datacontext.Classes.ToList();

        }

        private void btnDeleteAndUpdate_Update_Click(object sender, EventArgs e)
        {

            int number;
            double sala;
          

            if (ttxtDUCoachSalry.Text == "" || comboxCoachClass.Text == "" ||
                txtDUCoachPhone.Text == "" || txtDUCoachName.Text == "" ||
                txtDUCoachAge.Text == "")
            {
                MessageBox.Show("Please Enter All the Coach Information");
            }
            else if (int.TryParse(txtDUCoachName.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Name";
                lblErrorMsg.Visible = true;
            }

            else if (!int.TryParse(txtDUCoachAge.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Age";
                lblErrorMsg.Visible = true;
            }

            else if ( !int.TryParse(txtDUCoachPhone.Text, out number))

            {
                lblErrorMsg.Text = "Please enter Valid value in phone";
                lblErrorMsg.Visible = true;
            }
            else if (!double.TryParse(ttxtDUCoachSalry.Text, out sala))
            {
                lblErrorMsg.Text = "Please enter Valid value in Salary";
                lblErrorMsg.Visible = true;
            }
            else if (radCoachFemale.Checked == false && radCoachMale.Checked == false)
            {
                lblErrorMsg.Text = "Please choose gender";
                lblErrorMsg.Visible = true;
            }
            else if (CoachHireDate == null)
            {
                lblErrorMsg.Text = "Please enter Valid value Join date";
                lblErrorMsg.Visible = true;
            }
            /////////////////////////////////////////////////

            else
            {
                string messa = "Are you Sure ?";
                string title = "Close Window";
                MessageBoxButtons bb = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show(messa, title, bb);
                if (res == DialogResult.Yes)
                {
                    coch.HireDate = CoachHireDate.Value;
                    coch.name = txtDUCoachName.Text;

                    coch.Salary = double.Parse(ttxtDUCoachSalry.Text);
                    coch.Phone = txtDUCoachPhone.Text;
                    coch.age = int.Parse(txtDUCoachAge.Text);


                    int classID = (int)(comboxCoachClass.SelectedValue);
                    coch.classs = datacontext.Classes.FirstOrDefault(g => g.ID == classID);



                    if (radCoachFemale.Checked)
                        coch.gender = radCoachFemale.Text;
                    else
                        coch.gender = radCoachMale.Text;

                    datacontext.SaveChanges();
                    Loadd();
                    clear();
                    MessageBox.Show("Coach Updated successufly");
                }
            }
        }

       
        private void grdCoachUpdate_DoubleClick(object sender, EventArgs e)
        {
            if (grdCoachUpdate.CurrentRow.Index != -1)
            {
                var cc = Convert.ToInt32(grdCoachUpdate.CurrentRow.Cells["grdCoachID"].Value);


                coch = datacontext.Choachs.Where(c => c.ID == cc).FirstOrDefault();


                txtDUCoachID.Text = cc.ToString();
                txtDUCoachName.Text = coch.name;
                txtDUCoachAge.Text = coch.age.ToString();
              
                txtDUCoachPhone.Text = coch.Phone;
                ttxtDUCoachSalry.Text = coch.Salary.ToString();
                CoachHireDate.Value = coch.HireDate;
                comboxCoachClass.Text = coch.ClassName;
                if (coch.gender == "Male")
                    radCoachMale.Checked = true;
                else
                    radCoachFemale.Checked = true;



            }
        }
    }
}

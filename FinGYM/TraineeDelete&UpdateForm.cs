using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinGYM
{
    public partial class TraineeDelete_UpdateForm : Form
    {
        Trainee train = new Trainee();
        Datacontext datacontext = new Datacontext(); 
        public TraineeDelete_UpdateForm()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtDeleteAndUpdateName.Text =
            txtDeleteAndUpdateAge.Text =
            txtDeleteAndUpdatePhone.Text =
            txtDeleteAndUpdateID.Text =
            txtTraineeDuration.Text =

            comboxCoachClass.Text=
            comboxCoachMAng.Text=
            comboxTrainCoach.Text=

            txtDeleteAndUpdateSubFee.Text = "";
            //traineeCoach.Text = 
            //TraineeClass.Text=



            radioTraineeFemale.Checked =
            radioTraineeMale.Checked =
                false;
        }

        void loadd()
        {
            grdTraineeUpdate.DataSource = datacontext.Trainees.ToList();
         
        }
        private void btnDeleteAndUpdate_Back_Click(object sender, EventArgs e)
        {
            Hide();
        }

       
        private void btnDeleteAndUpdate_Reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDeleteAndUpdate_Update_Click(object sender, EventArgs e)
        {
            int number;
            double sala;

            if (txtDeleteAndUpdateAge.Text == "" || txtDeleteAndUpdateSubFee.Text == "" ||
                comboxCoachMAng.Text == "" || comboxTrainCoach.Text == "" ||
                comboxCoachClass.Text == "" || txtTraineeDuration.Text == "" ||
                txtDeleteAndUpdateName.Text == "" || txtDeleteAndUpdatePhone.Text == "")
            {
                MessageBox.Show("Please Enter All the Traine Information");

            }
            else if (int.TryParse(txtDeleteAndUpdateName.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Name";
                lblErrorMsg.Visible = true;
            }

            else if (!int.TryParse(txtDeleteAndUpdateAge.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Age";
                lblErrorMsg.Visible = true;
            }
            else if (txtDeleteAndUpdatePhone.Text.Length < 11 || !int.TryParse(txtDeleteAndUpdatePhone.Text, out number))

            {
                lblErrorMsg.Text = "Please enter Valid value in phone";
                lblErrorMsg.Visible = true;
            }
            else if (!double.TryParse(txtDeleteAndUpdateSubFee.Text, out sala))
            {
                lblErrorMsg.Text = "Please enter Valid value in Salary";
                lblErrorMsg.Visible = true;
            }
            else if (radioTraineeFemale.Checked == false && radioTraineeMale.Checked == false)
            {
                lblErrorMsg.Text = "Please choose gender";
                lblErrorMsg.Visible = true;
            }
            else if ( DeleteAndUpdateJoinDate == null)
            {
                lblErrorMsg.Text = "Please enter Valid value Join date";
                lblErrorMsg.Visible = true;
            }
            else if (!int.TryParse(txtTraineeDuration.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Duration";
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
                    train.StartJoinDate = DeleteAndUpdateJoinDate.Value;
                    train.name = txtDeleteAndUpdateName.Text;
                    train.Duration = int.Parse(txtTraineeDuration.Text);
                    train.SubtractionFees = double.Parse(txtDeleteAndUpdateSubFee.Text);
                    train.Phone = txtDeleteAndUpdatePhone.Text;
                    train.age = int.Parse(txtDeleteAndUpdateAge.Text);
                    int managerID = (int)(comboxCoachMAng.SelectedValue);
                    train.manger = datacontext.Mangers.FirstOrDefault(g => g.ID == managerID);

                    int classID = (int)(comboxCoachClass.SelectedValue);
                    train.clas = datacontext.Classes.FirstOrDefault(g => g.ID == classID);

                    int CoachID = (int)(comboxTrainCoach.SelectedValue);
                    train.coach = datacontext.Choachs.FirstOrDefault(g => g.ID == CoachID);

                    if (radioTraineeFemale.Checked)
                        train.gender = radioTraineeFemale.Text;
                    else
                        train.gender = radioTraineeMale.Text;

                    datacontext.SaveChanges();
                    loadd();
                    clear();
                    MessageBox.Show("Trainee Updated successufly");
                }
            }

            ////////////////////////////////////////////////////////
            
        }

        private void TraineeDelete_UpdateForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtDeleteAndUpdateName;
            loadd();
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

            var traineeCoach = datacontext.Choachs.ToList();
            comboxTrainCoach.DataSource = traineeCoach;
            comboxTrainCoach.DisplayMember = "Name";
            comboxTrainCoach.ValueMember = "ID";
            traineeCoach = datacontext.Choachs.ToList();


        }

        private void grdTraineeUpdate_DoubleClick(object sender, EventArgs e)
        {
            if (grdTraineeUpdate.CurrentRow.Index != -1)
            {
                var cc = Convert.ToInt32(grdTraineeUpdate.CurrentRow.Cells["grdTeaineeID"].Value);


                train = datacontext.Trainees.Where(c => c.ID == cc).FirstOrDefault();


                txtDeleteAndUpdateID.Text = cc.ToString();
                txtDeleteAndUpdateName.Text = train.name;
                txtDeleteAndUpdateAge.Text = train.age.ToString();
                txtTraineeDuration.Text = train.Duration.ToString();
                txtDeleteAndUpdatePhone.Text = train.Phone;
                txtDeleteAndUpdateSubFee.Text = train.SubtractionFees.ToString();
                DeleteAndUpdateJoinDate.Value = train.StartJoinDate;
                comboxCoachClass.Text = train.clas.name;
                comboxCoachMAng.Text = train.manger.UserName;
                comboxTrainCoach.Text = train.coach.name;


                //traineeCoach.Text = train.coachNAme;
                //TraineeClass.Text = train.ClassNAme;
                if (train.gender == "Male")
                    radioTraineeMale.Checked = true;
                else
                    radioTraineeFemale.Checked = true;



            }
        }
    }
}

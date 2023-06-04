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
    public partial class TraineeAddForm : Form
    {
        Trainee traine = new Trainee();
        Classes cls = new Classes();

        Coach coa = new Coach();
       
        Datacontext datacontext = new Datacontext();
        public TraineeAddForm()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtTraineeName.Text =
            txtTraineeAge.Text =
            comboxTrainCoach.Text =
            comboxCoachMAng.Text =
            comboxCoachClass.Text =
            txtTraineePhone.Text =
            txtTraineeDuration.Text =
            txtTraineeSubscriptionFee.Text="";
          
            lblErrorMsg.Visible = false;

            radioTraineeFemale.Checked =
            radioTraineeMale.Checked =
                false;
        }
      
        bool flag = false;
        void addTrainee()
        {
            int number;
            double sala;
        
            if (txtTraineeAge.Text == "" || txtTraineeSubscriptionFee.Text== "" ||
                comboxCoachMAng.Text == ""|| comboxTrainCoach.Text == "" ||
                comboxCoachClass.Text == "" || txtTraineeDuration.Text == "" ||
                txtTraineeName.Text == "" || txtTraineePhone.Text == "")
            {
                MessageBox.Show("Please Enter All the Traine Information");
               
            }
            else if (int.TryParse(txtTraineeName.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Name";
                lblErrorMsg.Visible = true;
            }

            else if (!int.TryParse(txtTraineeAge.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Age";
                lblErrorMsg.Visible = true;
            }
            else if (txtTraineePhone.Text.Length < 11 || !int.TryParse(txtTraineePhone.Text, out number))

            {
                lblErrorMsg.Text = "Please enter Valid value in phone";
                lblErrorMsg.Visible = true;
            }
            else if (!double.TryParse(txtTraineeSubscriptionFee.Text, out sala))
            {
                lblErrorMsg.Text = "Please enter Valid value in Subtraction Fees";
                lblErrorMsg.Visible = true;
            }
            else if (radioTraineeFemale.Checked == false && radioTraineeMale.Checked == false)
            {
                lblErrorMsg.Text = "Please choose gender";
                lblErrorMsg.Visible = true;
            }
            else if (TraineeJoinDate == null)
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

               
                traine.name = txtTraineeName.Text;

                traine.age = int.Parse(txtTraineeAge.Text);
                traine.SubtractionFees = double.Parse(txtTraineeSubscriptionFee.Text);
                traine.StartJoinDate = TraineeJoinDate.Value;
                traine.Phone = txtTraineePhone.Text;
                traine.Duration = int.Parse(txtTraineeDuration.Text);

                int managerID = (int)(comboxCoachMAng.SelectedValue);
                traine.manger = datacontext.Mangers.FirstOrDefault(g => g.ID == managerID);

                int classID = (int)(comboxCoachClass.SelectedValue);
                traine.clas = datacontext.Classes.FirstOrDefault(g => g.ID == classID);

                int CoachID = (int)(comboxTrainCoach.SelectedValue);
                traine.coach = datacontext.Choachs.FirstOrDefault(g => g.ID == CoachID);

                //traine.coachNAme = traineeCoach.Text;
                //traine.ClassNAme = TraineeClass.Text;



                //traine.coach = coa;
                //foreach(var a in traineeClassList.Items)
                //{
                //    cls.Append(a);
                //}

                //traine.classes = cls;

                if (radioTraineeFemale.Checked)
                    traine.gender = radioTraineeFemale.Text;
                else
                    traine.gender = radioTraineeMale.Text;
              
                flag = true;
            }

        }
        private void TraineeAddForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtTraineeName;

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

       
        private void btnTraineeBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnTraineeReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTraineeSave_Click(object sender, EventArgs e)
        {
            addTrainee();
            if (flag)
            {
                datacontext.Trainees.Add(traine);
                datacontext.SaveChanges();
                MessageBox.Show("Saved new Trainee!");
                clear();

            }
        }

        private void comboxCoachMAng_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

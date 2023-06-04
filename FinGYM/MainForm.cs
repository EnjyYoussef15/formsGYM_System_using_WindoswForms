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
    public partial class MainForm : Form
    {
        LoginForm lg = new LoginForm();
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        bool b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraineeAddForm tadd = new TraineeAddForm();
            tadd.Show();
        }

        private void coutchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachAddForm caf = new CoachAddForm();
            caf.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAddForm employee = new EmployeeAddForm();
            employee.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquepmentAddForm equepmentAddForm = new EquepmentAddForm(); 
            equepmentAddForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentDeleteForm edu = new EquipmentDeleteForm();
            edu.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquepmentSearchForm esf = new EquepmentSearchForm();
            esf.Show();
        }

        private void coachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachSearchForm csf = new CoachSearchForm();
            csf.Show();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeSearchForm employeeSearchForm = new EmployeeSearchForm();  
            employeeSearchForm.Show();
        }

        private void traineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraineeSearchForm tra = new TraineeSearchForm();
            tra.Show();
        }

        private void coachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CoachDeleteForm co = new CoachDeleteForm();
            co.Show();
        }

        private void emplyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDeleteForm employeeDeleteForm = new EmployeeDeleteForm();
            employeeDeleteForm.Show();
        }

        private void traineeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TraineeDeleteForm traineeDeleteForm = new TraineeDeleteForm();
            traineeDeleteForm.Show();
        }

      
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lg.Show();
            Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void coashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachDelete_UpdateForm cdu = new CoachDelete_UpdateForm();
            cdu.Show();
        }

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmployeeDelete_UpdateForm edu = new EmployeeDelete_UpdateForm();
            edu.Show();
        }

        private void traineeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TraineeDelete_UpdateForm traine = new TraineeDelete_UpdateForm();
            traine.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashForm df = new DashForm();
            df.Show();
        }

        private void newClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassAddForm caf = new ClassAddForm();
            caf.Show();
        }

        private void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassUpdateForm CUF = new ClassUpdateForm();
            CUF.Show();
        }

        private void upDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquepmentDelete_UpdateForm equpdate = new EquepmentDelete_UpdateForm();
            equpdate.Show();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\EF\FinGYM\arrow-right.jpg");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\EF\FinGYM\down-arrow.jpg");

            }
        }

        private void ClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

        private void addMangerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddMangerForm adm = new AddMangerForm();
            adm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using FinGYM.BuisnessLogic;
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
    public partial class ChangePasswordForm : Form
    {
        Manger mang = new Manger();
        Datacontext datacontext = new Datacontext();
        FirstTest testing = new FirstTest();
        public ChangePasswordForm()
        {
            InitializeComponent();
            ActiveControl = txtUsernAme;
        }

        void clear()
        {
            txtAddNewPassword.Text =
            txtChangeOldPassword.Text =
            txtConfirmNewPassword.Text =
            txtUsernAme.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBackChangePass_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSaveNewPass_Click(object sender, EventArgs e)
        {
            string res = testing.ChangePass(txtUsernAme.Text, txtChangeOldPassword.Text, txtAddNewPassword.Text, txtConfirmNewPassword.Text);
            if (res == "Done")
            {
                if (testing.CheckYesOrnot())
                {
                    mang.PassWord = txtConfirmNewPassword.Text;
                    datacontext.SaveChanges();
                    MessageBox.Show("Password Change successufly");
                    clear();
                }

                
            }
            else
            {
                notConfirm.Text = res;
                notConfirm.Visible = true;
            }
        }
    }

        


        
}

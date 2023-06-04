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
    public partial class LoginForm : Form
    {
        Manger mang = new Manger();
        Datacontext datacontext = new Datacontext();
        FirstTest testing = new FirstTest();

        public LoginForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainPage = new MainForm();
            string res= testing.Login(txtLoginName.Text , txtLoginPass.Text );
            if (res == "Found")
            {
                mainPage.Show();
                Hide();
            }
            else
            {
                labelWrongUserNameOrPassowrd.Visible = true;
                labelWrongUserNameOrPassowrd.Text = res;
            }

        }
        private void lblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(); 
            form.Show();
        }

    }
}

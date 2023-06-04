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
    public partial class AddMangerForm : Form
    {
        Manger mang= new Manger();
        Datacontext datacontext = new Datacontext();
        FirstTest testing= new FirstTest();
        public AddMangerForm()
        {
            InitializeComponent();
        }

        private void AddMangerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            string res = testing.AddManger( txtUserName.Text, txtpass.Text);
            if (res == "Done")
            {
                mang.UserName = txtUserName.Text;
                mang.PassWord = txtpass.Text;
                datacontext.Mangers.Add(mang);
                datacontext.SaveChanges();
                MessageBox.Show("Manger Add successufly");
                txtUserName.Text = txtpass.Text = "";
            }
            else
            {

                labelWrongUserNameOrPassowrd.Visible = true;
                labelWrongUserNameOrPassowrd.Text = res;
                
            }
            //var objects = datacontext.Mangers.Select(d => d.UserName).ToList();

            //if (objects.Contains(txtUserName.Text) )
            //{
            //    labelWrongUserNameOrPassowrd.Visible = true;
            //    labelWrongUserNameOrPassowrd.Text = $"There is Alraedy manger {txtUserName.Text} ";
            //}


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

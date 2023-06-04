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
    public partial class ClassAddForm : Form
    {
        Classes classs = new Classes();
        Datacontext datacontext = new Datacontext();
        FirstTest testing = new FirstTest();
        public ClassAddForm()
        {
            InitializeComponent();
        }
        void clear()
        {
           ComboxClassMAng.Text=
           txtClassNme.Text = "";
        }
        private void ClassAddForm_Load(object sender, EventArgs e)
        {
            clear();
            var CLassMAng = datacontext.Mangers.ToList();
            ComboxClassMAng.DataSource = CLassMAng;
            ComboxClassMAng.DisplayMember = "UserName";
            ComboxClassMAng.ValueMember = "ID";
            CLassMAng = datacontext.Mangers.ToList();

            ActiveControl = txtClassNme;
        }

        private void btnAddClassReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdateClassBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnClassAdd_Click(object sender, EventArgs e)
        {
        
            string res = testing.ClasstName( txtClassNme.Text);
            if(res == "Done" && ComboxClassMAng.Text != "")
            
            {
                int managerID = (int)(ComboxClassMAng.SelectedValue);
                classs.manger = datacontext.Mangers.FirstOrDefault(g => g.ID == managerID);
                classs.name = txtClassNme.Text;
                datacontext.Classes.Add(classs);
                datacontext.SaveChanges();
                clear();
                MessageBox.Show("Class Add successufly");
            }
            else
            {
                ErrorMsg.Text = res;
                ErrorMsg.Visible = true;
            }





        }
    }
}

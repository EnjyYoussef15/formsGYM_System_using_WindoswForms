using FinGYM.BuisnessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinGYM
{
    public partial class ClassUpdateForm : Form
    {
        Classes classs = new Classes();
        Datacontext datacontext = new Datacontext();
        FirstTest testing = new FirstTest();
        public ClassUpdateForm()
        {
            InitializeComponent();
        }

        void clear()
        {
           
            txtClassID.Text=
            txtClassNme.Text = "";
        }

        void Loadd()
        {
            grdClassUpdate.DataSource = datacontext.Classes.ToList();
            
        }
        private void ClassUpdateForm_Load(object sender, EventArgs e)
        {
            clear();
            ActiveControl = txtClassNme;
            Loadd();
        }

        private void btnUpdateClassBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnUpdateClassReset_Click(object sender, EventArgs e)
        {
            
            if (testing.CheckYesOrnot())
            {
                var cc = int.Parse(txtClassID.Text);
                classs = datacontext.Classes.Where(c => c.ID == cc).FirstOrDefault();
                datacontext.Classes.Remove(classs);
                datacontext.SaveChanges();
                Loadd();
                clear();
                MessageBox.Show("Class Deleted successufly");

            }
        }

        private void btnUpdateClassSave_Click(object sender, EventArgs e)
        {
            string res = testing.ClasstName(txtClassNme.Text);
            
            if (res == "Done")

            {
                if (testing.CheckYesOrnot())
                {
                    classs.name = txtClassNme.Text;
                    Loadd();
                    datacontext.SaveChanges();
                    clear();
                    MessageBox.Show("Class Updated successufly");
                }
            else
            {
                ErrorMsg.Text = res;
                ErrorMsg.Visible = true;
            }
        
            }




        }

        private void grdClassUpdate_DoubleClick(object sender, EventArgs e)
        {
            
            
            if (grdClassUpdate.CurrentRow.Index != -1)
            {
               var cc= Convert.ToInt32(grdClassUpdate.CurrentRow.Cells["grdClassID"].Value);
                classs =datacontext.Classes.Where(c => c.ID == cc).FirstOrDefault();
                //int managerID = (int)(txtcomboManager.SelectedValue);
                //coach.manager = context.managers.FirstOrDefault(g => g.ID == managerID);

                txtClassID.Text = cc.ToString();
                txtClassNme.Text = classs.name;

              

            }
        }

    }
}

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
    public partial class EquipmentDeleteForm : Form
    {
        Equipments equp = new Equipments();
        Datacontext datacontext = new Datacontext();    
        public EquipmentDeleteForm()
        {
            InitializeComponent();
        }


        void Loadd()
        {
            grdDeleteEquipment.DataSource = datacontext.Equipments.ToList();
        }
        private void EquipmentDeleteForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtEquipmentDelete;
            Loadd();
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            int number;
            if (txtEquipmentDelete.Text == "" || !int.TryParse(txtEquipmentDelete.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Equepment ID";
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

                    var objects = datacontext.Equipments.Select(d => d.ID).ToList();
                    if (objects.Contains(int.Parse(txtEquipmentDelete.Text)))
                    {
                        var cc = int.Parse(txtEquipmentDelete.Text);
                        equp = datacontext.Equipments.Where(c => c.ID == cc).FirstOrDefault();
                        datacontext.Equipments.Remove(equp);
                        datacontext.SaveChanges();
                        Loadd();
                        txtEquipmentDelete.Text = "";
                        MessageBox.Show("Equepment Deleted successufly");
                    }
                    else
                    {
                        MessageBox.Show($"There is no Equepment with {txtEquipmentDelete.Text} ID ");

                    }
                }
            }
            
        }

        private void btnBask_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void grdDeleteEquipment_DoubleClick(object sender, EventArgs e)
        {
            if (grdDeleteEquipment.CurrentRow.Index != -1)
            {
                var cc = Convert.ToInt32(grdDeleteEquipment.CurrentRow.Cells["grdEqupID"].Value);
                equp = datacontext.Equipments.Where(c => c.ID == cc).FirstOrDefault();
                txtEquipmentDelete.Text = cc.ToString();

            }
        }
    }
}

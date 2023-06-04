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
    public partial class EquepmentDelete_UpdateForm : Form
    {
        Equipments equp = new Equipments();
        Datacontext datacontext = new Datacontext();
        public EquepmentDelete_UpdateForm()
        {
            InitializeComponent();
         
        }
        void clear()
        {
            txtEqupmentID.Text = 
            Txt_equipment_equipmentname.Text =
            Txt_equipment_price.Text =
            Txt_equipment_product_num.Text =
            Txt_equipment_total_price.Text = "";

            lblErrorMsg.Visible = false;
        }
        void Loadd()
        {
            grdEqupUpdate.DataSource = datacontext.Equipments.ToList();
        }

        private void Btn_equipment_Back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Btn_equipment_update_Click(object sender, EventArgs e)
        {
            int number;
            double sala;
            var objects = datacontext.Classes.Select(d => d.ID).ToList();

            if (Txt_equipment_equipmentname.Text == "" ||
                Txt_equipment_price.Text == "" ||
                Txt_equipment_product_num.Text == "" || Txt_equipment_delivery.Checked == false)
            {
                MessageBox.Show("Please Enter All the Equepment Information");
            }
            else if (int.TryParse(Txt_equipment_equipmentname.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Name";
                lblErrorMsg.Visible = true;
            }

            else if (!double.TryParse(Txt_equipment_price.Text, out sala))
            {
                lblErrorMsg.Text = "Please enter Valid value in Price";
                lblErrorMsg.Visible = true;
            }

            else if (!int.TryParse(Txt_equipment_product_num.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Product Number";
                lblErrorMsg.Visible = true;
            }
         

            else if (Txt_equipment_delivery == null)
            {
                lblErrorMsg.Text = "Please enter Valid value Delivery date";
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
                    equp.DeleivryDate = Txt_equipment_delivery.Value;
                    equp.name = Txt_equipment_equipmentname.Text;
                    equp.totalNumber = int.Parse(Txt_equipment_product_num.Text);

                    equp.price = double.Parse(Txt_equipment_price.Text);

                    equp.manager = equp.manager;





                    datacontext.SaveChanges();
                    Loadd();
                    clear();
                    MessageBox.Show("Euepment Updated successufly"); ;
                }
            }


            ///////////////////////////////////////////
            
        }

        private void EquepmentDelete_UpdateForm_Load(object sender, EventArgs e)
        {
            ActiveControl = Txt_equipment_equipmentname;
            Loadd();
        }

        private void btnEqupReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void grdEqupUpdate_DoubleClick(object sender, EventArgs e)
        {
            if (grdEqupUpdate.CurrentRow.Index != -1)
            {
                var cc = Convert.ToInt32(grdEqupUpdate.CurrentRow.Cells["gedEqupID"].Value);


                equp = datacontext.Equipments.Where(c => c.ID == cc).FirstOrDefault();


                txtEqupmentID.Text = cc.ToString();
                Txt_equipment_equipmentname.Text = equp.name;
                Txt_equipment_product_num.Text = equp.totalNumber.ToString();

                Txt_equipment_price.Text = equp.price.ToString();
                Txt_equipment_total_price.Text = equp.totalPrice.ToString();
               
                Txt_equipment_delivery.Value = equp.DeleivryDate;
             


            }
        }
    }
}

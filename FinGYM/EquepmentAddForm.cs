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
    public partial class EquepmentAddForm : Form
    {
        Equipments equp = new Equipments();
        Datacontext datacontext = new Datacontext();
        public EquepmentAddForm()
        {
            InitializeComponent();
        }

        private void Btn_equipment_back_equipment_Click(object sender, EventArgs e)
        {
            Hide();
        }
        void clear()
        {
            Txt_equipment_equipmentname.Text =
            Txt_equipment_price.Text =
            ComboxEqupMAng.Text=
            lblErrorMsg.Text=
            Txt_equipment_product_num.Text = "";
        }

        bool flag = false;

        void addEupment()
        {
            int number;
            double sala;
            var objects = datacontext.Classes.Select(d => d.ID).ToList();

            if (Txt_equipment_equipmentname.Text == "" ||
                Txt_equipment_price.Text == "" || ComboxEqupMAng.Text== "" ||
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
                int managerID = (int)(ComboxEqupMAng.SelectedValue);
                equp.manager = datacontext.Mangers.FirstOrDefault(g => g.ID == managerID);

                equp.name = Txt_equipment_equipmentname.Text;
                equp.totalNumber = int.Parse(Txt_equipment_product_num.Text);
                equp.price = double.Parse(Txt_equipment_price.Text);
               
                equp.DeleivryDate = Txt_equipment_delivery.Value;
                flag = true;
            }

        }
        private void Btn_equipment_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_equipment_add_Click(object sender, EventArgs e)
        {
            addEupment();
            if (flag)
            {
                datacontext.Equipments.Add(equp);
                datacontext.SaveChanges();
                clear();
                MessageBox.Show("Saved new Equepment!");
                

            }
        }

        private void EquepmentAddForm_Load(object sender, EventArgs e)
        {
            ActiveControl = Txt_equipment_equipmentname;

            var CLassMAng = datacontext.Mangers.ToList();
            ComboxEqupMAng.DataSource = CLassMAng;
            ComboxEqupMAng.DisplayMember = "UserName";
            ComboxEqupMAng.ValueMember = "ID";
            CLassMAng = datacontext.Mangers.ToList();
        }
    }
}

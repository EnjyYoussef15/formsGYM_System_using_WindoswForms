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
    public partial class EquepmentSearchForm : Form
    {
        Equipments equp = new Equipments();
        Datacontext datacontext = new Datacontext();
        public EquepmentSearchForm()
        {
            InitializeComponent();
        }
        void Loadd()
        {
            grdEqupSearch.DataSource = datacontext.Equipments.ToList();
        }
        private void Btn_equipment_back_equipment_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnEquRefresh_Click(object sender, EventArgs e)
        {
            txtEqupSearch.Text = "";
            ActiveControl = txtEqupSearch;
            Loadd();
        }

        private void EquepmentSearchForm_Load(object sender, EventArgs e)
        {
            txtEqupSearch.Text = "";
            ActiveControl = txtEqupSearch;
            Loadd();
            lblErrorMsg.Visible = false;

        }

        private void btnEquSearch_Click(object sender, EventArgs e)
        {
            int number;
            if (txtEqupSearch.Text == "" || !int.TryParse(txtEqupSearch.Text, out number))
            {
                lblErrorMsg.Text = "Please enter Valid value in Equepment ID";
                lblErrorMsg.Visible = true;
            }
            else
            {
                var objects = datacontext.Equipments.Select(d => d.ID).ToList();
                if (objects.Contains(int.Parse(txtEqupSearch.Text)))
                {
                    var cc = int.Parse(txtEqupSearch.Text);
                    equp = datacontext.Equipments.Where(c => c.ID == cc).FirstOrDefault();

                    grdEqupSearch.DataSource = new List<Equipments> { equp };
                    lblErrorMsg.Visible = false;
                }
                else
                {
                    MessageBox.Show($"There is no Euepment with {txtEqupSearch.Text} ID ");
                    Loadd();
                    lblErrorMsg.Visible = false;

                }
            }
           
        }
    }
}

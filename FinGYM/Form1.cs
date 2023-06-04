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
    public partial class Welcomeform : Form
    {
        public Welcomeform()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm lf = new LoginForm();
            lf.Show();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_LTWin
{
    public partial class FSeller_Layout : Form
    {
        public FSeller_Layout()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FSeller_Layout_Load(object sender, EventArgs e)
        {

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            userControlCategory1.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            userControlCategory1.Visible = false;

        }

        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            userControlCategory1.Visible = true;

        }

        private void btnBuyer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHome fhome = new FHome();
            fhome.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();
            this.Close();
        }
    }
}

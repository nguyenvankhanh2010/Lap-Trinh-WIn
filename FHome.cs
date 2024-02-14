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
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();
            this.Close();
        }

        private void btnSellerPage_Click(object sender, EventArgs e)
        {
            FSeller fSeller = new FSeller();
            this.Hide();
            fSeller.ShowDialog();
            this.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FAccount fAccount = new FAccount();
            this.Hide();
            fAccount.ShowDialog();
            this.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            FCart fCart = new FCart();
            this.Hide();
            fCart.ShowDialog();
            this.Show();

        }
    }
}

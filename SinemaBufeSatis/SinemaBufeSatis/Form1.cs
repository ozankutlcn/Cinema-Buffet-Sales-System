using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufeSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int totalPrice;
        int totalCase;

        private void button1_Click(object sender, EventArgs e)
        {
            int popcornTotalCount = int.Parse(txtMisir.Text);
            int waterTotalCount = int.Parse(txtSu.Text);
            int teaTotalCount = int.Parse(txtCay.Text);
            int ticketTotalCount = int.Parse(txtBilet.Text);
            int totalPrice = (popcornTotalCount * 4) + (waterTotalCount * 1) + (teaTotalCount * 2) + (ticketTotalCount * 8);
            totalCase = totalCase + totalPrice;
            lblToplam.Text = totalPrice.ToString();
            lblKasa.Text = totalCase.ToString();
            
        }

        private void txtTemizle_Click(object sender, EventArgs e)
        {
            lblToplam.Text = "00";
            lblKasa.Text = "00";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKNPCParts_Layout
{
    public partial class Storage_Devices : TKNPCPart_Layout
    {
        public Storage_Devices()
        {
            InitializeComponent();
        }

        public void showCartMessage()
        {
            MessageBox.Show("Your Item has been added to cart!", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Samsung 970 EVO", "SSD", 200);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Samsung 980 EVO", "SSD", 300);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Samsung 870 EVO", "SSD", 100);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Samsung 870 QVO", "SSD", 150);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Western Digital BLUE SN550", "SSD", 400);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Western Digital BLACK SN770", "SSD", 260);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Western Digital BLUE SATA", "SSD", 190);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Western Digital RED SA500", "SSD", 150);

            part.AddToCart(part);

            showCartMessage();
        }
    }
}

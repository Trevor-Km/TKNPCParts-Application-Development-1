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
    public partial class Motherboards : TKNPCPart_Layout
    {
        public Motherboards()
        {
            InitializeComponent();
        }

        public void showCartMessage()
        {
            MessageBox.Show("Your Item has been added to cart!", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addToCartButton1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("ASUS ROG Strix Z790-A", "Motherboard", 400);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("ASUS AM4 TUF Gaming", "Motherboard", 260);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("ASUS Prime H510M-E LGA1200", "Motherboard", 190);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("ASUS ROG Strix Z690-E Gaming WiFi 6E LGA 1700", "Motherboard", 300);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("MSI MPG Z790 Carbon", "Motherboard", 500);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("MSI Meg X570 Unify", "Motherboard", 420);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("MSI MPG X670 Carbon", "Motherboard", 615);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("MSI MPG B650 Carbon", "Motherboard", 350);

            part.AddToCart(part);

            showCartMessage();
        }
    }
}

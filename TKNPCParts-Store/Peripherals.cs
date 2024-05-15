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
    public partial class Peripherals : TKNPCPart_Layout
    {
        public Peripherals()
        {
            InitializeComponent();
        }

        public void showCartMessage()
        {
            MessageBox.Show("Your Item has been added to cart!", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addToCartButton1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Logitech G915 TKL", "Keyboard", 440);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Logitech G815 LIGHTSYNC", "Keyboard", 350);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Logitech G715", "Keyboard", 450);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Logitech G513 CARBON", "Keyboard", 170);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Steelseries AEROX 3", "Mouse", 250);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Steelseries AEROX 5", "Mouse", 170);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Steelseries AEROX 9", "Mouse", 300);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Steelseries RIVAL 600", "Mouse", 100);

            part.AddToCart(part);

            showCartMessage();
        }
    }
}

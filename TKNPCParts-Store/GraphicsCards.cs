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
    public partial class GraphicsCards : TKNPCPart_Layout
    {
        public GraphicsCards()
        {
            InitializeComponent();
        }

        public void showCartMessage()
        {
            MessageBox.Show("Your Item has been added to cart!", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addToCartButton1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("NVIDIA RTX 4090", "Graphics Card", 2719);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("NVIDIA RTX 4080 SUPER", "Graphics Card", 2610);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("NVIDIA RTX 3090 Ti", "Graphics Card", 2099);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("NVIDIA RTX 3080 Ti", "Graphics Card", 1334);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton5_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("AMD Radeon™ RX 7900 XTX", "Graphics Card", 1334);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton6_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("AMD Radeon™ RX 7800 XT", "Graphics Card", 780);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton7_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("AMD Radeon™ RX 7700 XT", "Graphics Card", 603);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton8_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("AMD Radeon™ RX 7600 XT", "Graphics Card", 449);

            part.AddToCart(part);

            showCartMessage();
        }
    }
}

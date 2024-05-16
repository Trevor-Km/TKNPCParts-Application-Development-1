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
    public partial class Processors : TKNPCPart_Layout
    {
        public Processors()
        {
            InitializeComponent();
        }

        public void showCartMessage()
        {
            switch (LanguageToolStripComboBox.Text)
            {
                case "English":
                    MessageBox.Show("Your Item has been added to cart!", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "French":
                    MessageBox.Show("Votre article a été ajouté au panier!", "Ajouté au panier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Spanish":
                    MessageBox.Show("¡Tu artículo ha sido agregado al cesta!", "Agregado al cesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }
        }

        private void addToCartButton1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Intel Core i9", "Processor", 1000);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Intel Core i7", "Processor", 800);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Intel Core i5", "Processor", 600);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Intel Core i3", "Processor", 400);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("AMD Ryzen 9", "Processor", 900);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("AMD Ryzen 7", "Processor", 700);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("AMD Ryzen 5", "Processor", 500);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("AMD Ryzen 3", "Processor", 380);

            part.AddToCart(part);

            showCartMessage();
        }
    }
}

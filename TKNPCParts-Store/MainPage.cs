using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKNPCParts_Layout
{
    public partial class MainPage : TKNPCPart_Layout
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public static void Main(string[] args)
        {
            var language = ConfigurationManager.AppSettings["language"];

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);

            Application.Run(new MainPage());
        }

        public void showCartMessage()
        {
            MessageBox.Show("Your Item has been added to cart!", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addToCartButton21_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Steelseries AEROX 9", "Mouse", 175);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton17_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Intel Core i9", "Processor", 1050);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton18_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("MSI PRO Z790-A MAX", "Motherboard", 350);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton19_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Samsung 980 PRO", "SSD", 500);

            part.AddToCart(part);

            showCartMessage();
        }

        private void addToCartButton20_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("NVIDIA RTX 4090", "Graphics Card", 2650);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Logitech G513", "Keyboard", 170);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Ryzen 5", "Processor", 500);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("Western Digital BLUE", "SSD", 400);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("NVIDIA RTX 4080 SUPER", "Graphics Card", 2610);

            part.AddToCart(part);

            showCartMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCPart part = new PCPart("MSI MPG Z790 Carbon", "Motherboard", 500);

            part.AddToCart(part);

            showCartMessage();
        }
    }
}

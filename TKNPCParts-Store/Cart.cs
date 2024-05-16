using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKNPCParts_Layout
{
    public partial class Cart : TKNPCPart_Layout
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            LoadItems();
            LoadPrices();
            CalculateTotal();
        }

        private void LoadItems()
        {
            if (PCPart.partsList.Count != 0)
            {
                for (int i = 0; i < PCPart.partsList.Count; i++)
                {
                    cartListBox.Items.Add(PCPart.partsList[i].Name);
                }
            }

        }

        private void LoadPrices()
        {
            if (PCPart.partsList.Count != 0)
            {
                switch (LanguageToolStripComboBox.Text)
                {
                    case "English":
                        for (int i = 0; i < PCPart.partsList.Count; i++)
                        {
                            priceListBox.Items.Add("$ " + PCPart.partsList[i].Price);
                        }
                        break;

                    case "French":
                        for (int i = 0; i < PCPart.partsList.Count; i++)
                        {
                            priceListBox.Items.Add("$ " + PCPart.partsList[i].Price);
                        }
                        break;

                    case "Spanish":
                        for (int i = 0; i < PCPart.partsList.Count; i++)
                        {
                            priceListBox.Items.Add("$ " + (int)(PCPart.partsList[i].Price * 12.27));
                        }
                        break;
                }

            }
        }

        private void CalculateTotal()
        {
            double total = 0;

            if (PCPart.partsList.Count != 0)
            {
                switch (LanguageToolStripComboBox.Text)
                {
                    case "English":
                        for (int i = 0; i < PCPart.partsList.Count; i++)
                        {
                            total += PCPart.partsList[i].Price;
                        }
                        break;

                    case "French":
                        for (int i = 0; i < PCPart.partsList.Count; i++)
                        {
                            total += PCPart.partsList[i].Price;
                        }
                        break;

                    case "Spanish":
                        for (int i = 0; i < PCPart.partsList.Count; i++)
                        {
                            total += (int)(PCPart.partsList[i].Price * 12.27);
                        }
                        break;
                }
            }

            totalTextBox.Text = "$ " + total.ToString();
        }


        private int CalculateReceiptTotal()
        {
            int totalPrice = 0;

            foreach (PCPart part in PCPart.partsList)
            {
                totalPrice += part.Price;
            }

            return totalPrice;
        }

        private void OpenNewForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (PCPart.partsList.Count != 0)
            {
                // Create or append to the receipt.txt file
                using (StreamWriter writer = new StreamWriter("receipt.txt"))
                {
                    // Write general description about the webstore transaction
                    writer.WriteLine("Webstore Transaction Receipt");
                    writer.WriteLine(DateTime.Now.ToString("F")); // Date and time of transaction
                    writer.WriteLine();

                    // Write list of items
                    writer.WriteLine("Items:");

                    foreach (PCPart part in PCPart.partsList)
                    {
                        writer.WriteLine($"- {part.Name}: {part.Description} - ${part.Price}");
                    }

                    writer.WriteLine();

                    // Calculate total price of items
                    int totalPrice = CalculateReceiptTotal();
                    writer.WriteLine($"Total Price: ${totalPrice}");
                }

                switch (LanguageToolStripComboBox.Text)
                {
                    case "English":
                        MessageBox.Show("Receipt generated successfully in /bin/Debug !", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "French":
                        MessageBox.Show("Reçu généré avec succès dans bin/debug", "Caisse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Spanish":
                        MessageBox.Show("Recibo generado exitosamente en bin/debug", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }
                clearCartButton_Click(sender, e);
            }
            else
            {
                switch (LanguageToolStripComboBox.Text)
                {
                    case "English":
                        MessageBox.Show("Cart is Empty! Please add items to cart before proceeding to checkout.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "French":
                        MessageBox.Show("Le panier est vide! Veuillez ajouter des articles au panier avant de procéder au paiement.", "Caisse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Spanish":
                        MessageBox.Show("¡El carrito esta vacío! Agregue artículos al carrito antes de realizar el pago.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }
               
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            PCPart.partsList.Clear();
            OpenNewForm(new Cart());
        }
    }
}

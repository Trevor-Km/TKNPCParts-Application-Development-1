using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TKNPCParts_Layout
{
    public partial class TKNPCPart_Layout : Form
    {
        public TKNPCPart_Layout()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void close_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public virtual void graphicsCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewForm(new GraphicsCards());
            
        }

        private void processorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewForm(new Processors());
            
        }

        private void mainPageToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            openNewForm(new MainPage());
        }


        private void allItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openNewForm(new AllItems());
        }

        private void TKNPCPart_Layout_Load(object sender, EventArgs e)
        {

        }

        private void openNewForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void peripheralsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewForm(new Peripherals());
        }

        private void motherboardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewForm(new Motherboards());
        }

        private void storageDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewForm(new Storage_Devices());
        }

        private void termsAndAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string startupPath = Application.StartupPath;
           

           
            string relativeFilePath = "TermsAndAgreement.txt"; 

            
            string filePath = Path.Combine(startupPath, relativeFilePath);

            try
            {
                if (File.Exists(filePath))
                {
                    
                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewForm(new License());
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewForm(new Cart());
        }

        private void LanguageToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch (LanguageToolStripComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;

                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;

                case 2:
                    changeLanguage.UpdateConfig("language", "es-MX");
                    Application.Restart();
                    break;
            }
        }
    }
}

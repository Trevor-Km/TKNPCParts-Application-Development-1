using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKNPCParts_Layout
{
    public partial class License : TKNPCPart_Layout
    {
        public License()
        {
            InitializeComponent();
        }

        private void License_Load(object sender, EventArgs e)
        {

            try
            {
                string startupPath = Application.StartupPath;
                string relativePath = "license.txt"; 

           
                licenseBox.Text = File.ReadAllText(Path.Combine(startupPath,relativePath));

                
                
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("License not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException er)
            {
                MessageBox.Show("Error reading from file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }


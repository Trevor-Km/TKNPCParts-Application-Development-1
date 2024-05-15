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

        private void graphicsCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicsCards graphicsCardsFrame = new GraphicsCards();
            graphicsCardsFrame.ShowDialog();
        }

        private void processorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mainFrame = new MainPage();
            mainFrame.ShowDialog();
            
        }

        private void allItemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AllItems allItemsFrame = new AllItems();
            allItemsFrame.Show();
        }

        private void TKNPCPart_Layout_Load(object sender, EventArgs e)
        {

        }
    }
}

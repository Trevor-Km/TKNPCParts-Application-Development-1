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


    }
}

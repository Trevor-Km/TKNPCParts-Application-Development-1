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
    public partial class AllItems : TKNPCPart_Layout
    {
        public AllItems()
        {
            InitializeComponent();
        }

        private void AllItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tKNPcPartsDataSet.TKNPcPartsDB' table. You can move, or remove it, as needed.
            this.tKNPcPartsDBTableAdapter.Fill(this.tKNPcPartsDataSet.TKNPcPartsDB);

        }
    }
}

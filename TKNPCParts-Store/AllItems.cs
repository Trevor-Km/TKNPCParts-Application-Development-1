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
    public partial class AllItems : Form
    {
        public AllItems()
        {
            InitializeComponent();
        }

        private void tKNPcPartsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tKNPcPartsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tKNPcPartsDBDataSet);

        }

        private void AllItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tKNPcPartsDBDataSet.TKNPcParts' table. You can move, or remove it, as needed.
            this.tKNPcPartsTableAdapter.Fill(this.tKNPcPartsDBDataSet.TKNPcParts);

        }
    }
}

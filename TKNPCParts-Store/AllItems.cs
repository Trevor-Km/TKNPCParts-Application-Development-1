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
            this.tKNPcPartsDBTableAdapter.showAllItems(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }

        private void searchNameButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.SearchByName(this.tKNPcPartsDataSet.TKNPcPartsDB, inputName.Text);
            inputName.Text = "";
        }

        private void searchDescButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.SearchDesc(this.tKNPcPartsDataSet.TKNPcPartsDB, searchDesc.Text);
            searchDesc.Text = "";
        }

        private void graphicsCardButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.sortByGraphicsCard(this.tKNPcPartsDataSet.TKNPcPartsDB);

        }

        private void processorButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.sortByProcessor(this.tKNPcPartsDataSet.TKNPcPartsDB);

        }

        private void peripheralsButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.sortByPeripherals(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }

        private void motherboardButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.sortByMotherboard(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }

        private void allItemsButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.showAllItems(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }

        private void sortByStorage_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.sortByStorageDevices(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }

        private void sortByNameButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.sortByName(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.sortByPriceASC(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.sortByPriceDESC(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }

        private void highEndButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.FindHighEndBuild(this.tKNPcPartsDataSet.TKNPcPartsDB);

        }

        private void budgetButton_Click(object sender, EventArgs e)
        {
            this.tKNPcPartsDBTableAdapter.BudgetBuild(this.tKNPcPartsDataSet.TKNPcPartsDB);
        }
    }
}

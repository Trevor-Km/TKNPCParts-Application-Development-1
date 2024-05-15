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
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            timeLabel.Text = dateTime.ToLongTimeString();
        }
    }
}

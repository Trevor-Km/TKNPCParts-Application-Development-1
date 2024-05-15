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
    public partial class MainPage : TKNPCPart_Layout
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public static void Main(string[] args)
        {
            Application.Run(new MainPage());
        }

    }
}

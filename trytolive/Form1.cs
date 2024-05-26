using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trytolive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void supplyChain_click(object sender, EventArgs e)
        {
            this.Hide();
            SupplyChain SupplyChain = new SupplyChain();
            SupplyChain.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LankCatalog lankCatalog = new LankCatalog();
            lankCatalog.Show();
        }
    }
}

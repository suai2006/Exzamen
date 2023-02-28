using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_Forms
{
    public partial class Form3 : Form
    {
        static public string NameStr = "";
        static public string BrandStr = "";
        static public string PriceStr = "";
        static public string CatStr = "";
        static public string PriceSaleStr = "";
        static public string CountStr = "";
        public Form3()
        {
            
            InitializeComponent();
            NameField.Text = NameStr;
            Brand.Text = BrandStr;
            Price.Text = PriceStr;
            PriceSale.Text = PriceSaleStr;
            Count.Text = CountStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Task3_Forms
{
    

    public partial class Form1 : Form
    {
        static public Form2 form2;
        static public Form3 form3;
        public Form1()
        {
            form2 = new Form2();
            
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idx =e.RowIndex;
            var row = dataGridView1.Rows[idx];
            Form3.NameStr = row.Cells["Product"].Value.ToString();
            Form3.BrandStr = row.Cells["Brand"].Value.ToString();
            Form3.PriceStr = row.Cells["Price"].Value.ToString();
            Form3.PriceSaleStr = row.Cells["Sale"].Value.ToString();
            var sale = int.Parse(Form3.PriceSaleStr);
            var priceSale = (int.Parse(Form3.PriceStr) - ((int.Parse(Form3.PriceStr) * sale) /100)).ToString();
            Form3.PriceSaleStr = priceSale;
            Form3.CountStr = row.Cells["Count"].Value.ToString();
            form3 = new Form3();
            form3.ShowDialog();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if (form2.ShowDialog(this) == DialogResult.OK) 
            {
                dataGridView1.Rows.Add(
                    Form2.newProduct.Name,
                    Form2.newProduct.Brand,
                    Form2.newProduct.Cat,
                    Form2.newProduct.Price,
                    Form2.newProduct.Sale,
                    Form2.newProduct.Count
                );
            }
        }
    }
}

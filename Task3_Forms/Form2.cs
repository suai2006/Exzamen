using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_Forms
{

    public partial class Form2 : Form
    {
        public struct PRODUCT
        {
            public String Name { get; set; }
            public String Brand { get; set; }
            public int Price { get; set; }
            public int Count { get; set; }
            public String Cat { get; set; }
            public int Sale { get; set; }
        };

        public String Category = "";
        public String Sale = "";   
        static public PRODUCT newProduct;
        static public AddCat addCat;
        public Form2()
        {
            InitializeComponent();
            addCat = new AddCat();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var RBCat = groupCat.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var Sale = groupSale.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            int i = 0;
            if (Product.Text != "") {
                newProduct.Name = Product.Text;
                i++;
            }
            if (Brand.Text != "") 
            {
                newProduct.Brand = Brand.Text;
                i++;
            }
            if (Price.Text != "") {
                newProduct.Price = int.Parse(Price.Text);
                i++;
            }
            if (Count.Text != "") {
                newProduct.Count = int.Parse(Count.Text);
                i++;
            }
            if (Sale != null && Sale.Checked) {
                newProduct.Sale = int.Parse(Sale.Text.Replace("%", ""));
                i++;
            }
            if (RBCat != null && RBCat.Checked) {
                newProduct.Cat = RBCat.Text;
                i++;
            }
            if (i < 6) 
            {
                MessageBox.Show("Все поля обязательны к заполнению");                
                return;
            }

            Product.Text = "";
            Brand.Text = "";
            Brand.SelectedIndex = -1;
            RBCat.Checked = false;
            Sale.Checked = false;
            Price.Text = "";
            Count.Text = "";
            DialogResult = DialogResult.OK;
        }

        private void addBrand_Click(object sender, EventArgs e)
        {
            if (addCat.ShowDialog(this) == DialogResult.OK) 
            {
                Brand.Items.Add(AddCat.catText);
            }
        }
    }
}

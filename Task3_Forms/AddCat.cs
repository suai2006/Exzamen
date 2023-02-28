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
    public partial class AddCat : Form
    {
        static public String catText = "";
        public AddCat()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                catText = textBox1.Text;
                DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Введите название");
                return;
            }
            
        }
    }
}

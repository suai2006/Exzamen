using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task17_WPF
{
    /// <summary>
    /// Логика взаимодействия для AddPerson.xaml
    /// </summary>
     
    public partial class AddPerson : Window
    {
        static MyTable person;
        public AddPerson()
        {
            InitializeComponent();
            //person = new MyTable("Антонов", "Александр", 1982, "муж.", "г. Санкт-Петербург, Фуражный пер. д. 2, кв 12", "Крайний север");
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}

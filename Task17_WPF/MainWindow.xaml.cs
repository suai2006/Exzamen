using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace Task17_WPF
{
    class MyTable
    {
        public MyTable(string LastName, string FirstName, string Birth, string Sex, string Address,  string Benefits)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Birth = Birth;
            this.Address = Address;
            this.Sex = Sex;
            this.Benefits = Benefits;
            
        }
        
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Birth { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }        
        public string Benefits { get; set; }
        
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MyTable> PersonsList;
        public MainWindow()
        {
            InitializeComponent();
            PersonsList = new List<MyTable>
            {
                new MyTable("Антонов", "Александр", "12.12.1982", "муж.", "г. Санкт-Петербург, Фуражный пер. д. 2, кв 12", "Крайний север"),
                new MyTable("Кот", "Светлана", "12.10.1972", "жен.", "г. Санкт-Петербург, Фуражный пер. д. 2, кв 14", "за пед.выслугу"),
                new MyTable("Иванов", "Иван", "06.08.1982", "муж.","г. Санкт-Петербург, Фуражный пер. д. 2, кв 15", "За вредность")
            };
            grid.ItemsSource = PersonsList;
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            AddPerson addPerson = new AddPerson();
           
            bool? result = addPerson.ShowDialog();
            if (result.HasValue && result.Value)
            {
                var sex = "";
                if (addPerson.Sex1.IsChecked == true) sex = "муж.";
                if (addPerson.Sex2.IsChecked == true) sex = "жен.";
                var person = new MyTable(
                    addPerson.LastName.Text,
                    addPerson.FirstName.Text,
                    addPerson.Birth.Text,
                    sex,
                    addPerson.Address.Text,
                    addPerson.Benefits.Text);
                PersonsList.Add(person);
                grid.ItemsSource = PersonsList;
                grid.Items.Refresh();
            }
        }

        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MyTable path = grid.SelectedItem as MyTable;
            if (path != null) 
            {
                double dx = 60;
                if(path.Sex == "жен.") dx = 55;
                if (path.Benefits == "Крайний север") dx = Math.Floor((dx / 2));
                if (path.Benefits == "Крайний север") dx = Math.Floor((dx / 2));
                else if (path.Benefits == "Герой труда") dx -= 5;
                else if (path.Benefits == "За вредность") dx *= 2;
                else dx -= 2;
                var years = 0;
                DateTime date = DateTime.Parse(path.Birth.ToString(), CultureInfo.CurrentUICulture);
                int age = DateTime.Now.Year - date.Year;
                
                if (age < dx) 
                {
                    years = int.Parse(dx.ToString()) - age;
                }
                var msg = "Фамилия: " + path.LastName + "\n" +
                    "Имя: " + path.FirstName + "\n" +
                    "Дата рождения:" + path.Birth + "\n" +
                    "Пол:" + path.Sex + "\n" +
                    "Адрес: " + path.Address + "\n" +
                    "Пенсионные льготы: " + path.Benefits + "\n" +
                    "Осталось до пенсии: " + years.ToString();
                MessageBox.Show(msg, "Информация");
                grid.UnselectAllCells();
                grid.UnselectAll();                
            }
            
        }
    }
}

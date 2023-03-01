using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task21_XAML
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    class MyTable
    {
        public MyTable(string FolderName, string CreatedDate)
        {
            this.FolderName = FolderName;
            this.CreatedDate = CreatedDate;
        }
        public string FolderName { get; set; }
        public string CreatedDate { get; set; }

    }

    public partial class MainWindow : System.Windows.Window
    {
        string[] dirs;
        List<MyTable> DirectoryList;
        List<MyTable> FiltredList;
        public MainWindow()
        {
            InitializeComponent();
            DirectoryList = new List<MyTable>();
            FiltredList = new List<MyTable>();
        }

        private void SelectCat_Click(object sender, RoutedEventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            FolderPath.Text = fbd.SelectedPath;
            dirs = Directory.GetDirectories(fbd.SelectedPath);
            foreach (string dir in dirs)
            {
                if (Directory.Exists(dir))
                {
                    DirectoryInfo info = new DirectoryInfo(dir);                    
                    var person = new MyTable(info.Name, info.CreationTime.ToString());
                    DirectoryList.Add(person);
                }
            }
            grid.ItemsSource = DirectoryList;
            grid.Items.Refresh();
        }

        private void DirFilter_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            String text = DirFilter.Text;
            FiltredList.Clear();
            if (text != "")
            {
                foreach (var item in DirectoryList)
                {
                    if (item.FolderName.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        FiltredList.Add(item);
                    }
                }
                grid.ItemsSource = FiltredList;
                grid.Items.Refresh();
            }
            else 
            {
                grid.ItemsSource = DirectoryList;
                grid.Items.Refresh();
            }
            
        }
    }
}

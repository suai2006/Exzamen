using System;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using System.Windows.Forms;

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
        private List<MyTable> DirectoryList;
        private List<MyTable> FiltredList;
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
            string[] dirs = Directory.GetDirectories(fbd.SelectedPath);
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

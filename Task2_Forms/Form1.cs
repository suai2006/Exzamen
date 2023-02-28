using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Task2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Text files|*.txt;*.rtf|MS Word|*.doc;*.docx";
            
            if (dlg.ShowDialog(this) == DialogResult.OK) 
            {
                try
                {
                    var fileName = dlg.FileName;
                    var fi1 = new FileInfo(fileName);
                    var fileStream = dlg.OpenFile();
                    StreamReader stream = new StreamReader(fileName);
                    var content = "";

                    if (fi1.Extension == ".rtf")
                    {
                        RichTextBox rtb = new RichTextBox();
                        rtb.Rtf = stream.ReadToEnd();
                        content = rtb.Text;
                    }
                    else if (fi1.Extension == ".txt") content = stream.ReadToEnd();
                    else 
                    {
                        content = "Данный формат не поддерживается";
                    }

                    richTextBox1.Clear();
                    richTextBox1.Text = content;
                    stream.Close();
                }
                catch (Exception ex)
                {
                    richTextBox1.Text = "Error: Could not read file from disk. Original error: " + ex.Message;
                }
                
            }
            
        }

        private void exitMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showInfo(object sender, EventArgs e)
        {
            var msg = "Автор : Гаврилюк Вячеслав Викторович\n"
            + "Студент группы КЗФ-051";

            MessageBox.Show(msg, "О программе");
        }

        private void showTaskText(object sender, EventArgs e)
        {
            var msg = "Создайте приложение, которое обладает следущей функцмональностью:\n"
            + "a. Позволяет открывать и просматривать\n содержимое существующего файла\n"
            + "b. при открытии позволяет пользователю нужный файл на диске"
            + "c. позволяет открывать содержимое файлов в формате как txt,\n так и текстовых файлов с другими расширениями\n"
            + "d. имеет главное меню со следующей структурой:\n Файл (Открыть, Выход) и \n Справка(О программе(данные автора), "
            + "Задание (отобразить текст задания))";

            MessageBox.Show(msg, "Задание");
        }
    }
}

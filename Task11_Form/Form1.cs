using System;
using System.Windows.Forms;

namespace Task11_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void about_Click(object sender, EventArgs e)
        {
            var msg = "Автор : Гаврилюк Вячеслав Викторович\n"
            + "Студент группы КЗФ-051";

            MessageBox.Show(msg, "О программе");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void font_Click(object sender, EventArgs e)
        {
            var dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var font = dlg.Font;
                richTextBox1.Font = font;
            }
        }

        private void Task_Click(object sender, EventArgs e)
        {
            var msg = "a. иметь поле для ввода многострочного текста;\n"
            + "b. для изменения параметров шрифта использовать стандартное диалоговое окно задания параметров шрифта;\n"
            + "c. иметь главное меню со следующей структурой: \n" +
            "\tШрифт (выводит диалоговое окно изменения шрифта),\n" +
            "\tО программе (данные автора),\n " +
            "\tЗадание (отобразить текст задания),\n " +
            "\tВыход (закрытие приложения).";

            MessageBox.Show(msg, "Создайте приложение, которое обладает следущей функцмональностью");
        }
    }
}

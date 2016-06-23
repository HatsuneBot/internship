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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            Stream stream = null;
            
            Microsoft.Win32.OpenFileDialog file = new Microsoft.Win32.OpenFileDialog();
            byte[] result;
            if (file.ShowDialog() == true)
            {
                try
                {
                    winTask win = new winTask();
                    win.ShowDialog();
                    if (win.DialogResult == true)
                    {
                        if ((stream = file.OpenFile()) != null)
                        {
                            using (stream)
                            {
                                result = new byte[stream.Length];
                                await stream.ReadAsync(result, 0, (int)stream.Length);
                            }
                            output.Text = System.Text.Encoding.UTF8.GetString(result);
                        }
                    }
                    else
                    {
                        output.Text = "Неверно введен пароль!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно считать файл. Текст ошибки: " + ex.Message);
                }
            }
        }
    }
}

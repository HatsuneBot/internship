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

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool flag;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void FileOpen_Click(object sender, RoutedEventArgs e)
        {
            Stream stream = null;
            Microsoft.Win32.OpenFileDialog file = new Microsoft.Win32.OpenFileDialog();
            byte[] result;
            flag = false;

            if (file.ShowDialog() == true)
            {
                try
                {
                    if ((stream = file.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            result = new byte[stream.Length];
                            await stream.ReadAsync(result, 0, (int)stream.Length);
                        }
                        output.Text = System.Text.Encoding.UTF8.GetString(result);
                        flag = true;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно считать файл. Текст ошибки: " + ex.Message);
                }
            }
        }
        private void output_ScrollChanged(object sender, RoutedEventArgs e)
        {
            if (flag == true)
                label1.Content = Math.Round(((output.VerticalOffset + output.ViewportHeight) * 100 / output.ExtentHeight)).ToString() + "%";
        }
    }
}

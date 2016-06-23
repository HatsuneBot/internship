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

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для winTask.xaml
    /// </summary>
    public partial class winTask : Window
    {
        public winTask()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string password = "password";
            if (Password.Text != password) { MessageBox.Show("Неверно введен пароль!"); Password.Clear(); }
            else { DialogResult = true; Close(); }
        }
    }
}

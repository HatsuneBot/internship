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

namespace WpfApplication1
{
    
    /// <summary>
    /// Приложение форматирует строки по указанному формату
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// При нажатии клавиши "Ок" из текстбоксов считываются значения и передаются в метод PrintOut класса Formatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            output.AppendText(Formatting.PrintOut(X.GetLineText(0) + "," + Y.GetLineText(0)));
            X.Clear(); Y.Clear();
        }
        /// <summary>
        /// При нажатии клавиши "Ок" из текстбокса считывается имя файла и содержимое передается в метод PrintOut класса Formatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            output.AppendText(Formatting.PrintOut(File.ReadAllText(filename.Text)));            
        }

    }
    /// <summary>
    /// Класс Formatting выполняет необходимый функционал
    /// </summary>
    static class Formatting
    {
        /// <summary>
        /// Строка result будет содержать в себе результат форматирования
        /// </summary>
        public static string result=String.Empty;
        /// <summary>
        /// Метод PrintOut форматирует входящий текст и сохраняет его в строке result
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string PrintOut(string s)
        {
            result = "";
            int i = 0;
            string[] separators = { ",", " ", "\n" };
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            while (i < words.Length)
            {
                //Console.WriteLine(words[i]);
                result +="X:" + double.Parse(words[i]) + " Y:" + double.Parse(words[i + 1]) + "\n";
                i += 2;
            }
            return result;
        }
        //мы изменили этот файл. но изменений на сервере нет жеш, теперь нам надо изменения файла залить на сервер.
        //галочка значит что он был изменен, если какой-то файл новый добавишь - то плюсик
    }
}

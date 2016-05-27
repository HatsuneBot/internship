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

namespace task1_WPF
{
    
    /// <summary>
    /// The application formats the input data
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Point> point_list = new List<Point>();
        public MainWindow()
        {
            InitializeComponent();            
            
        }
        /// <summary>
        /// This method formats the data entered by the user in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void format_Click(object sender, RoutedEventArgs e)
        {
            output.Clear();
            ParseLine.SplitInput(point_list, input.Text);
            foreach (Point point in point_list)
            {
                output.AppendText(point.ToString());
            }
            
            input.Clear();
        }
        /// <summary>
        /// This method formats the data from a file whose name user enters in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openfile_Click(object sender, RoutedEventArgs e)
        {
            output.Clear();
            ParseLine.SplitInput(point_list, File.ReadAllText(filename.Text));
            foreach (Point point in point_list)
            {
                output.AppendText(point.ToString());
            }
        }

    }

}

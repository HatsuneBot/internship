﻿using System;
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

namespace _2_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            out1.AppendText(Calculate.SqrtN(double.Parse(in1.Text), double.Parse(in2.Text), double.Parse(in3.Text)).ToString()+"\n");
            out2.AppendText(Math.Pow(double.Parse(in1.Text), 1.0/double.Parse(in2.Text)).ToString() + "\n");
            in1.Clear(); in2.Clear(); in3.Clear();
        }
    }
    
     
}

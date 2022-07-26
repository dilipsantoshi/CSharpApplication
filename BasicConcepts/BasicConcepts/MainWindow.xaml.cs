﻿using BasicConcepts.Common;
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

namespace BasicConcepts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string title = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            title = "Testing git practice";
        }

        private void oopsConcept_Click(object sender, RoutedEventArgs e)
        {
            Func<int, int> square = x => x * x;
            MessageBox.Show(square(5).ToString());
            ClassA objA=new ClassA();
            MessageBox.Show(objA.X.ToString());
            MessageBox.Show("Just testing Merge conflict");
        }
    }
}

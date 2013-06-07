using System;
using System.Collections.Generic;
using System.Windows;
using FileIOLib.FileIODAL;
using FileIOLib.Models;
using WpfApp.Models;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataGridBookOrders.Visibility = Visibility.Collapsed;       
        } 

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            this.DataGridBookOrders.Visibility = Visibility.Visible;

            IList<BookOrderModel> customerList = DatabaseDAL.GetOrders();  
            DataGridBookOrders.ItemsSource = customerList;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Environment.Exit(1);
            this.Close();
        }
    }
}

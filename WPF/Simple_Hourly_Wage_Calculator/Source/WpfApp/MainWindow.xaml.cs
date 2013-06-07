using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.models;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtName.Focus();
        }

        void btnShow_Click(object sender, RoutedEventArgs e)
        {
            // name input
            var Name = txtName.Text;
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Name input is missing", "Missing Input", MessageBoxButton.OK, MessageBoxImage.Stop);
                txtName.Focus();
                return;
            }

            // Hours worked input
            var hoursWorkedStr = txtHoursWorked.Text;
            if (string.IsNullOrEmpty(hoursWorkedStr))
            {
                MessageBox.Show("hoursWorked input is missing", "Missing Input", MessageBoxButton.OK, MessageBoxImage.Stop);
                txtHoursWorked.Focus();
                return;
            }
            double hoursWorked = Convert.ToDouble(hoursWorkedStr);
            

            //hourly pay input
            var hourlyPayStr = txtHourlyPay.Text;
            if (string.IsNullOrEmpty(hourlyPayStr))
            {
                MessageBox.Show("txtHourlyPay input is missing", "Missing Input", MessageBoxButton.OK, MessageBoxImage.Stop);
                txtHourlyPay.Focus();
                return;
            }
            double hourlyPay = Convert.ToDouble(hourlyPayStr);

            EmployeeModel EmployeeObject =
                new EmployeeModel(Name, hoursWorked, hourlyPay); 
    
            MessageBox.Show(EmployeeObject.ToString(),
            "Payroll",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
            
           
        }
    }
}

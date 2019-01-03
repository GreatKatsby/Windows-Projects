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

namespace WpfLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee[] employees;
        decimal min;
        decimal max;

        public MainWindow()
        {
            InitializeComponent();
            employees = new Employee[]
            {
                new Employee("Jason", "Red", 5000M),
                new Employee("Ashley", "Green", 7600M),
                new Employee("Matthew", "Indigo", 3587.5M),
                new Employee("James", "Indigo", 4700.77M),
                new Employee("Luke", "Indigo", 6200M),
                new Employee("Jason", "Blue", 1200M),
                new Employee("Jacob", "Blue", 3200M),
                new Employee("James", "Blue", 7200M),
                new Employee("Wendy", "Brown", 4236.4M)
            };
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            min = Convert.ToDecimal(txtMin.Text);
            max = Convert.ToDecimal(txtMax.Text);

            var filter = from emp in employees
                         where emp.MonthlySalary >= min &&
                         emp.MonthlySalary <= max
                         orderby emp.LastName ascending
                         select emp;

            lstFilter.ItemsSource = filter;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var all = from emp in employees
                      orderby emp.LastName ascending
                      select emp;
            lstAll.ItemsSource = all;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_WPF
{
    class Employee
    {
        private decimal monthlySalary;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee(string first, string last, decimal salary)
        {
            FirstName = first;
            LastName = last;
            monthlySalary = salary;
        }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value >= 0M)
                    monthlySalary = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0,-15} {1,-15} {2,10:C}",
                FirstName, LastName, MonthlySalary);
        }
    }
}

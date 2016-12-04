using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    public class Employee
    {
        private String name;
        private int employeeNumber;
        private decimal hoursWorked;

        public Employee(String name, int employeeNumber, decimal hoursWorked)
        {
            this.name = name;
            this.employeeNumber = employeeNumber;
            this.hoursWorked = hoursWorked;
        }
        public string Name { get; set; }

        public int EmployeeNumber { get; set; }
       
        public decimal HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price of product cannot be less than 0");
                }
                hoursWorked = value;
            }


        }
            
    }
}

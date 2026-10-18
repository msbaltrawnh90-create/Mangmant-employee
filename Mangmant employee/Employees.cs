using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mangmant_employee
{
    public abstract class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal _Salary;
        public decimal salary
        {
            get { return _Salary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Salary must be greater than zero.");
                    _Salary = value;
                }
               
            }

        }
        public Employees(int id, string name)
        {
            Id = id;
            Name = name;
           
        }

        public abstract decimal CalculateSalary();
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
                
        }

    }
}

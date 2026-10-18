using System;
using System.Collections.Generic;
using System.Text;

namespace Mangmant_employee
{
    public class FullTimeEmployee : Employees, IWorkable
    {
        private decimal _MonthlySalary;
        public decimal MonthlySalary
        {
            get { return _MonthlySalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Monthly salary must be greater than zero.");
                }
                _MonthlySalary = value;
            }
        }
        public FullTimeEmployee(int id, string name, decimal monthlySalary) : base(id, name)
        {
            MonthlySalary = monthlySalary;
        }
        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
        public void Work()
        {
            Console.WriteLine($"{Name} is working full-time with a monthly salary of {MonthlySalary:C}.");
        }
    }
}

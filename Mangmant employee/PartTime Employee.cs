using System;
using System.Collections.Generic;
using System.Text;

namespace Mangmant_employee
{
    public class PartTimeEmployee : Employees, IWorkable
    {
        private decimal _HourlyRate;
        private int _HoursWorked;
        public decimal HourlyRate
        {
            get { return _HourlyRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hourly rate must be greater than zero.");
                }
                _HourlyRate = value;
            }
        }
        public int HoursWorked
        {
            get { return _HoursWorked; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours worked cannot be negative.");
                }
                _HoursWorked = value;
            }
        }
        public PartTimeEmployee(int id, string name, decimal hourlyRate, int hoursWorked) : base(id, name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
        public void Work()
        {
            Console.WriteLine($"{Name} is working part-time for {HoursWorked} hours at a rate of {HourlyRate:C} per hour.");
        }
    }
}
using Mangmant_employee;

var employees = new List<Employees>()
{
    new FullTimeEmployee(1, "Ahmad", 5000),
    new PartTimeEmployee(2, "Omar", 20, 25),
   
};
foreach (var employee in employees)
{
    employee.DisplayEmployeeInfo();
    Console.WriteLine($"Salary: {employee.CalculateSalary()}");
    Console.WriteLine();
}
var workableEmployees = employees.OfType<IWorkable>();
foreach (var employee in workableEmployees)
{
    employee.Work();
}

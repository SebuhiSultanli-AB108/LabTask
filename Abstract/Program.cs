using Abstract.Models;

namespace Abstract;

internal class Program
{
    static void Main()
    {
        HourlyEmployee RTE = new HourlyEmployee()
        {
            Name = "Receb Tayyip",
            Surname = "Erdogan",
            Age = 100,
            HourlyRate = 20,
            HoursWorked = 180,
        };

        SalariedEmployee Rick = new SalariedEmployee()
        {
            Name = "Rick",
            Surname = "Astley",
            Age = 56,
            MonthlySalary = 2000
        };

        double salaryOfRte = RTE.CalculateSalary();
        Console.WriteLine($"Salary: {salaryOfRte}");
        RTE.DisplayDetails();

        Console.WriteLine("---------------------------");

        double salaryOfRick = Rick.CalculateSalary();
        Console.WriteLine($"Salary: {salaryOfRick}");
        Rick.DisplayDetails();
    }
}
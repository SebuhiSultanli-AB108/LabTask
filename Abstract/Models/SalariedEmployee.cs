namespace Abstract.Models;

public class SalariedEmployee : Employee
{
    public double MonthlySalary { get; set; }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine(
            $"""
            Id: {Id}
            Name: {Name}
            Surname: {Surname}
            Age: {Age}
            MonthlySalary: {MonthlySalary}
            """);
    }
}
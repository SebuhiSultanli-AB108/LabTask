namespace Abstract.Models;

public class HourlyEmployee : Employee
{

    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine(
            $"""
            Id: {Id}
            Name: {Name}
            Surname: {Surname}
            Age: {Age}
            HourlyRate: {HourlyRate}
            HoursWorked: {HoursWorked}
            """);
    }
    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}




/*

3.1 HourlyEmployee

3.2 Özəllikləri:
HourlyRate - dobule type, HourlyEmployee object'in saatlıq qazancı saxlanılacaq.
HoursWorked - double type, HourlyEMployee object'in aylıq çalışdığı saat saxlanılacaq.

3.3 Davranış:

double CalculateSalary() - override edilməlidir və method HourlyEmployee'un saatlıq qazancını * aylıq işlədiyi saata vurub geri qaytarmalıdır.

void DisplayDetails() - override edilməlidir və method HourlyEmployee'un haqqındaki məlumatları ekrana çıxarmalıdır.
*/
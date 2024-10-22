namespace Abstract.Models;

public abstract class Employee
{
    private static int _id = -1;
    public static int Id
    {
        get
        {
            _id++;
            return _id;
        }
    }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public abstract double CalculateSalary();
    public abstract void DisplayDetails();
}
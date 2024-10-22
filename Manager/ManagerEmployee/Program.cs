using Models;

namespace Test1;

//  /\_/\
// ( o.o )
//   >^<

internal class Program
{
    static void Main()
    {
        Assistant AngryAssistant = new Assistant();
        
        Employee TheBestEmployee = new Employee("Sabuhi", true, 1000f);
        Employee TheWorstEmployee = new Employee("Ruslan", false, 200f);

        Console.WriteLine(TheBestEmployee.Salary);
        AngryAssistant.GetFeedBack(TheBestEmployee);
        Console.WriteLine(TheBestEmployee.Salary);
    }
}

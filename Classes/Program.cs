namespace Classes
{
    internal class Program
    {
        static void Main()
        {
            Car Car1 = new Car("Toyota", "Corolla", 2022, 50, 5);
            
            Console.Write("Given fuel: ");
            int fuelGiven = Convert.ToInt32(Console.ReadLine());
            Console.Write("Distance: ");
            int distancePlan = Convert.ToInt32(Console.ReadLine());
            Car1.CurrentFuel = fuelGiven;


            Car1.ShowInfo();
            Car1.Drive(distancePlan);
            Car1.ShowInfo();
        }
    }
}

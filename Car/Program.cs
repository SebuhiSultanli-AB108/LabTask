using CarsAndStuff.Models;

namespace CarsAndStuff;

internal class Program
{
    static void Main()
    {
        Car myCar1 = new Car()
        {
            Id = 1,
            Brand = "dsa",
            Model = "sss",
            Year = 2000,
            EngineCode = 1234565
        };
        Car myCar2 = new Car()
        {
            Id = 2,
            Brand = "mer",
            Model = "sss",
            Year = 2020,
            EngineCode = 1234565
        };
        Car myCar3 = new Car()
        {
            Id = 3,
            Brand = "mehryer",
            Model = "sss",
            Year = 1980,
            EngineCode = 1234565
        };
        Car myCar4 = new Car()
        {
            Id = 4,
            Brand = "gjrt",
            Model = "sss",
            Year = 2024,
            EngineCode = 1234565
        };
        Car[] cars = { myCar1, myCar2, myCar3, myCar4 };
        cars.OrderByYear();
        foreach (Car car in cars)
        {
            Console.WriteLine($"""
                               =================================
                               Id: {car.Id}
                               Brand: {car.Brand}
                               Model: {car.Model}
                               Year: {car.Year}
                               Engine Code: {car.EngineCode}
                               """);
        }
        Console.WriteLine("=================================");
    }
}

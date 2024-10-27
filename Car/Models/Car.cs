namespace CarsAndStuff.Models;

class Car
{
    public int Id { get; set; }
    public int Year { get; set; }
    public int EngineCode { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }

    public static bool operator <(Car car1, Car car2)
    {
        return car1.Year < car2.Year;
    }
    public static bool operator >(Car car1, Car car2)
    {
        return car1.Year > car2.Year;
    }
}

static class Helper
{
    public static void OrderByYear(this Car[] cars)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            for (int j = 0; j < cars.Length; j++)
            {
                if (j != cars.Length - 1 && cars[j] > cars[j + 1])
                {
                    Car newcar = cars[j];
                    cars[j] = cars[j + 1];
                    cars[j + 1] = newcar;
                }
            }
        }
    }
}
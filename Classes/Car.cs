namespace Classes
{
    public class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCap;
        public int FuelForKm;
        public int CurrentFuel;

        public Car(string Brand, string Model, int Year, int FuelCap, int FuelForKm) : base(Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCap = FuelCap;
            this.FuelForKm = FuelForKm;
        }

        public void Drive(int Distance)
        {
            if (CurrentFuel > FuelCap)
            {
                Console.WriteLine("More fuel than expected!");
                Console.WriteLine("What a waste!");
                CurrentFuel = FuelCap;
            }
            int FuelUsed = CurrentFuel - FuelForKm * Distance;
            if (FuelUsed >= 0)
            {
                Console.WriteLine("Dive is successful!");
                CurrentFuel -= FuelForKm*Distance;
                Console.WriteLine($"Fuel left: {CurrentFuel}");
            }
            else
            {
                Console.WriteLine("Not enought fuel!");
                Console.WriteLine("Dive is unsuccessful!");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------Info_Start---------------");
            Console.WriteLine($" Brand: {Brand} \n Model: {Model} \n FuelCap: {FuelCap} \n FuelForKm: {FuelForKm} \n CurrentFuel: {CurrentFuel}");
            Console.WriteLine("----------------Info_End----------------");
            Console.WriteLine();
        }
    }
}

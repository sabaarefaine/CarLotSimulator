using System;
namespace CarLotSimulator
{
    public class Car
    {

        public Car()
        {
            //every time car constructor used, car is added to numberofcars
            CarLot.numberOfCars++;
            //call class name & static member
        }
        //passing through constructor method
        public Car(int year, string make, string model, string engine, string honk, bool driveable)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.EngineNoise = engine;
            this.HonkNoise = honk;
            this.IsDriveable = driveable;
        }

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public static void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public static void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
    }
}

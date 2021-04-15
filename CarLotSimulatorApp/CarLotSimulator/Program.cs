using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car-DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-DONE
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //dot notation
            var firstVehicle = new Car();
            firstVehicle.Year = 2015;
            firstVehicle.Make = "Honda";
            firstVehicle.Model = "Accord";
            firstVehicle.EngineNoise = "vroom";
            firstVehicle.HonkNoise = "beep beep beep";
            firstVehicle.IsDriveable = true;


            //object initializer
            var secondVehicle = new Car()
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2016,
                EngineNoise = "vroom vroom",
                HonkNoise = "beep beep",
                IsDriveable = true
            };

            //passing through constructor
            var thirdVehicle = new Car(2020, "Audi", "Q5", "vrrooom", "beeeep", true);

            //LIST
            var onLot = new CarLot();

            onLot.Cars.Add(firstVehicle);
            onLot.Cars.Add(secondVehicle);
            onLot.Cars.Add(thirdVehicle);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (Car vehicle in onLot.Cars)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model}, Made in the year {vehicle.Year}. It's engine goes {vehicle.EngineNoise} on the freeway, and when a car cuts them off, they go {vehicle.HonkNoise}. Definitely {vehicle.IsDriveable}, very reliable car. ");
            }

            
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

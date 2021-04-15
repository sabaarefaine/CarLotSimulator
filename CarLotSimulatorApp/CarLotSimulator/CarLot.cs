using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        //Create a static field called numberOfCars inside of the CarLot class
        //Have this number only increment when we create a new car

        public static int numberOfCars = 1;

        public CarLot()
        {
        }
        //type Car
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}

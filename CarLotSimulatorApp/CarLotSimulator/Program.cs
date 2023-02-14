using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Ranger";
            car1.Year = 2019;
            car1.IsDrivable = true;
            car1.EngineNoise = "VROOOOOM";
            car1.HonkNoise = "BEEP BEEP";

            Car car2 = new Car()
            {
                Make = "Toyota",
                Model = "Tacoma",
                Year = 2019,
                IsDrivable = true,
                EngineNoise = "VROOM vrooom",
                HonkNoise = "BEEP BEEP beep"
            };

            Car car3 = new Car(2023, "Ford", "F-150");


            //Call each of the methods for each car


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var item in myCarLot.ListOfCars)
            {
                Console.WriteLine($"Year: {car.Year} / Make: {car.Make} / Model: {car.Model})

            }
        }
    }
}

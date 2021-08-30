using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            CarLot lot = new CarLot();
            
            
            Car cadillac = new Car();
            lot.CarList.Add(cadillac);

            cadillac.Year = 2022;
            cadillac.Make = "Cadillac";
            cadillac.Model = "XT5";
            cadillac.EngineNoise = "Vroom vroom";
            cadillac.HonkNoise = "BEEP";
            cadillac.IsDrivable = true;

            cadillac.MakeEngineNoise();
            cadillac.MakeHonkNoise();

            Car bronco = new Car() { Year = 1996, Make = "Ford", Model = "Bronco", EngineNoise = "Nothing", HonkNoise = "Beep" };
            lot.CarList.Add(bronco);
            bronco.MakeEngineNoise();
            bronco.MakeHonkNoise();

            Car myOtherCar = new Car(2030, "Banshee", "Sky Demon", "Vap", "Zing");
            lot.CarList.Add(myOtherCar);

            myOtherCar.MakeEngineNoise();
            myOtherCar.MakeHonkNoise();

            Console.WriteLine("---------------");
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} and Model: {car.Model}");
            }
        }
    }
}
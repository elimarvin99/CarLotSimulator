using System;
using System.Collections.Generic;

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
            //The methods should take one string parameter: the respective noise property                                     //Done


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var Car1 = new Car() { Year = "1996", Make = "Toyota", Model = "Camry", EngineNoise = "Vroom", HonkNoise = "Beep", IsDriveable = true };
            Console.WriteLine($"Number of cars in the lot is {CarLot.NumberOfCars}");
            var Car2 = new Car("2019","Honda","Accord", "vrrrrrrrm","Beep, beep",false);
            Console.WriteLine($"Number of cars in the lot is {CarLot.NumberOfCars}");
            var Car3 = new Car();
            Car3.Year = "2006";
            Car3.Make = "Audi";
            Car3.Model = "Q8";
            Car3.EngineNoise = "vrmvrm";
            Car3.HonkNoise = "Deutsche";
            Car3.IsDriveable = true;
            Console.WriteLine($"Number of cars in the lot is {CarLot.NumberOfCars}");

            Car1.MakeEngineNoise();
            Car1.MakeHonkNoise();
            Car2.MakeEngineNoise();
            Car2.MakeHonkNoise();
            Car3.MakeEngineNoise();
            Car3.MakeHonkNoise();


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car                   //Done

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            //var carLot1 = new CarLot(new List<Car>());   //this is how to add to the list if it's not static and we need to create a specific instance of it
            //CarLot.MyCarList = new List<Car>();
            //CarLot.MyCarList.Add(Car1);
            //CarLot.MyCarList.Add(Car2);
            //CarLot.MyCarList.Add(Car3);

            Console.WriteLine("Our Car Lot has these vehicles:");

            foreach (var car in CarLot.MyCarList)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
            }



        }
    }
}

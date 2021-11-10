using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{

    //Create a seperate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property
    public class Car
    {
        public Car()
        {
            //this will automatically increase the car by one each time a car object is created
            CarLot.NumberOfCars++;
            CarLot.MyCarList.Add(this);  //the this keyword refers to the specific object being created
        }
        public Car(string year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.NumberOfCars++;
            CarLot.MyCarList.Add(this);

        }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise ()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

    }
}



using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator

                    //*************BONUS X 2*************//

                    //Create a CarLot class
                    //It should have at least one property: a List of cars
                    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                    //At the end iterate through the list printing each of car's Year, Make, and Model to the console
{
    public class CarLot
    {
        public CarLot()   //default
        {

        }
        public CarLot(List<Car> mycarlist)    //custom
        {
            MyCarList = mycarlist;
        }
        public static List<Car> MyCarList { get; set; } = new List<Car>();

        public static int NumberOfCars { get; set; }
    }
}

using System;
using System.Linq.Expressions;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car -Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            // DONE- Now that the Car class is created we can instanciate 3 new cars          

            //Set the properties for each of the cars
            //Call each of the methods for each car

            var focus = new Car();
            focus.CarMake = "Ford";
            focus.CarModel = "Focus";
            focus.CarYear = 2020;
            focus.EngineNoise = "No";
            focus.HonkNoise = "Yes";
            focus.IsDrivable = true;

            var camry = new Car();
            camry.CarMake = "Toyota";
            camry.CarModel = "Camry";
            camry.CarYear = 2019;
            camry.EngineNoise = "Yes";
            camry.HonkNoise = "No";
            camry.IsDrivable = true;

            var infiniti = new Car()
            {
                CarYear = 2016,
                CarMake = "Infiniti",
                CarModel = "Q60",
                EngineNoise = "Yes",
                HonkNoise = "Yes",
                IsDrivable = true,
            };

            var audi = new Car(2016, "Audi", "A8", "No", "Yes", true);

            //call Methods

            



            //*************BONUS*************//

            //DONE- Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

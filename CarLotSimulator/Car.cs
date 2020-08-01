using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CarLotSimulator
{
     public class Car 
    {//Create a seperate class file called Car -Done
     //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
     //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
     //The methods should take one string parameter: the respective noise property            
        public Car() 
        {
            CarLot.numberOfCars++;
        }

      public int CarYear { get; set; }
      public string CarMake { get;  set; }      
      public string CarModel { get; set; }
      public string EngineNoise { get; set; }
      public string HonkNoise { get; set; }
      public bool IsDrivable { get; set; }
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prius = new Car();
            prius.Make = "Toyota";
            prius.Model = "Prius";
            prius.Year = 2006;

  


            //Console.WriteLine(prius.Make);
            //Console.WriteLine(prius.Model);
            //Console.WriteLine(prius.Year);

            var mazda = new Car()
            {
             Make = "Mazda",
            Model = "CX5",
            Year = 2015,
            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { prius,mazda, chevy };
            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
            
          
            
            
            



        }

    }
}

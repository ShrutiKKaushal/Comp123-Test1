using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_CarClass
{
    class Car
    {
        //Private properties ++++++++++++++++++++
        private string Make;
        private string Model;
        private string Year;
        private string Colour;

        // Constructor Method ++++++++++++++++++++
        public Car(string Make, string Model, string Year, string Colour)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Colour = Colour;


            //Method Call
            show();
        }


     
        //Public Methods  +++++++++++++++++++++++++++++++++
        public void drive()
         {
            Console.WriteLine("The car is Driving");
         }

        public void show()
        {

            Console.WriteLine(" ********************* ");
            Console.WriteLine(" Car Make : {0}", this.Make);
            Console.WriteLine(" Car Model : {0}", this.Model);
            Console.WriteLine(" Car Year : {0}", this.Year);
            Console.WriteLine("Car Colour : {0}", this.Colour);
            Console.WriteLine(" ********************* ");
        }
    }
}

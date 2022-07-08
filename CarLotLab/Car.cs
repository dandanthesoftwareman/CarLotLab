using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotLab
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //Constructor with default values and no passed parameters
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0m;
        }

        //Constructor with 4 passed parameters
        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        //Override ToString() to return a custom formatted string of car details
        public override string ToString()
        {
            return string.Format("{0,-20} | {1,-20} | {2,-20} | {3,-20}", $"{Make}", $"{Model}", $"{Year}",$"${Price}");
;
        }

        //methods

    }
}

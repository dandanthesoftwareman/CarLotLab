using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotLab
{
    internal class UsedCar : Car
    {
        public double Mileage { get; set; }
        //constructor
        public UsedCar(string make, string model, int year, decimal price,double mileage) : base(make,model,year,price)
        {
            Mileage = mileage;
        }

        //Override ToString() to return a custom formatted string of car details
        public override string ToString()
        {
            return string.Format("{0,-20} | {1,-20} | {2,-20} | {3,-20}| {4,-20}", $"(Used) {Make}", $"{Model}", $"{Year}",$"${Price}", $"{Mileage} miles");
        }

    }
}

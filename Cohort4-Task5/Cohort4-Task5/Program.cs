using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort4_Task5
{
    public class Car
    {

        public int Year { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public string PalletNumber { get; set; }
        public string Model { get; set; }
        public Car(int year, string color, double price, string type, string palletNumber, string model)
        {
            this.Year = year;
            this.Color = color;
            this.Price = price;
            this.Type = type;
            this.PalletNumber = palletNumber;
            this.Model = model;
        }
        
        public void Start()
        {
            Console.WriteLine("The car engine is on");
        }
        public void Stop()
        {
            Console.WriteLine("The car engine is off");
        }

        public string Display()
        {

             return $"The year is : {this.Year}\n The color is : {this.Color}\n The price is : {this.Type}\n The Model is : {this.Model}\n The Paller Number is : {this.PalletNumber}\n";

        }
    }

    public class BMW : Car
    {
        public BMW(int year, string color, double price, string type, string palletNumber, string model) : base(year, color, price, type, palletNumber, model)
        {

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Car car = new Car(2000, "Red", 25000, "Mercedes", "47 - 2020", "G63");
            car.Start();
            car.Stop();
            Console.WriteLine(car.Display());

            //////********************************************//////

            BMW bmw = new BMW(2024, "DarkBlue", 35000, "BMW", "40 - 4142", "X5");
            Console.WriteLine(bmw.Display());

        }
    }
    
}

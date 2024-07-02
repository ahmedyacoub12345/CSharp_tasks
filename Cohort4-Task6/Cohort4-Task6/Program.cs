using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort4_Task6
{
    class Car
    {
        public int Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public string PalletNumber { get; set; }
        public string Color { get; set; }

        public Car(int make, int year, string type, double price, string model, string palletNumber, string color)
        {
            Make = make;
            Year = year;    
            Type = type;
            Price = price;
            Model = model;
            PalletNumber = palletNumber;
            Color = color;
        }
        public void DisplayInfo(int make , int year)
        {
            Console.WriteLine($"Car Make : {make} , Year is : {year}");

        }
        public void DisplayInfo(int make)
        {
            Console.WriteLine($"Car Make : {make}");
        }
        public virtual void Display()
        {
            Console.WriteLine("Welcome Car");
        }
    }
    class BMW : Car
    {
        public BMW(int make, int year, string type, double price, string model, string palletNumber, string color) :base(make,year,type,price,model,palletNumber,color)
        {

        }
        
        public override void Display()
        {
            Console.WriteLine("welcome BMW");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(2024,2024,"Mercedes",55000,"G63","47-4747","Silver");
            car1.DisplayInfo(2020, 2023);
            car1.DisplayInfo(2000);
            car1.Display();
            Console.WriteLine("********************");

            BMW bmw = new BMW(2020, 2021, "BMW", 50000, "X5", "40-4849", "Blue");

            bmw.DisplayInfo(2000);
            bmw.DisplayInfo(2001,2005);
            bmw.Display();
            Console.WriteLine("********************");


            Car car = new BMW(2020, 2021, "BMW", 50000, "X5", "40-4849", "Blue");
            car.Display(); 
                
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort4_Task5
{
    public class Car
    {
        // Short hand : prop + tab to build a proparity ...
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
            Console.WriteLine("The Car Engine is ON");
        }
        public void Stop()
        {
            Console.WriteLine("The Car Engine is OFF");
        }

        public string Display()
        {

             return $"The year is : {this.Year}\n The color is : {this.Color}\n The price is : {this.Type}\n The Model is : {this.Model}\n The Paller Number is : {this.PalletNumber}\n";

        }
    }

    public class BMW : Car
    {
        // Note : base is a perant for BMW and i write in the base (arguments of Car ,but without type of value)
        //Note : internal class : i can use assemply this class in all blocks of code . 
        //if i have a another class file ,i can't use this class , الا اذا وضعت نوع ال class is a public class . لانه بنيم سبيس مختلف عن النيم سبيس اللي انا فيها مثل ملف ال program.cs .
        // initial value for string = "" and initial value for int = 0 .
        // if the class type is seald class i can't inherit the seald class to any another class . 
        //i use static with method ex : static void print(){Consol.WriteLine("Ahmed Yacoub")} and i can call this function in main like This code : print() ... without call name of class .مثلا بقدر اكتي=ب اي ميثود باي مكان واستدعيه .



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
            bmw.Start();
            bmw.Stop();

        }
    }
    
}

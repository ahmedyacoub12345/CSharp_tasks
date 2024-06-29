using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cohort4_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question1
            Console.WriteLine("Enter two number for detect minimum number :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int smallerNumber = Math.Min(num1, num2);
            Console.WriteLine("The smaller number is: " + smallerNumber);
            Console.WriteLine("*************************************");

            ///////////////////////////////////////////////////////////////////

            //Question2
            Console.WriteLine("Enter Number For detect Sign : ");
            int number = int.Parse(Console.ReadLine());
            string sign = (number > 0) ? "+" : (number < 0) ? "-" : "0";
            Console.WriteLine("The sign is " + sign);
            Console.WriteLine("*************************************");

            //Other way :
            //string x = "-10";
            //string y = "20";
            //Console.WriteLine(x[0]);
            //Console.WriteLine(y[0]);

            //////////////////////////////////////////////////////////////////

            //Question3
            Console.WriteLine("Sort The number:");

            int[] numbers = { 0, -1, 4 };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
            Console.WriteLine("*************************************");

            ////////////////////////////////////////////////////////////////

            //Question4
            Console.WriteLine("Show the maximum number :");
            int[] num = { -5, -2, -6, 0, -1 };
            int maxNumber = Math.Max(num[0], Math.Max(num[1], Math.Max(num[2], Math.Max(num[3], num[4]))));
            Console.WriteLine("maxNumber is: " + maxNumber);
            Console.WriteLine("*************************************");

            //////////////////////////////////////////////////////////////////

            //Question5
            Console.WriteLine("converts kilometers per hour to miles per hour.");
            double kilometersPerHour = double.Parse(Console.ReadLine());
            double milesPerHour = kilometersPerHour * 0.621371;
            Console.WriteLine($"{kilometersPerHour} kilometers per hour is {milesPerHour} miles per hour");
            Console.WriteLine("*************************************");

            //////////////////////////////////////////////////////////////

            //Question6
            Console.WriteLine("takes hours and minutes as input and calculates the total number of minutes.");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("enter minute:");
            int minutes = int.Parse(Console.ReadLine());
            int totalMinutes = (hours * 60) + minutes;
            Console.WriteLine($"Total: {totalMinutes} minutes.");
            Console.WriteLine("*************************************");

            ////////////////////////////////////////////////////////////

            //Question7
            Console.WriteLine("takes minutes as input and display the total number of hours and minutes.");
            int TotalMinutes = int.Parse(Console.ReadLine());
            int Hours = TotalMinutes / 60;
            int Minutes = TotalMinutes % 60;
            Console.WriteLine($"{Hours} Hours, {Minutes} Minutes");
            Console.WriteLine("*************************************");

            ////////////////////////////////////////////////////////

            //Question8
            Console.WriteLine("Show the Sentance based on fixed length.");
            string[] sentences = {"My Name Is ", "Ahmed mohammed yacoub", "i was old year", "24 Years Old", "Thanks."
            };
            int fixedLength = 10;
            Console.WriteLine(sentences[0].Substring(0, fixedLength));
            Console.WriteLine(sentences[1].Substring(0, fixedLength));
            Console.WriteLine(sentences[2].Substring(0, fixedLength));
            Console.WriteLine(sentences[3].Substring(0, fixedLength));
            Console.WriteLine(sentences[4].Substring(0, fixedLength));
            Console.WriteLine("*************************************");

            


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cohort4_Task4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double[] array = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i+1} = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Class1 class1 = new Class1();
            Console.WriteLine(class1.AvarageSum(array));
            Console.WriteLine(class1.AvarageSum(array).Item1);
            Console.WriteLine(class1.AvarageSum(array).Item2);
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();
            /////////////////////////////////////////////////////////////////////////
            

            Console.Write("Enter the Number of cube : ");
            double num = double.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Numbers is{i} and cube of the {i} is : {Class1.cube(i)}");
            }
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();
            /////////////////////////////////////////////////////////////////////////////////


            int[] year = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            Class1 yer = new Class1();
            int[] newyear = yer.GreaterYears(year);
            Console.WriteLine("Years Greater Than 1950 : ");
            for (int i = 0; i < newyear.Length; i++)
            {
                if (newyear[i] != 0)
                {
                    Console.WriteLine(newyear[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////



            Console.Write("Enter your Age : ");
            double yearindays = double.Parse(Console.ReadLine());
            Class1 days = new Class1();
            days.YearsInDays(yearindays);
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();
            ////////////////////////////////////////////////////////////////////////////////////



            Informations ahmedInformation = new Informations(24, "male", "Ahmed", "ahmed@yahoo.com", 123321, "0797182579");

            ahmedInformation.Display();


        }
    }
}

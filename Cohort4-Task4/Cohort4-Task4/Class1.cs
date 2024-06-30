using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort4_Task4
{
    internal class Class1
    {
        public (double, double) AvarageSum(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avarge = sum / array.Length;
            return (sum, avarge);

        }


        public static double cube(int number)
        {
            double cube = number * number * number;
            return cube;

        }



        public int[] GreaterYears(int[] year)
        {
            int[] years = new int[year.Length];
            for (int i = 0; i < year.Length; i++)
            {
                if (year[i] >= 1950)
                {
                    years[i] = year[i];
                }
            }
            return years;
        }


        public void YearsInDays(double x)
        {
            Console.WriteLine($"Your age in days = {x * 365}");
        }




    }
}

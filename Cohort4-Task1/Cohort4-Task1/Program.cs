using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohort4_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string print = Console.ReadLine();
            Console.WriteLine ("The string you input to print : "+print) ;
            Console.WriteLine("********************************");
            //////////////////////////////////////////////////////////////

            double x = 76.4848;
            Console.WriteLine(x);

            int c = 5;
            Console.WriteLine(c);

            string name = "Ahmed Yacoub";
            Console.WriteLine(name);

            char character = 'A';
            Console.WriteLine(character);

            bool boolian = true;
            Console.WriteLine(boolian);

            const int i = 15; 
            Console.WriteLine(i);
            //i = 60;
            Console.WriteLine("********************************");

            ///////////////////////////////////////////////////////////////////

            string[] arrayOfCars = { "Mercedes", "BMW", "Hyundai", "Ferari" };
            for (int r = 0; r < arrayOfCars.Length; r++) {
                Console.WriteLine(arrayOfCars[r]);
                
            }
            Console.WriteLine(arrayOfCars.Length);
            Console.WriteLine("********************************");
            ///////////////////////////////////////////////////////////////////
            
            string firstName = Console.ReadLine();
            string surrName = Console.ReadLine();
            string birthDate = Console.ReadLine();
            Console.WriteLine(firstName + " " + surrName + " " +birthDate );
            Console.WriteLine("********************************");
            ///////////////////////////////////////////////////////////////
            int[] arrayOfNum = new int[10];
            arrayOfNum[0] = 1;
            arrayOfNum[1] = 1;
            arrayOfNum[2] = 2;
            arrayOfNum[3] = 3;
            arrayOfNum[4] = 4;
            arrayOfNum[5] = 5;
            arrayOfNum[6] = 6;
            arrayOfNum[7] = 7;
            arrayOfNum[8] = 8;
            arrayOfNum[9] = 9;
            Console.WriteLine("Elements in array are:" + arrayOfNum[0] +" "+ arrayOfNum[1] + " " + arrayOfNum[2] + " " + arrayOfNum[3] + " " + arrayOfNum[4] + " " + arrayOfNum[5] + " " + arrayOfNum[6] + " " + arrayOfNum[7] + " " + arrayOfNum[8] + " " + arrayOfNum[9]);
            Console.WriteLine("********************************");
            ///////////////////////////////////////////////////////
            
            int[] testData = {2,7,8};
            Console.WriteLine(testData[0] + testData[1] + testData[2]);
        }
    }
}

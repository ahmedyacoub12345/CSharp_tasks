using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cohort4_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1 - Correct the syntax error:

            //•	string[] ARR = [1, 7  9  45,]
            //•	int arr2 = ["Str" "alex","moh"
            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]

            int[] Arr = { 1, 7, 9, 45 };

            string[] arr2 = { "str", "alex", "moh" };

            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            //2 - What the index of "Banana","Tomato" ?
            //String[ ]  fruits = ["Tomato", "Banana", "Watermelon"]

            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine("The index of \"Banana\" :");
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            Console.WriteLine("The index of \"Tomato\" :");
            Console.WriteLine(Array.IndexOf(fruits, "Tomato"));

            //3 - Create an multiple arrays that represents your:
            //•	Favorite Food(5 item)
            //•	Favorite Sport(3 item)
            //•	Favorite Movie(4 item)
            //Then, print each array using foreach, and Loop Through an Array

            string[] favFood = { "Mansaf", "Kabsah", "Makmoura", "Mandi", "Shawermah" };
            string[] favSport = { "Football", "Basketball", "Vollyball" };
            string[] favMovies = { "Babalhara", "GameOfThronse", "LacasaDePabale", "Hakaya" };
            foreach (string food in favFood)
            {
                Console.WriteLine("The favorite food is : " + food);
            }
            Console.WriteLine("**************");
            foreach (string sport in favSport)
            {
                Console.WriteLine("The favorite sport is : " + sport);
            }
            Console.WriteLine("**************");
            foreach (string movie in favMovies)
            {
                Console.WriteLine("The favorite movies is : " + movie);
            }
            Console.WriteLine("*****************************");


            //4 - Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            //•	Expected Output:
            //•	Input three numbers separated by comma: 5,10,15
            //•	The sum of three numbers: 30.

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2 + num3);
            Console.WriteLine("*****************************");

            //5 - Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            //•	Test Data
            //•	The odd numbers are1 3 5 7 9 11 13 15 17 19……
            //•	The Sum of odd Numbers is: …...
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("The odd number is : " + i);
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of odd Numbers is : {sum}");
            Console.WriteLine("******************************");


            //6 - Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
            //The pattern like:
            //   *
            //  **
            // ***
            //****

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }

            Console.WriteLine("************************************");

            //7 - Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            //The pattern like :

            //    1
            //   2 3
            //  4 5 6
            //7 8 9 10

            int number = 1; 

            for (int i = 1; i <= 4; i++)
            {
                // Print spaces
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }

                // Print numbers
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }

                Console.WriteLine(); 

            }

        }

    }
}

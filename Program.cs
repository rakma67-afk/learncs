using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'Hello World!'");
            /*
             * int a = 10;
             * float b = 20.5f;
             * duble c = 30.5;
             * char d = 'A';
             * string e = "Hello";
             * 
             * var f = 100; // Implicitly typed variable
             * const double pi = 3.14159; // Constant variable
             */

            string[] fruits = { "Apple", "Banana", "Orange" };

            string[] cars = new string[3];
            cars[0] = "BMW";
            cars[1] = "Audi";

            List<int> list = new List<int>();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            char grade = 'A';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good!");
                    break;
                case 'C':
                    Console.WriteLine("Average!");
                    break;
                case 'D':
                    Console.WriteLine("Below Average!");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            
            string Hello(string name)
            {
                return $"Hello {name} from the Hello method!";
            }

            Console.WriteLine(Hello("Jay"));

            string NumberCompare(int num1, int num2)
            {
                if (num1 > num2)
                {
                    return $"{num1} is greater than {num2}";
                }
                else if (num1 < num2)
                {
                    return $"{num1} is less than {num2}";
                }
                else
                {
                    return $"{num1} is equal to {num2}";
                }
            }

            Console.WriteLine( NumberCompare(10, 20));
        }
    }
}

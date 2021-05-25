using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = 0;
            decimal num2 = 0;
            Console.WriteLine("HI There! Welcome to my Calci...!!\r");
            Console.WriteLine("********************************\n");

            Console.WriteLine("Type a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hi User! Please choose an option from below");
            Console.WriteLine("\tA - Add");
            Console.WriteLine("\tS - Subtract");
            Console.WriteLine("\tM - Multiply");
            Console.WriteLine("\tD - Division");
            Console.WriteLine("What is your option?");

            switch(Console.ReadLine())
            {
                case "A":
                    Console.WriteLine($"Your Result:{num1}+{num2}=" + (num1 + num2));
                    break;
                case "S":
                    Console.WriteLine($"Your Result:{num1}-{num2}=" + (num1 - num2));
                    break;
                case "M":
                    Console.WriteLine($"Your Result:{num1}*{num2}=" + (num1 * num2));
                    break;
                case "D":
                    while(num2==0)
                    {
                        Console.WriteLine("Enter a non-zero divisor:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your Result:{num1}/{num2}=" + (num1 / num2));
                    break;

            }
            Console.WriteLine("Press any key to close the Calci! Thank you :)");
            Console.ReadKey();

        }
    }
}

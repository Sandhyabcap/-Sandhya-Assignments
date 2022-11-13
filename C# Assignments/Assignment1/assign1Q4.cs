using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{

    internal class Assign1Q4
    { 
          static void Main(string[] args)
            {
                int num1, num2, temp;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("enter first integer");
                Console.ForegroundColor = ConsoleColor.White;
                num1 = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("enter second integer");
                Console.ForegroundColor = ConsoleColor.White;
                num2 = int.Parse(Console.ReadLine());
                temp = num1;
                num1 = num2;
                num2 = temp;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("After Swapping : ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n First integer : " + num1);
                Console.Write("\n Second integer : " + num2);
                Console.Read();




            }
        }
    }




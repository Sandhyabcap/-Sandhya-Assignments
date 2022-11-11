using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class AssignQ1
    {
        
    
        
        
            static void Main(string[] args)
            {
                Console.WriteLine("--------SELECT OPTION----------");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division \n");
                Console.WriteLine("en");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st input");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (action)
                {
                    case 1:
                        {
                            result = Addition(num1, num2);
                            break;
                        }
                    case 2:
                        {
                            result = Subtraction(num1, num2);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(num1, num2);
                            break;
                        }
                    case 4:
                        {
                            result = Division(num1, num2);
                            break;
                        }
                    default:
                        Console.WriteLine("select correct option");
                        break;
                }
                Console.WriteLine("The result is {0}", result);
                Console.ReadKey();
            }
            //Addition
            public static int Addition(int num1, int num2)
            {
                int add = num1 + num2;
                return add;
            }
            //Substraction
            public static int Subtraction(int num1, int num2)
            {
                int sub = num1 - num2;
                return sub;
            }
            //Multiplication
            public static int Multiplication(int num1, int num2)
            {
                int multi = num1 * num2;
                return multi;
            }
            //Division
            public static int Division(int num1, int num2)
            {
                int div = num1 / num2;
                return div;
            }
        }
    }


    



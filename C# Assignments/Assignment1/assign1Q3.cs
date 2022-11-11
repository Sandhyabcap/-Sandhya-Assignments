using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class assign1Q3
    {
      
            static void Main(string[] args)
            {
                int[] a = new int[100];
                int i, n, sum = 0;

                Console.Write("Enter array limit :");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("Enter the numbers as per ur limit {0} : ", i);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (i = 0; i < n; i++)
                {
                    sum += a[i];
                }

                Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
                Console.ReadKey();

            }
        }

    }


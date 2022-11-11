using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assign1Q2
    {
        public static void Main()

        {
            Console.WriteLine("Average marks of 5 students:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int[] average = { a, b, c, d, e };
            Console.WriteLine("maximum marks obtained are:" + average.Max());
            Console.ReadKey();

        }
    }
}

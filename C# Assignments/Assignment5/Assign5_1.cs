using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ArrayClass
    {
        public static void Main()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            string[] array2 = new string[5];
            array2[0] = "Sandhya";
            array2[1] = "Poornima";
            array2[2] = "Vaishnavi";
            array2[3] = "Santhoshi";
            array2[4] = "Teju";
            int i;
            Console.WriteLine("-----The int values are-----");
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                Console.WriteLine("-----The STRING values---");
            }
            foreach (string str in array2)
            {
                Console.WriteLine(str);

            }
            Console.WriteLine();
            Console.WriteLine("-----The copied Int/String values are-----");
            Console.WriteLine("-----The Sorted Array-----");
            Array.Sort(array);
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine();
            }
            foreach (string str in array2)
            {
                Console.WriteLine(str);

            }
            Console.WriteLine();
            Console.WriteLine("-----clear the Array----");
            Array.Clear(array, 1, 2);

            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                Console.WriteLine();
                Array.Clear(array, 1, 2);
            }
            foreach (string str in array2)
            {
                Console.WriteLine(str);
                Console.WriteLine();
            }
            Console.WriteLine("-------REVERSED ARRAY----");
            Array.Reverse(array2);
            foreach (string str in array2)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("reversed array");
            Array.Reverse(array);
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                Console.ReadLine();
            }


        }
    }
}
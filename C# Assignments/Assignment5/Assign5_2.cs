using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Assignment5_2
    {
      


        class Employee
        {
            protected int id;
            protected string name;
            protected double salary;


            public Employee()
            {
            }

            public Employee(int _id, string nm, double sal)
            {
                id = _id;
                name = nm;
                salary = sal;
            }


            public void PrintEmployee()
            {

                Console.WriteLine("id: {0}", id);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Salary: {0}", salary);


            }


        }


        class EmployeeArray : Employee
        {
            private Employee[] a;
            private int currSize;
            private const int SIZE = 100;

            public EmployeeArray()
            : base()
            {

            }
            public EmployeeArray(int s, int _id, string nm, double sal)
            : base(_id, nm, sal)
            {
                a = new Employee[SIZE];
                if (s > SIZE)
                    Console.WriteLine("Array size is overflow!");
                else if (s == SIZE)
                    Console.WriteLine("Array is full.");
                else
                    currSize = s;




            }

            public void Input()
            {
                a = new Employee[3];
                for (int i = 0; i < currSize; i++)
                {
                    a[i] = new Employee(id, name, salary);
                }



            }
            public void Output()
            {
                Console.WriteLine("Array is: ");
                foreach (Employee x in a)
                    Console.WriteLine("a[{0}]= {1}", name, x);


            }




            public int Search(int key)
            {
                for (int i = 0; i < currSize; i++)
                {
                    //if (a[i] == key)
                    // return i;
                }
                return -1;
            }

            public void Insert()
            {
                if (currSize == SIZE)
                {
                    Console.Write("Array is full! ");
                    return;
                }
                Console.WriteLine("Enter a number to insert: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Enter the index to where it is to insert: ");
                int pos = int.Parse(Console.ReadLine());
                for (int i = currSize; i > pos; i--)
                    a[i] = a[i - 1];


                //a[pos] = y;
                currSize++;
            }

            public void Delete()
            {
                if (currSize == 0)
                {
                    Console.WriteLine("Array is empty! ");
                    return;
                }
                Console.Write("Delete by value (1) or by index (2): ");
                int key = int.Parse(Console.ReadLine());
                int pos = -1;
                if (key == 1)
                {
                    Console.WriteLine("Enter the number to delete: ");
                    int d = int.Parse(Console.ReadLine());
                    pos = Search(d);
                    while (pos == -1)
                    {
                        Console.WriteLine("The number does not exist, enter again: ");
                        d = int.Parse(Console.ReadLine());
                        pos = Search(d);
                    }
                }
                else if (key == 2)
                {
                    Console.WriteLine("Enter the index to delete from: ");
                    pos = int.Parse(Console.ReadLine());

                    while (pos < 0 || pos > currSize)
                    {
                        Console.WriteLine("The index is out of range, enter again: ");
                        pos = int.Parse(Console.ReadLine());
                    }

                }
                else
                    return;

                for (int i = pos; i < currSize; i++)
                    a[i] = a[i + 1];

                currSize--;
                if (currSize <= 0)
                    Console.Write("Array is empty! ");
            }

            public void Update()
            {
                Console.WriteLine("Enter the index where to update: ");
                int pos = int.Parse(Console.ReadLine());
                while (pos < 0 || pos >= currSize)
                {
                    Console.WriteLine("The index you entered is not valid, enter again: ");
                    pos = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter the new value: ");
                int x = int.Parse(Console.ReadLine());
                //a[pos] = x;
                Console.Write("Update complete! ");
            }


        }
        class Program
        {
            //static char ShowMenu()
            //{
            // Console.WriteLine("\nEnter the letter of operation: \n(o)Print, (s)Search, (i)Insertion, (d)Deletion, (u)Update, (e)Exit\n");
            // return char.Parse(Console.ReadLine());
            //}
            static void Main(string[] args)
            {
                //char sel = ' ';
                Console.Write("Enter number of Employees; ");
                int i = 0;
                int s = int.Parse(Console.ReadLine());

                while (i < s)
                {


                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine("Enter id: ");
                    int _id = int.Parse(Console.ReadLine());


                    Console.WriteLine("");
                    Console.WriteLine("Enter Name: ");
                    string nm = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine("Enter Salary: ");
                    double sal = int.Parse(Console.ReadLine());

                    EmployeeArray arr = new EmployeeArray(s, _id, nm, sal);


                    i++;
                }



            }
        }
       
    }
}

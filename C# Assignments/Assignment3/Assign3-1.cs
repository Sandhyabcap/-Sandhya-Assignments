using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class _3_1
    {
       
            public interface Iprintable
            {
                void print();
            }
            public class EmployeeManagementSystem : Iprintable
            {
                public int salary;
                public void print()
                {
                    Console.WriteLine("enter the Fname of employee");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("enter the Lname of employee");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("enter salary : ");
                    salary = Convert.ToInt32(Console.ReadLine());
                    if (salary <= 0 || salary > 20000)
                    {
                        Console.WriteLine("enter valid salary");
                        print();
                    }
                    else if (salary < 5000)
                    {
                        Console.WriteLine("employee name : {0}", FirstName + LastName);
                        Console.WriteLine("Net Salary : {0}", salary);
                        int PF = 8 * (salary / 100);
                        Console.WriteLine("Gross salary is : {0}", salary + PF);
                    }
                    else if (salary > 5000 && salary < 10000)
                    {
                        Console.WriteLine("employee name : {0}", FirstName + LastName);
                        Console.WriteLine("Net Salary : {0}", salary);
                        int PF = 9 * (salary / 100);
                        Console.WriteLine("Gross salary is : {0}", salary + PF);
                    }
                    else if (salary > 10000 && salary < 20000)
                    {
                        Console.WriteLine("employee name : {0}", FirstName + LastName);
                        Console.WriteLine("Net Salary : {0}", salary);
                        int PF = 10 * (salary / 100);
                        Console.WriteLine("Gross salary is : {0}", salary + PF);
                    }
                }
                public class Manager : EmployeeManagementSystem
                {
                    private double PetrolAllowance;
                    private double FoodAllowance;
                    private double OtherAllowance;
                    public void Calculate()
                    {
                        Console.WriteLine("ENTER MANAGER SALARY :");
                        salary = Convert.ToInt32(Console.ReadLine());
                        PetrolAllowance = 8 * (salary / 100);
                        FoodAllowance = 13 * (salary / 100);
                        OtherAllowance = 3 * (salary / 100);
                        Console.WriteLine("GROSS SALARY OF MANAGER = {0}", salary + FoodAllowance + PetrolAllowance + OtherAllowance);
                    }
                    public void CalculateSalary()
                    {
                        Console.WriteLine("Net salary of mamnager = {0}", salary);
                    }
                }
                public class MarketingExecutive : EmployeeManagementSystem
                {
                    private int KmTravel;
                    private int TourAllowance;
                    private int TelephoneAllowance;
                    public void Calcualate()
                    {
                        Console.WriteLine("enter marketing executive salary : ");
                        salary = Convert.ToInt32(Console.Read());
                        Console.WriteLine("enter total distance trave in km :");
                        KmTravel = Convert.ToInt32(Console.Read());
                        TourAllowance = KmTravel * 5;
                        Console.WriteLine("Gross salary of marketing executive : {0}", salary + TourAllowance + TelephoneAllowance);
                    }
                    public void CalculateSalary()
                    {
                        Console.WriteLine("Net salary of marketing Executive = {0}", +salary);
                    }
                }
                public class Q1
                {
                    public static void Main()
                    {
                        Iprintable IP = new EmployeeManagementSystem();
                        IP.print();
                        EmployeeManagementSystem.Manager manager = new Manager();
                        manager.Calculate();
                        manager.CalculateSalary();
                        EmployeeManagementSystem.MarketingExecutive ME = new MarketingExecutive();
                        ME.Calcualate();
                        ME.CalculateSalary();
                        Console.ReadKey();
                    }
                }
            }
        
    }
}




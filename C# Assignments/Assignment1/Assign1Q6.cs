using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpQ1
{
    internal class csharpQ6
    
        {
            int bookid;
            string _title;
            float _price;
            int booktype;
            public int Id
            {
                get { return bookid; }
                set { bookid = value; }
            }
            public string Title
            {
                get { return _title; }
                set { _title = value; }
            }
            public float Price
            {
                get { return _price; }
                set { _price = value; }
            }
            public Type Booktype
            {
                get { return (Type)booktype; }
                set { booktype = (int)value; }
            }
            public void print()
            {
                Console.WriteLine("Your Book Id={0} Title={1} Price={2} Type={3}", bookid, _title, _price, booktype);
            }
            public enum Type
            {
                magazine,
                novel,
                referencebook,
                miscelleous
            }
            class Bookcall

            {
                public static void Main()
                {
                    try
                    {
                        csharpQ6 b1 = new csharpQ6();
                        b1.Id = 1;
                        b1.Title = "Changed History";
                        b1.Price = 860.44F;
                        b1.Booktype = Type.miscelleous;
                        b1.print();

                        csharpQ6 b2 = new csharpQ6();
                        b2.Id = 2;
                        b2.Title = "CSharp";
                        b2.Price = 763.21F;
                        b2.Booktype = Type.referencebook;
                        b2.print();

                        csharpQ6 b3 = new csharpQ6();
                        b3.Id = 3;
                        b3.Title = "Empty Pocket";
                        b3.Price = 899.23F;
                        b3.Booktype = Type.magazine;
                        b3.print();
                    }
                    catch (Exception Error)
                    {
                        Console.WriteLine(Error.ToString());
                    }
                    finally
                    {
                        Console.WriteLine("It was final");
                    }
                }
            }
        }
    }


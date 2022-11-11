using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Assignment5_3
    {

        class Player
        {
            public string Name { get; set; }
            public int Run { get; set; }
            public Player(string name, int run)
            {
                Name = name;
                Run = run;
            }
        }
        class Team : Assignment5_3
        {
            private Player[] playerArray = new Player[4];
            public Team()
            {
                playerArray[0] = new Player("virat", 30);
                playerArray[1] = new Player("Dhoni", 40);
                playerArray[2] = new Player("Rohit", 50);
                playerArray[3] = new Player("Zadeja", 60);
            }
            public System.Collections.IEnumerator GetEnumerator()
            {
                foreach (Player player in playerArray)
                {
                    Console.WriteLine("name is {0} and run is {1}", player.Name, player.Run);
                }
                return playerArray.GetEnumerator();
            }
            internal class program
            {
                public static void Main(string[] args)
                {
                    Team India = new Team();
                    India.GetEnumerator();
                    Console.ReadLine();
                }
            }
        }
    }
}




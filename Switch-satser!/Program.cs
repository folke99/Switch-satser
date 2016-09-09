using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_satser
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Övning 1
            Console.WriteLine("Skriv in ett heltal:");
            int tal = int.Parse(Console.ReadLine());

            switch (tal) {
                case 1: Console.WriteLine("Ett"); break;
                case 2: Console.WriteLine("Två"); break;
                case 3: Console.WriteLine("Tre"); break;
                case 4: Console.WriteLine("Fyra");break;
                default: Console.WriteLine("Ojiltigt allternativ"); break;
              }
            Console.ReadKey();

            //Övning 2
            */
            Console.WriteLine("Skriv N,S,E eller W");
            string bokstav = Console.ReadLine();

            switch (bokstav)
            {
                case "N": Console.WriteLine("You walk north"); break;
                case "S": Console.WriteLine("You walk south"); break;
                case "W": Console.WriteLine("You walk west"); break;
                case "E": Console.WriteLine("You walk east"); break;
                default: Console.WriteLine("I dont understand!"); break;
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetTheUser
{
    internal class Program
    {
        static void SayHi()
        {
            Console.Write("What is your name: ");
            string sName = Console.ReadLine();

            Console.WriteLine("Hello " + sName);
        }
        static void Main(string[] args)
        {
            //ConsoleColor
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Call the SayHi method
            //Greet the User
            SayHi();

            //Press any key to exit the program
            Console.WriteLine("\nPress Any key yo exit the progam...");
            Console.ReadKey();
        }
    }
}

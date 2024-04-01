using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxOS.Terminal
{
    internal class Main
    {
        public static void Terminal()
        {
            var input = Console.ReadLine();
            if (input == "help" || input == "Help")
            {
                Help();
            }
            else if (input == "clear")
            {
                Console.Clear();
            }
            else if (input == "echo")
            {
                Echo();
            }
            else if (input == "")
            {
                Console.WriteLine("Please Type A Command In The Terminal!");
            }
            else
            {
                Console.WriteLine("The command " + input + " is not a valid command");
                Console.WriteLine("please make sure you are using the correct capitalization");
                Console.WriteLine("do the command 'help' to see all valid commands");
                Console.WriteLine();
            }
        }

        public static void Help()
        {
            Console.WriteLine();
            Console.WriteLine("Here Are A List Of Commands You Can Perform:");
            Console.WriteLine();
            Console.WriteLine("help: shows a list of commands you can perform.");
            Console.WriteLine("clear: Clears the console.");
            Console.WriteLine("echo: Prints what you typed into the console.");
            Console.WriteLine();
        }

        public static void Echo()
        {
            Console.WriteLine("Type what you would like to have printed to the console.");
            Console.Write("echo: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.WriteLine();
        }
    }
}

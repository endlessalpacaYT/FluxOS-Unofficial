using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Sys = Cosmos.System;

namespace FluxOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("FluxOS 0.01 booted successfully.");
            Console.WriteLine();
            Console.WriteLine("To Show A list Of Commands Type The Command 'Help'");
            Console.WriteLine();
        }

        protected override void Run()
        {
            Console.Write("-> ");
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

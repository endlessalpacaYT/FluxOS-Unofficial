using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace FluxOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("FluxOS booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}

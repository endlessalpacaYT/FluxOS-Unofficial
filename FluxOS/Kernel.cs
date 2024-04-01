using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace FluxOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Filesystem.Main.Filesystem();
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("FluxOS 0.01 booted successfully.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("To Show A list Of Commands Type The Command 'Help'");
            Console.WriteLine();
        }

        protected override void Run()
        {
            Console.Write("-> ");
            Terminal.Main.Terminal();
        }

        
    }
}
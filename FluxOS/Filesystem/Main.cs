using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace FluxOS.Filesystem
{
    internal class Main
    {
        public static void Filesystem()
        {
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("Filesytem Active");
        }
    }
}

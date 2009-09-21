using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var megabytes = 40.5;

            bool ok = CheckFreeSpace(megabytes);
            Console.WriteLine(ok);
        }

        private static bool CheckFreeSpace(double megabytes)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var driveName = Path.GetPathRoot(currentDirectory);
            var drive = new DriveInfo(driveName);
            checked
            {
                var requiredBytes = (long)megabytes * 1048576L;
                return drive.AvailableFreeSpace > requiredBytes;
            }
        }
    }
}

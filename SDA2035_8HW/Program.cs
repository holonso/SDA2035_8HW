using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SDA2035_8HW
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Soft";
            string searchPattern = "*.*";
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] directories = dir.GetDirectories(searchPattern, SearchOption.AllDirectories);

            Console.WriteLine("{0}\\", path);
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("- {0}", file.Name);
            }
            Console.WriteLine();

            foreach (DirectoryInfo subdir in directories)
            {
                Console.WriteLine("{0}\\", subdir.FullName);

                foreach (FileInfo file in subdir.GetFiles())
                {
                    Console.WriteLine("- {0}", file.Name);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

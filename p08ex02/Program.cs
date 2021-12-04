using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p08ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "randomNumbers.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            Random random = new Random();

            int[] writeArray = new int[10];
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (int i in writeArray)
                {
                    writeArray[i] = random.Next(0, 500);
                    sw.WriteLine("{0}", writeArray[i]);
                    Console.WriteLine("{0} ", writeArray[i]);
                }
            }
            Console.WriteLine();

            int[] readArray = new int[10];
            int S = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        readArray[j] = Convert.ToInt32(sr.ReadLine());
                        S += readArray[j];
                    }
                }
            }
            Console.WriteLine("S = {0}", S);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    Console.Write((i == 0 ? j : (j == 0 ? i : i * j)) + "\t");
                }
                Console.Write("\n");

                Console.Write("\n");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("\n");


            }
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

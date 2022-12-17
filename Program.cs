using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello at Prime application");

            Console.WriteLine("Please Enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter n2");
            int n2 = int.Parse(Console.ReadLine());


            for (int i = n1; i <= n2; i++)
            {
                int count = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                {

                    Console.WriteLine("\n" + i + "is prime");


                }

            }



            Console.ReadKey();

        }
    }
}

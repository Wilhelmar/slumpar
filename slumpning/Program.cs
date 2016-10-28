using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slumpning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            Console.WriteLine("Övning 1");

            Random slump = new Random();
            int summa = 0;
            int tal = 0;
            for (int i = 0; i <= 10; i++)
            {
                tal = slump.Next(1,21);
                summa = summa + tal;
                Console.Write(tal + " ");
            }
            Console.WriteLine("Medelvärdet är: " + summa/10);

            Console.ReadLine();

            //Övning 2

            Console.WriteLine("Övning 2");

            Random randomiserare = new Random();
            int[] lager = new int[20];
            int talen = 0;

            for (int i = 0; i < 20; i++)
            {
                talen = randomiserare.Next(15, 31);
                lager[i] = talen;
            }
            Array.Sort(lager);
            for (int y = 0; y < lager.Length; y++)
            {
                Console.Write(lager[y] + " ");
                if (y == 9)
                {
                    Console.Write(":" + " ");
                }
            }
            Console.ReadLine();
            Console.WriteLine("Medianvärdet är: " + (lager[9] + lager[10])/2);

            Console.ReadLine();

            //Övning 3

            Console.WriteLine("Övning 3");



            
        }
    }
}

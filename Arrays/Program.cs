using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = { "ayşe", "ali", "veli" };

            //foreach (var student in students) 
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"İstanbul" , "Kocaeli" , "Bursa" },
                {"Ankara" , "Konya" , "Kırşehir" },
                {"Antalya" , "Adana" , "Mersin" },
                {"İzmir" , "Muğla" , "Aydın" },
                {"Rize" , "Trabzon" , "Ordu" },
                
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }

                Console.WriteLine("**********");
            }

            Console.ReadLine();
        }
    }
}

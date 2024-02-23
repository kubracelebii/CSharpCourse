using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            bool condition = false;
            char character = 'a';
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            double number5 = 10.4;
            decimal number6 = 10.4m;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine(number7); // var ı int olarak başlattığımız için A nın int karşılığını ekrana bastırır.
            Console.WriteLine("Number is {0}",number1); //32 bit
            Console.WriteLine("Number is {0}",number2); //64 bit
            Console.WriteLine("Number is {0}",number3); //16 bit
            Console.WriteLine("Number is {0}",number4); //8 bit yani 1 byte
            Console.WriteLine("Number is {0}",number5);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}

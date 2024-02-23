using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(10, 20);
            //Console.WriteLine(result);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1 , number2); // burada ref diyerek number1 çağrıldığında onun değerini aşağıda yazdığımız methoddaki şekilde referans almamızı sağlar.
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(Multiply(2,5,10));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2=30) // default değer verme
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2) //ref yerine out kullanır isek bu method içinde kesinlikle set etmemiz gerekir.Fakat yukarıda number1 e değer vermemizin bi önemi yoktur.
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add4(params int[] numbers) // params diyerek bir veya birden fazla aynı türden parametre ile iş yapabilmemizi sağlar.
        {
            return numbers.Sum();
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int  number3) // aynı method fakat parametreler farklı ise buna overloading denir.
        {
            return number1 * number2 * number3;
        }
    }
}

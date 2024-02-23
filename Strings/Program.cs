using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Kübra";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "my name is ayşe";

            bool result3 = sentence.EndsWith("a");
            bool result4 = sentence.StartsWith("my");
            var result5 = sentence.IndexOf("name"); // sentence içinde baştan name arar
            var result6 = sentence.LastIndexOf("name"); // sentence içinde sondan name arar
            var result7 = sentence.Insert(0, "Hello, "); // 0.indexten sonra bunu yazdır.
            var result8 = sentence.Substring(3); // 3.indexten itibaren al
            var result9 = sentence.ToLower(); // karakterleri küçük yap
            var result10 = sentence.ToUpper(); // karakterleri büyük yap
            var result11 = sentence.Replace(" ", "-"); // boşluk gördüğü yere - ekle
            var result12 = sentence.Remove(2,5); // 2. indexten sonra 5 karakter sil
            Console.WriteLine(result5);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            foreach (var s in city)
            {
                Console.WriteLine(s);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}

using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici ...";
            string kurs2 = "Programlamaya başlangıç ...";
            string kurs3 = "Java";

            //Array - dizi

            string[] kurslar = new string[]
            { "Yazılım Geliştirici ...", "Programlamaya başlangıç ...","Java","Python"};
         

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu-footer");
        }
        
    }
}

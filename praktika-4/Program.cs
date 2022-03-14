using System;

namespace praktika_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******");
            Console.WriteLine("Yarishmaya xosh geldiniz");
            Console.Title = "Bilgi yarishmasi";
            string ad, soyad;
            Console.WriteLine("Adiniz");
            ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyadiniz");
            soyad= Convert.ToString(Console.ReadLine());


            Console.WriteLine("Basliyirig  Enter Duymesine Bashin");

            Console.WriteLine("Cavabinizi BOYUK herifle yazin");
            Console.ReadLine();
            int dogru, sehf, pul;
            dogru = 0;
            sehf = 0;
            pul = 0;

            string s1;
            Console.WriteLine("Sual 1- Daglig Qarabag uzerinde Zefer gunumuz hansi tarixdir ? Enter");
            s1 = Convert.ToString(Console.ReadLine());
            string c1;
            Console.WriteLine("A-11.11.2020/ B-08.09-2020/ C-9-12.2020/ D-08.11.2020 Cavabiniz:");
            c1 = Console.ReadLine();
            if ( c1== "D")
            {
                dogru = dogru + 1;
                pul = pul + 100;
                Console.WriteLine("Tebrikler Cavabiniz dogrudur, Enter duymesine bashin");
                Console.ReadLine();

            }
        



            







        }
    }
}

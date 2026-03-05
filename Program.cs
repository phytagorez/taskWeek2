using System;
using case1; //mobil
using case2; //ikan
using case3; //burung
using case4; //komputer

namespace taskWeek2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Mobil Sedan ===");

            mobilSedan m1 = new mobilSedan(4) { };
            m1.Maju(10);
            m1.isiBensin(5);


            Console.WriteLine("\n\n=== Ikan ===");

            Ikan ikan1 = new Ikan();
            ikan1.Menyelam(5);
            ikan1.Makan(3);


            Console.WriteLine("\n\n=== Burung ===");
            Burung burung1 = new Burung();
            burung1.Terbang(8);
            burung1.sedangMinum(199);


            Console.WriteLine("\n\n=== Komputer ===");
            Komputer komputer1 = new Komputer();
            komputer1.NyalakanKipas(10);
            komputer1.MulaiAplikasi(20);
        }
    }
}
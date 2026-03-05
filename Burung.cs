using System;
using System.Collections.Generic;
using System.Text;

namespace case3
{
    class Burung
    {
        public int Ketinggian;
        public int Begah;

        public Burung()
        {
            this.Ketinggian = 0;
            this.Begah = 0;
        }

        public void Terbang(int meter)
        {
            Ketinggian += meter;
            Console.WriteLine($"Burung terbang pada ketinggian {Ketinggian} meter di atas permukaan laut");
        }

        public void sedangMinum(int miliLiter)
        {
            Begah += miliLiter;

            if (Begah >= 500)
            {
                Begah = 500;
                Console.WriteLine("Burung sudah begah");
            }
            else if (Begah < 200)
            {
                Console.WriteLine("Burung sedang kehausan");
            }
            else
            {
                Console.WriteLine("Burung sedang terhidrasi normal");
            }
        }

    }
}

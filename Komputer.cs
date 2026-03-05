using System;
using System.Collections.Generic;
using System.Text;

namespace case4
{
    class Komputer
    {
        public int Suhu;
        public int bebanCpu;

        public Komputer()
        {
            this.Suhu = 38;
            this.bebanCpu = 0;
        }

        public void NyalakanKipas(int turunSuhu)
        {
            Suhu -= turunSuhu;
            Console.WriteLine($"Kipas menyala suhu laptop turun menjadi {Suhu}");
        }

        public void MulaiAplikasi(int tambahBeban)
        {
            bebanCpu += tambahBeban;

            if (bebanCpu >= 100)
            {
                bebanCpu = 100;
                Console.WriteLine($"CPU digunakan {bebanCpu}%, membuat laptop overheat!!");
            }
            else if (bebanCpu < 50)
            {
                Console.WriteLine($"Beban CPU {bebanCpu}%, laptop aman dan lancar");
            }
            else
            {
                Console.WriteLine($"Beban CPU {bebanCpu}%, laptop sudah mulai terasa berat untuk digunakan");    
            }
        }
    }
}

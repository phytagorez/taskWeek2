using System;
using System.Collections.Generic;
using System.Text;

//namespace buat import ke Program.Cs
namespace case2
{
    //class ikan
    class Ikan
    {
        //fields
        public int Kedalaman;
        public int Kenyang;

        //constructor
        public Ikan()
        {
            this.Kedalaman = 0;
            this.Kenyang = 0;
        }

        //method
        public void Menyelam(int meter)
        {
            Kedalaman += meter;
            Console.WriteLine($"Ikan saat ini menyelam pada kedalaman {Kedalaman} meter dibawah permukaan laut");
        }

        public void Makan(int jmlPelet)
        {
            Kenyang += jmlPelet;
            {
                if (Kenyang >= 10)
                {
                    Console.WriteLine("Ikan sudah kenyang, stop memberi makan");
                }
                else if (Kenyang < 4)
                {
                    Console.WriteLine("Ikan dalam keadaan kelaparan banget");
                }
                else
                {
                    Console.WriteLine("Ikan dalam keadaan perut yang normal");
                }
            }

        }
    }
}

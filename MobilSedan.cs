using System;

//namespace buat import ke Program.Cs
namespace case1
{
    //class mobilSedan
    class mobilSedan
    {
        // fields
        public int Bensin;
        public int Kecepatan;

        // constructor
        public mobilSedan(int bensinAwal)
        {
            this.Bensin = bensinAwal;
            this.Kecepatan = 0;
        }

        //Method
        public void isiBensin(int liter)
        {
            Bensin += liter;

            if (Bensin > 50)
            {
                Bensin = 50;
                Console.WriteLine("Bensin sudah penuh tolo cabut selang bensin..");
            }
            else
            {
                Console.WriteLine($"Isi tangki dengan {liter} liter bensin, dan total bensin sekrang {Bensin} liter");
            }
        }

        public void Maju(int tambahKecepatan)
        {
            if (Bensin > 0)
            { 
                Kecepatan += tambahKecepatan;
                Bensin -= 1;
                int sisaJarak = Bensin * 10;

                Console.WriteLine($"Mobil melaju dengan kecepatan: {Kecepatan} km/jam | bensin yang tersisa {Bensin} liter " +
                    $"| jarak maksimal yang akan ditempuh {sisaJarak} km");
            }
            else
            {
                Console.WriteLine("Mobil mogok dikarenakan bensin sudah habis");
            }
        }
    }
}

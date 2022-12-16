using System;

namespace nomor2
{
    class Program
    {
        static void Main (string[] args)
        {
            int Jawaban = 0;
            Random rnd = new Random();
            int cek = rnd.Next(1, 100);

            while (Jawaban != cek)
            {
                Console.Write("Tebak angka antara 1-100 : ");
                Jawaban = Convert.ToInt32(Console.ReadLine());

                if(Jawaban < cek)
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah");
                }
                else if(Jawaban > cek)
                {
                    Console.WriteLine("Salah. Nilai terlalu tinggi");
                }
                else
                {
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye...");
                    Console.ReadKey();
                }
            }
        }
    }
}

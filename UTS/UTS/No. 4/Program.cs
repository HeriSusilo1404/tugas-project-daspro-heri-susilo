using System;

namespace nomor4
{
    class Program
    {
        static void Main (string[] args)
        {
            //masukkan variabel
            int skorImbang = 0;
            int skorMenang = 0;
            int skorKalah = 0;
            char userInput = ' ';
            Random rnd = new Random();

            while(userInput != 'e')
            {
                Console.WriteLine("Batu, Gunting, Kertas");
                Console.Write("Choose [b]atu, [g]uting, [k]ertas, or [e]xit : ");
                userInput = Convert.ToChar(Console.ReadLine());

                if (userInput == 'e')
                {
                    Console.WriteLine("Selamat tinggal...");
                    break;
                }

                int computer = rnd.Next(1, 4);
                if (userInput == 'b')
                {
                    if (computer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Hasil Imbang!");
                        skorImbang++;
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Kamu Menang!");
                        skorMenang++;
                    }
                    else if (computer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Kamu Kalah!");
                        skorKalah++;
                    }
                }
                else if (userInput == 'g')
                {
                   if (computer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Kamu kalah!");
                        skorKalah++;
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Hasil Imbang!");
                        skorImbang++;
                    }
                    else if (computer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Kamu Menang");
                        skorMenang++;
                    }
                }
                else if (userInput == 'k')
                {
                    if (computer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Kamu Menang");
                        skorMenang++;
                    }
                    if (computer == 2)
                    {
                       Console.WriteLine("Komputer memilih gunting");
                       Console.WriteLine("Kamu Kalah!");
                       skorKalah++; 
                    }
                    if (computer == 3)
                    {
                       Console.WriteLine("Komputer memilih kertas");
                       Console.WriteLine("Hasil Seri!");
                       skorImbang++; 
                    }
                }
                Console.WriteLine("Skor kamu : {0} menang - {1} kalah - {2} seri", skorMenang, skorKalah, skorImbang);
                Console.WriteLine("Tekan Enter untuk melanjutkan...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

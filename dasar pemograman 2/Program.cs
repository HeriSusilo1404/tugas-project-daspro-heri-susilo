using System;

namespace dasasrpemograman
{
    class program
    {
        static void Main(string[] args)
        {
            Intro();
            Utama();
        }
        static void Intro()
        {
            Console.WriteLine("ADU DADU");
            Console.WriteLine("............................................................................................");
            Console.WriteLine("Selamat Datang di Permainan Adu Dadu ");
            Console.WriteLine("Permainan ini akan dimainkan antara player melawan komputer");
            Console.WriteLine("Permainan ini akan dimainkan sebanyak 10 Ronde");
            Console.WriteLine("Setiap ronde player dan komputer akan melempar sebuah dadu");
            Console.WriteLine("Player atau Komputer yang mendapatkan point paling banyak akan memenangkan permainan ini");
            Console.WriteLine("...........................................................................................");
            {

            }
        }
        static void Utama()
        {
            int angkaDaduComputer;
            int angkaDaduPlayer;
            int Ronde = 0;
            int computerPoint = 0;
            int playerPoint = 0;
            Random satu = new Random();
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine("\nTekan tombol enter untuk memulai permainan....\n");
               Console.ReadKey();

               Ronde++;
               angkaDaduComputer = satu.Next(1,7);
               angkaDaduPlayer = satu.Next(1,7);
               Console.WriteLine("Game "+ Ronde);
               Console.WriteLine("Komputer mulai melempar dadu dan mendapatkan angka " +angkaDaduComputer + ".");
               Console.ReadKey();
               Console.WriteLine("Player mulai melempar dadu dan mendapatkan angka " +angkaDaduPlayer + ".");


               if(angkaDaduComputer > angkaDaduPlayer)
               {
                computerPoint++;
                Console.WriteLine("\nComputer memenangkan ronde " + Ronde + "!\n");
               }
               else if(angkaDaduComputer < angkaDaduPlayer)
               {
                playerPoint++;
                Console.WriteLine("\nPlayer memenangkan ronde "+ Ronde + "!\n");
               }
               else 
               {
                Console.WriteLine("\nRonde "+ Ronde + "berakhir imbang!\n");
               }
               Console.WriteLine("Point Player saat ini " + playerPoint + "|| Point Computer saat ini: "+ computerPoint);
               Console.ReadKey();
            }
            if (playerPoint > computerPoint)
            {
                Console.WriteLine("\n--------------------------------------------------------");
                Console.WriteLine("Wah Selamat, Player memenangkan pertandingan Adu Dadu");
                Console.WriteLine("--------------------------\n");
            }
            else if(playerPoint < computerPoint)
            {
                Console.WriteLine("\n--------------------------------------------------------");
                Console.WriteLine("Wah Selamat, Computer memenangkan pertandingan Adu Dadu");
                Console.WriteLine("----------------------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("\n--------------------------------------------------------");
                Console.WriteLine("pertandingan berakhir imbang");
                Console.WriteLine("----------------------------------------------------------\n");
            }
            Console.ReadKey();

            //Dibuat Oleh :
            //Nama  : Heri Susilo
            //NIM   : 2207111404
            //Kelas : Teknik Informatika-A
        }
    }
}
        

            
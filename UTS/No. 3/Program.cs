using System;

namespace nomor3
{
    class Program
    {
        static void Main (string[] args)
        {
            int Hari = 0;
            int denda = 0;
            Console.Write("Input jumlah Hari peminjaman : ");
            Hari = Convert.ToInt32(Console.ReadLine());
            
            if(Hari <=5)
            {
                Console.Write("Total denda: Rp."+denda);
            }
            else if(Hari > 30)
            {
                denda = (Hari - 30) *30000 + 50000 + 400000; 
                Console.Write("Total denda: Rp."+denda);
                Console.WriteLine("Keanggotaan anda dibatalkan");
            }
            else if(Hari > 10 && Hari <=30)
            {
                denda = (Hari - 10) * 20000 + 50000;
                Console.Write("Total denda: Rp."+denda);
            }
            else if(Hari > 5 && Hari <=10)
            {
                denda = (Hari - 5) * 10000;
                Console.Write("Total denda: Rp."+denda);
            }
            else
            {
              Console.WriteLine("Tidak ada denda");  
            }
            Console.ReadKey();
        }
    }
}
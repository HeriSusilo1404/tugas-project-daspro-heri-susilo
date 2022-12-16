using System;

namespace nomor1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nama;
            string Nim;
            string Konsentrasi;

            Console.WriteLine("Nama Mahasiswa               : ");
            Nama = Console.ReadLine();
            Console.WriteLine("Nim Mahasiswa                : ");
            Nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi Mahasiswa        : ");
            Konsentrasi = Console.ReadLine();

            Console.WriteLine("|**********************|");
            Console.WriteLine( "{0,-11} {1,12}", "|Nama:",Nama+ "|");
            Console.WriteLine("{0,-12} {1,9}", "|",Nim+ "|");
            Console.WriteLine("|----------------------|");
            Console.WriteLine("{0,-12} {1,11}", "|",Konsentrasi+ "|");
            Console.WriteLine("|**********************|");
            Console.ReadLine();
        }
    }
}

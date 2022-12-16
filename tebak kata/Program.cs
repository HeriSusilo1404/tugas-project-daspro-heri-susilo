using System;
using System.Collections.Generic;

namespace tebakkata
{
    class Program
    {
        static string kataRahasia = "matoa";
        static int kesempatan = 5;
        static List<string> tebakanpemain = new List<string>{};
        static void Main (string[] args)
        {
            Intro();
            MulaiMain();
            Endgame();
        }
        static void Intro()
        {
            Console.WriteLine("Selemat datang, hari ini kita akan bermain tebak kata....");
            Console.WriteLine($"kamu mempunyai {kesempatan} kesempatan untuk menebak kata misteri hari ini...");
            Console.WriteLine("petunjuknya adalah kata ini merupakan nama Buah/sayur..");
            Console.WriteLine($"kata ini terdiri dari {kataRahasia.Length} huruf");
            Console.WriteLine("Hewan apakah yang dimaksud?..");
            Console.ReadKey();
            Console.WriteLine();        
        }

            static string cekkata(string kataRahasia, List<string> list){
                string x = "";
                for (int i = 0; i < kataRahasia.Length; i++)
                {
                    string c = Convert.ToString(kataRahasia[i]);
                    if (list.Contains(c))
                    {
                        x = x + c;
                    }else{
                        x = x + ".";
                    }
                }  
                return x;
            }

            static bool cekJawaban(string kata, List<string> List)
            {
                bool x = false;
                for (int i = 0; i < kataRahasia.Length; i++)
                {
                    string c = Convert.ToString(kataRahasia[i]);
                    if (List.Contains(c))
                    {
                        x = true;
                    }else{
                        return x = false;
                    }
                }
                return x;
            }
            static void MulaiMain(){
                while (kesempatan>0)
            {
                Console.Write("apakah hewan tebakanmu?(a-z) : ");
                string input = Console.ReadLine();
                tebakanpemain.Add(input);
                if(cekJawaban (kataRahasia, tebakanpemain)){
                    Console.WriteLine("Tebakan Anda Benar..");
                    Console.WriteLine($"Kata Misteri Hari ini adalah :{kataRahasia} ");
                    break;
                }else if (kataRahasia.Contains(input)){
                    Console.WriteLine("huruf itu ada didalam kata ini");
                    Console.WriteLine("Ayo tebak huruf lainnya");
                    Console.WriteLine(cekkata(kataRahasia, tebakanpemain));
                }else{
                    Console.WriteLine("Huruf tidak ada system...");
                    kesempatan--;
                    Console.WriteLine($"kesempatan anda tinggal{kesempatan}");
                }
                //showhend();
                //break;

                if (kesempatan==0){
                   Console.WriteLine("Mohon maaf kesempatan anda Habis.");
                   Console.WriteLine($"kata misteri yang dimaksud adalah {kataRahasia}.");
                   Console.WriteLine("Terima kasih sudah bermain ..");
                   break; 
                }            
            }
        }  
        static void Endgame()
        {
            Console.WriteLine("Terima kasih telah bermain tebak kata hari ini");
            Console.WriteLine("Sampai jumpa dipermainan selanjutnya");
            Console.ReadKey();
        }
    }
}

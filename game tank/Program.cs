using System;

namespace gametank
{
    class Program
    {
        static void Main(string[] args)
        {
           //Inisialisasi variabel yang dibutuhkan
        int panjangRuang = 5;
        char rumput = '~';
        char tank = 't';
        char hit = 'x';
        char miss = 'o';
        int totalTank = 3;

            char[,] playArea = buatRuang(panjangRuang,rumput,tank,totalTank);

            printArea(playArea,rumput,tank);

            int totalTankTersembunyi = totalTank;

            //Gamplay
            while(totalTankTersembunyi > 0){
                int[] tebakanKoordinat = getkoordinatTebakan(panjangRuang);
                char updateTampilanArea = verifikasiTebakan(tebakanKoordinat, playArea, tank, rumput, hit, miss);
                if(updateTampilanArea == hit){
                    totalTankTersembunyi--;
                }
                playArea = updateArea(playArea, tebakanKoordinat, updateTampilanArea);
                printArea(playArea,rumput,tank);
            }

            Console.WriteLine("Game Over...");
            Console.ReadKey();
        }
        static char [,] buatRuang(int panjangRuang, char rumput, char tank, int totalTank)
        {
            char[,] ruangan = new char[panjangRuang,panjangRuang];

            for(int baris = 0; baris < panjangRuang;baris++)
            {
                for(int kolom=0;kolom<panjangRuang;kolom++){
                    ruangan[baris,kolom] = rumput;
                }
            }
            return letakkanTank(ruangan, totalTank, rumput, tank);
        }
        
        //meletakkan tank didalam area
        static char[,] letakkanTank(char[,]ruangan, int jumlahTank, char rumput, char tank){
            int letakTank = 0;
            int panjangRuang = 5;

            while(letakTank < jumlahTank){
                int[]lokasiTank = tentukanKoordinatTank(panjangRuang);
                char posisi = ruangan[lokasiTank[0],lokasiTank[1]];

                if(posisi == rumput){
                    ruangan[lokasiTank[0],lokasiTank[1]] =  tank;
                    letakTank++;
                }
            }
           
            return ruangan;
        }
        
        //menentukan posisi koordinat tank (x,y)
        static int[] tentukanKoordinatTank(int panjangRuang){
            Random rng = new Random();
            int[] koordinat = new int[2];
            for(int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rng.Next(panjangRuang);// x = random(0,4) ; y = random(0,4)
            }
            
            return koordinat;
        }

        static void printArea(char[,] playArea, char rumput, char tank){
            Console.Write("  ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");//1 2 3 4 
            }
            Console.WriteLine();

            for(int baris = 0; baris < 5; baris++){
                Console.Write(baris + 1 + " ");//1 2 3 4 
                for(int kolom = 0; kolom < 5; kolom++)
                {
                    char posisi = playArea[baris,kolom];
                    if (posisi == tank){
                        Console.Write(rumput + " ");
                    }else{
                        Console.Write(posisi + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        //tebakan koordinat pemain
        static int[] getkoordinatTebakan(int panjangRuang){
            int baris;
            int kolom;

            do{
                Console.Write("pilih baris : ");
                baris = Convert.ToInt32(Console.ReadLine());
            }while(baris < 0 || baris > panjangRuang + 1);

            do{
                Console.Write("pilih kolom : ");
                kolom = Convert.ToInt32(Console.ReadLine());
            }while(kolom <0 || kolom > panjangRuang + 1);

            return new[]{baris-1, kolom-1};
        }
            //Verifikasi tebakan pemain
        static char verifikasiTebakan(int[] tebakan, char[,] playArea, char tank, char rumput, char hit, char miss){

            string pesan;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playArea[baris, kolom];

            if(target == tank){
                pesan ="KERJA BAGUS, TANK DIHANCURKAN!!";
                target = hit;
            }else if (target == rumput){
                pesan ="KITA KURANG BERUNTUNG KALI INI!!";
                target = miss;
            }else{
                pesan = "AREA SAFE!!!";
            }
            Console.WriteLine(pesan);
            Console.WriteLine("  ");
            return target;
        }

        //update tampilan area
        private static char[,] updateArea(char[,] ruang, int[] tebakKoordinat, char updateTampilanArea){

            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            ruang[baris,kolom] = updateTampilanArea;
            return ruang;   
        }
    }
}

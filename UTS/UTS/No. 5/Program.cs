using System;

namespace nomor5
{
    class Program
    {
        static bool berakhir;
        static int x, y, giliran, hitung, state, akhiran;
        static char[] XO = new char[9];
        static int[,] posXO = new int[9,2];
        static string map = "";
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Inisialisasi();

            while(hitung <= XO.Length)
            {
                Console.Clear();

                int cxo = CekXO();
                if(cxo != -1)
                {
                    akhiran = cxo;
                    berakhir = true;
                }

                if(berakhir)
                {
                    Gambar();
                    if(akhiran != -1)
                        System.Console.WriteLine("Seri.");
                    Console.ReadKey();
                }
                else if(!berakhir)
                {
                    Gambar();
                    Console.Write("\nPilih posisi lalu tekan Enter.");
                    Update();
                    Console.SetCursorPosition(x, y);
                    if(giliran == 0)
                    {
                        var tombol = Console.ReadKey();
                        if(tombol.Key == ConsoleKey.UpArrow || tombol.Key == ConsoleKey.W)
                        {
                            if(state > 2)
                                state -= 3;
                        }
                        else if(tombol.Key == ConsoleKey.DownArrow || tombol.Key == ConsoleKey.S)
                        {
                            if(state < 6)
                                state += 3;
                        }
                        else if(tombol.Key == ConsoleKey.LeftArrow || tombol.Key == ConsoleKey.A)
                        {
                            if(state > 0)
                                state--;
                        }
                        else if(tombol.Key == ConsoleKey.RightArrow || tombol.Key == ConsoleKey.D)
                        {
                            if(state < 8)
                                state++;
                        }
                        else if(tombol.Key == ConsoleKey.Enter)
                        {
                            if(XO[state] == ' ')
                            {
                                XO[state] = 'X';
                                Update();
                                posXO[state, 0] = x;
                                posXO[state, 1] = y;
                                hitung++;
                                giliran = 1;
                            }
                        }
                    }
                    else
                    {
                        while(giliran == 1)
                        {
                            int ch = rnd.Next(9);
                            if(XO[ch] == ' ')
                            {
                                XO[ch] = 'O';
                                state = ch;
                                Update();
                                posXO[state, 0] = x;
                                posXO[state, 1] = y;
                                hitung++;
                                giliran = 0;
                            }
                        }
                    }
                }
            }
        }

        static void Inisialisasi()
        {
            berakhir = false;
            x = 0;
            y = 0;
            giliran = 0;
            hitung = 0;
            state = 0;
            akhiran = -1;
            XO = new char[9]{
                ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '
            };
            posXO = new int[9,2];
            map = "   |     |   \n   |     |   \n__|_|_\n   |     |   \n   |     |   \n_|_|__\n   |     |   \n   |     |   \n   |     |   ";
        }

        static int CekXO()
        {
            bool garis = false;
            if(CekLine(0, 1, 2) || CekLine(3, 4, 5) || CekLine(6, 7, 8) || CekLine(0, 3, 6) || CekLine(0, 4, 8) || CekLine(1, 4, 7) || CekLine(2, 5, 8) || CekLine(2, 4, 6))
                garis = true;

            if(garis)
            {
                if(XO[state] == 'X')
                {
                    return 2;
                }
                else if(XO[state] == 'O')
                {
                    return 1;
                }
            }
            else if(hitung >= XO.Length)
            {
                return 0;
            }

            return -1;
        }

        static void Update()
        {
            switch(state)
            {
                case 0:
                y = 0; x = 0;
                break;
                case 1:
                y = 0; x = 6;
                break;
                case 2:
                y = 0; x = 12;
                break;
                case 3:
                y = 4; x = 0;
                break;
                case 4:
                y = 4; x = 6;
                break;
                case 5:
                y = 4; x = 12;
                break;
                case 6:
                y = 7; x = 0;
                break;
                case 7:
                y = 7; x = 6;
                break;
                case 8:
                y = 7; x = 12;
                break;
            }
        }

        static bool CekLine(int x, int y, int z)
        {
            return XO[y] == XO[x];
        }

        static void Gambar()
        {
            Console.WriteLine(map);
            int X = Console.CursorLeft;
            int Y = Console.CursorTop;

            for(int i=0; i<XO.Length;i++)
            {
                if(XO[i] != ' ')
                {
                    Console.SetCursorPosition(posXO[i,0], posXO[i,1]);
                    Console.Write(XO[i]);
                }
            }

            Console.SetCursorPosition(X, Y);
        }
    }
}

using System;

namespace SoalNomor4
{
    class Program
    {
        static void Main(string[] args){
            int skorMenang = 0;
            int skorKalah = 0;
            int skorSeri = 0;
            int userinput = ' ';
            Random rng = new Random();

            while (userinput != 'e')
            {
                Console.WriteLine("Batu, Gunting, Kertas\n");
                Console.Write("Choose [b]atu, [g]unting, [k]ertas, or [e]xit : ");
                userinput = Convert.ToChar(Console.ReadLine());

                if (userinput == 'e')
                {
                    Console.WriteLine("Bye....");
                    break;
                }

                int komputer = rng.Next(1,4);
                if (userinput == 'b')
                {
                    if (komputer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Seri");
                        skorSeri++;
                    }
                    else if (komputer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda Menang");
                        skorMenang++;
                    }
                    else if (komputer == 3)
                    {
                       Console.WriteLine("Komputer memilih kertas");
                       Console.WriteLine("Anda Kalah");
                       skorKalah++;
                    }
                }
                else if (userinput == 'g')
                {
                    if (komputer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda Kalah");
                        skorKalah++;
                    }
                    else if (komputer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Seri");
                        skorSeri++;
                    }
                    else if (komputer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Anda Menang");
                        skorMenang++;
                    }
                }
                else if (userinput == 'k')
                {
                    if (komputer == 1)
                    {
                        Console.WriteLine("Komputer memilih batu");
                        Console.WriteLine("Anda Menang");
                        skorMenang++;
                    }
                    else if (komputer == 2)
                    {
                        Console.WriteLine("Komputer memilih gunting");
                        Console.WriteLine("Anda Kalah");
                        skorKalah++;
                    }
                    else if (komputer == 3)
                    {
                        Console.WriteLine("Komputer memilih kertas");
                        Console.WriteLine("Seri");
                        skorSeri++;
                    }
                }
                Console.WriteLine("skor kamu : {0} - {1} - {2}", skorMenang, skorSeri, skorKalah);
                Console.WriteLine("Tekan Enter untuk melanjutkan....");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
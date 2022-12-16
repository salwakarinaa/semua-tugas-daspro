using System;

namespace AduDadu
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            GamePlay();
            Outro();
            
        }
        static void Intro()
        {
            Console.WriteLine("Adu Dadu\n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Game Adu Dadu");
            Console.WriteLine("Pada permainan ini player akan berlawanan dengan komputer");
            Console.WriteLine("Permainan ini terdiri darii 10 ronde");
            Console.WriteLine("Setiap ronde player dan komputer akan bergantian melempar sebuah dadu");
            Console.WriteLine("Player/Komputer dengan point terbanyak akan memenangkan permainan");
            Console.WriteLine("-----------------------------\n");

        }
        static void GamePlay()
        {
            int daduKomputer;
            int daduPlayer;

            int jumlahRonde = 0;
            int pointKomputer = 0;
            int pointPlayer = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nTekan Enter untuk memulai permainan...\n");
                Console.ReadKey();

                jumlahRonde++;
                Console.WriteLine("Ronde " + jumlahRonde);
                daduKomputer = numbGen();
                Console.WriteLine("Komputer melempar dadu dan mendapat angka " + daduKomputer + ".");
                Console.ReadKey();
                Console.Write("...");
                System.Threading.Thread.Sleep(2000);
                Console.Write("\b\b\b");
                daduPlayer = numbGen();
                Console.WriteLine("Player melempar dadu dan mendapatkan angka " + daduPlayer + ".");

                if (daduPlayer > daduKomputer)
                {
                    pointPlayer++;
                    Console.WriteLine("Komputer memenangkan ronde ini!");
                } else if (daduKomputer > daduPlayer) {
                    pointKomputer++;
                    Console.WriteLine("Kompoter memenangkan ronde ini!");
                } else {
                    Console.WriteLine("Ronde ini seri!");
                }

                Console.WriteLine("Skor Player saat ini: " + pointPlayer + " || Skor Komputer saat ini: " + pointKomputer);
                Console.WriteLine("---------");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }

            if (pointPlayer > pointKomputer)
            {
                Console.WriteLine("\n------");
                Console.WriteLine("Selamat! Komputer memenangkan permainan");
                Console.WriteLine("--------");
            } else if (pointKomputer > pointPlayer) {
                Console.WriteLine("\n----------");
                Console.WriteLine("Player memenangkan permainan ini");
                Console.WriteLine("------------");
            } else {
                Console.WriteLine("\n--------");
                Console.WriteLine("Permainan ini berakhir seri...");
                Console.WriteLine("----------");
            }
             Console.ReadKey();
        }

        static void Outro()
        {
            Console.WriteLine("\nPermainan Selesai");
            Console.WriteLine("Dibuat oleh :");
            Console.WriteLine("Nama  : Salwa Destrin Karina");
            Console.WriteLine("Prodi : Teknik Informatika");
            Console.WriteLine("NIM   : 2207125084");
            Console.ReadKey();
        }
        static int numbGen()
        {
            Random numbGen = new Random();
            int numb = numbGen.Next(1, 7);
            return numb;
        }
    }
}
using System;

namespace SoalNomor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalDenda = 0;
            int Hari = 0;
            Console.Write("Jumlah hari peminjaman buku : ");
            Hari = Convert.ToInt32(Console.ReadLine());
            if (Hari > 30)
            {
                TotalDenda = (Hari - 30) * 30000 + 50000 + 400000;
                Console.WriteLine("Total Denda : " + TotalDenda);
                Console.WriteLine("Keanggotaan dibatalkan");
            }
            else if (Hari > 10)
            {
                TotalDenda = (Hari - 10) * 20000 + 50000;
                Console.WriteLine("Total Denda: " + TotalDenda);
            }
            else if (Hari > 5)
            {
                TotalDenda = Hari * 10000;
                Console.WriteLine("Total Denda: " + TotalDenda);
            }
            else
            {
                Console.WriteLine("Total Denda: Rp.0");
            }
            Console.ReadKey();
        }

    }
}
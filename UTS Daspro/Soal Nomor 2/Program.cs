using System;

namespace SoalNomor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int jawab = 0;
            Random rng = new Random();
            int cek = rng.Next(1,100);
            while (jawab != cek )
            {
                Console.Write("Tebaklah angka antara 1-100 : ");
                jawab = Convert.ToInt32(Console.ReadLine());
                if (jawab < cek )
                {
                    Console.WriteLine("SALAH, angka terlalu rendah");
                }else if (jawab > cek ){
                    Console.WriteLine("SALAH, angka terlalu tinggi");
                }else{
                    Console.WriteLine("Anda benar!");
                    Console.WriteLine("Bye....");
                    Console.ReadKey();
                }
            }
        }
    }
}
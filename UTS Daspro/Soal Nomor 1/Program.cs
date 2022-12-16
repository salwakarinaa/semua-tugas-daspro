using System;

namespace Nametag
{
    class Program
    {
        public static void Main(string[] args){
            string Nama;
            Console.WriteLine("Nama : ");
            Nama = Console.ReadLine();
            string NIM;
            Console.WriteLine("NIM : ");
             NIM = Console.ReadLine();
            string Konsentrasi;
            Console.WriteLine("Konsentrasi : ");
            Konsentrasi = Console.ReadLine();

            Console.WriteLine("|****************************************|");
            Console.WriteLine("{0,-10} {1,31}", "|Nama:", Nama+"|");
            Console.WriteLine("{0,-10} {1,31}", "|", NIM+"|");
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("{0,-10} {1,31}", "|", Konsentrasi+"|");
            Console.WriteLine("|****************************************|");
        }
    }

}
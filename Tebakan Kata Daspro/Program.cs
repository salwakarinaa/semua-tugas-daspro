using System;
using System.Collections.Generic;

namespace TebakanKataDaspro
{
    class Program
    {
        static string kataRahasia = "frozen";
        static int kesempatan = 5;
        static List<string> listTebakan = new List<string> {};
        static void Main(string[] args)
        {
            Intro();
            MulaiMain();
            //EndGame();
        }
        static void Intro()
        {
            Console.WriteLine("Selamat Datang, hari ini kita akan bermain tebak kata.");
            Console.WriteLine($"Kamu mempunyai {kesempatan} kesempatan untuk menebak kata misteri hari ini.");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan nama film animasi.");
            Console.WriteLine($"Kata ini terdiri dari {kataRahasia.Length} huruf.");
            Console.WriteLine("Film apakah yang dimaksud?");
            Console.ReadKey();
            Console.WriteLine();
        }
         static void MulaiMain(){
            while (kesempatan>0)
            {
                Console.Write("Apa huruf tebakanmu? (pilih a-z) : ");
                string input = Console.ReadLine().ToLower();
                listTebakan.Add(input);
                if(Cekjawaban(kataRahasia, listTebakan)){
                    Console.WriteLine("Selamat tebakan anda benar!");
                    Console.WriteLine($"kata miteri hari ini adalah {kataRahasia}");
                    break;
                }else if(kataRahasia.Contains(input)){
                    Console.WriteLine("huruf itu ada didalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf lainnya...");
                    //menampilkan huruf yang sudah ditebak
                    Console.WriteLine(Cekhuruf(kataRahasia, listTebakan));
                }else{
                    Console.WriteLine("Huruf itu tidak ada dalam kata ini");
                    kesempatan--;//kesempatan = kesempatan - 1;
                    Console.WriteLine($"kesempatan anda tinggal{kesempatan}");
                }
                //showed();
                //break;
                }

                if(kesempatan == 0){
                {
                    //Console.WriteLine("Maaf kesempatan anda telah habis.");
                    //Console.WriteLine($"jawaban adalah : {kesempatan} ");
                    EndGame();
                }
            }
        }
        static bool Cekjawaban(string kataRahasia, List<string> list){
                    bool status = false;
                    for (int i = 0; i < kataRahasia.Length; i++)
                    {
                        string c = Convert.ToString(kataRahasia[i]);
                        if (list.Contains(c))
                        {
                            status = true;
                        }else{
                            return status = false;
                        }
                    }
                    
                    return status;
                }
        
                static string Cekhuruf(string kataRahasia, List<string> list){
                    string x = "";
            
                    for (int i = 0; i < kataRahasia.Length; i++)
                    {
                        string c = Convert.ToString(kataRahasia[i]);
                        if (list.Contains(c)){
                            x = x + c;
                        }else{
                            x = x + ".";
                        }
                    }
            
                    return x;
                }
                
                static void EndGame(){
                    Console.WriteLine("Permainan Selesai");
                    Console.WriteLine($"kata Rahasia adalah {kataRahasia}");
                }
    }
}
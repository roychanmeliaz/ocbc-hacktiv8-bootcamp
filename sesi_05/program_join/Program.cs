using System;

namespace program_join
{
    class Program : Override
    {
        public override void penjumlahanperkaliandll() {
            Console.WriteLine("overiding 2...");
            Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}",bilangan1, bilangan2, bilangan1/bilangan2);
            Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}",bilangan1, bilangan2, bilangan1-bilangan2);
        }

        public static void inheritance() {
            Pesawat pesawat = new Pesawat();
            Pesawat_Tempur tempur = new Pesawat_Tempur();

            pesawat.nama = "pesawat";
            pesawat.jumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.jumlahPenumpang = "3 penumpang";
            tempur.nama = "AZ500TPU";
            tempur.jumlahRoda=5;
            tempur.Ketinggian = "200 kaki";
            tempur.jumlahPenumpang = "2 penumpang + kopilot";

            pesawat.terbang();
            tempur.terbang();
        }
        public static void overloading() {
            data datanew = new data();
            datanew.print("Foxy");
            datanew.print(1641231231);
        }
        public static void bilangan() {
            Override over = new Override();
            over.bilangan(5,10);
            over.penjumlahanperkaliandll();
            Program over2 = new Program();
            over2.bilangan(5,10);
            over2.penjumlahanperkaliandll();
        }
        public static void about() {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                 ABOUT ME                ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nama:       Muhammad Roychan Meliaz");
            Console.WriteLine("Kode:       FSDO001ONL021");
            Console.WriteLine("Asal:       Kota Batam");
            Console.WriteLine("Selama belajar C# seru, jadi tau fitur2 yang gaada di bahasa pemograman lainnya");
        }

        public static void Main() {
            string quit="y";
            while (quit=="y") {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("               JOIN PROGRAM              ");
                Console.WriteLine();
                Console.WriteLine("         Muhammad Roychan Meliaz         ");
                Console.WriteLine("               FSDO001ONL021             ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("                  MENU                   ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1. Inheritance");
                Console.WriteLine("2. Overloading");
                Console.WriteLine("3. Bilangan");
                Console.WriteLine("4. About Me");
                Console.WriteLine("5. Quit");
                Console.WriteLine("-----------------------------------------");
                Console.Write    ("Masukkan angka untuk melanjutkan (1-7): ");
                string option = Console.ReadLine();
                switch (option) {
                    case "1":
                        inheritance();
                        break;
                    case "2":
                        overloading();
                        break;
                    case "3":
                        bilangan();
                        break;
                    case "4":
                        about();
                        break;
                    case "5":
                        System.Environment.Exit(1);
                        break;
                }
                Console.Write("Kembali ke halaman utama? (y/n): ");
                quit = Console.ReadLine();   
            }
        }
    }
}

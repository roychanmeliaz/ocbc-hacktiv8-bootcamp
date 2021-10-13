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

            Console.Write("Masukkan nama pesawat: ");
            pesawat.nama = Console.ReadLine();
            Console.Write("Masukkan ketinggian pesawat: ");
            pesawat.Ketinggian = Console.ReadLine();

            Console.Write("Masukkan nama pesawat tempur: ");
            tempur.nama = Console.ReadLine();
            Console.Write("Masukkan jumlah roda pesawat tempur: ");
            tempur.jumlahRoda=int.Parse(Console.ReadLine());
            Console.Write("Masukkan ketinggian pesawat tempur: ");
            tempur.Ketinggian = Console.ReadLine();
            Console.Write("Masukkan jumlah penumpang pesawat tempur: ");
            tempur.jumlahPenumpang = Console.ReadLine();

            pesawat.terbang();
            tempur.terbang();
        }
        public static void overloading() {
            data datanew = new data();
            Console.Write("Masukkan string atau number: ");
            string c = Console.ReadLine();
            int value;
            if (int.TryParse(c, out value)) {
                datanew.print(value);
            }
            else {
                datanew.print(c);
            }
        }
        public static void bilangan() {
            int bil1,bil2;
            Console.Write("Masukkan bilangan 1: ");
            bil1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan 2: ");
            bil2 = int.Parse(Console.ReadLine());
            Override over = new Override();
            over.bilangan(bil1,bil2);
            over.penjumlahanperkaliandll();
            Program over2 = new Program();
            over2.bilangan(bil1,bil2);
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
                Console.WriteLine("3. Overriding");
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

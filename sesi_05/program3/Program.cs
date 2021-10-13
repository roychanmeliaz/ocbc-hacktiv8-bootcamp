using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.Read();
        }
    }
}

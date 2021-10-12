using System;

namespace sesi_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello nama kalian!");
            Console.WriteLine("Selamat datang di program bootcamp ocbc");
            Console.WriteLine("Tahap 1 saya akan belajar c# atau csharp");

            string namaCustomer = "Foxi";
            double harga1 = 10.000, harga2 = 5.000, harga3 = 20.000;
            int jumlah1 = 10, jumlah2 = 7, jumlah3 = 13;

            double total1 = harga1*jumlah1;
            double total2 = harga2*jumlah2;
            double total3 = harga3*jumlah3;

            double totalHargaSemuaBarang = total1+total2+total3;
            int jumlahSemuaBarang = jumlah1+jumlah2+jumlah3;
            Console.WriteLine();
            Console.WriteLine("Nama customer : "+namaCustomer);
            Console.WriteLine("Barang 1 ber jumlah : "+jumlah1+ " dengan harga "+harga1+" yang harus dibayar "+total1);
            Console.WriteLine("Barang 2 ber jumlah : "+jumlah2+ " dengan harga "+harga2+" yang harus dibayar "+total1);
            Console.WriteLine("Barang 3 ber jumlah : "+jumlah3+ " dengan harga "+harga3+" yang harus dibayar "+total1);
            Console.WriteLine();
            Console.WriteLine("Jumlah semua barang : "+jumlahSemuaBarang);
            Console.WriteLine("Total harga semua barang : "+totalHargaSemuaBarang);
            Console.WriteLine();
        }
    }
}

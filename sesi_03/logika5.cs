using System;

public class Logika2
{
    public static void Main()
    {
        Console.Write("Masukkan bulan dalam angka (1-12): ");
        int nilai = int.Parse(Console.ReadLine());
        string snilai="";

        switch (nilai) {
            case 1:
                snilai = "Januari";
                break;
            case 2:
                snilai = "Februari";
                break;
            case 3:
                snilai = "Maret";
                break;
            case 4:
                snilai = "April";
                break;
            case 5:
                snilai = "Mei";
                break;
            case 6:
                snilai = "Juni";
                break;
            case 7:
                snilai = "Juli";
                break;
            case 8:
                snilai = "Agustus";
                break;
            case 9:
                snilai = "September";
                break;
            case 10:
                snilai = "Oktober";
                break;
            case 11:
                snilai = "November";
                break;
            case 12:
                snilai = "Desember";
                break;
        }
        Console.WriteLine($"Bulan adalah {snilai}");
    }
}
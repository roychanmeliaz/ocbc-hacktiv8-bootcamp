using System;

public class Logika2
{
    public static void Main()
    {
        Console.Write("Masukkan nama: ");
        string nama = Console.ReadLine();
        Console.Write("Masukkan nilai: ");
        int nilai = int.Parse(Console.ReadLine());
        string snilai;

        if (nilai<60) {
            snilai = "C";
        }
        else if (nilai<80) {
            snilai = "B";
        }
        else {
            snilai = "A";
        }

        Console.WriteLine($"Halo {nama}, nilai kamu {snilai}!");

    }
}
using System;

public class Logika2
{
    public static void Main()
    {
        Console.Write("Masukkan nama: ");
        string nama = Console.ReadLine();
        Console.Write("Masukkan nilai: ");
        double nilai = double.Parse(Console.ReadLine());
        string snilai;

        if (nilai>=85) {
            snilai = "A";
        }
        else if (nilai>=65) {
            snilai = "B";
        }
        else if (nilai>=45) {
            snilai = "B";
        }
        else {
            snilai = "D";
        }

        Console.WriteLine($"Halo {nama}, kamu mendapat grade {snilai}!");

    }
}
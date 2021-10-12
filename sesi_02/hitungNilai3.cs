using System;
class HitungNilai3
{
    public static void Main(String[] args) {
        int nilai1, nilai2 = 0;

        Console.Write("jumlah nilai1 = ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("jumlah nilai2 = ");
        nilai2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Hasil perbandingan: ");
        Console.WriteLine($"nilai1 > nilai2 : {nilai1 > nilai2}");
        Console.WriteLine($"nilai1 >= nilai2 : {nilai1 >= nilai2}");
        Console.WriteLine($"nilai1 < nilai2 : {nilai1 < nilai2}");
        Console.WriteLine($"nilai1 <= nilai2 : {nilai1 <= nilai2}");
        Console.WriteLine($"nilai1 == nilai2 : {nilai1 == nilai2}");
        Console.WriteLine($"nilai1 != nilai2 : {nilai1 != nilai2}");
    }
}
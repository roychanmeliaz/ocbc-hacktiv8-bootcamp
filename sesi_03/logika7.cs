using System;

public class logika7
{
    public static void Main() {
        Console.Write("Masukkan angka untuk di loop hingga 19: ");
        int a = int.Parse(Console.ReadLine());
        for (int i=a; i<20; i++) {
            Console.WriteLine("Iterasi ke "+i);
        }
    }
}
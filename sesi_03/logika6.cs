using System;

public class logika6
{
    public static void Main() {
        Console.Write("Masukkan angka untuk di loop hingga 19: ");
        int a = int.Parse(Console.ReadLine());
        while (a<20) {
            Console.WriteLine("Nilai a: "+a);
            a+=1;
        }
    }
}
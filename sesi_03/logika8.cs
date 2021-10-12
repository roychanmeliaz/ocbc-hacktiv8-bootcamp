using System;

public class logika8
{
    public static void Main() {
        Console.Write("Input nilai awal loop: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Input nilai akhir loop: ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Input jenis operasi (+,-,*,/): ");
        string jenisoperasi = Console.ReadLine();
        Console.Write("Input nilai yang akan dioperasikan: ");
        int nilaioperasi = int.Parse(Console.ReadLine());
        for (int i=start; i<end; i++) {
            if (jenisoperasi=="+"){
                Console.WriteLine($"loop {i} dengan hasil operasi {jenisoperasi} dengan {nilaioperasi} bernilai {i+nilaioperasi}");
            }
            else if (jenisoperasi=="-"){
                Console.WriteLine($"loop {i} dengan hasil operasi {jenisoperasi} dengan {nilaioperasi} bernilai {i-nilaioperasi}");
            }
            else if (jenisoperasi=="*"){
                Console.WriteLine($"loop {i} dengan hasil operasi {jenisoperasi} dengan {nilaioperasi} bernilai {i*nilaioperasi}");
            }
            else if (jenisoperasi=="/"){
                Console.WriteLine($"loop {i} dengan hasil operasi {jenisoperasi} dengan {nilaioperasi} bernilai {i/nilaioperasi}");
            }
        }
    }
}
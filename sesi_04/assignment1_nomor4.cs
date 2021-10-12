using System;

class assignment1_nomor4
{
    public static void Main() {
        // input constrain, dipastikan input valid
        Console.Write("Masukkan angka yang ingin dibalik: ");
        string input = Console.ReadLine();
        // start the loop
        char[] charArray = input.ToCharArray();
        Array.Reverse( charArray );
        string hasil = new string( charArray );
        Console.WriteLine(hasil);
    }
}
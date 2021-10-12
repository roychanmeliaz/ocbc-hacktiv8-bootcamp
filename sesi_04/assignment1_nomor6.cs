using System;

class assignment1_nomor6
{
    public static void Main() {
        // input
        Console.Write("Masukkan string: ");
        string input = Console.ReadLine();
        // logic
        char[] charArray = input.ToCharArray();
        Array.Reverse( charArray );
        string hasil = new string( charArray );
        if (hasil==input) {
            Console.WriteLine("String palindrome");
        }
        else {
            Console.WriteLine("String tidak palindrome");
        }
    }
}
using System;

class data2
{
    static void Main() {
        string[] contoh = new string[4]
        {
            "Motherboard", "Processor", "Power Supply", "Video Card"
        };

        Console.WriteLine("Menampilkan semua data dalam array");
        Console.WriteLine("");

        foreach (string item in contoh) {
            Console.WriteLine(item);
        }
    }
}
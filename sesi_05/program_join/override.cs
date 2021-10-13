using System;

public class Override
{
    public int bilangan1;
    public int bilangan2;
    public void bilangan(int angka1, int angka2) {
        bilangan1 = angka1;
        bilangan2 = angka2;
    }
    public virtual void penjumlahanperkaliandll() {
        Console.WriteLine("overiding 1...");
        Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1} = {2}",bilangan1, bilangan2, bilangan1+bilangan2);
        Console.WriteLine("Hasil perkalian angka {0} dan angka {1} = {2}",bilangan1, bilangan2, bilangan1*bilangan2);
    }
}
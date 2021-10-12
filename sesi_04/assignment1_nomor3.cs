using System;

class assignment1_nomor3
{
    public static void Main() {
        bool pass = false;
        int n=0;
        // input constrain, dipastikan input valid
        while (!pass) {
            Console.Write("Masukkan sebuah angka: ");
            n = int.Parse(Console.ReadLine());
            if (n<1) {
                Console.WriteLine("Input salah, masukkan nilai positif");
            } else {
                pass=true;
            }
        }
        // start the loop
        int hasil=1;
        for (int i=2; i<=n; i++) {
            hasil*=i;
        }
        Console.WriteLine(hasil);
    }
}
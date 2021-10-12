using System;

class assignment1_nomor2
{
    public static void Main() {
        bool pass = false;
        int n=0;
        // input constrain, dipastikan input valid
        while (!pass) {
            Console.Write("Masukkan tinggi segitiga: ");
            n = int.Parse(Console.ReadLine());
            if (n<1) {
                Console.WriteLine("Input salah, masukkan nilai positif");
            } else {
                pass=true;
            }
        }
        // start the loop
        for (int i=0; i<n; i++) {
            int angka=0;
            for (int j=0; j<(n*2)-1; j++) {
                if (j<n-i-1) {
                    Console.Write(" ");
                }
                else if (j<n+i){
                    if (j>=n) {
                        angka--;
                    }
                    else {
                        angka++;
                    }
                    Console.Write(angka);
                }
            }
            Console.WriteLine();
        }
    }
}
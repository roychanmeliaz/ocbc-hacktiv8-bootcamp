using System;

class assignment1_nomor1
{
    public static void Main() {
        bool pass = false;
        int n=0;
        // input constrain, dipastikan input valid
        while (!pass) {
            Console.Write("Masukkan tinggi segitiga (1-26): ");
            n = int.Parse(Console.ReadLine());
            if (n<1 || n>26) {
                Console.WriteLine("Input salah, masukkan nilai antara 1-26");
            } else {
                pass=true;
            }
        }
        // start the loop
        for (int i=0; i<n; i++) {
            int asciiindex=64;
            for (int j=0; j<(n*2)-1; j++) {
                if (j<n-i-1) {
                    Console.Write(" ");
                }
                else if (j<n+i){
                    if (j>=n) {
                        asciiindex--;
                    }
                    else {
                        asciiindex++;
                    }
                    Console.Write(Convert.ToChar(asciiindex));
                }
            }
            Console.WriteLine();
        }
    }
}
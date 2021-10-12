using System;

class Assignment1 {
    public static void segitigaAlphabet() {
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

    public static void segitigaAngka() {
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

    public static void bilanganFaktorial() {
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

    public static void membalikkanAngka() {
       // input constrain, dipastikan input valid
        Console.Write("Masukkan angka yang ingin dibalik: ");
        string input = Console.ReadLine();
        // start logic
        char[] charArray = input.ToCharArray();
        Array.Reverse( charArray );
        string hasil = new string( charArray );
        Console.WriteLine(hasil);
    }

    public static void converterAngkaDanString() {
        // input constrain, dipastikan input valid
        Console.Write("Masukkan angka: ");
        string input = Console.ReadLine();
        // start the loop
        string hasil="";
        char[] charArray = input.ToCharArray();
        foreach (char charArr in charArray)
        {
            switch (charArr) {
                case '0':
                    hasil+="zero ";
                    break;
                case '1':
                    hasil+="one ";
                    break;
                case '2':
                    hasil+="two ";
                    break;
                case '3':
                    hasil+="three ";
                    break;
                case '4':
                    hasil+="four ";
                    break;
                case '5':
                    hasil+="five ";
                    break;
                case '6':
                    hasil+="six ";
                    break;
                case '7':
                    hasil+="seven ";
                    break;
                case '8':
                    hasil+="eight ";
                    break;
                case '9':
                    hasil+="nine ";
                    break;
            }
        }
        Console.WriteLine(hasil);
    }

    public static void cekPalindrome() {
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

    public static void biodata() {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("                 ABOUT ME                ");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Nama:       Muhammad Roychan Meliaz");
        Console.WriteLine("Kode:       FSDO001ONL021");
        Console.WriteLine("Asal:       Kota Batam");
        Console.WriteLine("Pendidikan: ITS, Teknik Komputer S1");
    }

    public static void Main() {
        string quit="y";
        while (quit=="y") {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("               ASSIGNMENT 1              ");
            Console.WriteLine();
            Console.WriteLine("         Muhammad Roychan Meliaz         ");
            Console.WriteLine("               FSDO001ONL021             ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                  MENU                   ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. Segitiga Alphabet");
            Console.WriteLine("2. Segitiga Angka");
            Console.WriteLine("3. Bilangan Faktorial");
            Console.WriteLine("4. Membalikkan Angka");
            Console.WriteLine("5. Converter Angka dan String");
            Console.WriteLine("6. Cek Palindrome");
            Console.WriteLine("7. Biodata");
            Console.WriteLine("-----------------------------------------");
            Console.Write    ("Masukkan angka untuk melanjutkan (1-7): ");
            string option = Console.ReadLine();
            switch (option) {
                case "1":
                    segitigaAlphabet();
                    break;
                case "2":
                    segitigaAngka();
                    break;
                case "3":
                    bilanganFaktorial();
                    break;
                case "4":
                    membalikkanAngka();
                    break;
                case "5":
                    converterAngkaDanString();
                    break;
                case "6":
                    cekPalindrome();
                    break;
                case "7":
                    biodata();
                    break;
            }
            Console.Write("Kembali ke halaman utama? (y/n): ");
            quit = Console.ReadLine();   
        }
   }
}
using System;

class assignment1_nomor5
{
    public static void Main() {
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
}
using System;
class logika3
{
    public static void Main(String[] args) {
        Console.Write("Username: ");
        string uname =  Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (uname == "ocbc" && password == "bootcamp") {
            Console.WriteLine("Anda berhasil login");
        }
        else {
            Console.WriteLine("Username atau password anda salah");
        }
    }
}
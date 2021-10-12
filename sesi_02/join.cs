using System;
class Join
{
    public static void Main(String[] args) {
        Console.WriteLine("===Masukkan Biodata===");
        Console.Write("username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Jenis Kelamin: ");
        string jenkel = Console.ReadLine();
        Console.Write("Status Nikah: ");
        string statusNikah = Console.ReadLine();

        int pertama,kedua,ketiga,total;
        double rata;
        Console.WriteLine("===Menghitung Nilai===");
        Console.Write("Masukan nilai PERTAMA: ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai KEDUA: ");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai KETIGA: ");
        ketiga = int.Parse(Console.ReadLine());

        bool isAdult = age>18;
        bool isPasswordValid = password == "OCBC";
        bool isUsernameValid = username == "roychanmeliaz";

        if (isAdult && isPasswordValid && isUsernameValid) {
            Console.WriteLine("WELCOME TO THE CLUB!");
            Console.WriteLine("Username anda adalah "+username);
            Console.WriteLine("Umur anda adalah "+age);
            Console.WriteLine("Jenis kelamin anda "+jenkel);
            Console.WriteLine("Status nikah anda adalah "+statusNikah);
            
            total = pertama+kedua+ketiga;
            rata = total/3.0;
            Console.WriteLine("Total Nilai adalah: "+total);
            Console.WriteLine("Rata Rata Nilai adalah: "+rata);
        }
        else {
            Console.WriteLine("Sorry, try again!");
        }
    }
}
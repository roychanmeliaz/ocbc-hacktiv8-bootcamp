using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan jumlah laptop: ");
            int n = int.Parse(Console.ReadLine());

            Laptop[] laptop_arr = new Laptop[n];

            for (int i=0; i<n; i++) {
                laptop_arr[i] = new Laptop();
                Console.Write($"Masukkan merk laptop {i}: ");
                laptop_arr[i].merk = Console.ReadLine();
                Console.Write($"Masukkan ram laptop {i}: ");
                laptop_arr[i].ram = int.Parse(Console.ReadLine());
                Console.Write($"Masukkan memory laptop {i}: ");
                laptop_arr[i].memory = int.Parse(Console.ReadLine());
            }

            for (int i=0; i<n; i++) {
                Console.WriteLine("\nMerk Laptop {1} adalah {0}", laptop_arr[i].merk,i);
                Console.WriteLine("Kapasitas RAM {1} adalah {0}", laptop_arr[i].ram,i);
                Console.WriteLine("Kapasitas Memory {1} adalah {0}", laptop_arr[i].memory,i);

                laptop_arr[i].Chatting();
                laptop_arr[i].Sosmed();
                laptop_arr[i].OnlineShop();
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

// using System;

// namespace program1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Masukkan jumlah laptop: ");
//             int n = int.Parse(Console.ReadLine());

//             Laptop laptop1 = new Laptop();

//             laptop1.merk = "lenovo";
//             laptop1.ram = 4;
//             laptop1.memory = 128;

//             Console.WriteLine("\nMerk Laptop adalah {0}", laptop1.merk);
//             Console.WriteLine("Kapasitas RAM adalah {0}", laptop1.ram);
//             Console.WriteLine("Kapasitas Memory adalah {0}", laptop1.memory);

//             laptop1.Chatting();
//             laptop1.Sosmed();
//             laptop1.OnlineShop();

//             Console.Read();
//         }
//     }
// }

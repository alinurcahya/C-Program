using System;

namespace ProgramInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menampilkan teks dengan enter
            Console.WriteLine("=== PROGRAM INPUT ===");

            // Menampilkan teks tanpa enter
            Console.Write("Tuliskan nama kamu: ");

            // Untuk menyimpan teks yang diinputkan
            string nama = Console.ReadLine();

            // Menampilkan teks dari variabel yang telah diinputkan
            Console.WriteLine("Hi, "+ nama + " selamat datang!");

            // Menampilkan ketikan keyboard sampai ketika di ketik kembali program akan tertutup
            Console.ReadKey();
        }
    }
}

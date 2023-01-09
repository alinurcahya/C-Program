using System;

namespace ProgramInput2
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat variabel kosong
            string nama;
            int umur;

            Console.WriteLine("=== PROGRAM INPUT 2 ===");
            Console.Write("Masukan nama: ");
            nama = Console.ReadLine();
            Console.Write("Masukan alamat: ");
            var alamat = Console.ReadLine();
            Console.Write("Masukan umur: ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terimakasih!");
            Console.WriteLine("Data Berikut");
            Console.WriteLine("Nama: {0}", nama);
            Console.WriteLine("Alamat: {0}", alamat);
            Console.WriteLine("Umur: {0} tahun", umur);
            Console.WriteLine("SUDAH DISIMPAN!");
            Console.ReadLine();
        }
    }
}

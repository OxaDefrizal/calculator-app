using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int a, b;
            Console.WriteLine("Pilih menu calculator");

            Console.WriteLine();

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();

            Console.Write("Inputkan nomor menu dari 1-4 : ");
            int menu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (menu == 1)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
            }
            else if (menu == 2)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (menu == 3)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.WriteLine();
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (menu == 4)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.WriteLine();
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang ada pilih tidak tersedia");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            Daftar daftar = new Daftar();
            bool selesai = false;

            while (!selesai)
            {
            Console.WriteLine("1. Tambah Tugas Kerja, 2. Tambah Tugas Pribadi, 3. Lihat Tugas, 4. Keluar");
                Console.Write("Pilihan : ");
            string pilihan = Console.ReadLine();
            Console.Clear();
            switch (pilihan)
            {
                case "1":
                    {
                            Console.Clear();
                            TambahTugasKerja(daftar);
                        break;
                    }
                case "2":
                    {
                            Console.Clear();
                            TambahTugasPribadi(daftar);
                        break;
                    }
                case "3":
                    {
                            Console.Clear();
                            daftar.Print();
                            Console.ReadLine();
                            break;
                    }
                case "4":
                    {
                            selesai = true;
                            break;
                    }
                default:
                    {
                        Console.WriteLine("Pilihan tidak valid");
                            Console.ReadLine();
                            break;
                    }
            }
        }
            Console.ReadLine();
        }
        static void TambahTugasKerja(Daftar daftar)
        {
            Console.WriteLine("Masukkan Judul Tugas Kerja:");
            string Tugas = Console.ReadLine();

            Console.WriteLine("Masukkan DeadLine Tugas Kerja:");
            string DeadLine = Console.ReadLine();

            Console.WriteLine("Masukkan Deskripsi Tugas Kerja:");
            string deskripsi = Console.ReadLine();

            TugasKerja tugasKerja = new TugasKerja(Tugas, DeadLine, deskripsi);
            daftar.Add(tugasKerja);
        }

        static void TambahTugasPribadi(Daftar daftar)
        {
            Console.WriteLine("Masukkan Judul Tugas Pribadi:");
            string Tugas = Console.ReadLine();

            Console.WriteLine("Masukkan DeadLine Tugas Pribadi:");
            string DeadLine = Console.ReadLine();

            Console.WriteLine("Masukkan Deskripsi Tugas Pribadi:");
            string deskripsi = Console.ReadLine();

            TugasPribadi tugasPribadi = new TugasPribadi(Tugas, DeadLine, deskripsi);
            daftar.Add(tugasPribadi);
        }
    }
}


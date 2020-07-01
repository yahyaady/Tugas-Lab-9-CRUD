using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab9.ClassInduk;
using TugasLab9.ClassAnak;

namespace TugasLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karyawan> listKaryawan = new List<Karyawan>();

            void KarywanTetap(string jenis, string nik, string nama, int gajibulanan)
            {
                listKaryawan.Add(new KaryawanTetap { Jenis = jenis, NIK = nik, Nama = nama, GajiBulanan = gajibulanan });
            }

            void KaryawanHarian(string jenis, string nik, string nama, int jamkerja, int upah)
            {
                listKaryawan.Add(new KaryawanHarian { Jenis = jenis, NIK = nik, Nama = nama, JumlahJamKerja = jamkerja, UpahPerJam = upah });
            }

            void Sales(string jenis, string nik, string nama, int jumlahjual, int komisi)
            {
                listKaryawan.Add(new Sales { Jenis = jenis, NIK = nik, Nama = nama, JumlahPenjualan = jumlahjual, Komisi = komisi });
            }

            void tampildata()
            {
                int noUrut = 1;

                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. NIK: {1}, \tNama: {2}, \tGaji: {3}, \t{4}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), karyawan.Jenis);

                    noUrut++;
                }
            }

            void hapusdata()
            {
                Console.Clear();
                int noUrut = 1;
                int jumlah = 0;

                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. NIK: {1}, \tNama: {2}, \tGaji: {3}, \t{4}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), karyawan.Jenis);

                    noUrut++;
                    jumlah += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlah);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;
                listKaryawan.RemoveAt(index_nik);
            }

            void tambahdata()
            {
                Console.WriteLine("1. Karyawan Tetap\n2. Karyawan Harian\n3. Sales");
                Console.WriteLine();
                Console.Write("Nomor Menu [1..3] = ");
                string submenu = Console.ReadLine();
                Console.WriteLine();
                if (submenu == "1")
                {
                    Console.Write("NIK = ");
                    string nik = Console.ReadLine();
                    Console.Write("Nama = ");
                    string nama = Console.ReadLine();
                    Console.Write("Gaji Bulanan = ");
                    int gajibulanan = int.Parse(Console.ReadLine());
                    string jenis = "Karyawan Tetap";

                    KarywanTetap(jenis, nik, nama, gajibulanan);
                }
                else if (submenu == "2")
                {
                    Console.Write("NIK = ");
                    string nik = Console.ReadLine();
                    Console.Write("Nama = ");
                    string nama = Console.ReadLine();
                    Console.Write("Jumlah Jam Kerja = ");
                    int jamkerja = int.Parse(Console.ReadLine());
                    Console.Write("Upah Per Jam = ");
                    int upah = int.Parse(Console.ReadLine());
                    string jenis = "Karyawan Harian";

                    KaryawanHarian(jenis, nik, nama, jamkerja, upah);
                }
                else if (submenu == "3")
                {
                    Console.Write("NIK = ");
                    string nik = Console.ReadLine();
                    Console.Write("Nama = ");
                    string nama = Console.ReadLine();
                    Console.Write("Jumlah Jual = ");
                    int jumlahjual = int.Parse(Console.ReadLine());
                    Console.Write("Komisi = ");
                    int komisi = int.Parse(Console.ReadLine());
                    string jenis = "Sales";

                    Sales(jenis, nik, nama, jumlahjual, komisi);
                }
                else
                {
                    Console.WriteLine("Pilihan tidak ada, Silahkan coba lagi");
                }
            }

            bool status = false;
            while (status == false)
            {
                Console.Clear();
                Console.WriteLine("Pilih Menu Aplikasi :");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomor Menu [1..4] = ");
                string menu = Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
                if (menu == "1")
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine();
                    tambahdata();
                }
                else if (menu == "2")
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Hapus Data Karyawan");
                    Console.WriteLine();
                    hapusdata();
                    Console.WriteLine();
                    Console.WriteLine("Data Karyawan Berhasil Dihapus ");
                    Console.WriteLine();
                    Console.WriteLine("Tekan Sembarang Untuk Kembali ke Menu Awal");
                }
                else if (menu == "3")
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Tampilkan Data Karyawan");
                    Console.WriteLine();
                    tampildata();
                    Console.WriteLine();
                    Console.WriteLine("Tekan Sembarang Untuk Kembali ke Menu Awal");
                }
                else if (menu == "4")
                {
                    status = true;
                }
                else
                {
                    Console.WriteLine("Tekan Sembarang Untuk Kembali ke Menu Awal");
                }
                Console.ReadKey();
            }
        }
    }
}
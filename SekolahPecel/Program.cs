using System;
using System.Collections.Generic;

namespace SistemSekolah
{
    class Program
    {
        static void Main(string[] args)
        {
            // a. Buat objek sekolah
            Sekolah sekolahKita = new Sekolah();

            // b. Buat beberapa objek orang
            SiswaSD siswa1 = new SiswaSD("Andi", 10, "4A");
            SiswaSMA siswa2 = new SiswaSMA("Budi", 17, "12 IPA 1");
            GuruMatematika guru1 = new GuruMatematika("Pak Cipto", 45);
            GuruBahasa guru2 = new GuruBahasa("Bu Dina", 38);

            // c. Tambahkan ke sekolah
            sekolahKita.TambahOrang(siswa1);
            sekolahKita.TambahOrang(siswa2);
            sekolahKita.TambahOrang(guru1);
            sekolahKita.TambahOrang(guru2);

            // d. Tampilkan semua data
            sekolahKita.DaftarOrang();

            // e. Demonstrasikan polymorphism 
            Console.WriteLine("--- Demonstrasi Polymorphism ---");
            List<Orang> tesPolymorphism = new List<Orang> { siswa1, guru1 };
            foreach (var o in tesPolymorphism)
            {
                o.Aktivitas();
            }

            // f. Panggil method khusus
            Console.WriteLine("\n--- Panggilan Method Khusus ---");
            siswa1.Main();
            siswa2.UjianNasional(); 
            guru1.MengajarHitung(); 
            guru2.MengajarBahasa();

            // Demonstrasi Soal 5 di Modul:
            Console.WriteLine("\n--- Demonstrasi Soal 5 ---");
            Orang orangBebas = new SiswaSD("Citra", 9, "3B");
            orangBebas.Aktivitas();

            
            Console.ReadLine();
        }
    }
}
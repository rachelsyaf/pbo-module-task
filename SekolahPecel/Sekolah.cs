using System;
using System.Collections.Generic;

namespace SistemSekolah
{
    public class Sekolah
    {
        public List<Orang> daftarOrang = new List<Orang>();

        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
            Console.WriteLine($"{orang.nama} berhasil ditambahkan ke sekolah.");
        }

        public void DaftarOrang()
        {
            Console.WriteLine("\n--- Daftar Orang di Sekolah ---");
            foreach (var orang in daftarOrang)
            {
                orang.InfoOrang();
            }
            Console.WriteLine("-------------------------------\n");
        }
    }
}
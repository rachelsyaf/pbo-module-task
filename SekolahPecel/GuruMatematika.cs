using System;

namespace SistemSekolah
{
    public class GuruMatematika : Guru
    {
        public GuruMatematika(string nama, int umur) : base(nama, umur, "Matematika") { }

        public void MengajarHitung()
        {
            Console.WriteLine($"{nama} sedang mengajarkan rumus berhitung matematika.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} beraktivitas sebagai guru Matematika, yaitu mengasah logika siswa.");
        }
    }
}
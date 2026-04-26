using System;

namespace SistemSekolah
{
    public class GuruBahasa : Guru
    {
        public GuruBahasa(string nama, int umur) : base(nama, umur, "Bahasa") { }

        public void MengajarBahasa()
        {
            Console.WriteLine($"{nama} sedang mengajarkan tata bahasa.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} beraktivitas sebagai guru Bahasa, yaitu melatih literasi siswa.");
        }
    }
}
using System;

namespace SistemSekolah
{
    public class Siswa : Orang
    {
        public string kelas { get; set; }

        public Siswa(string nama, int umur, string kelas) : base(nama, umur)
        {
            this.kelas = kelas;
        }

        public void Belajar()
        {
            Console.WriteLine($"{nama} sedang belajar di kelas {kelas}.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} beraktivitas sebagai siswa, yaitu belajar.");
        }
    }
}
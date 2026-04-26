using System;

namespace SistemSekolah
{
    public class SiswaSD : Siswa
    {
        public SiswaSD(string nama, int umur, string kelas) : base(nama, umur, kelas) { }

        public void Main()
        {
            Console.WriteLine($"{nama} sedang bermain di jam istirahat SD.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} beraktivitas sebagai siswa SD, yaitu belajar sambil bermain.");
        }
    }
}
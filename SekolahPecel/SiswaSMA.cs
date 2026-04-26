using System;

namespace SistemSekolah
{
    public class SiswaSMA : Siswa
    {
        public SiswaSMA(string nama, int umur, string kelas) : base(nama, umur, kelas) { }

        public void UjianNasional()
        {
            Console.WriteLine($"{nama} sedang mengikuti Ujian Nasional SMA.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} beraktivitas sebagai siswa SMA, yaitu fokus persiapan ujian.");
        }
    }
}
using System;

namespace SistemSekolah
{
    public class Guru : Orang
    {
        public string mataPelajaran { get; set; }

        public Guru(string nama, int umur, string mataPelajaran) : base(nama, umur)
        {
            this.mataPelajaran = mataPelajaran;
        }

        public void Mengajar()
        {
            Console.WriteLine($"{nama} sedang mengajar mata pelajaran {mataPelajaran}.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} beraktivitas sebagai guru, yaitu mendidik siswa.");
        }
    }
}
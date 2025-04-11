using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_SistemManajemenKaryawan
{
    class Karyawan
    {
        private string nama;
        private string id;
        private double gajiPokok;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public double GajiPokok
        {
            get { return gajiPokok; }
            set { gajiPokok = value; }
        }

        // Method untuk HitungGaji
        public virtual double HitungGaji()
        {
            return GajiPokok;
        }

        
        public void TampilkanData()
        {
            Console.WriteLine("Nama       : " + Nama);
            Console.WriteLine("ID         : " + ID);
            Console.WriteLine("Gaji Pokok : Rp" + GajiPokok);
            Console.WriteLine("Gaji Akhir : Rp" + HitungGaji());
        }
    }

    class KaryawanTetap : Karyawan
    {
        public override double HitungGaji()
        {
            return GajiPokok + 500000;
        }
    }

    class KaryawanKontrak : Karyawan
    {
        public override double HitungGaji()
        {
            return GajiPokok - 200000;
        }
    }

    class KaryawanMagang : Karyawan
    {
        public override double HitungGaji()
        {
            return GajiPokok;
        }
    }

}

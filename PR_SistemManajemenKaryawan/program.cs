using PR_SistemManajemenKaryawan;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Jenis Karyawan (Tetap/Kontrak/Magang): ");
        string jenis = Console.ReadLine().ToLower();

        Console.Write("Nama: ");
        string nama = Console.ReadLine();

        Console.Write("ID: ");
        string id = Console.ReadLine();

        double gaji;
        Console.Write("Gaji Pokok: ");
        while (!double.TryParse(Console.ReadLine(), out gaji))
        {
            Console.Write("Masukkan angka yang valid untuk gaji: ");
        }

        //objek berdasarkan jenis karyawan
        Karyawan karyawan;
        if (jenis == "tetap")
        {
            karyawan = new KaryawanTetap();
        }
        else if (jenis == "kontrak")
        {
            karyawan = new KaryawanKontrak();
        }
        else
        {
            karyawan = new KaryawanMagang();
        }

        karyawan.Nama = nama;
        karyawan.ID = id;
        karyawan.GajiPokok = gaji;
        karyawan.TampilkanData();
        Console.ReadLine(); 
    }
}

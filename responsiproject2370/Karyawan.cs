using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiproject2370
{
    class Karyawan
    {

        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        
        public Karyawan(string nik, string nama, int gajibulanan)
        {


            if (gajibulanan < 0)
            {
                gajibulanan = 0;
                

            }
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;

        }
        
    }
}


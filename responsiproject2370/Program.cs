using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiproject2370
{
    class Program
    {


        static void Main(string[] args)
        {
           
            Karyawan kry1 = new Karyawan("122341269","mustaffa",2000000);

            Karyawan kry2 = new Karyawan("122441269","afan",-2000000);

            Console.WriteLine("No\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}\n", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0}  {1}\t\t{2}\n", kry2.Nik, kry2.Nama, kry2.GajiBulanan);
            
            Console.WriteLine("\n\n");
            Console.WriteLine("Asyiikk Kenaikan Gaji 10%\n");
            Console.WriteLine("No\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}\n", kry1.Nik, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0}  {1}\t\t{2}\n", kry2.Nik, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}

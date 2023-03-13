using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatarACT8
{
    /// <summary>
    /// membuat class persegi panjang
    /// </summary>
    public class PersegiPanjang
    {
        /// <summary>
        /// mendeklarasikan variable
        /// </summary>
        /// <param name="panjang">Memasukkan Panjang  Persegi Panjang</param>
        /// <param name="lebar">Memasukkan Lebar  Persegi panjang</param>
        /// <param name="keliling">Memasukkan keliling Persegi Panjang</param>
        /// <param name="luas">Memasukkan luas Persegi Panjang</param>
        public double panjang, lebar, keliling, luas;

        /// <remarks>input panjang dan lebar</remarks>
        public void sisiPP()
        {
            Console.Write("Masukkan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// mencari luas persegi panjang menggunakan rumus
        /// </summary>
        /// <param name="p"> Panjang</param>
        /// <param name="l"> Lebar</param>
        /// <returns>hasil luas persegi panjang</returns>
        public double LuasPP(double p, double l)
        {
            return p * l;
        }

        /// <remarks>mencari keliling persegi panjang menggunakan rumus</remarks>
        public double KelPP(double p, double l)
        {
            return 2 * (p + l);
        }

        /// <summary>
        /// Menampilkan Hasil dari luas dan keliling Persei Panjang
        /// </summary>
        public void tampilPP()
        {
            Console.WriteLine("");
            Console.WriteLine("Luas Persegi Panjang = " + this.LuasPP(panjang, lebar));
            Console.WriteLine("Keliling Persegi Panjang = " + this.KelPP(panjang, lebar));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// membuat class persegi
    /// </summary>
    
    public class Persegi
    {
        /// <summary>
        /// input panjang sisi
        /// </summary>
        public double s;
        public void  sisi()
        {
            Console.Write("Masukkan Panjang Sisi = ");
            s = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// mencari luas persegi menggunakan rumus
        /// </summary>
        /// <param name="s">sisi </param>
        /// <returns>hasil luas persegi </returns>
        public double LuasPersegi(double s)
        {
            return s * s;
        }

        /// <remarks>mencari keliling persegi menggunakan rumus</remarks>
        public double KelilingPersegi(double s)
        {
            return s * s * s * s;
        }

        /// <summary>
        /// menampilkan hasil luas dan keliling persegi
        /// </summary>
        public void tampilpersegi()
        {
            Console.WriteLine("");
            Console.WriteLine("Luas Persegi = " + this.LuasPersegi(s));
            Console.WriteLine("Keliling Persegi = " + this.KelilingPersegi(s));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// membuat class Segitiga
    /// </summary>
    public class Segitiga
    {
        /// <remarks>
        /// <para>alas = alas bangun datar</para>
        /// <para>tinggi = tinggi bangun datar</para>
        /// <para>sisi = sisi bangun datar</para>
        /// </remarks>
        public double alas, tinggi, sisi;

        /// <summary>
        /// Membuat iput data yang ingin dihitung
        /// </summary>
        public void sisiS3()
        {
            Console.Write("Masukan Alas = ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Sisi = ");
            sisi = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// mencari luas segitiga menggunakan rumus
        /// </summary>
        /// <param name="a">alas segitiga</param>
        /// <param name="t">tinggi segitiga</param>
        /// <returns>hasil luas segitiga</returns>
        public double LuasS3(double a, double t)
        {
            return  a * t / 2;
        }

        /// <remarks>menghitung keliling segitiga</remarks>
        public double KelS3(double s)
        {
            return s + s + s;
        }

        /// <remarks>menampilkan hasil luas dan keliling segitiga</remarks>
        public void tampilS3()
        {
            Console.WriteLine("");
            Console.WriteLine("Luas Segitiga = " + this.LuasS3(alas, tinggi));
            Console.WriteLine("Keliling Segitiga = " + this.KelS3(sisi));
            Console.ReadKey();
        }

    }

    /// <summary>
    /// membuat class program
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            PersegiPanjang pp = new PersegiPanjang();
            Persegi p = new Persegi();
            Segitiga s3 = new Segitiga();


            ///<remarks>membuat menu</remarks>
            int pilih;
            Console.WriteLine("------------------");
            Console.WriteLine("    <--MENU-->    ");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Persegi Panjang");
            Console.WriteLine("2. Persegi");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilihan (1/2/3/4) =  ");
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            ///<code>switch = pernyataan yang digunakan untuk menjalankan salah satu pernyataan dari beberapa kemungkinan pernyataan.</code>
            ///<code>break = perintah khusus yang dipakai untuk memaksa sebuah perulangan berhenti sebelum waktunya.</code>
            switch (pilih)
            {
                case 1:
                    pp.sisiPP();
                    pp.tampilPP();
                    break;
                case 2:
                    p.sisi();
                    p.tampilpersegi();
                    break;
                case 3:
                    s3.sisiS3();
                    s3.tampilS3();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Pilihan Salah!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCDIndividu
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class Program dapat menghitung luas persegi panjang</remarks>
    class Program
    {
        /// <summary>
        /// operasi menghitung luas persegi panjang
        /// </summary>
        /// <param name="p">angka pertama yang menunjukkan panjang dari persegi panjang</param>
        /// <param name="l">angka kedua yang menunjukkan lebar dari persegi panjang</param>
        /// <return>luas merupakan hasil dari perkalian angka pertama dan angka kedua</returns>
        static void Main(string[] args)
        {//Begin

            //numeric p,l,luas
            double p, l, luas;

            //Display 'Masukkan panjangnya: '
            Console.Write("Masukkan Panjangnya = ");

            //Accept p
            p = Convert.ToDouble(Console.ReadLine());

            //Display 'Masukkan lebarnya: '
            Console.Write("Masukkan Lebarnya = ");

            //Accept 1
            l = Convert.ToDouble(Console.ReadLine());

            //Compute luas = p*l
            luas = p * l;


            //Display 'Luasnya= ' +luas
            Console.WriteLine("Panjang = {0} Lebar = {1} Luasnya {2}", p, l, luas);
            Console.ReadKey();

        }//End
    }
}

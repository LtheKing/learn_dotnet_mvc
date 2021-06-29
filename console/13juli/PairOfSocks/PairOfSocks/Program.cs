using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOfSocks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //=============DAY 1 ==============
            //string[] barang1, barang2;
            //ListOfSocks obj = new ListOfSocks();
            //obj.DaftarKK(out barang1, out barang2);
            //Model.CategorySocks category = new Model.CategorySocks();

            //Console.WriteLine("Warna : "+ barang1[1]);
            //Console.WriteLine("Merk : "+ barang2[2]);

            //========== DAY 2 ===================
            //int bil1;
            //Console.WriteLine("masukan angka : ");
            //bil1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(bil1);

            //var deret = new List<int>();

            //int[] arr = deret.ToArray();
            int[] arr = new int[5];
            int jmlAngka;
            int i;

            Console.WriteLine("Masukan Jumlah Angka");
            jmlAngka = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= jmlAngka; i++)
            {
                Console.WriteLine(i);
                //Console.WriteLine("Masukan Angka : ");
                //arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int k = 0; k < jmlAngka; k++)
            {
                Console.WriteLine(arr[k]);
            }

            Console.ReadKey();



        }
    }
}

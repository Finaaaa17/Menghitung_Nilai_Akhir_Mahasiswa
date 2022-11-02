using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menghitung_Nilai_Mahasiswa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Masukkan nilai akhir : ");
            float akhir = Convert.ToInt16(Console.ReadLine());
            float nilai =((akhir));
            //Console.WriteLine();

            Console.Clear();
            Console.WriteLine("Nilai Mahasiswa");
            Console.WriteLine(" ");
            Console.WriteLine("Nilai      = {0} ", nilai);
            if (nilai >= 75)
            {
                Console.WriteLine("Grade      = A");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("Grade      = B");
            }
            else if (nilai >= 50)
            {
                Console.WriteLine("Grade      = C");
            }
            else if (nilai >= 40)
            {
                Console.WriteLine("Grade      = D");
            }
            else
            {
                Console.WriteLine("Grade      = E");
            }
            Console.ReadKey(true);
         
        }
    }
}

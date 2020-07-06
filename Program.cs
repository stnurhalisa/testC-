using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalTestKreditPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 3;
            int[] x = { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };
            int temp;

            a = b;
            
            for(int i = 0; i < x.Length - 1; i++)
            {
                for (int j = 0; j < x.Length - 1; j++) //8
                {
                    if(x[j] > x[j + 1]) // 20 > 10
                    {
                        temp = x[j + 1]; //temp = 10
                        x[j + 1] = x[j];  // tukar posisi index
                        x[j] = temp; // urutan index jadi 10 
                        //{10, 20, 50, 46, 26, 87, 25, 5, 97, 24}
                    }
                }
            }

            Console.WriteLine("Nomor 1, nilai = b = " + a);

            Console.Write("2. Sorted : ");
            foreach(int s in x)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_08._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] arr2 = { 10, 2, 5, 3, 9, 11 };

            #region Зад 1
            var buf1 = arr1.Except(arr2);
            foreach (int i in buf1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Зад 2
            var buf2 = arr1.Intersect(arr2);
            foreach (int i in buf2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Зад 3
            var buf3 = arr1.Union(arr2);
            foreach (int i in buf3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Зад 4
            var buf4 = arr1.Distinct();
            foreach (int i in buf4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion
        }
    }
}

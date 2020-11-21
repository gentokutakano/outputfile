   using System;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target = { 2, 10, 1245, 6, 7, 5, 3, 9, 4, 8, 1, 0 };
            NamberSort.ArraySort(target);

            //for (int i = 0; i < target.Length; i++) //target.lengthは10が入っている
            //{
            //    Console.Write("{0} ", target[i]);
            //}
        }
    }
}

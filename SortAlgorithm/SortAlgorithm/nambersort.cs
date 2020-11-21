using System;
using System.Collections.Generic;
using System.Text;

namespace SortAlgorithm
{
    class NamberSort
    {
        public static void ArraySort(int[] namber)
        {
            for (int i = 0; i < namber.Length; i++)　　//入力された要素数を超えるまで繰り返す
            {
                for (int j = 0; j + 1 < namber.Length; j++)   //nanber.Lengthは配列の要素数　j+1は配列の次の要素
                {
                    if (namber[j] > namber[j + 1])  // jの要素より「j + 1(次の要素)」が大きければ処理
                    {
                        int save = namber[j];  //入れ替えする処理
                        namber[j] = namber[j + 1];
                        namber[j + 1] = save;
                    }
                }
                for (int k = 0; k < namber.Length; k++) //整列化の過程を表示
                {
                    Console.Write(namber[k] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}

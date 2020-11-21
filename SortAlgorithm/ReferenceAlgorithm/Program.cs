using System;
using System.Collections.Generic;

namespace ReferenceAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "BBB", "ccc", "aaa", "g", "n", "え", "い", "う", "お","あ" };

            //大文字小文字を区別しない序数比較で並び替える
            StringComparer cmp = StringComparer.OrdinalIgnoreCase;
            Array.Sort(strs, cmp);

            //並び替えた結果を表示
            Console.WriteLine(string.Join(", ", strs));　//コレクションで指定した文字を連結してくれる
        }
    }
}

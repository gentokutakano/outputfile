using System;

namespace ReferenceSort
{
    class Program
    {
        static void Main(int[] args)
        {
            string[] strs = new string[] { "BBB", "ccc", "aaa" };

            //大文字小文字を区別しない序数比較で並び替える
            StringComparer cmp = StringComparer.OrdinalIgnoreCase;
            Array.Sort(strs, cmp);

            //並び替えた結果を表示する
            Console.WriteLine(string.Join(", ", strs));
            //"aaa, BBB, ccc"と表示される
        }
    }
}

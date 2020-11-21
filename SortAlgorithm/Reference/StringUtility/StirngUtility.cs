using System;
using System.Collections.Generic;
using System.Text;

namespace StringSort
{
    class StringUtility
    {
        /// <summary>
        /// Get String Array Sort
        /// </summary>
        /// <returns></returns>
        public static char[] StringSort(string inputString)
        {
            char[] charArray = GetCharArray(inputString);

            for (int i = 0; i < charArray.Length; i++)　　//入力された要素数を超えるまで繰り返す
            {
                for (int j = 0; j + 1 < charArray.Length - i; j++)   //charArra.Lengthは配列の要素数　j+1は配列の次の要素
                {
                    if (charArray[j] > charArray[j + 1])  // jの要素より「j + 1(次の要素)」が大きければ処理
                    {
                        char save = charArray[j];  //入れ替えする処理
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = save;
                    }
                }
            }
            //return charArray.ToString();
            return charArray;
        }

        /// <summary>
        /// String ToCharArray
        /// </summary>
        /// <returns></returns>
        public static char[] GetCharArray(string stringValue)  //ToCharArrayしている（）
        {
            string sInput = stringValue;
            char[] chArraryOutPut = new char[sInput.Length]; //入力された文字列の数を取得
            for (int i = 0; i < sInput.Length; i++)
            {
                chArraryOutPut[i] = sInput[i];　　//文字列をchar[]に格納
            }
            return chArraryOutPut;　//char配列になっている
        }

        //降順用メソッド
        //public static void ArraySort(char[] namber)
        //{
        //    for (int i = 0; i < namber.Length -1 ; i++)　　//入力された要素数を超えるまで繰り返す
        //    {
        //        for (int j = namber.Length - 1; j > i; j--)   //nanber.Lengthは配列の要素数　j+1は配列の次の要素
        //        {
        //            if (namber[j] > namber[j - 1])  // jの要素より「j + 1(次の要素)」が大きければ処理
        //            {
        //                char save = namber[j];  //入れ替えする処理
        //                namber[j] = namber[j - 1];
        //                namber[j - 1] = save;
        //            }
        //        }    
        //for (int k = 0; k < namber.Length; k++) //整列化の過程を表示 過程確認用
        //{
        //    Console.Write("{0}",namber[k]);
        //}
        //for (int k = 0; k < namber.Length; k++)
        //{
        //    Console.Write("{0}",namber[k]);
        //}
        //    }
        //    Console.Write(namber);
        //}
    }
}

using StringSort.Command;
using System;
using System.Reflection.Metadata;
using StringSort.Utility;
namespace StringSort
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write(Constants.UserInputMessage);
            string stringInput = ConsoleUtility.GetStringConsole();  //コンソールからstringを入力
            char[] sortResult = StringUtility.StringSort(stringInput);　　//配列にして並び替え
            Console.Write(Constants.ProcessingResultMessage);　　　//以下　メッセージと結果を表示
            Console.Write(sortResult);

            Console.ReadKey();
        }
    }
}

using System;
using System.Xml;

namespace ProjectFileUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ファイルサイズを選択してくださいKB(1) MB(2) GB(3)");
            int dataType = GetIntFromConsole(); //入力用メソッド
            Console.Write("データ数を入力してください : ");
            int dataAmount = GetIntFromConsole();
            Console.Write("データ速度を入力してください Kb単位　: ");
            int dataSpeed = GetIntFromConsole();

            switch (dataType)
            {
                case 1:   //KB
                    int KbData = dataAmount;
                    int processingSpeed = KbData / dataSpeed;
                    Console.WriteLine("このファイルが移動にかかる時間は{0}秒です。", processingSpeed);
                    break;
                case 2:     //MB
                    KbData = dataAmount * 1024;
                    processingSpeed = KbData / dataSpeed;
                    Console.WriteLine("このファイルが移動にかかる時間は{0}秒です。", processingSpeed);
                    break;
                case 3:     //GB
                    KbData = dataAmount * (1024 * 1024);
                    processingSpeed = KbData / dataSpeed;
                    Console.WriteLine("このファイルが移動にかかる時間は{0}秒です。", processingSpeed);
                    break;
                //case 4:     //プログラム終了
                //    i = false;
                //    objSHape = null;
                //    break;
                default:    //不正な入力
                    Console.WriteLine("1～4の数字を入力してください");
                    break;
                    //continue;  // do whileの終わりまでスキップする
            }

            int GetIntFromConsole() // ファイル移動
            {
                string userInput;
                int IntValue;
                bool Value = true;
                do
                {
                    if (Value == false) //整数以外の入力判定があった場合
                    {
                        Console.Write("整数を入力してください : ");
                    }
                    userInput = Console.ReadLine();
                    Value = int.TryParse(userInput, out IntValue);

                } while (Value == false);

                return IntValue;
            }
        }
    }
}

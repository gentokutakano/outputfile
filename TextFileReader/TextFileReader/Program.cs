using System;
using TextFileReader.FileOperatation;
using TextFileReader.Utility;

namespace TextFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine(Constants.ExceptionMessageEmp);
                    Environment.Exit(0);
                }

                string textFilePath = args[0];

                ///入力されたテキストファイルお検証する
                bool isFileValid = TextFileValidatator.CheckValidatation(textFilePath, out string fileValidatationMessage);

                if (isFileValid == false)
                {   
                    Console.WriteLine(fileValidatationMessage + (Constants.EndMessage));
                    Environment.Exit(0);
                }

                ///テキストファイルをバイナリで読み込む
                TextFileRead.ReadFileUsingBuffer(textFilePath);
                Console.WriteLine("\nファイルを読み込みました");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("知らないエラーｶﾞ発生しました。", Constants.EndMessage);
            }
        }
    }
}

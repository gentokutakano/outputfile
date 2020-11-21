using System;
using TextFileMergeApp.ConstantUtility;
using TextFileMergeApp.FileOperatation;

namespace TextFileMergeApp
{
    class Program
    {

        static void Main(string[] args)
        {

            //空か確認
            if (args.Length == 0)
            {
                Console.WriteLine(Constants.ExceptionMessageMergeFileEmp);
                Environment.Exit(0);
            }

            string TextMergeFile = MergeSystem.MergeFlow(args);
            Console.WriteLine(Constants.MargeMessage, TextMergeFile);
        }
    }
}
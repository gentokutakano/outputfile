using System;
using TextFileMergeApp.ConstantUtility;

namespace TextFileMergeApp.FileOperatation
{
    class MergeSystem
    {
        public static string MergeFlow(string[] args)
        {
            string textMergeFilePath = args[0];
            try
            {
                //ソースパスを抽出
                string[] sourceFIlePaths = new string[args.Length - 1];
                for (int argumentIndex = 0; argumentIndex < sourceFIlePaths.Length; argumentIndex++)
                {
                    sourceFIlePaths[argumentIndex] = args[argumentIndex + 1];
                }

                //マージ先ファイルを作れるか確認
                bool isMergeFileExists = TextFileValidator.ValidatateFilePath(textMergeFilePath, false, out string fileValidationMessage);
                if (isMergeFileExists == false)
                {
                    Console.WriteLine(fileValidationMessage + Constants.EndMessage);
                    Environment.Exit(0);
                }

                //ソースパスが正しいのか確認
                bool textFileExists = TextFileValidator.validationSourceFilePath(sourceFIlePaths, out fileValidationMessage);
                if (textFileExists == false)
                {
                    Console.WriteLine(fileValidationMessage + Constants.EndMessage);
                    Environment.Exit(0);
                }

                Merge.TextFileMerge(textMergeFilePath, sourceFIlePaths);
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex);
#endif
                Console.WriteLine(Constants.OtherErrorMessage + Constants.EndMessage);
            }

            return textMergeFilePath;
        }
    }
}

using System;
using System.IO;

namespace TextFileMergeApp
{
    class Merge
    {
        /// <summary>
        /// ファイルを一行づつ書き込む
        /// 上書き専用のファイルを作る
        /// </summary>
        /// <param name="sourceFilePaths"></param>
        public static void TextFileMerge(string meargeFilePath, string[] sourceFilePaths)
        {
            //書き込みファイル作成・立ち上げる
            using (StreamWriter mergeFile = new StreamWriter(meargeFilePath, false))
            {
                //配列を回す
                foreach (string sourceFilePath in sourceFilePaths)
                {
                    //ソースファイルを読み込み専用で開く
                    using (StreamReader inputTextFile = new StreamReader(sourceFilePath))
                    {
                        string textLine;
                        //一行ずつ読み込んで書き込む
                        while ((textLine = inputTextFile.ReadLine()) != null)
                        {
                            mergeFile.WriteLine(textLine);
#if DEBUG
                            Console.WriteLine(string.Format("{0}", textLine));
#endif
                        }
                    }
                }
            }
        }
    }
}

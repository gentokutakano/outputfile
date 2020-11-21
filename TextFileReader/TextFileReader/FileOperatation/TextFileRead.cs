using System;
using System.IO;
using System.Text;
using TextFileReader.Utility;

namespace TextFileReader.FileOperatation
{
    public class TextFileRead
    {
        #region ReadFileUsingStreamReader
        /// <summary>
        /// StreamReaderを使ったファイルの読み込み
        /// </summary>
        /// <param name="textFilePath"></param>
        /// <returns></returns>
        public static string ReadFileUsingStreamReader(string textFilePath)
        {
            using (StreamReader readFile = new StreamReader(textFilePath, Encoding.GetEncoding("UTF-8")))
            {
                string readText = readFile.ReadToEnd();
                return readText;
            }
        }
        #endregion

        #region ReadFileUsingFileReader
        /// <summary>
        /// File.ReadAllTextを使ったファイルの読み込み
        /// </summary>
        /// <param name="textFilePath"></param>
        /// <returns></returns>
        public static string ReadFileUsingFileReader(string textFilePath)
        {
            string readText = File.ReadAllText(textFilePath);
            return readText;
        }
        #endregion

        #region ReadFileUsingReader
        /// <summary>
        /// ReadLineを使って一行ずつ読み込み
        /// </summary>
        /// <param name="textFilePath"></param>
        /// <returns></returns>
        public static string ReadFileUsingReader(string textFilePath)
        {
            // 読み取るテキストファイル（実行ファイルと同じフォルダに置く）
            string fileData = string.Empty;

            // テキストファイルのStreamReaderオブジェクトを得る
            using (StreamReader reader = new StreamReader(textFilePath, Encoding.GetEncoding("UTF-8")))
            {
                string line;
                // 1行ずつ読み込み、変数lineに格納する
                while ((line = reader.ReadLine()) != null)
                    fileData += line; // 読み込んだ内容をコンソールに出力する
            }
            return fileData;
        }
        #endregion

        #region ReadFileCopyText
        /// <summary>
        /// Copy the received text file
        /// 受け取ったテキストファイルをコピーする
        /// </summary>
        /// <param name="textFilePath"></param>
        public static void ReadFileCopyText(string textFilePath)
        {
            int i;
            using (FileStream inputFile = new FileStream(textFilePath, FileMode.Open))
            using (FileStream outputFile = new FileStream(@"C:\work\SkillUp\CopyTest.txt", FileMode.Create))
            {
                while ((i = inputFile.ReadByte()) != -1)  //i が-1になったら終了  ReadByteで１バイトを順に読み込んでいる。　
                {
                    outputFile.WriteByte((byte)i); //バイトを書き出したら文字で表せる理由が分からない → txtファイルが裏側でbyteをcharに変換して表示している
                    Console.Write(string.Format("{0}", (char)i));
                }
            }
        }
        #endregion

        #region  TextReader
        /// <summary>
        ///  TextReader
        /// </summary>
        /// <param name="textFilePath"></param>
        public static void TextReader(string textFilePath)
        {
            string line;
            using (StreamReader readText = new StreamReader(textFilePath, Encoding.GetEncoding("UTF-8")))
            {
                while ((line = readText.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        #endregion  

        #region ReadFileMemmoryReader
        /// <summary>
        /// MemoryStreamを使ってbyte配列に直しテキストをコピーする
        /// </summary>
        /// <param name="textFilePath"></param> 
        public static void ReadFileMemmoryReader(string textFilePath)
        {

            byte[] bytes = File.ReadAllBytes(textFilePath);
            string textReadLine;

            using (MemoryStream memoryStream = new MemoryStream(bytes, false))
            using (StreamReader streamReader = new StreamReader(memoryStream, Encoding.GetEncoding("UTF-8")))
            {
                while ((textReadLine = streamReader.ReadLine()) != null)
                {

                    Console.Write(string.Format("{0}", textReadLine));
                }
            }
        }
        #endregion

        #region ReadFileUsingBuffer
        /// <summary>
        /// テキストファイルを100Byteづつ読み込む
        /// </summary>
        /// <param name="textFilePath"></param>
        public static void ReadFileUsingBuffer(string textFilePath)
        {
            ///テキストファイルを読み込み専用で開く
            using (FileStream fsSource = new FileStream(textFilePath, FileMode.Open, FileAccess.Read))
            {
                int numBytesToRead = (int)fsSource.Length;
                int numBytesOffset = Constants.StartBytes;
                int maxByteToRead = Constants.ReadBytes;

                //0になるまで読み込む
                while (numBytesToRead > 0)
                {
                    if (numBytesToRead < maxByteToRead)
                    {
                        maxByteToRead = numBytesToRead;
                    }

                    byte[] bytes = new byte[maxByteToRead];

                    ///動的に100バイトずつ読み込む
                    int readByteCount = fsSource.Read(bytes, 0, maxByteToRead);

                    if (readByteCount == 0)
                        break;

                    numBytesOffset += readByteCount;
                    numBytesToRead -= readByteCount;

                    ///100バイトずつ読み込んだテキストをコンソールに表示
                    Console.Write(string.Format("{0}", Encoding.UTF8.GetString(bytes)));
                }
            }
        }
        #endregion
    }
}
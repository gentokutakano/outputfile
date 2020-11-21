using System.IO;
using TextFileReader.Utility;

namespace TextFileReader.FileOperatation
{
    public class TextFileValidatator
    {
        /// <summary>
        /// Check 
        /// </summary>
        /// <param name="textFilePath"></param>
        /// <param name="validatationMessage"></param>
        /// <returns></returns>
        static public bool CheckValidatation(string textFilePath, out string validatationMessage)
        {
            validatationMessage = string.Empty;
            bool isValid = true;

            bool bIsFilePathExist = File.Exists(textFilePath);
            //ファイルが存在するのか
            if (bIsFilePathExist == true)
            {
                ///拡張子を取得
                string fileExtension = Path.GetExtension(textFilePath);

                //.txtの拡張子か確認
                if (fileExtension != Constants.TextFileExtension)
                {
                    validatationMessage = string.Format(Constants.NonExistentTextFile, textFilePath);
                    isValid = false;
                }
            }
            else
            {
                bool bIsDirectoryPathExist = Directory.Exists(textFilePath);

                //ディレクトリパスかどうか
                if (bIsDirectoryPathExist == true)
                {
                    validatationMessage = string.Format(Constants.NonExistentDirectory, textFilePath);
                    isValid = false;
                }
                else
                {
                    validatationMessage = string.Format(Constants.NonExistentFile, textFilePath);
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}

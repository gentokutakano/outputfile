using System.IO;
using TextFileMergeApp.ConstantUtility;

namespace TextFileMergeApp
{
    class TextFileValidator
    {
        #region Public Methods
        /// <summary>
        /// Check if it is text file and receive the message
        /// </summary>
        /// <param name="textFile"></param>
        /// <returns></returns>
        public static bool validationSourceFilePath(string[] textFilePaths, out string validationMessage)
        {
            validationMessage = string.Empty;
            bool isValid = true;

            foreach (string textFilePath in textFilePaths)
            {
                ValidatateFilePath(textFilePath, true, out validationMessage);
            }

            return isValid;
        }

        /// <summary>
        /// ファイルを作成できるか確認
        /// Check if you can create a file
        /// </summary>
        /// <param name="mergeFilePath"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        //public static bool CheckValidatationMerge(string mergeFilePath, out string validationMessage)

        //{
        //    validationMessage = string.Empty;
        //    bool isValid = true;
        //    bool isTextExtension = TextExtensionCheck(mergeFilePath, out validationMessage);

        //    if (isTextExtension == false)
        //    {
        //        DirextoryPathCheck(mergeFilePath, out validationMessage);
        //        isValid = false;
        //    }
        //    return isValid;
        //}
        public static bool ValidatateFilePath(string filePath, bool shouldCheckFileExist, out string validationMessage)
        {
            bool isValid = true;
            validationMessage = string.Empty;

            if (shouldCheckFileExist)
            {
                bool bIsFilePathExist = File.Exists(filePath);
                if (bIsFilePathExist == false)
                {
                    validationMessage = string.Format(Constants.NonExistentFile, filePath);
                    isValid = false;
                }
            }

            if (isValid)
            {
                isValid = TextExtensionCheck(filePath, out validationMessage);
            }

            if (isValid)
            {
                bool isDirPath = Directory.Exists(filePath);
                //validationMessage = isDirPath ? string.Format(Constants.NonExistentDirectory, textFilePath) : string.Format(Constants.NonExistentFile, textFilePath);
                if (isDirPath)
                {
                    validationMessage = string.Format(Constants.NonExistentDirectory, filePath);
                    isValid = false;
                }
                //isValid = DirextoryPathCheck(textFilePath, out validationMessage);
            }
                
            return isValid;
        }
        #endregion


        #region Private Methods

        /// <summary>
        /// .txtの拡張子か確認
        ///　Check if it has a .txt extension
        /// </summary>
        /// <param name="textFilePath"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        private static bool TextExtensionCheck(string textFilePath, out string validationMessage)
        {
            validationMessage = string.Empty;
            bool isValid = true;

            string fileExtension = Path.GetExtension(textFilePath);
            if (fileExtension != Constants.TextFileExtension)
            {
                validationMessage = string.Format(Constants.NonExistentTextFile, textFilePath);
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// ディレクトリパスか確認
        /// Check if it is a directory path
        /// </summary>
        /// <param name="directoryFilePath"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        //private static bool DirextoryPathCheck(string directoryFilePath, out string validationMessage)
        //{
        //    validationMessage = string.Empty;
        //    bool isValid = true;
        //    bool bIsDirectoryPathExist = Directory.Exists(directoryFilePath);

        //    if (bIsDirectoryPathExist == true)
        //    {
        //        isValid = true;
        //    }
        //    else
        //    {
        //        validationMessage = string.Format(Constants.NonExistentDirectory, directoryFilePath);
        //        isValid = false;
        //    }
        //    //else
        //    //{
        //    //    validationMessage = string.Format(Constants.NonExistentFile, directoryFilePath);
        //    //    isValid = false;
        //    //}

        //    return isValid;
        //}
        #endregion
    }
}

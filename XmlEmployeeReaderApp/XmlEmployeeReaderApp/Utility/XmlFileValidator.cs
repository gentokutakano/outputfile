using System.IO;

namespace XmlEmployeeReaderApp.Utility
{
    public class XmlFileValidator
    {
        #region Public Methods
        /// <summary>
        /// xmlファイルか検証
        /// </summary>
        /// <param name="xmlFilePath"></param>
        public static bool ValidateXmlFile(string xmlFilePath, out string fileValidationMessage)
        {
            bool isValid = true;
            //fileValidationMessage = string.Empty;

            ///存在するファイルか確認
            bool bIsFilePathExist = File.Exists(xmlFilePath);
            if (bIsFilePathExist == false)
            {
                isValid = false;
                fileValidationMessage = string.Format(Constants.DeXmlFileExists, xmlFilePath);
            }
            else
            {
                //コマンド引数パスでのXmlファイルを作れるか確認
                bool isMergeFileExists = ValidatateFilePath(xmlFilePath, false, out fileValidationMessage);
                if (isMergeFileExists == false)
                {
                    isValid = false;
                    fileValidationMessage = string.Format(fileValidationMessage + Constants.EndMessage);
                }
            }

            return isValid;
        }

        /// <summary>
        /// .xmlの拡張子か確認
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="shouldCheckFileExist"></param>
        /// <param name="fileValidationMessage"></param>
        /// <returns></returns>
        public static bool ValidatateFilePath(string filePath, bool shouldCheckFileExist, out string fileValidationMessage)
        {
            bool isValid = true;
            fileValidationMessage = string.Empty;

            if (isValid)
            {
                isValid = XmlExtensionCheck(filePath, out fileValidationMessage);
            }

            return isValid;
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// .xmlの拡張子か確認
        ///　Check if it has a .txt extension
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        private static bool XmlExtensionCheck(string xmlFilePath, out string validationMessage)
        {
            validationMessage = string.Empty;
            bool isValid = true;

            ///受け取ったxmlFilePathの拡張子を取得
            string fileExtension = Path.GetExtension(xmlFilePath);

            //.xmlの拡張子か確認
            if (fileExtension != Constants.XmlFileExtension)
            {
                validationMessage = string.Format(Constants.NonExistentTextFile, xmlFilePath);
                isValid = false;
            }
            return isValid;
        }

        #endregion
    }
}
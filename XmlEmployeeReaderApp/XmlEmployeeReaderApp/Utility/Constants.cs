namespace XmlEmployeeReaderApp.Utility
{
    class Constants
    {
        #region ErrorMessage
        public const string ExceptionXmlFileEmp = "コマンド引数が空です。\r\nコマンド引数にXmlファイルパスを入力してください。\r\n終了します。";
        public const string ExceptionMessageSourceFileEmp = "参照先のテキストファイルパスが空です。\r\nコマンド引数に①コピー元ファイル　②テキストファイルパスを入力してください。\r\n終了します。";
        public const string NonExistentDirectory = "[{0}]のディレクトリパスは無効となります。Xmlファイルパスを入力してください。";
        public const string NonExistentFile = "[{0}]は存在しないファイルパスです。Xmlファイルパスを入力してください。";
        public const string NonExistentTextFile = "[{0}]はXmlファイルではありません。";
        public const string DoneMessage = "\nファイルをシリアライズしました。";
        public const string OtherErrorMessage = "エラーです。";
        public const string EndMessage = "\r\n終了します。";
        public const string SerializeMessage = "{0}にてXmlファイルをシリアライズしました。";
        public const string DeXmlFileExists = "{0}は存在しないファイルです。";
        public const string EnterAnInteger = "整数を入力してください";
        public const string ExceptionMessage = "{0}の内容でエラーが発生しました。";
        public const string ValidToInteger = "整数を入力してください : ";
        public const string ValidationNullMessage = "存在しないIDです。";
        #endregion

        #region UserInput
        public const string InputEmpId = "社員Idを入力してください ：　";
        public const string InputIntError = "入力した数字は不正です";
        #endregion

        #region EmployeeInfo
        public const string Employee = "Employee";
        public const string EmpId = "Id";
        public const string EmpFirstName = "FirstName";
        public const string EmpLastName = "LastName";
        public const string EmpAddress = "Address";
        public const string EmpAge = "Age";
        public const string EmpEmail = "Email";
        #endregion

        #region Other
        public const string XmlFileExtension = ".xml";
        public const string ComprateMessage = "{0}のファイルを読み込みました";
        public const string ResultFullName = "FullName -> {0}";
        public const string ResultAddress = "Adress -> {0}";
        public const string ResultAge = "Age -> {0}";
        public const string ResultEmail = "Email -> {0}";
        #endregion
    }
}

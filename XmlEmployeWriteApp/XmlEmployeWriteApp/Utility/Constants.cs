namespace EmployeXmlFileApp.Utility
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

        #endregion

        #region UseuInput
        public const string InputFirstName = "苗字を入力してください : ";
        public const string InputLastName = "名前を入力してください : ";
        public const string InputAddress = "住所を入力してください : ";
        public const string InputAge = "年齢を入力してください : ";
        public const string InputEmail = "emailアドレスを入力してください : ";
        public const string InputCount = "何名分の情報を登録しますか : ";
        public const string ValidToInteger = "整数を入力してください : ";
        public const string PleaseValidAge = "年齢が不正です";
        public const string PleaseValidId = "Idが不正です";
        public const string Bouder = "\n-----------------------------\n";
        #endregion

        #region Other
        public const string XmlFileExtension = ".xml";
        public const string ComprateMessage = "{0}のファイルを書き込みました";
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
    }
}

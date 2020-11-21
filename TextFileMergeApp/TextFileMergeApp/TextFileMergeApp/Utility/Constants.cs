namespace TextFileMergeApp.ConstantUtility
{
    class Constants
    {
        public const string ExceptionMessageMergeFileEmp = "コマンド引数が空です。\r\nコマンド引数に①コピー元ファイル　②テキストファイルパスを入力してください。\r\n終了します。";
        public const string ExceptionMessageSourceFileEmp = "参照先のテキストファイルパスが空です。\r\nコマンド引数に①コピー元ファイル　②テキストファイルパスを入力してください。\r\n終了します。";
        public const string NonExistentDirectory = "[{0}]のディレクトリパスは無効となります。テキストファイルパスを入力してください。";
        public const string NonExistentFile = "[{0}]は存在しないファイルパスです。テキストファイルパスを入力してください。";
        public const string NonExistentTextFile = "[{0}]はテキストファイルではありません。";
        public const string DoneMessage = "\nファイルをマージしました。";
        public const string OtherErrorMessage = "エラーです。";
        public const string EndMessage = "\r\n終了します。";
        public const string MargeMessage = "{0}にてファイルをマージしました。";

        #region Other Constants
        public const string TextFileExtension = ".txt";
        #endregion
    }
}

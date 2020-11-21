namespace TextFileReader.Utility
{
    public class Constants
    {
        #region Message
        public const string ExceptionMessageEmp = "引数が空で入力されました。\r\nコマンド引数にテキストファイルパスを入力してください。\r\n終了します。";
        public const string NonExistentDirectory = "[{0}]ディレクトリパスは無効となります。テキストファイルパスを入力してください。";
        public const string NonExistentFile = "[{0}]は存在しないファイルパスです。テキストファイルパスを入力してください。";
        public const string NonExistentTextFile = "[{0}]はテキストファイルではありません。";
        public const string EndMessage = "\r\n終了します。";
        #endregion

        #region Other Constants
        public const string TextFileExtension = ".txt";
        public const int StartBytes = 0;
        public const int ReadBytes = 100;
        #endregion
    }
}

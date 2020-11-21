using System;
using System.Collections.Generic;
using System.Text;

namespace TextFileMergeApp.ConstantUtility
{
    class ConstantsUtility
    {
        public const string ExceptionMessageEmp = "引数が空で入力されました。\r\nコマンド引数にテキストファイルパスを入力してください。\r\n終了します。";
        public const string NonExistentDirectory = "[{0}]ディレクトリパスは無効となります。テキストファイルパスを入力してください。";
        public const string NonExistentFile = "[{0}]は存在しないファイルパスです。テキストファイルパスを入力してください。";
        public const string NonExistentTextFile = "[{0}]はテキストファイルではありません。";
        public const string EndMessage = "\r\n終了します。";
    }
}

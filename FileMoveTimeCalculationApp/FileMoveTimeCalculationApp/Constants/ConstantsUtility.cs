using System;
using System.Collections.Generic;
using System.Text;

namespace FileTransferTimeCalculationApp.Constants
{
    public class ConstantsUtility
    {
        //定義したら外部から変更できない定数群
        public const string UserInputDataType = "データタイプを選択してくださいKB(1) MB(2) GB(3)";
        public const string UserInputDataSize = "データサイズを入力してください : ";
        public const string UserInputDataSpeed = "回線速度を入力してください KB/s (キロ B/s)　: ";
        public const string UserInputZeroError = "0での入力はできません ";
        public const string UserOutputTime = "転送に要する時間は{0}です。";
        public const string UserConversionTime = "{0}日{1}時{2}分{3}秒";
    }
}

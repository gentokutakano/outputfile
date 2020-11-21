using System;
using XmlEmployeeReaderApp.Utility;

namespace XmlEmployeeReaderApp.ConsoleUtility
{
    /// <summary>
    /// 整数をコンソールから取得
    /// </summary>
    public class ConsoleReader
    {
        #region Public Method
        /// <summary>
        /// 数字をコンソールから取得
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int GetInt(string message)
        {

            string userInput;
            int IntValue;
            bool isSucess = true;
            Console.Write(message);

            do
            {
                if (isSucess == false)　//整数以外の入力判定があった場合
                {
                    Console.Write(Constants.ValidToInteger);
                }
                userInput = Console.ReadLine();
                isSucess = int.TryParse(userInput, out IntValue);
            } while (isSucess == false);

            return IntValue;
        }

        /// <summary>
        /// 年齢を取得
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int GetId(string message)
        {
            int Id;
            bool isSucess = true;
            do
            {
                if (isSucess == false)　//整数以外の入力判定があった場合
                {
                    Console.WriteLine(Constants.InputIntError);
                }

                isSucess = true;
                Id = GetInt(message);

                if (Id <= 0)
                {
                    isSucess = false;
                }

            } while (isSucess == false);
            return Id;
        }
    #endregion
    }
}

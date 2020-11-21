using System;

namespace FileTransferTimeCalculationApp.CommonUtility
{
    class ConsoleUtility
    {
        #region pulic method
        /// <summary>
        /// Enter an integer other than 0
        /// 1～３の列挙子をEnumにいれて「KB、MB、GB」を判断
        /// </summary>
        /// <returns></returns>
        static public DataKind GetDataKindEnumFromConsole()
        {
            string userInput;
            int IntValue;
            bool Value = true;
            DataKind temp;

            do
            {
                userInput = Console.ReadLine();
                Value = int.TryParse(userInput, out IntValue);
                temp = (DataKind)IntValue;
                
                ///Valueを検証
                if (Value == false || IntValue > 3 || IntValue <= 0)
                {
                    //Use Constants
                    Console.Write("1～3の整数を入力してください : ");
                }

            } while (Value == false || IntValue > 3 || IntValue <= 0);

            return temp;
        }

        /// <summary>
        /// Enter an integer other than 0
        /// </summary>
        /// <returns></returns>
        static public long GetLongFromConsole()
        {
            string userInput;
            long longValue = 0;
            bool Value = true;

            do
            {
                if (Value == false) //整数以外の入力判定があった場合
                {
                    Console.Write("整数を入力してください : ");
                }

                userInput = Console.ReadLine();
                Value = long.TryParse(userInput, out longValue);
            } while (Value == false);

            return longValue;

        }
        #endregion
    }
}

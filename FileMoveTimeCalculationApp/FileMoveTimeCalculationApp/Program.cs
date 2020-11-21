using FileTransferTimeCalculationApp;
using FileTransferTimeCalculationApp.CommonUtility;
using FileTransferTimeCalculationApp.Constants;
using System;

namespace FileMoveTimeCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataKind dataTypeEnum;
            long dataAmount;
            long dataSpeed;
            long transferSecondSpeed = 0;

            #region User Input
            Console.Write(ConstantsUtility.UserInputDataType);
            dataTypeEnum = ConsoleUtility.GetDataKindEnumFromConsole();
            Console.Write(ConstantsUtility.UserInputDataSize);
            dataAmount = ConsoleUtility.GetLongFromConsole();
            Console.Write(ConstantsUtility.UserInputDataSpeed);
            dataSpeed = ConsoleUtility.GetLongFromConsole();
            #endregion

            try
            {
                //受け取った値を秒単位で取得
                transferSecondSpeed = DataCalculator.GetDataTransferSpeedInSec(dataTypeEnum, dataAmount, dataSpeed);

                //秒単位(数字の羅列)を　→　0.00:00:00　に直す
                TimeSpan conversionTime = TimeSpan.FromSeconds(transferSecondSpeed);

                //秒の単位を[時間/分/秒]に変換
                FileTransferTimeCalculationApp.CalculationUtility.TimeSpan objectResult = TimeSpanCalculator.GetTimeSpanFromSec(transferSecondSpeed);

                Console.WriteLine(objectResult);

                ////0.00:00:00を0日0時間0分0秒に直す
                string stTime = string.Format(ConstantsUtility.UserConversionTime,
                    conversionTime.Days, conversionTime.Hours, conversionTime.Minutes, conversionTime.Seconds);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(ConstantsUtility.UserInputZeroError);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

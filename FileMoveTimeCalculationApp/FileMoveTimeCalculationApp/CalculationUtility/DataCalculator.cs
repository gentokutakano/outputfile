using FileTransferTimeCalculationApp.CommonUtility;

namespace FileTransferTimeCalculationApp
{
    class DataCalculator 
    {
        #region Constants
        //定義したら外部から変更できない定数群
        private const int _consversionNum = 1024;
        #endregion

        /// <summary>
        /// Data type acquisition
        /// 受けっとった値で転送時間を計算
        /// 秒単位で取得する
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="dataAmount"></param>
        /// <param name="dataSpeed"></param>
        /// <returns></returns>
        public static long GetDataTransferSpeedInSec(DataKind dataType, long dataAmount, long dataSpeed)
        {
            long transferSecondSpeed = 0;
            long conversionType = 0;

            ///DataTyoeを判断
            switch (dataType)
            {
                case DataKind.KB:
                    conversionType = dataAmount;
                    break;
                case DataKind.MB:
                    conversionType = dataAmount * _consversionNum;
                    break;
                case DataKind.GB:
                    conversionType = dataAmount * (_consversionNum * _consversionNum);
                    break;
                default:
                    break;
            }
            transferSecondSpeed = conversionType / dataSpeed;
            return transferSecondSpeed;
        }
    }
}

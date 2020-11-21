namespace FileTransferTimeCalculationApp
{
    /// <summary>
    /// Class for Calculate Time span
    /// </summary>
    class TimeSpanCalculator
    {
        #region Constants
        private const int HourseNum = 3600;
        private const int MinuteNum = 60;
        #endregion

        #region Private Member
        #endregion

        #region Constructor
        #endregion

        #region Public Method
        /// <summary>
        /// Hours minutes seconds acquisition
        /// 秒の単位を[時間/分/秒]に変換
        /// </summary>
        /// <param name="GetProcessingSpeed"></param>
        /// <returns></returns>
        public static CalculationUtility.TimeSpan GetTimeSpanFromSec(long secondSpeed)
        {
            CalculationUtility.TimeSpan type = new CalculationUtility.TimeSpan();

            ///計算し変換
            type.Hours = secondSpeed / HourseNum;
            type.Minute = secondSpeed % HourseNum / MinuteNum;
            type.Second = secondSpeed % HourseNum % MinuteNum;

            return type;
        }

        #endregion
    }
}
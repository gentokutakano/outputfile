using System;
using System.Collections.Generic;
using System.Text;
using FileTransferTimeCalculationApp.Constants;

namespace FileTransferTimeCalculationApp.CalculationUtility
{
    class TimeSpan
    {
        private long hourseInt;
        private long minuteInt;
        private long secondInt;

        /// <summary>
        /// Converts seconds to hours/minutes/seconds
        /// 値を代入　保管をする役割
        /// </summary>
        public long Hours
        {
            set { hourseInt = value; } //値の代入 外部からの値をvalueに入れている
            get { return hourseInt; } //外部に値を返す
        }

        public long Minute
        {
            set { minuteInt = (value); }
            get { return minuteInt; } 
        }

        public long Second
        {
            set { secondInt = (value ); } 
            get { return secondInt; }
        }

        public override string ToString()
        {
            return string.Format("転送に要する時間は{0}時間{1}分{2}秒です",
                    Hours, Minute, Second);
        }

    }
}
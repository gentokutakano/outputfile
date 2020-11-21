using EmployeXmlFileApp.Utility;
using System;

namespace EmployeXmlFileApp
{
    public class ConsoleReader
    {
        #region Public Methods
        /// <summary>
        /// ユーザー情報を入力してEmployeeに保管
        /// </summary>
        /// <returns></returns>
        public static Employee GetToEmployeeInfo()
        {
            Employee employeeinfo = new Employee();

            ///ユーザー入力用のメソッドにまとめる
            Console.Write(Constants.InputFirstName);
            employeeinfo.FirstName = Console.ReadLine();
            Console.Write(Constants.InputLastName);
            employeeinfo.LastName = Console.ReadLine();
            Console.Write(Constants.InputAddress);
            employeeinfo.Address = Console.ReadLine();
            employeeinfo.Age = GetAge(Constants.InputAge);
            Console.Write(Constants.InputEmail);
            employeeinfo.Email = Console.ReadLine();
            Console.WriteLine(Constants.Bouder);

            return employeeinfo;
        }

        /// <summary>
        /// 数字をコンソールから取得
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int GetInt(string message)　// ファイル移動
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
        public static int GetAge(string message)
        {
            int age;
            bool isSucess = true;
            do
            {
                if (isSucess == false)　//整数以外の入力判定があった場合
                {
                    Console.WriteLine(Constants.PleaseValidAge);
                }
                isSucess = true;
                age = GetInt(message);
                if (age <= 0 || age > 100)
                {
                    isSucess = false;
                }

            } while (isSucess == false);
            return age;
        }
        #endregion
    }
}

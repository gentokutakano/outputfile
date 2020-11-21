using System;
using XmlEmployeeReaderApp.ConsoleUtility;
using XmlEmployeeReaderApp.Model;
using XmlEmployeeReaderApp.Utility;

namespace XmlEmployeeReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //空か確認
                if (args.Length == 0)
                {
                    Console.WriteLine(Constants.ExceptionXmlFileEmp);
                    Environment.Exit(0);
                }
                string xmlFilePath = args[0];

                ///xmlファイルをバリデーションする
                bool bIsFilePathValid = XmlFileValidator.ValidateXmlFile
                    (xmlFilePath, out string ValidationMessage);

                if (bIsFilePathValid == false)
                {
                    Console.WriteLine(ValidationMessage);
                    Environment.Exit(0);
                }

                ///コンソールから引っ張ってくるEmployeeIdを取得する
                int isEmpId = ConsoleReader.GetId(Constants.InputEmpId);

                ///社員Idに対しての社員情報オブジェクトを取得
                Employee objEmployee = XmlFileUtility.GetEmployee(xmlFilePath, isEmpId);
                if(objEmployee == null)
                {
                    Console.WriteLine(Constants.ValidationNullMessage);
                    Environment.Exit(0);
                }

                Console.WriteLine(string.Format(Constants.ResultFullName, objEmployee.FirstName + objEmployee.LastName));
                Console.WriteLine(string.Format(Constants.ResultAddress, objEmployee.Address));
                Console.WriteLine(string.Format(Constants.ResultAge, objEmployee.Age));
                Console.WriteLine(string.Format(Constants.ResultEmail, objEmployee.Email));
                Console.WriteLine(Constants.ComprateMessage, xmlFilePath);
                Console.ReadKey();

            }
            catch (Exception e)
            {
                {
                    Console.WriteLine(Constants.EndMessage);
#if DEBUG
                    Console.WriteLine(Constants.ExceptionMessage, e);
#endif
                }
            }
        }
    }
}

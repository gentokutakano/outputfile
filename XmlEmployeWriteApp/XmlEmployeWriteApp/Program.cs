using EmployeXmlFileApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EmployeXmlFileApp
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
                    (xmlFilePath, out string fileValidationMessage);
                if (bIsFilePathValid == false)
                {
                    Console.WriteLine(fileValidationMessage);
                    Environment.Exit(0);
                }

                List<Employee> employeeList = new List<Employee>();

                ///入力した数字分だけ情報を入力してもらう
                int cleateCounts = ConsoleReader.GetInt(Constants.InputCount);

                foreach (int cleateCount in Enumerable.Range(1, cleateCounts))
                {
                    ///Employeeに情報を入力してもらう
                    Employee employeeinfo = ConsoleReader.GetToEmployeeInfo();
                    ///EmployeeListにEmployeeを入れる
                    employeeList.Add(employeeinfo);
                }

                ///社員情報をXmlファイルに上書きで入力追加する
                XmlFileUtility.WriteToXML(xmlFilePath, employeeList);

#if DEBUG
                XDocument xmlLoad = XDocument.Load(xmlFilePath);
                Console.WriteLine("{0}", xmlLoad);
#endif
            }
            catch (Exception e)
            {
                Console.WriteLine(Constants.EndMessage);
#if DEBUG
                Console.WriteLine(Constants.ExceptionMessage, e);
#endif
            }
        }
    }
}

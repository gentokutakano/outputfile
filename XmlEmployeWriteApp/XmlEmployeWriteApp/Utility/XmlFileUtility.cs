using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EmployeXmlFileApp.Utility;

namespace EmployeXmlFileApp
{
    public class XmlFileUtility
    {
        #region Public Method
        /// <summary>
        /// 引数で受け取ったリストデータ（List<Employee>）を元に１ユーザーごとに分解。
        /// 上書きしてファイルに書き込む
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <param name="employees"></param>
        /// <param name="shouldAppend"></param>
        public static void WriteToXML(string xmlFilePath, List<Employee> employees)
        {
            ///Xmlファイルを読み込む
            XElement employeeListElement = XElement.Load(xmlFilePath);

            ///タグないのシーケンスを削除
            employeeListElement.RemoveAll();

            ////タグの要素数（シーケンス）を取得
            int employeeCount = employeeListElement.Elements().Count();

            foreach (Employee employee in employees)
            {
                ///これは必要なのか検討
                employee.Id += ++employeeCount;

                ///入力されたリストデータの１ユーザーを取得し「保管」
                XElement employeeElement = GetXElementFromEmployee(employee);

                ///ファイルに１ユーザーを書き込む
                employeeListElement.Add(employeeElement);
            }

            employeeListElement.Save(xmlFilePath);
        }
        #endregion

        #region Private Method
        /// <summary>
        /// XElementにEmployee情報を保管する
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        private static XElement GetXElementFromEmployee(Employee employee)
        {
            XElement xmlElement = new XElement(Constants.Employee,
                 new XElement(Constants.EmpId, employee.Id),
                 new XElement(Constants.EmpFirstName, employee.FirstName),
                 new XElement(Constants.EmpLastName, employee.LastName),
                 new XElement(Constants.EmpAddress, employee.Address),
                 new XElement(Constants.EmpAge, employee.Age),
                 new XElement(Constants.EmpEmail, employee.Email));
            return xmlElement;
        }
        #endregion
    }
}

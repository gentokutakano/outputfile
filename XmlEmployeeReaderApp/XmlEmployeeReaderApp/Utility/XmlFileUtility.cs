using System.Linq;
using System.Xml.Linq;
using XmlEmployeeReaderApp.Model;
using XmlEmployeeReaderApp.Utility;

namespace XmlEmployeeReaderApp
{
    class XmlFileUtility
    {
        #region Public Mathod
        /// <summary>
        /// 取得したIdのEmployee情報を取得する
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <param name="emoloyeeID"></param>
        /// <returns></returns>
        public static Employee GetEmployee(string xmlFilePath, int emoloyeeID)
        {
            XElement xmlFileElement = XElement.Load(xmlFilePath);

            var result = xmlFileElement
                .Elements()
                .Where(whereItem => whereItem.Element(Constants.EmpId).Value == emoloyeeID.ToString());

            Employee employee = result.Select(S => new Employee()
            {
                FirstName = S.Element(Constants.EmpFirstName).Value,
                LastName = S.Element(Constants.EmpLastName).Value,
                Address = S.Element(Constants.EmpAddress).Value,
                Age = int.Parse(S.Element(Constants.EmpAge).Value),
                Email = S.Element(Constants.EmpEmail).Value
            }).FirstOrDefault(); //nullを返す

            return employee;

        }
        #endregion
    }
}
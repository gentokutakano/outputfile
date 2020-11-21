using EmployeXmlFileApp.Utility;
using System.Xml.Serialization;

namespace EmployeXmlFileApp
{
    /// <summary>
    /// 社員情報の保管
    /// </summary>
    public class Employee
    {
        [XmlElement(Constants.EmpId)]
        public int Id { get; set; }

        [XmlElement(Constants.EmpFirstName)]
        public string FirstName { get; set; }

        [XmlElement(Constants.EmpLastName)]
        public string LastName { get; set; }

        [XmlElement(Constants.EmpAddress)]
        public string Address { get; set; }

        [XmlElement(Constants.EmpAge)]
        public int Age { get; set; }

        [XmlElement(Constants.EmpEmail)]
        public string Email { get; set; }
    }
}

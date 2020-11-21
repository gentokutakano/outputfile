using EmployeXmlFileApp;
using EmployeXmlFileApp.Utility;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlEmployeWriteApp
{
    public class Employees
    {
        [XmlElement(Constants.Employee)]
        public List<Employee> EmployeeList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XML.ReaderApp.Utility
{
    [XmlRoot("Employees")]
    public class Employees
    {
        [XmlElement("Employee")]
        public List<Employee> EmployeeList { get; set; }
    }
}

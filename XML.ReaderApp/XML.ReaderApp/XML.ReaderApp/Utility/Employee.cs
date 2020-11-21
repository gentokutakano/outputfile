using System;
using System.Xml.Serialization;

namespace XML.ReaderApp
{
    [Serializable]
    public class Employee
    {
        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlElement("FirstName")]
        public string FirstName { get; set; }


        [XmlElement("LastName")]
        public string LastName { get; set; }


        [XmlElement("Address")]
        public string Address { get; set; }


        [XmlElement("Age")]
        public string Age { get; set; }


        [XmlElement("Email")]
        public string Email { get; set; }
    }
}

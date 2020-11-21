using System;

namespace XML.ReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("引数空だよ");
                Environment.Exit(0);
            }
            string xmlFilePath = args[0];
            //string xmlFileRoot = "Employee";

            //Employees xmlInfos = XmlUtility.DeserializeXmlFileReader(xmlFilePath);

            //foreach (Employee xmlInfo in xmlInfos.EmployeeList)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("ID : " + xmlInfo.Id);
            //    Console.WriteLine("FullName : " + xmlInfo.FirstName + xmlInfo.LastName);
            //    Console.WriteLine("Address : " + xmlInfo.Address);
            //    Console.WriteLine("Age : " + xmlInfo.Age);
            //    Console.WriteLine("Email : " + xmlInfo.Email);
            //    Console.WriteLine("------------------------------\n");
            //}

            XmlUtility.UpdateToXmlFile(xmlFilePath, "Employee");

            Console.WriteLine("表示できたよ");

        }
    }
}

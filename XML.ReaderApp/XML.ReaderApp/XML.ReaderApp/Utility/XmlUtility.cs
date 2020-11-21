using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using XML.ReaderApp.Utility;

namespace XML.ReaderApp
{
    public class XmlUtility
    {
        /// <summary>
        /// Xmlファイルをリストで読み込む
        /// コンソール表示方法　例:
        /// </summary>
        /// <param name="xmlFile"></param>
        public static IEnumerable<XElement> XmlReaderToList(string xmlFile, string xmlRoot)
        {
            XElement xml = XElement.Load(xmlFile);

            //xmlRootのタグ内の情報を取得する
            IEnumerable<XElement> xmlRootInfos = from item in xml.Elements(xmlRoot)
                                                 select item;

            return xmlRootInfos;
        }

        /// <summary>
        /// 条件付きでxmlFileを読み込む
        /// </summary>
        /// <param name="xmlFile"></param>
        public static IEnumerable<String> ConditionalXmlReader(string xmlFile, string xmlRoot)
        {
            //xmlファイルを指定する
            XElement xmlElement = XElement.Load(xmlFile);

            IEnumerable<String> xmlSpeciFiedInfos = xmlElement.Elements(xmlRoot)
                .Where(whereItem => whereItem.Element("Age").Value == "32")
                .Select(selectItem => selectItem.Element("Email").Value);


            return xmlSpeciFiedInfos;
        }


        /// <summary>
        /// Xmlファイルを更新する
        /// </summary>
        /// <param name="xmlFile"></param>
        public static void UpdateToXmlFile(string xmlFile, string xmlRoot)
        {
            //xmlファイルを指定する ロードする
            XElement xmlElement = XElement.Load(xmlFile);

            //                     Employeetタグ内を指定      　　
            //XElement info = (XElement)xmlElement.Elements(xmlRoot)
                //    引数   　　　　処理　　FirstNameが佐藤の情報を指定 この条件を満たせばSelectメソッドを処理
                //.Where(W => W.Element("FirstName").Value == "佐藤")
                //Selectはお飾り　Singleは唯一の要素を取得する
                //.Select(S => S).Single();


            //                     Employeeタグ内を指定      　　
            List<Employee> employeeList = xmlElement.Elements(xmlRoot)
                //    引数   　　　　処理　　FirstNameが佐藤の情報を指定 この条件を満たせばSelectメソッドを処理
                //.Where(W => W.Element("FirstName").Value == "佐藤")
                //　Singleは唯一の要素を取得する
                .Select(S => new Employee()
                {
                    Id = S.Attribute("Id").Value = "12",
                    FirstName = S.Element("FirstName").Value = "さとう",
                    LastName = S.Element("LastName").Value = "たける",
                    Address = S.Element("Address").Value = "おおさか",
                    Age = S.Element("Age").Value = "28",
                    Email = S.Element("Email").Value = "mmm@gmail.com",
                }).ToList();

            Employees employees = new Employees()
            {
                EmployeeList = employeeList
            };

            //info.Element("Address").Value = "不明";

            //変更を保存する
            xmlElement.Save(xmlFile);
        }

        /// <summary>
        /// シリアライズする
        /// </summary> 
        /// <param name="xmlFile"></param>
        public static void SiliarizerXmlFile(string xmlFile)
        {

            //保存先のファイル名
            string fileName = @"C:\work\SkillUp\XmlSirializeTest.xml";

            //シリアライズするクラスのインスタンスを作成
            Employees serializeClass = new Employees();
            //serializeClass.FirstName = "佐藤";
            //serializeClass.Address = "北海道札幌市";
            //serializeClass.Age = "28";

            //オブジェクトの型（今回はMemberinfo）を指定して、XmlSerializerを作成する。
            XmlSerializer xmlSrializer = new XmlSerializer(typeof(Employees));

            //ファイルを開く
            using (StreamWriter xmlFileWriter = new StreamWriter(fileName, false, new System.Text.UTF8Encoding(false)))
            {
                //シリアライズして保存
                xmlSrializer.Serialize(xmlFileWriter, serializeClass);
            }
        }

        /// <summary>
        /// デシリアライズして復元する
        /// 
        /// コンソール表示例:
        ///　Employees xmlInfos = XmlFlow.DeserializeXmlFileReader(xmlFilePath);
        //　foreach (Employee xmlInfo in xmlInfos.EmployeeList)
        //　{
        //    Console.WriteLine("ID : " + xmlInfo.Id);
        //　} 
        public static Employees DeserializeXmlFileReader(string xmlFile)
        {
            //オブジェクトの型（今回はMemberinfo）をtypeofで指定して、XmlSerializerを作成する。
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employees));

            //Xmlファイを開く
            using (FileStream xmlFileStream = new FileStream(xmlFile, FileMode.Open))
            {
                //デシリアライズして復元する
                Employees loadAry = (Employees)xmlSerializer.Deserialize(xmlFileStream);

                return loadAry;
            }
        }

        /// <summary>
        /// 概要:
        ///　XmlFileの情報をまとめて取得
        ///　引数にファイル入れてを各要素の情報を取得してくれる
        ///　
        ///　コンソール表示例:
        ///　IEnumerable<XElement> xmlInfos = XmlFlow.XmlFileReader(xmlFilePath, "Employee");
        ///　foreach (XElement xmlInfo in xmlInfos)
        ///  {
        ///　    Console.WriteLine("FullName : " + xmlInfo.Element("FirstName").Value + xmlInfo.Element("LastName").Value);
        ///　}
        /// </summary>
        /// <param name="xmlFile"></param>
        public static IEnumerable<XElement> XmlFileReader(string xmlFile, string xmlRoot)
        {
            XElement xmlLoad = XElement.Load(xmlFile);

            //メンバー情報のタグ内の情報を取得する
            IEnumerable<XElement> xmlEmpInfos = from item in xmlLoad.Elements(xmlRoot)
                                                select item;

            return xmlEmpInfos;
        }

        /// <summary>
        /// XmlFileのテキストをタグごとすべて取得する
        /// </summary>
        /// <param name="xmlFile"></param>
        public static void XmlFileDocumentAllReader(string xmlFile)
        {
            XDocument xmlLoad = XDocument.Load(xmlFile);
            Console.WriteLine(xmlLoad.ToString());
        }
    }
}

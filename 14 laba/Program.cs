using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace exersices_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Herb herb = new Herb();
            Herb herb1 = new Herb();
            Herb herb2 = new Herb();

            List<Herb> herbList = new List<Herb>();
            herbList.Add(herb);
            herbList.Add(herb1);
            herbList.Add(herb2);


            ///////////////
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, herbList);
                Console.WriteLine("Object is serialized");
            }
            using (FileStream fileStream = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                List<Herb> result = (List<Herb>)formatter.Deserialize(fileStream);
                int j = 1;
                foreach (Herb h in result)
                {
                    Console.WriteLine("It's number is " + h.Number);
                    j++;
                }
            }
            Console.WriteLine();
            ////////////////


            SoapFormatter sformatter = new SoapFormatter();
            using (FileStream fileStream = new FileStream("data.soap", FileMode.OpenOrCreate))
            {
                sformatter.Serialize(fileStream, herb);
                Console.WriteLine("Object is serialized");
            }
            using (FileStream fileStream = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                List<Herb> result = (List<Herb>)formatter.Deserialize(fileStream);
                try
                {
                    Console.WriteLine("It's number is " + result[0].Number);
                }
                catch (TypeLoadException) { };
            }
            Console.WriteLine();
            //////////////////


            XmlSerializer xSer = new XmlSerializer(typeof(List<Herb>));
            using (FileStream fileStream = new FileStream("data1.xml", FileMode.OpenOrCreate))
            {
                xSer.Serialize(fileStream, herbList);
                Console.WriteLine("Object is serialized");
            }
            using (FileStream fileStream = new FileStream("data1.xml", FileMode.OpenOrCreate))
            {
                List<Herb> newP = xSer.Deserialize(fileStream) as List<Herb>;
                int k = 1;
                foreach (Herb h in newP)
                {
                    Console.WriteLine("It's number is " + h.Number); k++;
                }
            }
            Console.WriteLine();
            ////////


            string json = JsonConvert.SerializeObject(herbList);
            Console.WriteLine("Object is serialized");
            List<Herb> js = JsonConvert.DeserializeObject<List<Herb>>(json);
            int i = 1;
            foreach (Herb h in js)
            {
                Console.WriteLine("It's number is " + h.Number); i++;
            }
            Console.WriteLine();


            ////////////
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("data1.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);

            Console.WriteLine();
            XmlNodeList nodes = xRoot.SelectNodes("Herb");
            foreach (XmlNode n in nodes)
            {
                XmlNodeList nnn = n.SelectNodes("Number");
                foreach (XmlNode c in nnn)
                {
                    Console.WriteLine("Number: " + c.InnerText);
                }
                XmlNodeList nn = n.SelectNodes("Number");
                foreach (XmlNode c in nn)
                {
                    Console.WriteLine("Number: " + c.InnerText);
                }
                Console.WriteLine();
            }
            XDocument doc = new XDocument();
            XElement user = new XElement("User");
            XElement user2 = new XElement("User");
            XAttribute userNumber = new XAttribute("Number", 123);
            XAttribute userNumber2 = new XAttribute("Number", 234);
            XElement userPass = new XElement("Password", "null");
            XElement userPass2 = new XElement("Password", "1234");
            user.Add(userNumber);
            user.Add(userPass);
            user2.Add(userNumber2);
            user2.Add(userPass2);
            XElement users = new XElement("City");
            users.Add(user);
            users.Add(user2);
            doc.Add(users);
            doc.Save("linq.xml");
            XDocument xdoc = XDocument.Load("linq.xml");
            var res = from xe in xdoc.Element("City").Elements("User")
                      select new Herb
                      {
                          Number = int.Parse(xe.Attribute("Number").Value)
                      };
            foreach (Herb h in res)
                Console.WriteLine(h.Number);
            Console.ReadKey();
        }
    }
}
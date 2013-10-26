namespace JsonToXML
{
    using System;
    using System.Linq;
    using System.Xml;
    using Newtonsoft.Json;

    public class Program
    {
        public static void Main(string[] args)
        {
            string jsonData = "{\"YourJSONData\":\"DATA\"}";

            XmlDocument doc = (XmlDocument)Newtonsoft.Json.JsonConvert.DeserializeXmlNode(jsonData);
            string xmlData = doc.InnerXml;

            Console.WriteLine(xmlData);

            string jsonText = JsonConvert.SerializeXmlNode(doc);
            Console.WriteLine(jsonText);
        }
    }
}

using System;
using System.Xml;

namespace ex3_1
{
    class Program
    {
      

        static void Main(string[] args)
        {
            ReadFile();
        }
        public static bool  ReadFile()
        {
            XmlTextReader xtr = new XmlTextReader("XmlFile.xml");
                while (xtr.Read())
                { 
                    if (xtr.Name == "name")
                    {
                    var product = xtr.ReadElementString();
                       //price = xmlTextReader.
                        Console.WriteLine("PRODUCT NAME:{0}  ",product);
                    }
                    if (xtr.Name == "price")
                    {
                    var price = xtr.ReadElementString();
                    //price = xmlTextReader.
                    Console.WriteLine("PRICE: {0} \n",price);
                    }
                }
            return false;
        }

    }
}

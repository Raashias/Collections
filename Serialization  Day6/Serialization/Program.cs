using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //City f = new City();*/
            //f.Name="Raashi";
            //f.Age = 22;
            //f.Population = 1000000;
            Person p = new Person();
            p.Name = "Ram";
            p.Age = 12;
            p.City = new City(); //City is a class and property of the person class.
            p.City.Name = "Blr";
            p.City.Population = 10000;
            p.ToString();
            
            //var/XmlSerialiser can be written as the data type
            var s = new XmlSerializer(typeof(Person)); //For Xml Serialisation mention the type as the class name which you want to access
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Serialization\Serialization\Program2.txt", FileMode.Create, FileAccess.Write);

            s.Serialize(fs, p);
            fs.Close();

            FileStream sf = new FileStream(@"C:\Training\EuroTraining\Serialization\Serialization\Program2.txt", FileMode.Open, FileAccess.Read);
            Person objnew = (Person)s.Deserialize(sf);
            //Binary Serialisation
            //var formatter = new BinaryFormatter();
            //FileStream fs = new FileStream(@"C:\Training\EuroTraining\Serialization\Serialization\Program1.txt", FileMode.Create, FileAccess.Write);

            //formatter.Serialize(fs, p);
            //fs.Close();

            //FileStream sf = new FileStream(@"C:\Training\EuroTraining\Serialization\Serialization\Program1.txt", FileMode.Open, FileAccess.Read);
            //Person objnew = (Person)formatter.Deserialize(sf);

            Console.WriteLine(objnew.Name);
            
            Console.WriteLine(objnew.Age);
            Console.WriteLine(objnew.City.Name);
            Console.WriteLine(objnew.City.Population);





            Console.Read();
        }
    }
}

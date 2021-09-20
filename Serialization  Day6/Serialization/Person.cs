using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; } 
        public int Age { get; set; }
        public City City { get; set; } 
        public override string ToString() 
        {
            StringBuilder str = new StringBuilder(); 
            str.AppendLine("Name: " + Name); 
            str.AppendLine("Age: " + Age); 
            str.AppendLine("City: " + City.Name);
            str.AppendLine("pop: " + City.Population);

            return str.ToString(); 
        }
    }
        [Serializable] 
    public class City
    {
        public string Name { get; set; } 
        public int Population { get; set; }
    }
        //String Name, Age, City;
        //public void Persons()
        //{
        //    Person obj = new Person();
        //    obj.Name = "Ram";
        //    obj.Age = "15";
        //    obj.City = "Bengaluru";

        //    var formatter = new BinaryFormatter();
        //    FileStream fs = new FileStream(@"C:\Training\EuroTraining\Serialization\Serialization\Program.txt", FileMode.OpenOrCreate, FileAccess.Write);

        //    formatter.Serialize(fs, obj);
        //    fs.Close();

        //    FileStream sf = new FileStream(@"C:\Training\EuroTraining\Serialization\Serialization\Program.txt", FileMode.Open, FileAccess.Read);
        //    Person objnew = (Person)formatter.Deserialize(sf);

        //    Console.WriteLine(objnew.Name);
        //    Console.WriteLine(objnew.Age);
        //    Console.WriteLine(objnew.City);
        //}

    }
   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fs = new FileInfo(@"C:\Training\EuroTraining\Collections\ReflectionSharp\ReflectionSharp\assemblies\ChordFileGenerator.dll");
            Assembly assembly_name = Assembly.LoadFrom(fs.FullName);

            Type a= assembly_name.GetType("ChordFileGenerator.ChordFileGenerator");

            object o = Activator.CreateInstance(a);

            Console.Write("Song Name: ");
            string songName = Console.ReadLine();
            SetProperty(o, "SongName", songName);

            Console.Write("Artist: ");
            string artist = Console.ReadLine();
            SetProperty(o, "Artist", artist);

            Console.Write("File Type: ");
            string fileTypeName = Console.ReadLine();
            Type fileTypeEnum = assembly_name.GetType("ChordFileGenerator.FileType");
            object fileTypeValue = GetEnumValue(fileTypeEnum, fileTypeName);
            SetProperty(o, "FileType", fileTypeValue);

            string lineType;
            do
            {

                Console.Write("Line Type - Lyric(L), Chords Lyric (CL) or blank to cancel: ");
                lineType = Console.ReadLine();

                if (lineType == "L")
                {
                    string lyrics = Console.ReadLine();

                    InvokeMethod(o, "LineAdd", new object[] { lyrics });
                }
                else if (lineType == "CL")
                {
                    string chords = Console.ReadLine();
                    string lyrics = Console.ReadLine();

                    InvokeMethod(o, "LineAdd", new object[] { chords, lyrics });
                }

                else
                    break;
            } while (lineType == "L" || lineType == "CL");

            
            InvokeMethod(o, "FileSaving", new object[] { "test.txt" });

            Console.WriteLine("Saved file!");
            Console.WriteLine(assembly_name);
            Console.ReadLine();
        }

    


    public static object GetProperty(object o, string PropertyName)
    {
        PropertyInfo property = o.GetType().GetProperty(PropertyName);

        return property.GetValue(o);
    }

    public static void SetProperty(object o, string PropertyName, object value)
    {
        PropertyInfo property = o.GetType().GetProperty(PropertyName);

        property.SetValue(o, value);
    }

    public static object InvokeMethod(object o, string methodName, object[] arguments)
    {
        Type[] tp = arguments.Select(x => x.GetType()).ToArray();

        MethodInfo method = o.GetType().GetMethod(methodName, tp);

        return method.Invoke(o, arguments);
    }

    public static object GetEnumValue(Type enumType, string enumItemName)
    {
        Type enumUnderlyingType = enumType.GetEnumUnderlyingType();

        List<string> enumNames = enumType.GetEnumNames().ToList();

        Array enumValues = enumType.GetEnumValues();

        object enumValue = enumValues.GetValue(enumNames.IndexOf(enumItemName));

        return Convert.ChangeType(enumValue, enumUnderlyingType);
    }
}
}

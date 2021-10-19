using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FileIOOperations
{
    class BinarySerialize
    {
        public void Serialization()
        {
            Demo demo = new Demo();
            FileStream fileStream = new FileStream(@"E:\ASP.NET\FileIOOperations\SerializeExample.txt", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, demo);
        }
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"E:\ASP.NET\FileIOOperations\SerializeExample.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Demo deserializeDemo = (Demo)binaryFormatter.Deserialize(fileStream);

            Console.WriteLine($"ApplicationName: " + deserializeDemo.ApplicationName);
            Console.WriteLine($"ApplicationId: " + deserializeDemo.ApplicationId);
        }

    }

    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";

        public int ApplicationId { get; set; } = 1001;

    }
}

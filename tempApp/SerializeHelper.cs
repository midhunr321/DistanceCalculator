using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DistanceCalculator
{
    class SerializeHelper
    {

        public static  void serialize_file(FileInfo serializationFile, Object list)
        {
            Stream stream = File.Open(serializationFile.FullName, FileMode.Create);
            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            bformatter.Serialize(stream,list);
        }
        public static void deserialize_file(FileInfo serializationFile, Object list)
        {
            Stream stream = File.Open(serializationFile.FullName, FileMode.Create);
            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        }
    }
}

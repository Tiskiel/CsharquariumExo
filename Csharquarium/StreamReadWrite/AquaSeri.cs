using Csharquarium.classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.StreamReadWrite
{
    public static class AquariumSerialisation
    {
        private static string filePath = "monAquarium.bin";

        public static void Save(Aquarium aqua)
        {
            FileStream fs = File.Create(filePath);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, aqua);
            fs.Close();
        }
    }

    //public static Aquarium Open()
    //{
    //    Aquarium a = new Aquarium(a);

    //    if(File.Exists(filePath))
    //    {

    //    }

    //}
}

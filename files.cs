using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace конвертер
{
    public class files
    {
        public string userformat;
        private static bool result;
        private static bool result1;
        private static bool result2;
        public static List<human> deseriliz = new List<human>();

        public static void deserizal()
        {
            Console.WriteLine("введиtе путь к файлу, который хотите прочитать");
            Console.WriteLine("----------------------------");
            string userInside = Console.ReadLine();
            result = userInside.Contains(".txt");
            result1 = userInside.Contains(".json");
            result2 = userInside.Contains(".xml");

            if (result == true)
            {
                human human = new human();
                string[] Stroki = File.ReadAllLines(userInside);
                for (int i = 0; i < Stroki.Length; i += 3)
                {
                    deseriliz.Add(new human(Stroki[i], Convert.ToInt32(Stroki[i + 1]), Stroki[i + 2]));
                }
                foreach (human vivodtxt in deseriliz) { Console.WriteLine(vivodtxt.name + "\n" + vivodtxt.age + "\n" + vivodtxt.color + "\n"); }
            }

            else if (result1 == true)
            {
                string text = File.ReadAllText(userInside);
                deseriliz = JsonConvert.DeserializeObject<List<human>>(text);
                foreach (human vivodjson in deseriliz)
                {
                    Console.WriteLine(vivodjson.name + "\n" + vivodjson.age + "\n" + vivodjson.color + "\n");
                }
            }

            else if (result2 == true)
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<human>));
                using (FileStream fs = new FileStream(userInside, FileMode.Open))
                {
                    deseriliz = (List<human>)xmls.Deserialize(fs);
                    
                }
                foreach (human vivodxml in deseriliz)
                {
                    Console.WriteLine(vivodxml.name + "\n" + vivodxml.age + "\n" + vivodxml.color + "\n");
                }
            }
        }

        public void serializal()
        {
            Console.WriteLine("введиtе путь до файла");
            Console.WriteLine("----------------------------");
            userformat = Console.ReadLine();
            result = userformat.Contains(".txt");
            result1 = userformat.Contains(".json");
            result2 = userformat.Contains(".xml");

            if (result == true)
            {
                foreach (human vivod in deseriliz)
                {
                    File.AppendAllText(userformat, vivod.name + "\n" + vivod.age + "\n" + vivod.color + "\n");
                }
            }

            else if (result1 == true)
            {
                string jsons = JsonConvert.SerializeObject(deseriliz);
                File.WriteAllText(userformat, "\n" + jsons);
            }

            else if (result2 == true)
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<human>));
                using (FileStream fs = new FileStream(userformat, FileMode.OpenOrCreate))
                {
                    xmls.Serialize(fs, deseriliz);
                }
            }
        }
    }
}
// Users\alinaryzhkova\Desktop.
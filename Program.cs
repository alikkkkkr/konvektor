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
    class Program
    {
        human human = new human();

        static void Main()
        {
            files.deserizal();
            changetext changetext = new changetext();
            changetext.changeText();
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape) { Console.Clear(); Console.WriteLine("вы завершили программу"); return; }
        }
        //static List<human> list()
        //{
        //    human human = new human();
        //    List<human> humans = new List<human>();
        //    human human1 = new human("алик", 17, "белый");
        //    human human2 = new human("суета", 10, "черный");
        //    human human3 = new human("анастасьон", 22, "фиол");
        //    humans.Add(human1);
        //    humans.Add(human2);
        //    humans.Add(human3);
        //    return humans;
        //}
    }
}

// Users\alinaryzhkova\Desktop.
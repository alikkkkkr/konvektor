using System;
using System.Collections.Generic;

namespace конвертер
{
    public class human
    {
        public string name;
        public int age;
        public string color;
        public List<human> humans;

        public human()
        { }

        public human(string korobkaname, int korobkaage, string korobkacolor)
        {
            name = korobkaname;
            age = korobkaage;
            color = korobkacolor;
        }
    }
}


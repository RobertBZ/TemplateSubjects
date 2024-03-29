﻿using PatternAdapter.ConvertData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlConverter = new XmlConverter();

            Console.WriteLine("Parser Json");
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
            Console.ReadKey();
        }
    }
}

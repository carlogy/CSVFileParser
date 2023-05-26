using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace CsvFileParser
{

    class Program
    {
        static void Main(string[] args)
        {
            GIExportParser.GIExportParse();
            
        }
    }
}







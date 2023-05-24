using System;
using CsvHelper;
using System.Globalization;
using System.IO;
using CsvHelper.Configuration;
using System.Linq;

namespace CsvFileParser
{

    public class GIExportParser

    {
        public static void GIExportParse()
        {

            Console.Write("Enter the path of the file you wish to parse: ");
            var inputPath = Console.ReadLine();

            TextReader streamReader;
            using (streamReader = new StreamReader($@"{inputPath}"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<GreatIdea>().ToList();

                    string[] itemsToSearch = new string[] { "portal", "portal home", "home" };
                    List<int> filteredIds = new List<int>();

                    foreach (var record in records)
                    {
                        if (record.Title.Contains(itemsToSearch[0]))
                        {
                            //Console.WriteLine(record.ID);
                            filteredIds.Add(record.ID);
                        }
                        else if (record.Title.Contains(itemsToSearch[1]))
                        {
                            //Console.WriteLine(record.ID);
                            filteredIds.Add(record.ID);
                        }
                        else if (record.Title.Contains(itemsToSearch[2]))
                        {
                            //Console.WriteLine(record.ID);
                            filteredIds.Add(record.ID);
                        }
                        else if (record.Description.Contains(itemsToSearch[0]))
                        {
                            //Console.WriteLine(record.ID);
                            filteredIds.Add(record.ID);
                        }
                        else if (record.Description.Contains(itemsToSearch[1]))
                        {
                            //Console.WriteLine(record.ID);
                            filteredIds.Add(record.ID);
                        }
                        else if (record.Description.Contains(itemsToSearch[2]))
                        {
                            //Console.WriteLine(record.ID);
                            filteredIds.Add(record.ID);
                        }


                    }

                    //Opportunity to iterate and create a CSV with this.
                    //Need to figure out how to 

                    foreach (var id in filteredIds)
                    {
                        Console.WriteLine(id);
                    }

                    Console.WriteLine("Total GI's: " + filteredIds.Count());
                }

                Console.ReadLine();


            }
        }
    }
}		 


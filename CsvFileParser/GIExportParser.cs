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

            Console.Write("Enter the keywords you want to search for separated by a comma: ");
            var keyWords = Console.ReadLine();


            Console.Write("Path to save file: ");
            var NewFilePath = Console.ReadLine() + "/FilteredGreatIdeas.csv";


            var keyArr = keyWords.Split(separator: ", ");

            List<GreatIdea> filteredIdeas = new List<GreatIdea>();

            TextReader streamReader;
            using (streamReader = new StreamReader($"{inputPath}"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<GreatIdea>().ToList();

                    
                   
                    foreach (var record in records)
                    {

                        if (keyArr.Any(item => record.Title.Contains(item) || record.Description.Contains(item)))
                       
                        {
                            //Console.WriteLine(record.ID);
                            filteredIdeas.Add(record);
                        }
              
                    }

                   
                     // Prints each idea that's filtered as a string   
                    //foreach (var idea in filteredIdeas)
                    //{
                    //    Console.WriteLine(idea.ToString());
                    //}

                    Console.WriteLine("Total GI's Filtered: " + filteredIdeas.Count());
                }



                // Builds the export

                var headerColumns = "GI_ID, Title, Description, Status, Upvotes";
                List<string> IdeaExport = new List<string>();

                IdeaExport.Add(headerColumns);
                

                foreach (var ideaLine in filteredIdeas)
                {
                   
                    IdeaExport.Add(ideaLine.ToString());
                }

                // writeAll lines to file, creates file, saves the file in path

                File.AppendAllLines(NewFilePath, IdeaExport);


                // confirmation file saved  in path

                Console.WriteLine($"Filtered ideas saved to {NewFilePath}");

               Console.ReadLine();


            }
        }

       
    }
}		 


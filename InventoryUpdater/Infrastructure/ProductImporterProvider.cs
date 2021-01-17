using InventoryUpdater.Domain.Interfaces;
using InventoryUpdater.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryUpdater.Infrastructure
{
    public class ProductImporterProvider : IProductImporter
    {
       public List<string> ProcessImporter(string input, string databaseSource)
        {
            var results = Load(input);
            var saveResult = Save(results, databaseSource);
            Console.WriteLine(saveResult);
            return results;
        }
        public List<string> Load(string input)
        {
            List<string> productResults = new List<string>();
            string[] inputPath;
            inputPath = input.Split(" "); ;
            //After splitting we should be having 3 parts by now inclue product prouctsource
            //We will first validate if we have 3 parts or not
            if (inputPath.Length != 3)
            {
                throw new FormatException(message: "Incorrect format!");
            }
            
                var filePath = inputPath[2];
                var fileName = CommonUtils.GetFileName(filePath);
                var extension = CommonUtils.GetFileExtension(fileName);
                Console.WriteLine("Filename is {0} with extension {1}", fileName, extension);
                string fileLocation;
                if (fileName.ToLower().Equals("capterra.yaml"))
                {
                    fileLocation = Constants.YAMPFILEPATH;
                }
                else
                {
                    fileLocation = Constants.JSONFILEPATH;
                }
                string fileContent = File.ReadAllText(fileLocation);
                FileReaderFactory fileReaderFactory = new FileReaderFactory();
            if(extension.Length < 3)
            {
                throw new FormatException(message: "Invalid file extension!");
            }
                IFileReader fileReader = fileReaderFactory.GetExtensionReader(extension);
                productResults = fileReader.Read(extension, fileContent);
                return productResults;            

        }
        public bool Validation(string [] input)
        {
            //to handle errors for file name and filepath
            return true;
        }
        
        public string Save(List<string> input, string databaseSource)
        {
            DatabaseSourceFactory databaseSourceFactory = new DatabaseSourceFactory();
            IDatabaseProvider databaseProvider= databaseSourceFactory.GetDatabaseProvider(databaseSource);
            var results = databaseProvider.SaveProducts(input);

            return results;

        }
    }
}

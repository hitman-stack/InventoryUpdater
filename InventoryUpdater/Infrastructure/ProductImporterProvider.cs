using InventoryUpdater.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryUpdater.Infrastructure
{
    class ProductImporterProvider : IProductImporter
    {
       public List<string> ProcessImporter(string input)
        {
            var results = Load(input);
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
                Console.WriteLine("Invalid input passed. Please pass input in the given format!");
            var filePath = inputPath[2];
            var fileName = GetFileName(filePath);
            var extension = GetFileExtension(fileName);
            Console.WriteLine("Filename is {0} with extension {1}", fileName, extension);
            string fileLocation;
            if (fileName.ToLower().Equals("capterra.yaml"))
            {
                fileLocation = @"C:\Users\Mohit Mishra\Documents\GitHub\InventoryUpdater\InventoryUpdater\Assets\feed-products\capterra.yaml";
            }
            else
            {
                fileLocation = @"C:\Users\Mohit Mishra\Documents\GitHub\InventoryUpdater\InventoryUpdater\Assets\feed-products\softwareadvice.json";
            }
            
            string fileContent = File.ReadAllText(fileLocation);
            FileReaderFactory fileReaderFactory = new FileReaderFactory();
            IFileReader fileReader= fileReaderFactory.GetExtensionReader(extension);
            productResults = fileReader.Read(extension, fileContent);
            return productResults;
        }
        public bool Validation(string [] input)
        {
            return true;
        }
        public string GetFileName(string input)
        {
            string[] pathFileName = input.Split("/");       
            return pathFileName[1];
        }
        public string GetFileExtension(string fileName)
        {
            int extensionStart = fileName.IndexOf('.');
            return fileName.Substring(extensionStart+1);
        }
        public string Save(string input)
        {
            throw new NotImplementedException();
        }
    }
}

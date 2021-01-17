using InventoryUpdater.Orchestrator;
using System;
using System.IO;

namespace InventoryUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please provide one of the below inputs \n import capterra feed-products/capterra.yaml or \n import softwareadvice feed-products/softwareadvice.json");
                string inputSource = Console.ReadLine();
                ProductImporterOrchestrator productImporterOrchestrator = new ProductImporterOrchestrator();
                var result = productImporterOrchestrator.ProcessImporter(inputSource);
                foreach(var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Oops we got an exception {0}", ex);
            }
            
        }
    }
}

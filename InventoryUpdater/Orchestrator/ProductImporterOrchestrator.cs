using InventoryUpdater.Domain.Interfaces;
using InventoryUpdater.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Orchestrator
{
    class ProductImporterOrchestrator
    {
         ProductImporterProvider productImporterProvider = new ProductImporterProvider();
        public List<string> ProcessImporter(string input)
        {
            return productImporterProvider.ProcessImporter(input);
        }
    }
}

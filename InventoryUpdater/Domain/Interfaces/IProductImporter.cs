using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Domain.Interfaces
{
    interface IProductImporter
    {
        List<string> Load(string input);
        string Save(List<string> input, string dataSource);
    }
}

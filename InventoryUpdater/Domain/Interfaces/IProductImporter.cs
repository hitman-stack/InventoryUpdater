using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Domain.Interfaces
{
    interface IProductImporter
    {
        string Load(string input);
        string Save(string input);
    }
}

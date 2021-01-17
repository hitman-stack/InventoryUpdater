using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Domain.Interfaces
{
    interface IDatabaseProvider
    {
        string SaveProducts(List<string> input);
    }
}

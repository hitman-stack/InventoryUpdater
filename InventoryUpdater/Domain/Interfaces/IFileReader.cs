using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Domain.Interfaces
{
    interface IFileReader
    {
        List<string> Read(string input);
    }
}

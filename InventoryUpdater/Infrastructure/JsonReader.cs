using InventoryUpdater.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Infrastructure
{
    class JsonReader : IFileReader
    {
        public List<string> Read(string extension, string content)
        {
            throw new NotImplementedException();
        }
    }
}

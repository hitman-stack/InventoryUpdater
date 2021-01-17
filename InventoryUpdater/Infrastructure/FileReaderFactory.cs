using InventoryUpdater.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Infrastructure
{
    class FileReaderFactory 
    {
        public IFileReader GetExtensionReader(string extension)
        {
            if (extension == null)
                return null;
            else if (extension.ToUpper().Equals("YAML"))
                return new YamlReader();
            else if (extension.ToUpper().Equals("JSON"))
            return new JsonReader();
            return null;
        }
    }
}
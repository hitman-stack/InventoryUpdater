using InventoryUpdater.Domain.Interfaces;
using InventoryUpdater.Models;
using InventoryUpdater.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using YamlDotNet;
namespace InventoryUpdater.Infrastructure
{
    class YamlReader : IFileReader
    {
        public List<string> Read(string extension, string content)
        {
            List<string> yamlList = new List<string>();
            var deserializer = new YamlDotNet.Serialization.Deserializer();
            var yamlResults = deserializer.Deserialize<List<CapterraModel>>(content);
            //adding data in list
            foreach (var item in yamlResults)
            {
                yamlList.Add(string.Format(Constants.YAMLRESULTFORMAT, item.tags, item.name, item.twitter));
            }
            return yamlList;
        }
    }
}

using InventoryUpdater.Domain.Interfaces;
using InventoryUpdater.Models;
using InventoryUpdater.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
namespace InventoryUpdater.Infrastructure
{
    class JsonReader : IFileReader
    {
        public List<string> Read(string extension, string content)
        {
            List<string> jsonList = new List<string>();
            var jsonResults = JsonConvert.DeserializeObject<SoftwareAdviceModel>(content);
            //adding data in list
            foreach (var item in jsonResults.products)
            {
                jsonList.Add(string.Format(Constants.JSONRESULTFORMAT, item.title, string.Join(',', item.categories), item.twitter));
            }
            return jsonList;
        }
    }
}

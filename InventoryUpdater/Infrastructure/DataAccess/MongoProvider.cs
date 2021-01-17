using InventoryUpdater.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Infrastructure.DataAccess
{
    class MongoProvider : IDatabaseProvider
    {
        public string SaveProducts(List<string> input)
        {
            if (input.Count == 0)
            {
                return "Save unsuccessfull in MongoDb!";
            }
            else
            {
                return "Save successfull in MongoDb!";
            }
        }
    }
}

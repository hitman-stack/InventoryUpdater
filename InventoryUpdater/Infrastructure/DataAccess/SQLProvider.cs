using InventoryUpdater.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Infrastructure.DataAccess
{
    class SQLProvider : IDatabaseProvider
    {
        public string SaveProducts(List<string> input)
        {
            if (input.Count == 0)
            {
                return "Save unsuccessfull in MySQL!";
            }
            else
            {
                return "Save successfull in MySQL!";
            }
        }
    }
}

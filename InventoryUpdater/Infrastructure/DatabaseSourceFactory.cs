using InventoryUpdater.Domain.Interfaces;
using InventoryUpdater.Infrastructure.DataAccess;
using InventoryUpdater.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Infrastructure
{
    class DatabaseSourceFactory
    {
        public IDatabaseProvider GetDatabaseProvider(string databaseSource)
        {
            if (databaseSource == null)
                return null;
            if (databaseSource.ToUpper().Equals(Constants.SOURCEMYSQL))
                return new SQLProvider();
            else if (databaseSource.ToUpper().Equals(Constants.SOURCEMONGODB))
                return new MongoProvider();
            throw new InvalidOperationException(message: "DatabaseSource not supported!");
        }
    }
}

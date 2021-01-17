using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Shared
{
    public static class Constants
    {
        public const string JSONRESULTFORMAT = "importing: Name: \"{0}\";  Categories: {1}; Twitter: {2}";
        public const string YAMLRESULTFORMAT = "importing: Tags: \"{0}\";  Name: {1}; Twitter: {2}";
        public const string JSONFILEPATH = @"C:\Users\Mohit Mishra\Documents\GitHub\InventoryUpdater\InventoryUpdater\Assets\feed-products\softwareadvice.json";
        public const string YAMPFILEPATH = @"C:\Users\Mohit Mishra\Documents\GitHub\InventoryUpdater\InventoryUpdater\Assets\feed-products\capterra.yaml";
        public const string SOURCEMYSQL = "MYSQL";
        public const string SOURCEMONGODB = "MONGODB";

    }
}

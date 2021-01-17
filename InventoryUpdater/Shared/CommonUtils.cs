using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Shared
{
  public static  class CommonUtils
    {
        public static string GetFileName(string input)
        {
            string[] pathFileName = input.Split("/");
            return pathFileName[1];
        }
        public static string GetFileExtension(string fileName)
        {
            int extensionStart = fileName.IndexOf('.');
            return fileName.Substring(extensionStart + 1);
        }

    }
}

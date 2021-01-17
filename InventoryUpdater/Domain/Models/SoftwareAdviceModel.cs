using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Models
{
    class SoftwareAdviceModel
    {
        public List<SoftwareAdviceBase> ProductList { get; set; }
    }
    class SoftwareAdviceBase
    {
        public List<string>  categories { get; set; }
        public string twitter { get; set; }
        public string title  { get; set; }
    }

}

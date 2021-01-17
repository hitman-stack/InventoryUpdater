using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryUpdater.Models
{
    public class SoftwareAdviceModel
    {
        public List<SoftwareAdviceBase> products { get; set; }
    }
   public  class SoftwareAdviceBase
    {
        public List<string>  categories { get; set; }
        public string twitter { get; set; }
        public string title  { get; set; }
    }

}

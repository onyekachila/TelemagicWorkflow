using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelemagicWorkflow.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // This is going to be the parent of the inventory item.
        // so we put in a child collection of the inventory item and lazily load them bu using the virtual keyword
        public virtual List<InventoryItem> InventoryItems { get; set; } 
    }
}
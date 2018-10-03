using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelemagicWorkflow.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public int WorkOrderId { get; set; }
        public WorkOrder WorkOrder { get; set; }

        // three properties from inventory item
        public string InventoryItemCode { get; set; }
        public string InventoryItemName { get; set; }
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
        public decimal ExtendedPrice { get; set; } // this will contain the product of the unit price and the quantity
        public string Notes { get; set; }
        public bool IsInstalled { get; set; }

    }
}
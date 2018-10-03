using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using TelemagicWorkflow.Models;

namespace TelemagicWorkflow.DataLayer
{
    public class PartConfiguration : EntityTypeConfiguration<Part>
    {
        public PartConfiguration()
        {
            Property(p => p.InventoryItemName)
                .HasMaxLength(15)
                .IsRequired()
                // To make sure we dont get duplicate part on the same workorder 
                // we need a unique index over the combination of inventory item code, and the parent work order id
                // we do this by placing the index annotation on both column like below
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("AK_Part", 2) { IsUnique = true })); 
                
            // Then we tell entity framework which column comes first in the index by doing the below
                Property(w => w.WorkOrderId)
                     .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("AK_Part", 1) { IsUnique = true }));

            // The code above means we make the workorderId as the first column in the index and inventoryItemName as the second column

            Property(p => p.InventoryItemCode)
                .HasMaxLength(80)
                .IsRequired();

            Property(p => p.UnitPrice).HasPrecision(18, 2);

            // This is going to be a computed column in the database
            Property(p => p.ExtendedPrice).HasPrecision(18, 2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed); 

            Property(p => p.Notes)
                .HasMaxLength(140)
                .IsOptional();


                


                
        }
    }
}
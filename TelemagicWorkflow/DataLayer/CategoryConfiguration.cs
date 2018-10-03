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
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(c => c.CategoryName)
                .HasMaxLength(20)
                .IsRequired()
                // The code below is for unique index becuse the category name is an alternate key
                .HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute("AK_Category_CategoryName") { IsUnique = true }));
        }
    }
}
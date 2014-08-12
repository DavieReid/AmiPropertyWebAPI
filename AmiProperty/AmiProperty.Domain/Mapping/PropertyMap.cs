using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Models;

namespace AmiProperty.Domain.Mapping
{
    public class PropertyMap : EntityTypeConfiguration<Property>
    {
        public PropertyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(250);

            this.Property(t => t.Summary)
               .HasMaxLength(250);

            this.Property(t => t.FullDescription)
               .HasMaxLength(2500);


            // Table & Column Mappings
            this.ToTable("Properties");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.AddressId).HasColumnName("AddressId");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.FullDescription).HasColumnName("FullDescription");
            this.Property(t => t.Available).HasColumnName("Available");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Models;

namespace AmiProperty.Domain.Mapping
{
    public class AddressMap : EntityTypeConfiguration<PropertyAddress>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.HouseNumber)
                .HasMaxLength(10);

            this.Property(t => t.Street)
                .HasMaxLength(100);

            this.Property(t => t.Town)
                .HasMaxLength(50);

            this.Property(t => t.Area)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            this.Property(t => t.PostCode)
                .HasMaxLength(10);

            this.Property(t => t.Latitude)
                .HasMaxLength(12);

            this.Property(t => t.Longitude)
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Addresses");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HouseNumber).HasColumnName("HouseNumber");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.Town).HasColumnName("Town");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
        }
    }
}

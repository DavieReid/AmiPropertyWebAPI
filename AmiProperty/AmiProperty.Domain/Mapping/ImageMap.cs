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
    public class ImageMap : EntityTypeConfiguration<PropertyImage>
    {
        public ImageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ImageUrl)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Images");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PropertyId).HasColumnName("PropertyId");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.IsCoverImage).HasColumnName("IsCoverImage");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Mapping;

namespace AmiProperty.Domain.Models
{
    public partial class PropertyContext : DbContext
    {

        static PropertyContext()
        {
            Database.SetInitializer<PropertyContext>(null);
        }

        public PropertyContext()
            : base("Name=PropertyContext")
        {
        }

        public DbSet<PropertyImage> Images { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyStatus> Status { get; set; }
        public DbSet<PropertyType> Types { get; set; }
        public DbSet<PropertyAddress> Address { get; set; }
        public DbSet<KeyFeature> KeyFeatures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ImageMap());
            modelBuilder.Configurations.Add(new PropertyMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new TypeMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new KeyFeatureMap());

            modelBuilder.Entity<PropertyImage>()
                .HasRequired<Property>(p => p.Property)
                .WithMany(s => s.Images).HasForeignKey(s => s.PropertyId);

            //Use map to specify joining table and keys.
            modelBuilder.Entity<Property>()
                .HasMany(p => p.KeyFeatures)
                .WithMany()
                .Map(m =>
                    {
                        m.MapLeftKey("PropertyId");
                        m.MapRightKey("FeatureId");
                        m.ToTable("PropertyFeatures");
                    });
        }
    }
}
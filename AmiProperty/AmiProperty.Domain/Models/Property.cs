using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Interfaces;

namespace AmiProperty.Domain.Models
{
    public partial class Property:BaseObject, IProperty
    {
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public int? StatusId { get; set; }
        public int? TypeId { get; set; }
        public int? AddressId {get; set;}

        public virtual PropertyAddress Address { get; set; }
        public virtual PropertyStatus Status { get; set; }
        public virtual PropertyType Type { get; set; }

        public string Summary { get; set; }
        public string FullDescription { get; set; }
        public bool Available { get; set; }

        public virtual ICollection<PropertyImage> Images { get; set; }
    }
}

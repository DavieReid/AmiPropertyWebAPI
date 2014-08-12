using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Models;

namespace AmiProperty.Domain.Interfaces
{
    public interface IProperty
    {
        string Title { get; set; }
        decimal? Price { get; set; }
        int? StatusId { get; set; }
        int? TypeId { get; set;}
        int? AddressId { get; set; } 

        PropertyStatus Status { get; set; }
        PropertyType Type { get; set; }
        PropertyAddress Address { get; set; }

        string Summary { get; set; }
        string FullDescription { get; set; }
        bool Available { get; set; }

        ICollection<PropertyImage> Images { get; set; }
    }
}

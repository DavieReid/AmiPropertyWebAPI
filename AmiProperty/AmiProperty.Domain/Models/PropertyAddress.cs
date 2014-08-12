using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Interfaces;

namespace AmiProperty.Domain.Models
{
    public class PropertyAddress:BaseObject, IAddress
    {
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Area { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}

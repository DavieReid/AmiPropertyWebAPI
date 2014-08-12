using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmiProperty.Domain.Interfaces
{
    public interface IAddress
    {

        string HouseNumber { get; set; }
        string Street { get; set; }
        string Town { get; set; }
        string Area { get; set; }
        string Country { get; set; }
        string PostCode { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }
    }
}

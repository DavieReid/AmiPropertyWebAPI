using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Interfaces;


namespace AmiProperty.Domain.Models
{
   public class PropertyStatus:BaseObject, IOrderableDisplay
    {
       public int? DisplayOrder { get; set; }
       public string DisplayName { get; set; }
    }
}

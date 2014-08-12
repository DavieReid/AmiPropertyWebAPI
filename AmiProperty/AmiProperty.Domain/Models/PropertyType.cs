using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Interfaces;

namespace AmiProperty.Domain.Models
{
    public class PropertyType:BaseObject, IOrderableDisplay
    {

        //public PropertyType()
        //{
        //    this.Properties = new List<Property>();
        //}

        public int? DisplayOrder { get; set; }
        public string DisplayName { get; set; }
        //public virtual ICollection<Property> Properties { get; set; }
    }
}

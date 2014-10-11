using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmiProperty.Domain.Models
{
    public partial class PropertyImage:BaseObject
    {
        public int PropertyId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsCoverImage { get; set; }

        public virtual Property Property { get; set; }
    }
}

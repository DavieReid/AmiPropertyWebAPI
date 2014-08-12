using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmiProperty.Domain.Interfaces
{
    public interface IOrderableDisplay
    {
        int? DisplayOrder { get; set; }
        string DisplayName { get; set; }
    }
}

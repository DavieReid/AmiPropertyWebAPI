using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Models;

namespace AmiProperty.Domain.Interfaces
{
    public interface IPropertyRepository : IDisposable
    {
        IEnumerable<Property> GetAllProperties();
        Property GetProperty(int id);
        void InsertProperty(Property prop);
        void DeleteProperty(int id);
        void UpdateProperty(Property prop);
        void Save();
    }
}

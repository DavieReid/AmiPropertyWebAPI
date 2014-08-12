using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmiProperty.Domain.Interfaces;

namespace AmiProperty.Domain.Models
{
    public class PropertyRepository: IPropertyRepository
    {
        private PropertyContext _context;

        public PropertyRepository(PropertyContext context)
        {
            this._context = context;
        }

        public IEnumerable<Property> GetAllProperties()
        {
            return _context.Properties.ToList().Where(p => p.Available);
        }

        public Property GetProperty(int id)
        {
            return _context.Properties.Find(id);
        }

        public void InsertProperty(Property prop)
        {
           _context.Properties.Add(prop);
        }

        public void DeleteProperty(int id)
        {
            Property prop = _context.Properties.Find(id);
            _context.Properties.Remove(prop);
        }

        public void UpdateProperty(Property prop)
        {
            _context.Entry(prop).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        #region dispose methods
        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}

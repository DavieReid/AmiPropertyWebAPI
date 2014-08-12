using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AmiProperty.Domain.Interfaces;
using AmiProperty.Domain.Models;

namespace AmiProperty.Controllers
{
    public class PropertiesController : ApiController
    {
        private IPropertyRepository _propertyRepo;

        // GET api/properties/
        [HttpGet]
        public IEnumerable<Property> Get()
        {
            _propertyRepo = new PropertyRepository(new PropertyContext());
            return _propertyRepo.GetAllProperties();
        }

        // GET api/properties/5
        [HttpGet]
        public Property Get(int id)
        {
            _propertyRepo = new PropertyRepository(new PropertyContext());
            return _propertyRepo.GetProperty(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}

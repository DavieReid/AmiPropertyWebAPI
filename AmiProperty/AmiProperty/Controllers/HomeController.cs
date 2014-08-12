using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmiProperty.Domain.Models;
using AmiProperty.Domain.Interfaces;

namespace AmiProperty.Controllers
{
    public class HomeController : Controller
    {
        private IPropertyRepository _propertyRepo;

        public ActionResult Index()
        {
            this._propertyRepo = new PropertyRepository(new PropertyContext());
            var temp = _propertyRepo.GetAllProperties();
            return View();
        }
    }
}

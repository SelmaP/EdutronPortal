using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdutronPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace EdutronPortal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(EgitimTanim egitimTanim)
        {
            //Bilgileri Veri Tabanına Kaydet
            //Model Binding
            if (ModelState.IsValid)
            {
                Repository.AddEgitimTanimla(egitimTanim);
                return View("MyView", egitimTanim);
            }
            else
            {
                return View();
            }
         
        }
        //Home/List
        public ViewResult List()
        {
            var liste = Repository.EgitimTanims.Where(i => i.Kategori == "Online");
            return View(liste);
        }
    }
}
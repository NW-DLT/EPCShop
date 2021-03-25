using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPCShop.Data.Interfaces;
using EPCShop.ViewModels;

namespace EPCShop.Controllers
{
    public class PcsController : Controller
    {
        private readonly IAllPcs _allPcs;

        public PcsController(IAllPcs iAllPcs) 
        {
            _allPcs = iAllPcs;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Готовые сборки";
            PcsListViewModel obj = new PcsListViewModel();
            return View(obj);
        }
    }
}

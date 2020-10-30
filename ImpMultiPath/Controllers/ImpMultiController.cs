using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImpMultiPath.Controllers
{
    public class ImpMultiController : Controller
    {
        bool flag = false;
        public IActionResult Index()
        {
            ViewBag.flagvalue = flag;
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection frm)
        { 
            flag = true;
            ViewBag.flagvalue = flag;
            ViewBag.Name = frm["FText"].ToString();
            ViewBag.Name2 = frm["SText"].ToString();
            ViewBag.Name3 = frm["ThText"].ToString();
            ViewBag.Name4 = frm["FoText"].ToString();
            return View();
        }

    }
    }

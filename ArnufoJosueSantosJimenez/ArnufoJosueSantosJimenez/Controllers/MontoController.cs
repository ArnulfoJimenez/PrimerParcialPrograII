using ArnufoJosueSantosJimenez.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArnufoJosueSantosJimenez.Controllers
{
    public class MontoController : Controller
    {
        // GET: Monto
        public ActionResult DescripcionMontoViewModel(MontoViewModel monto)
        {
            {
                if (!ModelState.IsValid)
                {
                    return View("MontoViewModel", monto );
                }
                return Redirect("MontoViewModel");
            }
        }
        public ActionResult Error()
        {
            return View();
        }
            public ActionResult Operacion()
            {
            
                return View();
            }

            public ActionResult MontoViewModel()
            {
                return View();
            }
        }
    }
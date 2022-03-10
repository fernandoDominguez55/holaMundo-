using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace holaMundo
{
    public class Saludo:  Controller
    {
        public ActionResult Index()
        {
            return View(); 
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Minimundo.Api.Controllers
{
    public class CustoSugestaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
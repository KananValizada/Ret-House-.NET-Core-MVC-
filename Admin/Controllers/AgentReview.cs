﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class AgentReview : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

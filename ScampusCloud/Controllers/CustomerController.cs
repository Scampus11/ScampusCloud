﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScampusCloud.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Customer()
        {
            return View();
        }
        public ActionResult AddEditCustomer()
        {
            return View();
        }
    }
}
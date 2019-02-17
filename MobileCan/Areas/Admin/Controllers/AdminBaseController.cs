﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileCan.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public abstract class AdminBaseController : Controller
    {
    }
}
using Labb4_MVC_Razor.Models;
using Labb4_MVC_Razor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Controllers
{
    public class BorrowBookController : Controller
    {
        public IActionResult BorrowBook()
        {
            return View();
        }
    }
}
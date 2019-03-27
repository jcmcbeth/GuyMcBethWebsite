using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GuyMcBeth.com.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
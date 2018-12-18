﻿namespace GuyMcBeth.com.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using GuyMcBeth.com.Models;
    using System.Reflection;
    using System.IO;
    using System;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LastUpdated()
        {
            var assembly = Assembly.GetExecutingAssembly();
            FileInfo fileInfo = new FileInfo(assembly.Location);
            DateTime lastModified = fileInfo.LastWriteTime;

            return this.Json(lastModified);
        }
    }
}

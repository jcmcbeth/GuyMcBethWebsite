namespace GuyMcBeth.com.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using GuyMcBeth.com.Models;
    using System.Reflection;
    using System.IO;
    using System;
    using Microsoft.AspNetCore.Hosting;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.Extensions.FileProviders;

    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

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
            var lastModified = this.GetContentFiles().Max(fi => fi.LastModified);

            return this.Json(lastModified);
        }

        private IEnumerable<IFileInfo> GetContentFiles()
        {
            var directories = new Queue<string>();
            var files = new List<IFileInfo>();

            directories.Enqueue("");

            while (directories.Count > 0)
            {
                var directory = directories.Dequeue();

                var items = this.hostingEnvironment
                    .ContentRootFileProvider
                    .GetDirectoryContents(directory)
                    .ToList();

                var directoryFiles = items.Where(fi => !fi.IsDirectory);

                files.AddRange(directoryFiles);

                foreach (var newDirectory in items.Where(fi => fi.IsDirectory))
                {
                    directories.Enqueue(directory + "\\" + newDirectory.Name);
                }
            }

            return files;
        }
    }
}

namespace GuyMcBeth.com.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
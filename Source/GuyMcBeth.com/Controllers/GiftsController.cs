namespace GuyMcBeth.com.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class GiftsController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
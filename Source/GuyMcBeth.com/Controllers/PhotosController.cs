namespace GuyMcBeth.com.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PhotosController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}

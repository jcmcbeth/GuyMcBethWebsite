namespace GuyMcBeth.com.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CareController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}

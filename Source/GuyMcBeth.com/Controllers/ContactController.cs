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
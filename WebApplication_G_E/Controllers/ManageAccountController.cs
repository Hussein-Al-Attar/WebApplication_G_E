using Microsoft.AspNetCore.Mvc;

namespace WebApplication_G_E.Controllers
{
    public class ManageAccountController : Controller
    {
       
        public IActionResult newAccount()
        {
            return View();
        }
    }
}

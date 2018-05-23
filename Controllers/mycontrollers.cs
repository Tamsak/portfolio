using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace Portfolio.Controllers
{
    public class mycontrollers : Controller
    {
        [Route("")]
        public ViewResult Home()
        {
            return View();
        }
        [Route("Projects")]
        public ViewResult Projects()
        {
            return View();
        }
        [Route("Contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}
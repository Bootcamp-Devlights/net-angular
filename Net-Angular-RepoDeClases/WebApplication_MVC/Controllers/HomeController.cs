using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    //Nombre: Algo + Controller ->
    //Algo->Ruta - 1ra Parte
    //Algo->Model
    //Algo->Folder->Views
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Métodos: 2da Parte de la Ruta - NombreDelMétodo -> Vista
        public IActionResult Index()
        {
            //   /Home/Index
            return View();
        }

        public IActionResult Privacy()
        {
            //  /Home/Privacy
            return View();
        }

        public IActionResult MiVista()
        {
            //  /Home/MiVista
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
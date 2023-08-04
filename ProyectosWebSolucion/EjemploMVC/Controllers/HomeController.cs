using EjemploMVC.Models;
using EjemploMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMail _mail;

        public HomeController(ILogger<HomeController> logger, IMail mail)
        {
            _logger = logger;
            _mail = mail;
        }

        public IActionResult Index()
        {
            ViewBag.saludo = "Hola Mundo desde C#";
            ViewBag.aguacate = true;
            ViewBag.sbhdcbhvbd = "lol";
            ViewBag.fecha = DateTime.Today;

            return View();
        }

        public IActionResult Privacy()
        {
            //+ No se usa 'new'
            _logger.LogInformation( _mail.EnviarMail() ); // Imprimir correo por consola(log) en web
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
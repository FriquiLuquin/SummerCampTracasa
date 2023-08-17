using Biblioteca;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploAPIDesdeCero.Controllers
{
    //+ 1-Ruta
    //  [Route("api/[controller]")]
    [Route("api/Monedas")]

    //+ 2-Controlador API
    [ApiController]

    public class MonedasController : ControllerBase //+ 3-Hereda de controlador APIs
    {
        private readonly IRepositorioMonedas repositorioMonedas;

        public MonedasController(IRepositorioMonedas repositorioMonedas)
        {
            this.repositorioMonedas = repositorioMonedas;
        }

        //+ A-Verbo Http
        [HttpGet]

        //+ B-Devuelve ActionResult<tipo> 
        public ActionResult<IEnumerable<Moneda>> ObtenerMonedas()
        {
            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();

            //+ C-Devolver resultado y codigo de estado
            return Ok(lista);
        }

    }
}

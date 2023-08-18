using AutoMapper;
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
        private readonly IMapper mapper;

        public MonedasController(IRepositorioMonedas repositorioMonedas, IMapper mapper)
        {
            this.repositorioMonedas = repositorioMonedas;
            this.mapper = mapper;
        }

        //+ A-Verbo Http
        [HttpGet]

        //+ B-Devuelve ActionResult<tipo> 
        public ActionResult<List<MonedaDto>> ObtenerMonedas()
        {
            List<Moneda> lista = repositorioMonedas.ObtenerMonedas().ToList();

            List <MonedaDto> listaDto = new List<MonedaDto>();
            foreach (var moneda in lista)
            {
                listaDto.Add(mapper.Map<MonedaDto>(moneda));
            }

            //+ C-Devolver resultado y codigo de estado
            //! STATUS = 200
            return Ok(listaDto);
        }

        [HttpGet("{idmoneda}", Name = "ObtenerMoneda")]
        public ActionResult<MonedaDto> ObtenerMoneda([FromRoute] int idmoneda)
        {
            Moneda moneda = repositorioMonedas.ObtenerMoneda(idmoneda);

            if (moneda == null)
            {
                //! STATUS = 404
                return NotFound();
            }

            //! STATUS = 200
            return Ok(mapper.Map<MonedaDto>(moneda));
        }

        [HttpPost]
        public ActionResult<MonedaAltaDto> CrearMoneda([FromBody] MonedaAlta monedaAlta)
        {
            Moneda moneda = mapper.Map<Moneda>(monedaAlta);

            repositorioMonedas.AgregarMoneda(moneda);

            var monedaReturn = mapper.Map<MonedaAltaDto>(moneda);

            //! STATUS = 201
            return CreatedAtRoute("ObtenerMoneda",
                                  new { idmoneda = monedaReturn.Id },
                                  monedaReturn);
        }

    }
}

using AutoMapper;
using DTOs;
using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositorio;

namespace ExamenRuben.Controllers
{
    [Route("api/persona")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IRepositorioBD repodb;
        private readonly IMapper _mapper;

        public PersonaController(IRepositorioBD repodb,IMapper mapper)
        {
            this.repodb = repodb;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<PersonaDTO>>> GetPersona()
        {
            // throw new Exception("Test exception");

            // get authors from repo
            List<Persona> personaFromRepo = await repodb
                .GetPersonaAsync();

            // return them
            //! STATUS = 200
            return Ok(_mapper.Map<List<PersonaDTO>>(personaFromRepo));
        }


        [HttpPost("registro")]
        public async Task<ActionResult> Register([FromBody] PersonaDTO parametros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          
            var UserRepo = _mapper.Map<Persona>(parametros);
           
           
            await repodb.RegistrarPersona(UserRepo);
            return NoContent();
            

            


        }
    }
}

using ApiCandataCUN.Data;
using ApiCandataCUN.Models;
using ApiCandataCUN.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCandataCUN.Controllers
{
    [ApiController]
    [Route("response/GuardarRespuestaBot")]
    public class CandidatoController : ControllerBase
    {

        // Inyectamos la conexion
        // /*
        private readonly ConexionSQLserver _conexionSQLServer;
        public CandidatoController(ConexionSQLserver conexionSQLserver)
        {
            this._conexionSQLServer = conexionSQLserver;
        }
        // */


        [HttpGet]
        public dynamic mostrarCandidato()
        {
            Candidato candidato = new Candidato("12", "Alexis", "Chavarria", "123456789");
            return candidato;
        }

        [HttpPost]
        public IActionResult guardarCandidato()
        {
            return Ok("Hola");
        }

        // /*
        [HttpPost]
        [Route("candidato")]
        public IActionResult crear(Candidato candidato)
        {
            _conexionSQLServer.Pruebas.Add(candidato);
            return Ok();
        }

        [HttpGet]
        [Route("candidato")]
        public async Task<ActionResult<IEnumerable<Candidato>>> listCandidato()
        {
            return await _conexionSQLServer.Pruebas.ToListAsync();
        }
        // */



        // Inyectamos el servicio
        /*
        private readonly ICandidatoService _candidatoService;

        public CandidatoController(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }
        

        [HttpPost]
        [Route("candidato")]
        public IActionResult crearCandidato(Candidato candidato)
        {
            try
            {
                _candidatoService.crearCandidato(candidato);
                return CreatedAtAction(nameof(obtenerCandidatoPorId), new { id = candidato.id }, candidato);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al crear el candidato: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult obtenerCandidatoPorId(string id)
        {
            var candidato = _candidatoService.obtenerCandidatoPorId(id);

            if(candidato == null)
            {
                return NotFound();
            }
            return Ok(candidato);
        }

        [HttpGet]
        [Route("candidatos")]
        public IActionResult obtenerCandidatos()
        {
            var candidatos = _candidatoService.obtenerCandidatos();
            return Ok(candidatos);

        }
        */


    }
}

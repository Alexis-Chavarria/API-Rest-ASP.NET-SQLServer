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

        // Inyectamos el servicio, encargado de comunicarse con la capa de persistencia de datos.        
        private readonly ICandidatoService _candidatoService;

        public CandidatoController(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }
        

        [HttpPost]
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
        


    }
}

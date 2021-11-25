using AlertasTempranas.Logica.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AlertasTempranas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly IEstudianteNegocio estudianteNegocio;

        public EstudiantesController(IEstudianteNegocio estudianteNegocio)
        {
            this.estudianteNegocio = estudianteNegocio;
        }

        [HttpGet("{id}")]
        public IActionResult GetDetalleEstudiante(string id)
        {
            var estudiante = estudianteNegocio.GetEstudianteById(id);
            return Ok(estudiante);
        }
    }
}

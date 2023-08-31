using Microsoft.AspNetCore.Mvc;
using ApiEstudiantes.Models;
using ApiEstudiantes.Data;


namespace ApiEstudiantes.Controllers
{
    [ApiController]
    [Route("api/estudiantes")]
    public class estudiantesController : ControllerBase
    {
        [HttpGet(Name = "GetEstudiantes")]
        public async Task<ActionResult<List<Estudiante>>> Get()
        {
            var estudiantes = new Estudiantes();
            var listaEstudiantes = await estudiantes.MostrarEstudiantes();
            return listaEstudiantes;
        }

        [HttpPost(Name ="pOSTEstudiantes")]
        public async Task<ActionResult<Estudiante>> Post([FromBody] Estudiante estudiante)
        {
            var estudiantes = new Estudiantes();
            estudiantes.InsertarEstudiantes(estudiante);
            return estudiante;
        }
    }
}
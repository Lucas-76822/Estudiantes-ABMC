using System.Runtime.CompilerServices;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using ApiEstudiantes.Models;
using ApiEstudiantes.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Routing;
using System.ComponentModel;


namespace ApiEstudiantes.Controllers
{
    [ApiController]
    [Route("api/estudiantes")]
    public class estudiantesController : ControllerBase
    {
        //Variable de la clase
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();

        //Constructor de la clase
        public estudiantesController()
        {
            cargarLista();
        }

        //Agrega elemetos a listaEstudiantes
        private void cargarLista(){
            Estudiantes estudiantes = new Estudiantes();
            this.listaEstudiantes = estudiantes.MostrarEstudiantes();
         }
        


        [HttpGet(Name = "GetEstudiantes")]
        public ActionResult<List<Estudiante>> Get()
        {
            return this.listaEstudiantes;
        }

        [HttpPost(Name ="POSTEstudiantes")]
        public ActionResult<List<Estudiante>> Post([FromBody] Estudiante estudiante)
        {
            this.listaEstudiantes.Add(estudiante);
            return this.listaEstudiantes;
        }

        [HttpGet("{id}", Name = "GetEstudianteID")]
        public ActionResult<Estudiante> GetEstudiante(int id){
            var estudiante = this.listaEstudiantes.FirstOrDefault(e => e.id == id);
            return estudiante;
        }

        [HttpPut("{id}", Name ="PutEstudiante")]
        public ActionResult<List<Estudiante>> PutEstudiante(int id, [FromBody] Estudiante estudiante){
            foreach(Estudiante e in this.listaEstudiantes)
            {
                if (e.id == id)
                {
                    e.name = estudiante.name;
                    e.surName = estudiante.surName;
                    e.birthdayDate = estudiante.birthdayDate;
                    e.mail = estudiante.mail;
                }
            }
            return this.listaEstudiantes;
        }

        [HttpDelete("{id}", Name = "DelteEstudiante")]
        public ActionResult<List<Estudiante>> DeleteEstudiante(int id, [FromBody] Estudiante estudiante){
            this.listaEstudiantes.Remove(this.listaEstudiantes.Single (e => e.id == estudiante.id));
            return this.listaEstudiantes;
        }

        
        
    }
}
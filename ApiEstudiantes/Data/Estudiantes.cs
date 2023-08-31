using ApiEstudiantes.Models;

namespace ApiEstudiantes.Data
{
    public class Estudiantes
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        public async Task<List<Estudiante>> MostrarEstudiantes()
        {
            var estudiante1 = new Estudiante();
            estudiante1.id = 1;
            estudiante1.name = "Pedro";
            estudiante1.surName = "Lopez";
            estudiante1.birthdayDate = "12/12/2012";
            estudiante1.mail = "pedro@gmail.com";
            this.estudiantes.Add(estudiante1);

            var estudiante2 = new Estudiante();
            estudiante2.id = 2;
            estudiante2.name = "Ana";
            estudiante2.surName = "Rodirguez";
            estudiante2.birthdayDate = "25/06/2001";
            estudiante2.mail = "ana@gmail.com";
            this.estudiantes.Add(estudiante2);

            var estudiante3 = new Estudiante();
            estudiante3.id = 3;
            estudiante3.name = "Juan";
            estudiante3.surName = "Fernandez";
            estudiante3.birthdayDate = "02/03/2000";
            estudiante3.mail = "juan@gmail.com";
            this.estudiantes.Add(estudiante3);

            var estudiante4 = new Estudiante();
            estudiante4.id = 4;
            estudiante4.name = "Andres";
            estudiante4.surName = "Torres";
            estudiante4.birthdayDate = "02/09/1999";
            estudiante4.mail = "torres@gmail.com";
            this.estudiantes.Add(estudiante4);

            var estudiante5 = new Estudiante();
            estudiante5.id = 5;
            estudiante5.name = "Sofia";
            estudiante5.surName = "Rodriguez";
            estudiante5.birthdayDate = "27/10/2002";
            estudiante5.mail = "sofia@gmail.com";
            this.estudiantes.Add(estudiante5);

            return estudiantes;
        }

        public async Task InsertarEstudiantes(Estudiante estudianteInsert)
        {
            var estudiante = new Estudiante();
            estudiante.id = estudianteInsert.id;
            estudiante.birthdayDate = estudianteInsert.birthdayDate;
            estudiante.name = estudianteInsert.name;
            estudiante.surName = estudianteInsert.surName;
            estudiante.mail = estudianteInsert.mail;
            this.estudiantes.Add(estudiante);
            
        }

    }
}
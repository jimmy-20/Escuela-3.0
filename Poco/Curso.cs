using System.Collections.Generic;

namespace CoreEscuela.Poco
{
    public class Curso:DatosBase
    {
        public string Horario { get; set; }
        public List <Estudiante> Estudiantes { get; set; }
        
    }
}
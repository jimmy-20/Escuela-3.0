using System.Collections.Generic;

namespace CoreEscuela.Poco
{
    public class Estudiante:Persona
    {
        public string IdEstudiante { get; set; }

        public Estudiante() => IdEstudiante = System.Guid.NewGuid().ToString();     
        public List <Evaluacion> Evaluaciones { get; set; }   
    }
}
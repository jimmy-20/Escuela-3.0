
namespace CoreEscuela.Poco
{
    public class Estudiante:Persona
    {
        public string IdEstudiante { get; set; }

        public Estudiante() => IdEstudiante = System.Guid.NewGuid().ToString();        
    }
}
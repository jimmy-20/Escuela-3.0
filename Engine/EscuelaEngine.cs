using CoreEscuela.Poco;
namespace CoreEscuela.Engine
{
    public class EscuelaEngine
    {
        private Escuela Escuela { get; set; }
        public EscuelaEngine(string nombre, string direccion, string telefono, string correo) {
            this.Escuela = new Escuela{
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono,
                Correo = correo
            };
        }
        
    }
}
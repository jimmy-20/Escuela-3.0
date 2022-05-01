using CoreEscuela.Poco;
namespace CoreEscuela.Engine
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; private set; }
        public EscuelaEngine(string nombre, string direccion, string telefono, string correo) {
            this.Escuela = new Escuela{
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono,
                Correo = correo
            };
        }
        
        #region CargarEscuela
        private void CargarCursos(){

        }

        private void CargarAsignaturas(){

        }

        private void CargarProfesores(){

        }

        private void CargarEstudiantes(){

        }

        private void CargarEvalauciones(){

        }
        #endregion
    }
}
namespace CoreEscuela.Poco
{
    public class Escuela : DatosBase
    {
        public string Direccion { get; set; }
        public string  Telefono { get; set; }
        public string Correo { get; set; }

        public override string  ToString(){
            return $"Nombre: {Nombre}, Direccion: {Direccion}, Telefono: {Telefono}, Correo: {Correo}";
        }
    }
}
using static System.Console;
using CoreEscuela.Engine;
using CoreEscuela.Util;

namespace CoreEscuela
{
    public class Program
    {
        static void Main(){
            bool flag = true;
            int opcion = 0;
            EscuelaEngine esEngine = new EscuelaEngine("Soberana","Praderas de Sandino","78029756","soberana@gmail.com");
            WriteLine("Hola mundo");

            Printer.WriteTitle(esEngine.Escuela.Nombre);
            WriteLine($"Direccion: {esEngine.Escuela.Direccion}");
            WriteLine($"Telefono: {esEngine.Escuela.Telefono}");
            
            do
            {
                Printer.Menu();
                Write("Ingrese una opcion: ");
                try
                {
                    opcion = int.Parse(ReadLine());    
        //        }
         //       catch (System.ArgumentException ar)
           //     {
             //       Printer.WriteTitle($"NameExcepction: {ar.Message}, el argumento debe ser un entero");
                  }catch(System.FormatException an)
                {
                    Printer.WriteTitle($"NameException: {an.Message}, debe contener un valor {nameof(an)}");
                }
                
            } while (flag);
        }


    }    
}
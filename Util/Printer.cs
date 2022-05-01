using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void WriteTitle(string cad,int opcion=1){
            switch (opcion)
            {
                case 1:
                WriteLine($"| {cad} |");
                break;
                
                case 2:
                WriteLine($"----- {cad} -----");
                break;

                case 3:
                WriteLine("===============");
                WriteLine(cad);
                WriteLine("===============");
                break;

                default:
                break;
            }
        }

        public static void Menu(){
            WriteTitle("MENU");
            WriteLine("1.Ver cursos ");
            WriteLine("2.Ver Asignaturas ");
            WriteLine("3.Ver Profesores ");
            WriteLine("4.Ver Alumnos ");
            WriteLine("5.Ver Evaluaciones ");
        }
    }
}
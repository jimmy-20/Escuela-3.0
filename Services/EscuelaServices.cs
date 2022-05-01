using System;
using CoreEscuela.Engine;

namespace CoreEscuela.Services
{
    public class EscuelaServices
    {
        private EscuelaEngine Se;
        public EscuelaServices(EscuelaEngine se) {
            if ( (se is null) || (se.Escuela is null) ){
                throw new NullReferenceException(nameof(se) + " es NULL o la escuela no ha inicializado");
            }

            this.Se = se;
        }

        public void Opc1(){

        }


        public void Opc2(){
            
        }

        public void Opc3(){
            
        }

        public void Opc4(){
            
        }

        public void Opc5(){
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatosBaldovino
{
    public class clsNodos
    {
        //Declarar los campos a utilizar

        private String nom;
        private String tra;
        private Int32 cod;
        private clsNodos sig;
        private clsNodos ant;

        //Crear y declarar propiedades para poder utilizar los datos en otro lado(Interfaz)

        public Int32 Codigo
        {
            //Si alguien quiere usar la propiedad le muestra lo que tiene la variable codigo
            get { return cod; }
            //si alguien quiere modificar la propiedad le modifica el valor y lo guarda
            set { cod = value; }

        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public clsNodos Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodos Anterior
        {
            get { return ant; }
            set { ant = value; }
        }



    }
}

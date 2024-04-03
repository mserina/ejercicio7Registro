using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7Resgistro.servicios
{
    internal interface MenuInterfaz
    {

        public int menuArchivosMostrar();

        public int opcionSeleccionada();

        public void menuArchivoLogica(string archivo, string[] lineas);

    }
}

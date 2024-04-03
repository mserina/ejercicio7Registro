using ejercicio7Resgistro.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7Resgistro
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int opcionSeleccionada()
        {
            int opcionRespuesta = 0;

            Console.WriteLine(" ");
            Console.WriteLine("#############");
            Console.WriteLine("0. Cerrar");
            Console.WriteLine("1. Modificar Linea");
            Console.WriteLine("2. Insertar texto en un posicion especifica");
            Console.WriteLine("3. Ver contenido archivo");
            Console.WriteLine("4. Guardar");
            Console.WriteLine(" ");

            opcionRespuesta = Convert.ToInt32(Console.ReadLine());
            return opcionRespuesta;
        }

        public int menuArchivosMostrar()
        {
            int opcionRespuesta = 0;

            Console.WriteLine(" ");
            Console.WriteLine("#############");
            Console.WriteLine("0. Cerrar");
            Console.WriteLine("1. Archivo 1");
            Console.WriteLine("2. Archivo 2");
            Console.WriteLine("3. Archivo 3");
            Console.WriteLine(" ");

            opcionRespuesta = Convert.ToInt32(Console.ReadLine());
            return opcionRespuesta;
        }

        public void menuArchivoLogica(string archivo, string[] lineas)
        {
            OperacionInterfaz op = new OperacionImplementacion(); 
            int opcionSeleccionada2 = 0;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {

                opcionSeleccionada2 = opcionSeleccionada();
                    switch (opcionSeleccionada2)
                    {
                        case 0:
                            cerrarMenu = true;
                            break;
                        case 1:

                            //METEMOS EL RESULTADO (EL MISMO ARRA STRING PERO CON MODIFICACIONES) PARA SOBREESCRIBIR EL STRING ARRAY ORIGINAL
                            lineas = op.modificarLineaEspecifica(archivo, lineas);
                            break;
                        case 2:
                            lineas = op.modificarPosicion(archivo, lineas);
                            break;
                        case 3:
                            op.verArchivo(archivo);
                            break;
                        case 4:
                            op.guardarArchivo(archivo, lineas);
                            break;
                    }
            }
        }
    }
}

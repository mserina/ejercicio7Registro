
using ejercicio7Resgistro.servicios;

namespace ejercicio7Resgistro
{
    class Program
    {

        public static void Main(string[] args)
        {



            string rutaArchivo = "C:\\Users\\csi23-mserina\\Desktop\\REGISTRO_VC 1.txt";
            string rutaArchivo2 = "C:\\Users\\csi23-mserina\\Desktop\\REGISTRO_VC 2.txt";
            string rutaArchivo3 = "C:\\Users\\csi23-mserina\\Desktop\\REGISTRO_VC 3.txt";

            //ERROR 1:C --> NO COGE LA LINEA NUEVA POR LA QUE LA QUIERO CAMBIAR
            string[] lineas = File.ReadAllLines(rutaArchivo);

            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();
            int opcionSeleccionada = 0;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {

                opcionSeleccionada = mi.menuArchivosMostrar();
                try
                {
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            cerrarMenu = true;
                            break;
                        case 1:
                            mi.menuArchivoLogica(rutaArchivo, lineas);
                            //METEMOS EL RESULTADO (EL MISMO ARRA STRING PERO CON MODIFICACIONES) PARA SOBREESCRIBIR EL STRING ARRAY ORIGINAL
                            
                            break;
                        case 2:
                            mi.menuArchivoLogica(rutaArchivo2, lineas);
                            break;
                        case 3:
                            mi.menuArchivoLogica(rutaArchivo3, lineas);
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("EL FICHERO NO SE ENCUENTRA DISPONIBLE");
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }

}
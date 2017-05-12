using ocpp_server_modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocpp_server_control
{
    public static class ControlSimulacion
    {
        public static Respuesta Vehiculos(int Cantidad)
        {
            Respuesta r = new Respuesta("ControlSimulacion.Vehiculos");

            try
            {
                Dictionary<int, string> ListaMarcas = CargarArchivo(@"C:\Simulacion\Marcas.txt");
                Dictionary<int, string> ListaNombres = CargarArchivo(@"C:\Simulacion\Nombres.txt");
                Dictionary<int, string> ListaApellidos = CargarArchivo(@"C:\Simulacion\Apellidos.txt");

                int Contador = 0;
                string Placa;
                string Tag;
                string Marca;
                string Modelo;
                string Propietario;
                Random rm = new Random(DateTime.Now.Millisecond);
                Respuesta res;

                while(true)
                {
                    Placa = PlacaAleatoria(rm);
                    Tag = TagAleatorio(rm);
                    Marca = ListaMarcas[rm.Next(1, ListaMarcas.Count)];
                    Modelo = rm.Next(1990, 2017).ToString();

                    Propietario = ListaNombres[rm.Next(1, ListaNombres.Count)] + " ";
                    Propietario += ListaApellidos[rm.Next(1,ListaApellidos.Count)];

                    res = ControlVehiculo.Agregar(Placa, Tag, Marca, Modelo, Propietario);

                    if (res.Estado == true)
                        Contador++;

                    if (Contador == Cantidad)
                        break;
                }

                //Servidor.getInstancia().ColeccionPuntoCarga.Eliminar(p);
                r.Mensaje += "Se finalizo la creacion de Vehiculos";
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);
            }

            return r;
        }

        private static Dictionary<int,string> CargarArchivo(string RutaArchivo)
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();

            if (!File.Exists(RutaArchivo))
                throw new Exception("Archivo no existe");

            StreamReader ArchivoTexto = new StreamReader(RutaArchivo);
            int Contador = 1;
            string Linea;

            while ((Linea = ArchivoTexto.ReadLine()) != null)
            {
                if (Linea.Trim().Length > 0)
                {
                    Lista.Add(Contador, Linea);
                    Contador++;
                }
            }

            ArchivoTexto.Close();

            return Lista;
        }

        private static string PlacaAleatoria(Random r)
        {
            string Caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Numeros = "0123456789";
            string Respuesta = "";
            int x;

            for(x=1;x<=3;x++)
            {
                Respuesta += Caracteres[r.Next(0,Caracteres.Length-1)];
            }

            for (x=1;x<=3;x++)
            {
                Respuesta += Numeros[r.Next(0, Numeros.Length - 1)];
            }

            return Respuesta;
        }

        private static string TagAleatorio(Random r)
        {
            string Caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string Respuesta = "";

            for (int x = 1; x <= 20; x++)
            {
                Respuesta += Caracteres[r.Next(0, Caracteres.Length - 1)];
            }

            return Respuesta;
        }
    }
}

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

            Dictionary<int, string> ListaMarcas;
            Dictionary<int, string> ListaNombres;
            Dictionary<int, string> ListaApellidos;

            try
            {
                ListaMarcas = CargarArchivo(@"C:\Simulacion\Marcas.txt");
                ListaNombres = CargarArchivo(@"C:\Simulacion\Nombres.txt");
                ListaApellidos = CargarArchivo(@"C:\Simulacion\Apellidos.txt");

                int Contador = 0;
                string Placa = "";
                string Tag = "";
                string Marca = "";
                string Modelo = "";
                string Propietario = "";
                Random rm = new Random(DateTime.Now.Millisecond);
                Respuesta res;
                Vehiculo v;

                while(true)
                {
                    if (Contador % 2 == 0)
                    {
                        Placa = PlacaAleatoria(rm);
                        Tag = TagAleatorio(rm);
                        Marca = ListaMarcas[rm.Next(1, ListaMarcas.Count)];
                        Modelo = rm.Next(1990, 2017).ToString();

                        Propietario = ListaNombres[rm.Next(1, ListaNombres.Count)] + " ";
                        Propietario += ListaApellidos[rm.Next(1, ListaApellidos.Count)];

                        Propietario = ListaNombres[rm.Next(1, ListaNombres.Count)] + " ";
                        Propietario += ListaApellidos[rm.Next(1, ListaApellidos.Count)];

                        res = ControlVehiculo.Agregar(Placa, Tag, Marca, Modelo, Propietario);
                    }
                    else
                    {
                        v = Servidor.getInstancia().ColeccionVehiculo.Aleatorio();

                        v.Placa = PlacaAleatoria(rm);
                        v.Tag = TagAleatorio(rm);
                        v.Marca = ListaMarcas[rm.Next(1, ListaMarcas.Count)];
                        v.Modelo = rm.Next(1990, 2017).ToString();
                        v.Propietario = ListaNombres[rm.Next(1, ListaNombres.Count)] +" ";
                        Propietario += ListaApellidos[rm.Next(1, ListaApellidos.Count)];

                        res = ControlVehiculo.Agregar(v);
                    }

                    if (res.Estado == true)
                        Contador++;

                    if (Contador == Cantidad)
                        break;
                }

                r.Mensaje += "Se realizo la simulacion de " + Cantidad + " Vehiculos";
            }
            catch (Exception ex)
            {
                r.Estado = false;
                r.Mensaje += ex.Message;
            }
            finally
            {
                ControlLog.Registrar(r);

                ListaMarcas = null; 
                ListaNombres = null;
                ListaApellidos = null;

                GC.Collect();
            }

            return r;
        }

        public static Respuesta Estacion(int CantidadEstacion, int CantidadPuntosCarga)
        {
            Respuesta r = new Respuesta("ControlSimulacion.Estacion");

            Dictionary<int, string> ListaEstaciones;
            Dictionary<int, string> ListaMarcas;

            try
            {
                Random rm = new Random(DateTime.Now.Millisecond);
                ListaEstaciones = CargarArchivo(@"C:\Simulacion\Estaciones.txt");
                ListaMarcas = CargarArchivo(@"C:\Simulacion\MarcasPuntoCarga.txt");

                int IdEstacion = 0;
                int IdPuntoCarga = 0;
                string Nombre = "";
                string Direccion = "";
                string Ubicacion = "";
                int Contador = 0;

                Respuesta res1;
                Estacion e;

                while(true)
                {
                    IdEstacion++;

                    if(Contador % 2 == 0)
                    {
                        Nombre = ListaEstaciones[rm.Next(0, ListaEstaciones.Count - 1)];
                        Direccion = DireccionAleatoria(rm);
                        Ubicacion = PosicionAleatoria(rm);

                        res1 = ControlEstacion.Agregar(IdEstacion.ToString(), Nombre, Direccion, Ubicacion);
                    }
                    else
                    {
                        e = Servidor.getInstancia().ColeccionEstacion.Aleatorio();

                        e.Id = IdEstacion;
                        e.Nombre = ListaEstaciones[rm.Next(0, ListaEstaciones.Count - 1)];
                        e.Direccion = DireccionAleatoria(rm);
                        e.Ubicacion = PosicionAleatoria(rm);

                        res1 = ControlEstacion.Agregar(e);
                    }

                    if (res1.Estado == true)
                    {
                        Contador++;

                        e = Servidor.getInstancia().ColeccionEstacion.BuscarPorId(IdEstacion);

                        res1 = PuntoCarga(ListaMarcas, e, CantidadPuntosCarga, IdPuntoCarga, rm);

                        IdPuntoCarga = (int)res1.Anexo;
                    }

                    if (Contador == CantidadEstacion)
                        break;
                }

                r.Mensaje += "Se realizo la simulacion de " + CantidadEstacion + " Estaciones";
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


        private static Respuesta PuntoCarga(Dictionary<int,string> ListaMarcas,Estacion e, int Cantidad, int pId, Random ram)
        {
            Respuesta r = new Respuesta("ControlSimulacion.PuntoCarga");

            try
            {
                int Id = pId;
                string NumeroSerie = "";
                string Marca = "";
                string Modelo = "";
                int Contador = 0;

                Respuesta res;

                PuntoCarga pc = new PuntoCarga();

                while (true)
                {
                    NumeroSerie = NumeroSerieAleatorio(ram);
                    Marca = ListaMarcas[ram.Next(0, ListaMarcas.Count - 1)];
                    Modelo = ram.Next(1990, 2016).ToString();

                    res = ControlPuntoCarga.Agregar(Id.ToString(), NumeroSerie, Marca, Modelo);

                    if (res.Estado == true)
                    {
                        Contador++;

                        pc = Servidor.getInstancia().ColeccionPuntoCarga.BuscarPorId(Id);

                        e.ColeccionPuntoCarga.Agregar(pc);
                    }

                    Id++;

                    if (Contador == Cantidad)
                        break;
                }

                r.Mensaje += "Se realizo la simulacion de " + Cantidad + " Estaciones";
                r.Anexo = Id + 1;
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

        private static string NumeroSerieAleatorio(Random r)
        {
            string Caracteres = "AEIOU0123456789-/*|#";
            string Respuesta = "";

            for (int x = 1; x <= 15; x++)
            {
                Respuesta += Caracteres[r.Next(0, Caracteres.Length - 1)];
            }

            return Respuesta;
        }

        private static string PosicionAleatoria(Random r)
        {
            string Grados = r.Next(-90,90).ToString();
            string Minutos = r.Next(0, 60).ToString();
            string Segundos = r.Next(0, 60).ToString();

            return Grados + "° " + Minutos + "' " + Segundos + "''";
        }

        private static string DireccionAleatoria(Random r)
        {
            string[] Notaciones = {"CALLE","CL", "CARRERA", "CR", "CRA", "AV" ,"DIAGONAL", "TRANVERSAL", "TRONCAL"};
            string Respuesta = ""; 

            for (int x = 1; x <= 3; x++)
            {
                switch(x)
                {
                    case 1:
                        Respuesta += Notaciones[r.Next(0,Notaciones.Length-1)] + " ";
                        break;
                    case 2:
                        Respuesta += r.Next(1, 100);
                        break;
                    case 3:
                        Respuesta += " NO " + r.Next(1, 200) + "-" + r.Next(1, 200); 
                        break;
                }
            }

            return Respuesta;
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

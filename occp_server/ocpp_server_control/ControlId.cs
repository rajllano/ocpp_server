using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocpp_server_control
{
    public static class ControlId
    {
        private static Dictionary<string, int> ListaId = null;

        private static Dictionary<string, int> getListaId()
        {
            if (ListaId == null)
                ListaId = new Dictionary<string, int>();

            return ListaId;
        }

        public static int Estacion()
        {
            Dictionary<string, int> Lista = getListaId();
            string Llave = "Estacion";

            if (!Lista.ContainsKey(Llave))
                ListaId.Add(Llave, 0);

            return Lista[Llave] += 1;
        }

        public static int PuntoCarga()
        {
            Dictionary<string, int> Lista = getListaId();
            string Llave = "PuntoCarga";

            if (!Lista.ContainsKey(Llave))
                ListaId.Add(Llave, 0);

            return Lista[Llave] += 1;
        }

        public static int Reserva()
        {
            Dictionary<string, int> Lista = getListaId();
            string Llave = "Reserva";

            if (!Lista.ContainsKey(Llave))
                ListaId.Add(Llave, 0);

            return Lista[Llave] += 1;
        }
    }
}

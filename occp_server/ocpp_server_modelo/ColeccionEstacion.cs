using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionEstacion : Coleccion<Estacion>, IIterable
    {
        public Estacion Aleatorio()
        {
            Estacion e = null;
            IteradorColeccionEstacion i = (IteradorColeccionEstacion)Iterador();

            while (i.tieneSiguiente())
            {
                e = i.Siguiente();

                if (e != null)
                    return e;
            }

            e = new Estacion();

            return e;
        }

        public Estacion BuscarPorId(int Id)
        {
            Estacion e = null;
            IteradorColeccionEstacion i = (IteradorColeccionEstacion)Iterador();

            while(i.tieneSiguiente())
            {
                e = i.Siguiente();

                if (e.Id == Id)
                    return e;
            }

            return null;
        }

        public object Iterador()
        {
            return new IteradorColeccionEstacion(this);
        }
    }
}
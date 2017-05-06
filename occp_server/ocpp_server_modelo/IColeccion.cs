using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public interface IColeccion<T>
    {
        void Agregar(T Elemento);
        void Eliminar(T Elemento);
        T Elemento(int Indice);
    }
}
/**
 * Clase: IIterador.cs
 * Objetivo: Interfaz para la definición de metodos de IIteración.
 * Fecha modificación: Mayo de 2017
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public interface IIterador<T>
    {
        T Siguiente();

        bool tieneSiguiente();
    }
}
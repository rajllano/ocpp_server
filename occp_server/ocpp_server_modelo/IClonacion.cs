/**
 * Clase: IClonacion.cs
 * Objetivo: Interfaz para la definición de metodos de clonación.
 * Fecha modificación: Mayo de 2017
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public interface IClonacion<T>
    {
        T Clonar();
    }
}
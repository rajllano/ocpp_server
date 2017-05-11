/**
 * Clase: IClonacion.cs
 * Objetivo: Interfaz para la definición de metodos de iteración.
 * Fecha modificación: Mayo de 2017
 **/
using ocpp_server_modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public interface IIterable
    {
        Object Iterador();
    }
}
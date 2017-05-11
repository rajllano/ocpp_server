/**
 * Clase: Coleccion.cs
 * Objetivo: Clase con la definición de colección y la gestión de la misma.
 * Fecha modificación: Mayo de 2017
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Coleccion<T>
    {
        private List<T> Lista;

        public Coleccion()
        {
            this.Lista = new List<T>();
        }

        ~Coleccion()
        {
            this.Lista = null;

            GC.Collect();
        }

        public void Agregar(T Elemento)
        {
            if (!this.Lista.Contains(Elemento))
                this.Lista.Add(Elemento);
        }

        public void Eliminar(T Elemento)
        {
            if (this.Lista.Contains(Elemento))
                this.Lista.Remove(Elemento);
        }

        public T Elemento(int Indice)
        {
            return this.Lista[Indice];
        }

        public int Tamano()
        {
            return this.Lista.Count;
        }
    }
}
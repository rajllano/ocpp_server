using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class Coleccion : ISujeto
    {
        private List<Object> Lista;
        private Coleccion ListaSuscriptores;

        public Coleccion()
        {
            Lista = new List<object>();
            ListaSuscriptores = new ocpp_server_modelo.Coleccion();
        }

        ~Coleccion()
        {
            Lista = null;
            ListaSuscriptores = null;

            GC.Collect();
        }

        public void Agregar(Object o)
        {
            Lista.Add(o);
        }

        public void Eliminar(Object o)
        {
            Lista.Remove(o);
        }

        public Object Elemento(int Indice)
        {
            return Lista[Indice];
        }

        public int Tamano()
        {
            return Lista.Count;
        }

        public IteradorColeccion Iterador()
        {
            return new IteradorColeccion(this.Lista);
        }

        public void RegistrarObservador(IObservador o)
        {
            this.ListaSuscriptores.Agregar(o);
        }

        public void EliminarObservador(IObservador o)
        {
            this.ListaSuscriptores.Eliminar(o);
        }

        public void NotificarObservador()
        {
            IteradorColeccion i = this.ListaSuscriptores.Iterador();

            IObservador o;

            while(i.tieneSiguiente())
            {
                o = (IObservador)i.Siguiente();
                o.Actualizar("me actualice");
            }
        }
    }
}
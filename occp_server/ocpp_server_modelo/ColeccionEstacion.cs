using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ocpp_server_modelo
{
    public class ColeccionEstacion : Coleccion<Estacion>, IColeccionGenerica<Estacion>
    {
        private List<IObservador> Suscriptores = null;

        public ColeccionEstacion()
        {
            this.Suscriptores = new List<IObservador>();
        }

        ~ColeccionEstacion()
        {
            this.Suscriptores = null;

            GC.Collect();
        }

        public void Agregar(Estacion Elemento)
        {
            if(!this.Lista.Contains(Elemento))
                this.Lista.Add(Elemento);
        }

        public Estacion Elemento(int Indice)
        {
            return this.Lista[Indice];
        }

        public void Eliminar(Estacion Elemento)
        {
            if (this.Lista.Contains(Elemento))
                this.Lista.Remove(Elemento);
        }

        public void EliminarObservador(IObservador o)
        {
            if(this.Suscriptores.Contains(o))
                this.Suscriptores.Remove(o);
        }

        public Object Iterador()
        {
            throw new NotImplementedException();
        }

        public void NotificarObservador()
        {
            foreach(IObservador o in this.Suscriptores)
            {
                o.Actualizar(this);
            }
        }

        public void RegistrarObservador(IObservador o)
        {
            if(!this.Suscriptores.Contains(o))
                this.Suscriptores.Add(o);
        }
    }
}
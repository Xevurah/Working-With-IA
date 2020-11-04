using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPOO
{
    class Persona
    {
        protected String Nombre;
        protected int Edad;
        protected bool EsMasculino;
        public Persona siguiente = null;

        public Persona(string Nombre, int Edad, bool EsMasculino)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.EsMasculino = EsMasculino;
        }

        public string GetDatos()
        {
            string datos = "";

            datos += Nombre;
            datos += Edad;
            datos += EsMasculino ? "Hombre" : "Mujer";

            return datos;
        }
    }
}

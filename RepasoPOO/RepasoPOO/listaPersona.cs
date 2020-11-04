using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPOO
{
    class listaPersona
    {
        Persona Raiz = null;//persona inicial
        public void AgregarPersona(Persona persona_nueva)
        {
            if (Raiz == null)
            {
                Raiz = persona_nueva;
            }
            else
            {
                Persona auxiliar = Raiz;
                while (auxiliar.siguiente != null)
                {
                    auxiliar = auxiliar.siguiente;
                }
                auxiliar.siguiente = persona_nueva;
            }
        }

        public string GetDatos()
        {
            String datos = "";
            if (Raiz == null)
            {
                datos = "No se encontraron datos";
            }
            else
            {
                Persona auxiliar = Raiz;
                
                while (auxiliar.siguiente != null)
                {

                    auxiliar = auxiliar.siguiente;
                    //datos += Raiz.GetDatos();
                    //datos += Raiz.siguiente.GetDatos();
                    //datos += Raiz.siguiente.siguiente.GetDatos();
                }
                datos += auxiliar.GetDatos();
            }
            return datos;
        }
        public void InsertarPersona(Persona persona_a_insertar, int posicion_de_insercion) {

        }
    }
}

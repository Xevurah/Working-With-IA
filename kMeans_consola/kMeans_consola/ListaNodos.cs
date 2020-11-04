using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kMeans_consola
{
    class ListaNodos
    {
        Nodos Raiz = null;
        public int contador = 0;
        public void AgregarNodo(Nodos NuevoNodo)
        {
            contador++;
            if (Raiz == null)
            {
                Raiz = NuevoNodo;
            }
            else
            {
                Nodos auxiliar = Raiz;
                while (auxiliar.siguiente != null)
                {
                    auxiliar = auxiliar.siguiente;
                }
                auxiliar.siguiente = NuevoNodo;
            }
        }
        public double[] DameCordenadas(int NumNodo)
        {
            Nodos auxiliar = Raiz;
            int contador = 1;
            while(contador<NumNodo)
            {
                auxiliar = auxiliar.siguiente;
                contador++;
            }
            double[] cordenadas = auxiliar.RegresaCordenadas();
            return cordenadas;
        }
    }
}

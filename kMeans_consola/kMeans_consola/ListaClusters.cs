using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kMeans_consola
{
    class ListaClusters
    {
        Cluster Raiz = null;
        public int contador = 0;
        public void AgregarCluster(Cluster NuevoCluster)
        {
            contador++;
            if (Raiz == null)
            {
                Raiz = NuevoCluster;
            }
            else
            {
                Cluster auxiliar = Raiz;
                while (auxiliar.siguiente != null)
                {
                    auxiliar = auxiliar.siguiente;
                }
                auxiliar.siguiente = NuevoCluster;
            } 
        }
        public double[] DameCordenadas(int NumNodo)
        {
            Cluster auxiliar = Raiz;
            int contador = 1;
            while (contador < NumNodo)
            {
                auxiliar = auxiliar.siguiente;
                contador++;
            }
            double[] cordenadas = auxiliar.RegresaCordenadas();
            return cordenadas;
        }
    }
}

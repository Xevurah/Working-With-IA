using System;
using System.Collections.Generic;
using System.Text;

namespace Kmeans_Iris
{
    class Cluster
    {
        public String nombre;
        ///el centroide es aleatorio
        public List<double> centroide = new List<double>();
        public List<Elemento> elementos = new List<Elemento>();
        public List<Elemento> elementosAnteriores = new List<Elemento>();

        public Cluster(string nombre, List<double> centroide, List<Elemento> elementos, List<Elemento> elementosAnteriores)
        {
            this.nombre = nombre;
            this.centroide = centroide;
            this.elementos = elementos;
            this.elementosAnteriores = elementosAnteriores;
        }

        public void NuevoCentroide()
        {

        }
    }
}

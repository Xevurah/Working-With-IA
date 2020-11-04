using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kMeans_consola
{
    class Cluster
    {
        private String Nombre;
        private double x, y;
        public Cluster siguiente = null;
        public Cluster(String Nombre, int x, int y)
        {
            this.Nombre = Nombre;
            this.x = x;
            this.y = y;
        }
        public double[] GetCluster()
        {
            double[] cluster = new double[2];
            cluster[0] = x;
            cluster[1] = y;
            return cluster;
        }
        public double[] RegresaCordenadas()
        {
            double[] cordenada = new double[2];
            cordenada[0] = x;
            cordenada[1] = y;
            return cordenada;
        }

    }
}

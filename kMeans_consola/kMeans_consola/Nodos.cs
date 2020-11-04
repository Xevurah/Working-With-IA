using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kMeans_consola
{
    class Nodos
    {
        private String Nombre;
        private double x, y;
        public Nodos siguiente = null;
        public Nodos(String Nombre, int x, int y)
        {
            this.Nombre = Nombre;
            this.x = x;
            this.y = y;
        }
        public double[] GetNodo()
        {
            double[] nodo = new double[2];
            nodo[0] = x;
            nodo[1] = y;
            return nodo;
        }
        public double[] RegresaCordenadas()
        {
            double[] cordenada = new double[2];
            cordenada[0]= x;
            cordenada[1] = y;
            return cordenada;
        }
    }
}

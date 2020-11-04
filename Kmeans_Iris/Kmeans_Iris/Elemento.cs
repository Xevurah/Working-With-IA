using System;
using System.Collections.Generic;
using System.Text;
//Coordenadas
namespace Kmeans_Iris
{
    class Elemento
    {
        public String nombre;
        public List<double> coordenadas = new List<double>();
        public List<double> distanciaRCluster = new List<double>();

       
        public Elemento()
        {
        }

        public Elemento(string nombre, List<double> coordenadas, List<double> distanciaRCluster)
        {
            this.nombre = nombre;
            this.coordenadas = coordenadas;
            this.distanciaRCluster = distanciaRCluster;
        }
    }
}

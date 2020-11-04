using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Kmeans_Iris
{
    class Program
    {
        private static List<double> centroide;
        ///private static object clustersTotales;

        static void Main(string[] args)
        {
            string[,] csv = Program.csvToMatrix();
            List<Elemento> elementosTotales = IniciarElementos(csv);
            MostrarInfoElementos(elementosTotales);
            List<Cluster> clustersTotales = IniciarClusters(csv);
            ImprimirInfoClusters(clustersTotales);

            newItera(elementosTotales, clustersTotales);
            //Calcular los nuevos centroides 
            //obtener la suma de las cordenadas[j] de y sacar promedio este promedio moverlo al centroide del cluster 
            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }


        public static void newItera(List<Elemento> elementosTotales, List<Cluster> clustersTotales)
        {
            ObtenerDistancias(elementosTotales, clustersTotales);

            OrdenarElementos(elementosTotales, clustersTotales);

            ImprimirEstadoActual(clustersTotales);
            ImprimirEstadoAnterior(clustersTotales);

            //Preguntar si las listas de los cluster son iguales a la lista anterior 

            //Puede tener error
            bool sonIguales = SonIgualesLosEstados(clustersTotales);
            Console.Read();

            if (sonIguales)
            {
                Console.WriteLine("SON IGUALES ");
                Console.WriteLine("Fin ");
            }
            else
            {
                Console.WriteLine("SON DIFERENTES");
                //Puede tener error
                CalcularNuevosCentroides(clustersTotales);

                //Tratar de reiniciar Clusters cordenadas del centroide, listas de elementos y elementos anteriores
                //Reiniciar las distancias de los elementos
                //Pasar el estado actual al anterior
                for (var i = 0; i < clustersTotales.Count; i++)
                {//Limpiar elementos anteriores
                    clustersTotales[i].elementosAnteriores.Clear();
                }
                for (var i = 0; i < clustersTotales.Count; i++)
                {//pasar los elementos actuales a los anteriores
                    clustersTotales[i].elementosAnteriores = clustersTotales[i].elementos;
                    //limpiar el elemento actual
                    clustersTotales[i].elementos.Clear();
                }

                //Puede tener error
                ImprimirInfoClusters(clustersTotales);

                for (var i = 0; i < elementosTotales.Count; i++)
                {
                    elementosTotales[i].distanciaRCluster.Clear();
                }
                newItera(elementosTotales, clustersTotales);

            }

        }
        public static void CalcularNuevosCentroides(List<Cluster> clustersTotales)
        {
            //NuevoCentroide();
            for (var i = 0; i < clustersTotales.Count; i++)
            {
                //clustersTotales[i].centroide.Clear();
                double[] CoordenadasDelCentroide = new double[clustersTotales[i].centroide.Count];
                for (int j = 0; j < (clustersTotales[i].centroide.Count); j++)
                {
                    double corde = obtenerPromedio(clustersTotales[i].elementos, j);
                    CoordenadasDelCentroide[j] = corde;
                    Program.centroide = new List<double>(CoordenadasDelCentroide);
                }
                clustersTotales[i].centroide = centroide;
            }
        }
        public static bool SonIgualesLosEstados(List<Cluster> clustersTotales)
        {

            bool sonIguales = false;
            var equalsFlag = 0;
            for (var i = 0; i < clustersTotales.Count; i++)
            {
                if (clustersTotales[i].elementos == clustersTotales[i].elementosAnteriores)
                {
                    Console.WriteLine("Son iguales ");
                    equalsFlag++;
                }
                else
                {
                    Console.WriteLine("Son diferentes ");
                }
            }
            if (equalsFlag == clustersTotales.Count)

            { sonIguales = true; return sonIguales; }

            else { return sonIguales; }
        }
        public static void ImprimirEstadoActual(List<Cluster> clustersTotales)
        {
            //Imprimir el resultado de la interaccion
            Console.WriteLine("Estado actual de los elementos  ");
            for (int j = 0; j < clustersTotales.Count; j++)
            {
                Console.Write("Cluster " + clustersTotales[j].nombre + " Elementos: ");
                for (int k = 0; k < clustersTotales[j].elementos.Count; k++)
                {
                    Console.Write(clustersTotales[j].elementos[k].nombre + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("************************************");

        }
        public static void ImprimirEstadoAnterior(List<Cluster> clustersTotales)
        {
            //Imprime estado anterior
            Console.WriteLine("Estado ANTERIOR de los elementos  ");

            for (int j = 0; j < clustersTotales.Count; j++)
            {
                Console.Write("Cluster " + clustersTotales[j].nombre + " Elementos: ");
                for (int k = 0; k < clustersTotales[j].elementosAnteriores.Count; k++)
                {
                    Console.Write(clustersTotales[j].elementosAnteriores[k].nombre + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("////////////////////////////////////////");
        }
        public static void OrdenarElementos(List<Elemento> elementosTotales, List<Cluster> clustersTotales)
        {
            //Para cada elemento comparar distancias de rC1 y rC2 la menor mandar su elemento a su cluster
            for (var i = 0; i < elementosTotales.Count; i++)
            {
                double menor = elementosTotales[i].distanciaRCluster.Min();
                int indexmenor = elementosTotales[i].distanciaRCluster.IndexOf(menor);
                //Console.WriteLine(indexmenor); 
                clustersTotales[indexmenor].elementos.Add(elementosTotales[i]);
            }
        }
        public static List<Elemento> IniciarElementos(string[,] csv)
        {
            List<Elemento> elementosTotales = new List<Elemento>();
            List<double> coordenadasDeElemetoL = new List<double>();

            //LLenar datos de las clases con los datos de la matriz
            for (int row = 0; row < csv.GetLength(0); row++)
            {
                coordenadasDeElemetoL.Clear();
                for (int col = 1; col < csv.GetLength(1); col++)
                {
                    double cord = double.Parse(csv[row, col], CultureInfo.InvariantCulture.NumberFormat);
                    coordenadasDeElemetoL.Add(cord);
                    List<double> coordena = new List<double>();
                }
                elementosTotales.Add(new Elemento() { nombre = csv[row, 0], coordenadas = (new List<double>(coordenadasDeElemetoL)) });
            }
            return elementosTotales;
        }
        public static void MostrarInfoElementos(List<Elemento> elementosTotales)
        {
            Console.WriteLine("**********************************************");
            for (int i = 0; i < elementosTotales.Count; i++)
            {
                Console.WriteLine("Elemento: " + elementosTotales[i].nombre + " cordenada 1= " + elementosTotales[i].coordenadas[0] + " cordenada 2=" + elementosTotales[i].coordenadas[1]);
            }
            Console.WriteLine("**********************************************");
        }
        public static List<Cluster> IniciarClusters(string[,] csv)
        {
            List<Cluster> clustersTotales = new List<Cluster>();
            int numeroClusters;
            //Iniciar los clusters, segun el numero de clusters 
            //Llenar las cordenadas en el arreglo de un cluster: aleatorias, cordenadas de elemento eleatorio, ingresarlos
            Console.WriteLine("Ingrese el numero de clusters");
            numeroClusters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Creando " + numeroClusters + " clusters");

            Console.WriteLine("Desea ingresar manualmente los datos de el cluster ? y/n");
            string option = Console.ReadLine();

            switch (option)

            {
                default:
                    break;
            }
            for (int i = 0; i < numeroClusters; i++)
            {

                if (option == "n")
                {
                    double[] CoordenadasDelCentroide = new double[csv.GetLength(1) - 1];
                    for (int j = 0; j < (csv.GetLength(1) - 1); j++)
                    {

                        double corde = new Random().Next(1, 10);
                        CoordenadasDelCentroide[j] = corde;

                        Program.centroide = new List<double>(CoordenadasDelCentroide);
                        List<double> centroide = new List<double>(CoordenadasDelCentroide);
                    }
                    Cluster C = new Cluster("Cluster " + (i + 1), centroide, new List<Elemento>(), new List<Elemento>());
                    clustersTotales.Add(C);
                }
                else
                {
                    Console.WriteLine("Ingrese el nombre del cluster " + (i + 1));
                    string nombre = Console.ReadLine();
                    double[] CoordenadasDelCentroideC = new double[csv.GetLength(1) - 1];
                    for (int j = 0; j < (csv.GetLength(1) - 1); j++)
                    {

                        Console.WriteLine("Ingrese la coordenada  " + (j + 1) + " Del cluster " + (i + 1));
                        int cord = Convert.ToInt32(Console.ReadLine());
                        double corde = cord;
                        CoordenadasDelCentroideC[j] = corde;
                        centroide = new List<double>(CoordenadasDelCentroideC);

                    }
                    Cluster C = new Cluster(nombre, centroide, new List<Elemento>(), new List<Elemento>(0));
                    clustersTotales.Add(C);
                    /*double[] CoordenadasDelCentroide = { new Random().Next(1, 10), new Random().Next(1, 10) };
                    int intc = Convert.ToInt32(Console.ReadLine());
                    double cordenadas = intc;


                    List<double> centroide = new List<double>(CoordenadasDelCentroide);
                    Cluster C = new Cluster(nombre, centroide, new List<Elemento>(), new List<Elemento>());*/
                }

            }
            return clustersTotales;
        }
        public static void ImprimirInfoClusters(List<Cluster> clustersTotales)
        {
            //mprime info de los clusters
            for (int i = 0; i < clustersTotales.Count; i++)
            {
                Console.Write("Cluster: " + clustersTotales[i].nombre + ": ");
                for (int j = 0; j < clustersTotales[i].centroide.Count; j++)
                {

                    Console.Write(" " + clustersTotales[i].centroide[j]);

                }
                Console.WriteLine();

            }
        }
        public static void ObtenerDistancias(List<Elemento> elementosTotales, List<Cluster> clustersTotales)
        {
            for (int i = 0; i < elementosTotales.Count; i++)
            {//para cada cluster
                for (int j = 0; j < clustersTotales.Count; j++)
                {
                    double distancia = Math.Sqrt(Program.ObtenerDistancia(elementosTotales[i], clustersTotales[j]));
                    //double distancia = Math.Sqrt(Math.Pow((clustersTotales[j].centroide[0] - elementosTotales[i].coordenadas[0]), 2) + Math.Pow((clustersTotales[j].centroide[1] - elementosTotales[i].coordenadas[1]), 2));
                    elementosTotales[i].distanciaRCluster.Add(distancia);
                    //Console.WriteLine("Formula = raiz de ((" + clustersTotales[j].centroide[0] + " - " + elementosTotales[i].coordenadas[0] + ")^2 + (" + clustersTotales[j].centroide[1] + " - " + elementosTotales[i].coordenadas[1] + ")^2)");
                    Console.WriteLine("Distancia del elemento: " + elementosTotales[i].nombre + ", respecto al cluster: " + (j + 1) + " = " + elementosTotales[i].distanciaRCluster[j]);

                }
                Console.WriteLine();
            }

        }
        public static double ObtenerDistancia(Elemento elemento, Cluster cluster)
        {
            double sumaDeCuadrados = 0;
            double distancia = 0;
            for (int i = 0; i < elemento.coordenadas.Count; i++)
            {
                sumaDeCuadrados = sumaDeCuadrados + Math.Pow((cluster.centroide[i] - elemento.coordenadas[i]), 2);
            }
            distancia = Math.Sqrt(sumaDeCuadrados);
            return distancia;
        }
        public static double obtenerPromedio(List<Elemento> conjunto, int PoscionAPromediar)
        {
            double prom = 0;
            for (var i = 0; i < conjunto.Count; i++)
            {
                prom = prom + conjunto[i].coordenadas[PoscionAPromediar];
            }
            prom = prom / conjunto.Count;
            return prom;
        }
        private static string[,] csvToMatrixN()
        {

            string fileData = System.IO.File.ReadAllText(@"../../../Iris.csv");
            //string fileData = System.IO.File.ReadAllText(@"../../../../KnnEjercicioData.csv");

            fileData = fileData.Replace('\n', '\r');

            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int totalRows = lines.Length;
            int totalCols = lines[0].Split(',').Length;


            string[,] resultVals = new string[totalRows, totalCols];

            for (int row = 0; row < totalRows; row++)
            {
                string[] line_r = lines[row].Split(',');
                for (int col = 0; col < totalCols; col++)
                {
                    resultVals[row, col] = line_r[col];

                    Console.Write(line_r[col]);
                }
                Console.WriteLine("");

            }

            return resultVals;
        }

        private static string[,] csvToMatrix()
        {

            string fileData = System.IO.File.ReadAllText(@"../../../Iris.csv");
            //string fileData = System.IO.File.ReadAllText(@"../../../../KnnEjercicioData.csv");

            fileData = fileData.Replace('\n', '\r');

            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int totalRows = lines.Length;
            int totalCols = lines[0].Split(',').Length;


            string[,] resultVals = new string[totalRows, totalCols];
            string[,] Parte1 = new string[40, totalCols];
            string[,] Parte2 = new string[40, totalCols];
            string[,] Parte3 = new string[40, totalCols];

            for (int row = 0; row < 40; row++)
            {

                string[] line_r = lines[new Random().Next(0,49) ].Split(',');
                for (int col = 0; col < totalCols; col++)
                {
                    Parte1[row, col] = line_r[col];
                    Console.Write(line_r[col]);
                }
                Console.WriteLine("");

            }
            for (int row = 0; row < 40; row++)
            {

                string[] line_r = lines[new Random().Next(50, 100)].Split(',');
                for (int col = 0; col < totalCols; col++)
                {
                    Parte2[row, col] = line_r[col];
                    Console.Write(line_r[col]);
                }
                Console.WriteLine("");

            }
            for (int row = 0; row < 40; row++)
            {

                string[] line_r = lines[new Random().Next(101, 150)].Split(',');
                for (int col = 0; col < totalCols; col++)
                {
                    Parte3[row, col] = line_r[col];
                    Console.Write(line_r[col]);
                }
                Console.WriteLine("");

            }

            for (int row = 0; row < totalRows; row++)
            {
                string[] line_r = lines[row].Split(',');
                for (int col = 0; col < totalCols; col++)
                {
                    resultVals[row, col] = line_r[col];

                    Console.Write(line_r[col]);
                }
                Console.WriteLine("");

            }
            var myList = new List<int>();
          

            return resultVals;
        }
    }
}

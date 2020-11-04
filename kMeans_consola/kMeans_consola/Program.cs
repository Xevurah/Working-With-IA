using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kMeans_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodos miNodo;
            Cluster miCluster;
            ListaNodos listaN = new ListaNodos();
            ListaClusters listaC = new ListaClusters();
            String ListaNombres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("Ingrese el numero de Nodos: ");
            String n = Console.ReadLine();
            int num_nodos = Int32.Parse(n);
            Console.WriteLine("Ingrese el numero de clusters: ");
            n = Console.ReadLine();
            int num_clusters = Int32.Parse(n);
            for(int i=0;i<num_nodos;i++)
            {
                Console.WriteLine("Ingrese la cordenada x del nodo " + ListaNombres.Substring(i, 1) + ": ");
                n = Console.ReadLine();
                int cordenadaX = Int32.Parse(n);
                Console.WriteLine("Ingrese la cordenada y del nodo " + ListaNombres.Substring(i, 1) + ": ");
                n = Console.ReadLine();
                int cordenadaY = Int32.Parse(n);
                miNodo = new Nodos(ListaNombres.Substring(i, 1), cordenadaX, cordenadaY);
                listaN.AgregarNodo(miNodo);
            }
            for (int i = 0; i < num_clusters; i++)
            {
                Console.WriteLine("Ingrese la cordenada x del cluster " + (i+1)+ ": ");
                n = Console.ReadLine();
                int cordenadaX = Int32.Parse(n);
                Console.WriteLine("Ingrese la cordenada y del cluster " + (i+1) + ": ");
                n = Console.ReadLine();
                int cordenadaY = Int32.Parse(n);
                miCluster = new Cluster(i.ToString(), cordenadaX, cordenadaY);
                listaC.AgregarCluster(miCluster);
            }
            int k = 1;
            Iteraciones(k,num_nodos,num_clusters,listaN,listaC);
        }
        public static void Iteraciones(int k,int num_nodos,int num_clusters,ListaNodos listaN,ListaClusters listaC)
        {
            String ListaNombres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double[,] resultados= new double[num_clusters,num_nodos];
            Console.WriteLine("Iteracion numero " + k + ": ");
            for(int i=0;i<num_clusters;i++)
            {
                Console.WriteLine("Cluster " + (i+1) + ": ");
                double[] cluster = listaC.DameCordenadas((i+1));
                for (int j=0;j<num_nodos;j++)
                {
                    Console.WriteLine("Nodo " + ListaNombres.Substring(j, 1) + ": ");
                    double[] nodo = listaN.DameCordenadas((j+1));
                    double valor1 = Potencia((cluster[0]-nodo[0]));
                    double valor2 = Potencia((cluster[1] - nodo[1]));
                    resultados[i, j] = Math.Sqrt(valor1+valor2);
                    resultados[i, j] = Math.Truncate(resultados[i, j] * 100)/100;
                    Console.WriteLine("(("+cluster[0]+"-"+nodo[0]+")^2 + ("+ cluster[1] + "-" + nodo[1] + ")^2)^1/2=  "+resultados[i,j]);
                }
                Console.WriteLine("\n");
            }

            double resultadomenor = resultados[0,0];
            int position = 0;

            for (int j=0;j< num_nodos; j++)
            {
                for (int i = 0; i < num_clusters; i++)
                {

                    if (resultadomenor < resultados[i, j])
                    {
                        resultadomenor = resultados[i, j];
                        position = i;
                    };
                }
                Console.WriteLine();
            }
            Console.Read();
        }
        public static double Potencia(double valor)
        {
            double resultado=Math.Pow(valor, 2);
            return resultado;
        }
    }
}

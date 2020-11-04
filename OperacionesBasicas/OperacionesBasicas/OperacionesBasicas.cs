using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas
{
    class OperacionesBasicas
    {
        protected Bitmap MapaFuente;
        protected Bitmap MapaDestino;
        protected Bitmap MapaRecorte;

        protected int[,] Pixeles;
        protected int[,] PixelesAux;
        protected int[,] R;
        protected int[,] G;
        protected int[,] B;
        protected int[,] RAux;
        protected int[,] GAux;
        protected int[,] BAux;
        protected int[,] AuxMatrix;
        

        protected int Anchura;
        protected int Altura;

        public OperacionesBasicas(Bitmap MapaFuente)
        {
            this.MapaFuente = new Bitmap(MapaFuente);
        }

        public void VaciarMapaAMatriz()
        {
            Anchura = MapaFuente.Width;
            Altura = MapaFuente.Height;

            Pixeles = new int[Anchura, Altura];
            for (int j = 0; j < Altura; j++)
                for (int i = 0; i < Anchura; i++)
                {
                    Pixeles[i, j] = MapaFuente.GetPixel(i, j).ToArgb();
                }
        }

        public void DescomponerRGB()
        {
            AuxMatrix = new int[Anchura, Altura];
            R = new int[Anchura, Altura];
            G = new int[Anchura, Altura];
            B = new int[Anchura, Altura];

            for (int j = 0; j < Altura; j++)
                for (int i = 0; i < Anchura; i++)
                {
                    R[i, j] = (Pixeles[i, j] & 0x00ff0000) >> 16;
                    G[i, j] = (Pixeles[i, j] & 0x0000ff00) >> 8;
                    B[i, j] = (Pixeles[i, j] & 0x000000ff);
                }
        }

        public void ComponerRGB()
        {
            Pixeles = new int[Anchura, Altura];

            for (int j = 0; j < Altura; j++)
                for (int i = 0; i < Anchura; i++)
                {
                    Pixeles[i, j] = (255 << 24) | (R[i, j] << 16) | (G[i, j] << 8) | (B[i, j]);
                }
        }

        public Bitmap VaciarMatrizAMapa()
        {
            MapaDestino = new Bitmap(Anchura, Altura, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            for (int j = 0; j < Altura; j++)
                for (int i = 0; i < Anchura; i++)
                {
                    MapaDestino.SetPixel(i, j, Color.FromArgb(Pixeles[i, j]));
                }

            return MapaDestino;
        }

        public void Prueba()
        {
            for (int j = 10; j < 100; j++)
                for (int i = 10; i < 100; i++)
                {
                    R[i, j] = 255;
                    G[i, j] = 0;
                    B[i, j] = 0;
                }
        }

        public void FlipY()
        {
            Pixeles = new int[Anchura, Altura];

            for (int j = Altura - 1; j > 0; j--)
                for (int i = 0; i < Anchura; i++)
                {
                    Pixeles[i, j] = (255 << 24) | (R[i, (Altura - 1) - j] << 16) | (G[i, (Altura - 1) - j] << 8) | (B[i, (Altura - 1) - j]);
                }
        }

        public void FlipX()
        {
            Pixeles = new int[Anchura, Altura];

            for (int j = 0; j < Altura; j++)
                for (int i = Anchura-1; i > 0; i--)
                {
                    Pixeles[i, j] = (255 << 24) | (R[(Anchura - 1)-i,j] << 16) | (G[(Anchura - 1) -i,j] << 8) | (B[(Anchura - 1)-i,j]);
                }
        }

        public void GuardarNuevoMapa() 
        {
            MapaFuente = MapaDestino;
        }
    }
}

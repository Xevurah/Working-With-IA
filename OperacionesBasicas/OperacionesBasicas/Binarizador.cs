using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas
{
    class Binarizador : OperacionesBasicas
    {
        public Binarizador(Bitmap MapaFuente) : base(MapaFuente)
        {

        }

        public void EscalamientoDeGrises()
        {
            int promedio;
            for (int j = 0; j < Altura; j++)
                for (int i = 0; i < Anchura; i++)
                {
                    promedio = (R[i, j] + G[i, j] + B[i, j]) / 3;
                    R[i, j] = promedio;
                    G[i, j] = promedio;
                    B[i, j] = promedio;
                }
        }

        public void Binarizacion(int Umbral)
        {
            for (int j = 0; j < Altura; j++)
                for (int i = 0; i < Anchura; i++)
                {
                    if (R[i, j] < Umbral)
                    {
                        R[i, j] = 0;
                        G[i, j] = 0;
                        B[i, j] = 0;
                    }
                    else 
                    {
                        R[i, j] = 255;
                        G[i, j] = 255;
                        B[i, j] = 255;
                    }
                }
        }

        public void ComponentesConx()
        {
            int contador = 1;
            for (int j = 0; j < Altura; j++)
                for (int i = 0; i < Anchura; i++)
                {
                    if (R[i, j] == 0)
                    {
                        AuxMatrix[i, j] = contador;
                        contador++;
                    }
                    
                }

            bool siono = true;
            while (siono)
            {
                siono = false;
                for (int j = 0; j < Altura; j++)
                    for (int i = 0; i < Anchura; i++)
                    {
                        if (AuxMatrix[i, j] > 0)
                        {
                            //try {
                            if (j != 0)
                            {
                                if (AuxMatrix[i, j] > AuxMatrix[i, j - 1] && AuxMatrix[i, j - 1] != 0)
                                {
                                    AuxMatrix[i, j] = AuxMatrix[i, j - 1];
                                    siono = true;
                                }
                            }
                            //} catch (Exception) { }
                            //try {
                            if (i != 0)
                            {
                                if (AuxMatrix[i, j] > AuxMatrix[i - 1, j] && AuxMatrix[i - 1, j] != 0)
                                {
                                    AuxMatrix[i, j] = AuxMatrix[i - 1, j];
                                    siono = true;
                                }
                            }
                            //} catch (Exception) { }
                            //try {
                            if (j < Altura - 1)
                            {
                                if (AuxMatrix[i, j] > AuxMatrix[i, j + 1] && AuxMatrix[i, j + 1] != 0)
                                {
                                    AuxMatrix[i, j] = AuxMatrix[i, j + 1];
                                    siono = true;
                                }
                            }
                            //} catch (Exception) { }
                            //try {
                            if (i < Anchura - 1)
                            {
                                if (AuxMatrix[i, j] > AuxMatrix[i + 1, j] && AuxMatrix[i + 1, j] != 0)
                                {
                                    AuxMatrix[i, j] = AuxMatrix[i + 1, j];
                                    siono = true;
                                }
                            }
                            //} catch (Exception) { }
                        }

                    }

                for (int j = Altura - 1; j >= 0; j--)
                    for (int i = Anchura - 1; i >= 0; i--)
                    {
                        if (AuxMatrix[i, j] > 0)
                        {
                            //try {
                            if (j != 0)
                            {
                                if (AuxMatrix[i, j] > AuxMatrix[i, j - 1] && AuxMatrix[i, j - 1] != 0)
                                {
                                    AuxMatrix[i, j] = AuxMatrix[i, j - 1];
                                    siono = true;
                                }
                            }
                            //} catch (Exception) { }
                            //try {
                            if (i != 0)
                            {
                                if (AuxMatrix[i, j] > AuxMatrix[i - 1, j] && AuxMatrix[i - 1, j] != 0)
                                {
                                    AuxMatrix[i, j] = AuxMatrix[i - 1, j];
                                    siono = true;
                                }
                            }
                            //} catch (Exception) { }
                            //try {
                            if (j < Altura - 1)
                            {
                                if (AuxMatrix[i, j] > AuxMatrix[i, j + 1] && AuxMatrix[i, j + 1] != 0)
                                {
                                    AuxMatrix[i, j] = AuxMatrix[i, j + 1];
                                    siono = true;
                                }
                            }
                            //} catch (Exception) { }
                            //try {
                            if (i < Anchura - 1)
                            {
                                if (AuxMatrix[i, j] > AuxMatrix[i + 1, j] && AuxMatrix[i + 1, j] != 0)
                                {
                                    AuxMatrix[i, j] = AuxMatrix[i + 1, j];
                                    siono = true;
                                }
                            }
                            //} catch (Exception) { }
                        }

                    }
            }
            Random rnd = new Random();
            int otrocontador = 1;
            while (contador>otrocontador) {
                bool appear = false;
                RAux = new int[Anchura, Altura];
                GAux = new int[Anchura, Altura];
                BAux = new int[Anchura, Altura];
                for (int j = 0; j < Altura; j++)
                    for (int i = 0; i < Anchura; i++)
                    {
                        RAux[i, j] = (0x00ff0000) >> 16;
                        GAux[i, j] = (0x0000ff00) >> 8;
                        BAux[i, j] = (0x000000ff);
                    }
                int red = rnd.Next(0, 256);
                int green = rnd.Next(0, 256);
                int blue = rnd.Next(0, 256);
                for (int j = 0; j < Altura; j++)
                    for (int i = 0; i < Anchura; i++)
                    {
                        if (AuxMatrix[i, j] == otrocontador)
                        {
                            R[i, j] = red;
                            G[i, j] = green;
                            B[i, j] = blue;
                            RAux[i, j] = (0x00000000) >> 16;
                            GAux[i, j] = (0x00000000) >> 8;
                            BAux[i, j] = (0x00000000);
                            appear = true;
                        }
                    }

                if (appear) {
                    PixelesAux = new int[Anchura, Altura];

                    for (int j = 0; j < Altura; j++)
                        for (int i = 0; i < Anchura; i++)
                        {
                            PixelesAux[i, j] = (255 << 24) | (RAux[i, j] << 16) | (GAux[i, j] << 8) | (BAux[i, j]);
                        }

                    MapaRecorte = new Bitmap(Anchura, Altura, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    for (int j = 0; j < Altura; j++)
                        for (int i = 0; i < Anchura; i++)
                        {
                            MapaRecorte.SetPixel(i, j, Color.FromArgb(PixelesAux[i, j]));
                        }

                    var inputPath = "./rec/"+otrocontador + ".png";
                    var outputPath = inputPath.Replace(".png", "-out.png");

                    var cropped = CropWhiteSpace(MapaRecorte);
                    cropped.Save(outputPath, ImageFormat.Png);
                }               


                otrocontador++; }

            //int otrocont = 0;
            //while (otrocont < (Altura * Anchura))
            //{
            //    Random rnd = new Random();
            //    otrocont++;
            //    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //    for (int j = 0; j < Altura; j++)
            //        for (int i = 0; i < Anchura; i++)
            //        {
            //            if (AuxMatrix[i, j] > 0)
            //            {
            //                //try {
            //                if (j != 0)
            //                {
            //                    if (AuxMatrix[i, j] == AuxMatrix[i, j - 1] && AuxMatrix[i, j - 1] != 0)
            //                    {
            //                        Pixeles[i, j] = randomColor.ToArgb();
            //                    }
            //                }
            //                //} catch (Exception) { }
            //                //try {
            //                if (i != 0)
            //                {
            //                    if (AuxMatrix[i, j] == AuxMatrix[i - 1, j] && AuxMatrix[i - 1, j] != 0)
            //                    {
            //                        Pixeles[i, j] = randomColor.ToArgb();
            //                    }
            //                }
            //                //} catch (Exception) { }
            //                //try {
            //                if (j < Altura - 1)
            //                {
            //                    if (AuxMatrix[i, j] == AuxMatrix[i, j + 1] && AuxMatrix[i, j + 1] != 0)
            //                    {
            //                        Pixeles[i, j] = randomColor.ToArgb();
            //                    }
            //                }
            //                //} catch (Exception) { }
            //                //try {
            //                if (i < Anchura - 1)
            //                {
            //                    if (AuxMatrix[i, j] == AuxMatrix[i + 1, j] && AuxMatrix[i + 1, j] != 0)
            //                    {
            //                        Pixeles[i, j] = randomColor.ToArgb();
            //                    }
            //                }
            //                //} catch (Exception) { }
            //            }

            //        }
            //}



        }

        public static Bitmap CropWhiteSpace(Bitmap bmp)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            int white = 0xffffff;

            Func<int, bool> allWhiteRow = r =>
            {
                for (int i = 0; i < w; ++i)
                    if ((bmp.GetPixel(i, r).ToArgb() & white) != white)
                        return false;
                return true;
            };

            Func<int, bool> allWhiteColumn = c =>
            {
                for (int i = 0; i < h; ++i)
                    if ((bmp.GetPixel(c, i).ToArgb() & white) != white)
                        return false;
                return true;
            };

            int topmost = 0;
            for (int row = 0; row < h; ++row)
            {
                if (!allWhiteRow(row))
                    break;
                topmost = row;
            }

            int bottommost = 0;
            for (int row = h - 1; row >= 0; --row)
            {
                if (!allWhiteRow(row))
                    break;
                bottommost = row;
            }

            int leftmost = 0, rightmost = 0;
            for (int col = 0; col < w; ++col)
            {
                if (!allWhiteColumn(col))
                    break;
                leftmost = col;
            }

            for (int col = w - 1; col >= 0; --col)
            {
                if (!allWhiteColumn(col))
                    break;
                rightmost = col;
            }

            if (rightmost == 0) rightmost = w; // As reached left
            if (bottommost == 0) bottommost = h; // As reached top.

            int croppedWidth = rightmost - leftmost;
            int croppedHeight = bottommost - topmost;

            if (croppedWidth == 0) // No border on left or right
            {
                leftmost = 0;
                croppedWidth = w;
            }

            if (croppedHeight == 0) // No border on top or bottom
            {
                topmost = 0;
                croppedHeight = h;
            }

            try
            {
                var target = new Bitmap(croppedWidth, croppedHeight);
                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(bmp,
                      new RectangleF(0, 0, croppedWidth, croppedHeight),
                      new RectangleF(leftmost, topmost, croppedWidth, croppedHeight),
                      GraphicsUnit.Pixel);
                }
                return target;
            }
            catch (Exception ex)
            {
                throw new Exception(
                  string.Format("Values are topmost={0} btm={1} left={2} right={3} croppedWidth={4} croppedHeight={5}", topmost, bottommost, leftmost, rightmost, croppedWidth, croppedHeight),
                  ex);
            }
        }
    }
}

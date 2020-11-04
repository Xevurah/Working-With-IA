using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesBasicas
{
    public partial class Form1 : Form
    {
        Binarizador operaciones;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFDImagen.ShowDialog() == DialogResult.OK)
            {
                PBImagen2.Image = new Bitmap(OFDImagen.FileName);
                PBImagen.Image = new Bitmap(OFDImagen.FileName);
                operaciones = new Binarizador((Bitmap)PBImagen.Image);
            }
        }

        private void descomponerRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operaciones.VaciarMapaAMatriz();
        }

        private void descomponerRGBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            operaciones.DescomponerRGB();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operaciones.EscalamientoDeGrises();
            operaciones.Binarizacion(128);
        }

        private void componerRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operaciones.ComponerRGB();
        }

        private void vaciarMatrizAMapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBImagen.Image = operaciones.VaciarMatrizAMapa();
            operaciones.GuardarNuevoMapa();
        }

        private void flipYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operaciones.VaciarMapaAMatriz();
            operaciones.DescomponerRGB();
            operaciones.FlipY();
            PBImagen.Image = operaciones.VaciarMatrizAMapa();
            operaciones.GuardarNuevoMapa();
        }

        private void flipXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operaciones.VaciarMapaAMatriz();
            operaciones.DescomponerRGB();
            operaciones.FlipX();
            PBImagen.Image = operaciones.VaciarMatrizAMapa();
            operaciones.GuardarNuevoMapa();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SFDImagen.ShowDialog() == DialogResult.OK)
            {
                PBImagen.Image.Save(SFDImagen.FileName);
            }
        }

        private void componentesConexasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operaciones.VaciarMapaAMatriz();
            operaciones.DescomponerRGB();
            operaciones.EscalamientoDeGrises();
            
            operaciones.Binarizacion(120);
            
            operaciones.ComponentesConx();
            operaciones.ComponerRGB();

            PBImagen.Image = operaciones.VaciarMatrizAMapa();
            operaciones.GuardarNuevoMapa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles("./rec/");
            foreach (string element in filePaths) 
            {
                comboBox1.Items.Add(element);
            }
        }

        private void change(object sender, EventArgs e) 
        {
            pictureBox1.ImageLocation = comboBox1.Text;
        }
    }
}

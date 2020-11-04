using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoPOO
{
    public partial class Form1 : Form
    {

        Persona mi_persona;
        listaPersona lista = new listaPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lo crea
            mi_persona = new Persona(tbName.Text, (int)nudEdad.Value, rbHombre.Checked);
            //lo agrega a la lista
            lista.AgregarPersona(mi_persona);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(lista.GetDatos());
            richTextBox1.Text += lista.GetDatos();
        }

    }
}

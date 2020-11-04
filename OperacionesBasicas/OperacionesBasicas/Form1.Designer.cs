namespace OperacionesBasicas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descomponerRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descomponerRGBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componerRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaciarMatrizAMapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesConexasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFDImagen = new System.Windows.Forms.OpenFileDialog();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.SFDImagen = new System.Windows.Forms.SaveFileDialog();
            this.PBImagen2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descomponerRGBToolStripMenuItem,
            this.descomponerRGBToolStripMenuItem1,
            this.pruebaToolStripMenuItem,
            this.componerRGBToolStripMenuItem,
            this.vaciarMatrizAMapaToolStripMenuItem,
            this.componentesConexasToolStripMenuItem,
            this.flipYToolStripMenuItem,
            this.flipXToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // descomponerRGBToolStripMenuItem
            // 
            this.descomponerRGBToolStripMenuItem.Name = "descomponerRGBToolStripMenuItem";
            this.descomponerRGBToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.descomponerRGBToolStripMenuItem.Text = "VaciarMapaAMatriz";
            this.descomponerRGBToolStripMenuItem.Click += new System.EventHandler(this.descomponerRGBToolStripMenuItem_Click);
            // 
            // descomponerRGBToolStripMenuItem1
            // 
            this.descomponerRGBToolStripMenuItem1.Name = "descomponerRGBToolStripMenuItem1";
            this.descomponerRGBToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.descomponerRGBToolStripMenuItem1.Text = "Descomponer RGB";
            this.descomponerRGBToolStripMenuItem1.Click += new System.EventHandler(this.descomponerRGBToolStripMenuItem1_Click);
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.pruebaToolStripMenuItem.Text = "Binarizacion";
            this.pruebaToolStripMenuItem.Click += new System.EventHandler(this.pruebaToolStripMenuItem_Click);
            // 
            // componerRGBToolStripMenuItem
            // 
            this.componerRGBToolStripMenuItem.Name = "componerRGBToolStripMenuItem";
            this.componerRGBToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.componerRGBToolStripMenuItem.Text = "Componer RGB";
            this.componerRGBToolStripMenuItem.Click += new System.EventHandler(this.componerRGBToolStripMenuItem_Click);
            // 
            // vaciarMatrizAMapaToolStripMenuItem
            // 
            this.vaciarMatrizAMapaToolStripMenuItem.Name = "vaciarMatrizAMapaToolStripMenuItem";
            this.vaciarMatrizAMapaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.vaciarMatrizAMapaToolStripMenuItem.Text = "VaciarMatrizAMapa";
            this.vaciarMatrizAMapaToolStripMenuItem.Click += new System.EventHandler(this.vaciarMatrizAMapaToolStripMenuItem_Click);
            // 
            // componentesConexasToolStripMenuItem
            // 
            this.componentesConexasToolStripMenuItem.Name = "componentesConexasToolStripMenuItem";
            this.componentesConexasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.componentesConexasToolStripMenuItem.Text = "Componentes conexas";
            this.componentesConexasToolStripMenuItem.Click += new System.EventHandler(this.componentesConexasToolStripMenuItem_Click);
            // 
            // flipYToolStripMenuItem
            // 
            this.flipYToolStripMenuItem.Name = "flipYToolStripMenuItem";
            this.flipYToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.flipYToolStripMenuItem.Text = "FlipY";
            this.flipYToolStripMenuItem.Click += new System.EventHandler(this.flipYToolStripMenuItem_Click);
            // 
            // flipXToolStripMenuItem
            // 
            this.flipXToolStripMenuItem.Name = "flipXToolStripMenuItem";
            this.flipXToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.flipXToolStripMenuItem.Text = "FlipX";
            this.flipXToolStripMenuItem.Click += new System.EventHandler(this.flipXToolStripMenuItem_Click);
            // 
            // OFDImagen
            // 
            this.OFDImagen.FileName = "openFileDialog1";
            this.OFDImagen.Filter = "Portable Network Graphics|*.png|Mapas de bits|*.bmp|Jpegs|*.jpg";
            this.OFDImagen.FilterIndex = 3;
            // 
            // PBImagen
            // 
            this.PBImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImagen.Location = new System.Drawing.Point(660, 27);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(374, 411);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImagen.TabIndex = 1;
            this.PBImagen.TabStop = false;
            // 
            // SFDImagen
            // 
            this.SFDImagen.FileName = "saveFileDialog1";
            this.SFDImagen.Filter = "Portable Network Graphics|*.png|Mapas de bits|*.bmp|Jpegs|*.jpg";
            this.SFDImagen.FilterIndex = 3;
            // 
            // PBImagen2
            // 
            this.PBImagen2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PBImagen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBImagen2.Location = new System.Drawing.Point(13, 28);
            this.PBImagen2.Name = "PBImagen2";
            this.PBImagen2.Size = new System.Drawing.Size(361, 410);
            this.PBImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImagen2.TabIndex = 2;
            this.PBImagen2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(457, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.change);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(391, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 219);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar Recortes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aviso Los recortes apareceran solo \r\ndespues de agregar una imagen \r\ny dar click " +
    "en operaciones y despues \r\nComponentes convexos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PBImagen2);
            this.Controls.Add(this.PBImagen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descomponerRGBToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OFDImagen;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.ToolStripMenuItem descomponerRGBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componerRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaciarMatrizAMapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipXToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SFDImagen;
        private System.Windows.Forms.ToolStripMenuItem componentesConexasToolStripMenuItem;
        private System.Windows.Forms.PictureBox PBImagen2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}


namespace Editor_de_texto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            adelanteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            seleccionarTodoToolStripMenuItem = new ToolStripMenuItem();
            borrarTodoToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem1 = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            colorDeFondoToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, fuenteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, toolStripMenuItem1, abrirToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(159, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(156, 6);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(159, 22);
            abrirToolStripMenuItem.Text = "Abrir...";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(159, 22);
            guardarComoToolStripMenuItem.Text = "Guardar como...";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(159, 22);
            salirToolStripMenuItem.Text = "&Salir";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { atrasToolStripMenuItem, adelanteToolStripMenuItem, toolStripMenuItem2, copiarToolStripMenuItem, pegarToolStripMenuItem, cortarToolStripMenuItem, toolStripMenuItem3, seleccionarTodoToolStripMenuItem, borrarTodoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // atrasToolStripMenuItem
            // 
            atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            atrasToolStripMenuItem.Size = new Size(180, 22);
            atrasToolStripMenuItem.Text = "Atras";
            atrasToolStripMenuItem.Click += atrasToolStripMenuItem_Click;
            // 
            // adelanteToolStripMenuItem
            // 
            adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            adelanteToolStripMenuItem.Size = new Size(180, 22);
            adelanteToolStripMenuItem.Text = "Adelante";
            adelanteToolStripMenuItem.Click += adelanteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(180, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(180, 22);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.Size = new Size(180, 22);
            cortarToolStripMenuItem.Text = "Cortar";
            cortarToolStripMenuItem.Click += cortarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(177, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            seleccionarTodoToolStripMenuItem.Size = new Size(180, 22);
            seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            seleccionarTodoToolStripMenuItem.Click += seleccionarTodoToolStripMenuItem_Click;
            // 
            // borrarTodoToolStripMenuItem
            // 
            borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            borrarTodoToolStripMenuItem.Size = new Size(180, 22);
            borrarTodoToolStripMenuItem.Text = "Borrar todo";
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem1, colorToolStripMenuItem, colorDeFondoToolStripMenuItem });
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(55, 20);
            fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // fuenteToolStripMenuItem1
            // 
            fuenteToolStripMenuItem1.Name = "fuenteToolStripMenuItem1";
            fuenteToolStripMenuItem1.Size = new Size(180, 22);
            fuenteToolStripMenuItem1.Text = "Fuente";
            fuenteToolStripMenuItem1.Click += fuenteToolStripMenuItem1_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // colorDeFondoToolStripMenuItem
            // 
            colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            colorDeFondoToolStripMenuItem.Size = new Size(180, 22);
            colorDeFondoToolStripMenuItem.Text = "Color de fondo";
            colorDeFondoToolStripMenuItem.Click += colorDeFondoToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 426);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem atrasToolStripMenuItem;
        private ToolStripMenuItem adelanteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem borrarTodoToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem1;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem colorDeFondoToolStripMenuItem;
    }
}

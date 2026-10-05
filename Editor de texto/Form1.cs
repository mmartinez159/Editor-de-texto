namespace Editor_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Asignar layout estilo Tabla
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;

            var layout = (TableLayoutSettings)menuStrip1.LayoutSettings;
            layout.RowCount = 1;
            layout.ColumnCount = menuStrip1.Items.Count;

            // 2. Definir que cada columna tenga el mismo porcentaje de ancho (100% / cantidad de items)
            layout.ColumnStyles.Clear();
            float porcentaje = 100f / menuStrip1.Items.Count;

            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcentaje));

                // Desactivar el auto-tamaño y hacer que ocupen todo el ancho asignado
                menuStrip1.Items[i].AutoSize = false;
                menuStrip1.Items[i].Dock = DockStyle.Fill;
                menuStrip1.Items[i].TextAlign = ContentAlignment.MiddleCenter; // Centrar el texto en su espacio
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            //el filtro e archivos de texto
            Open.Filter = "Archivos de texto (*.text)|*.txt|Todos los archivos (*.*)|*.*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir archivo";
            Open.ShowDialog(this);

            try
            {
                //Este código es para mostrar la info en el rich text box
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                richTextBox1.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se crea el objeto save filedialog para guardar el archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            // al igual que para abrir ponemos filytos para guardar 
            Save.Filter = "Archivos de texto (*.txt)|*.txt|HTML (*.html)|*.html|Todos los archivos (*.*)|*.*";
            Save.Title = "Guardar archivo";
            Save.CheckPathExists = true;
            Save.Title = "Guardar archivo";
            Save.ShowDialog(this);

            try
            {
                //Este código para guardar la info del rich text box en el archivo
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo(); //Desacer
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo(); //Rehacer
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy(); //Copiar
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(); //Pegar
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut(); //Cortar
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Creamos el objeto FontDialog para cambiar la fuente del texto
            FontDialog font = new FontDialog();
            //Aplicamos el tipo de fuente al rich text box
            font.Font = richTextBox1.Font;
            //Se hace la validación para que el usuario pueda cambiar la fuente

            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = fondo.Color;
            }
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

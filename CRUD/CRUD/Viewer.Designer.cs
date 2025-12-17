namespace CRUD
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lsb_Alumnos = new ListBox();
            Lb_Titulo = new Label();
            menuStrip1 = new MenuStrip();
            crearToolStripMenuItem = new ToolStripMenuItem();
            cargarDatosToolStripMenuItem = new ToolStripMenuItem();
            actualizarDatosToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            conectaToolStripMenuItem = new ToolStripMenuItem();
            bt_refrescar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Lsb_Alumnos
            // 
            Lsb_Alumnos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lsb_Alumnos.FormattingEnabled = true;
            Lsb_Alumnos.Items.AddRange(new object[] { "ID — Nombre — Carrera — Jornada", "01 - Gerardo Tejada - Desarrollo de software - Matutina" });
            Lsb_Alumnos.Location = new Point(12, 99);
            Lsb_Alumnos.Name = "Lsb_Alumnos";
            Lsb_Alumnos.Size = new Size(576, 264);
            Lsb_Alumnos.TabIndex = 0;
            // 
            // Lb_Titulo
            // 
            Lb_Titulo.AutoSize = true;
            Lb_Titulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Titulo.Location = new Point(12, 44);
            Lb_Titulo.Name = "Lb_Titulo";
            Lb_Titulo.Size = new Size(288, 38);
            Lb_Titulo.TabIndex = 37;
            Lb_Titulo.Text = "Alumnos registrados";
            Lb_Titulo.Click += Lb_Titulo_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Brown;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearToolStripMenuItem, cargarDatosToolStripMenuItem, actualizarDatosToolStripMenuItem, eliminarToolStripMenuItem, salirToolStripMenuItem, opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(602, 28);
            menuStrip1.TabIndex = 38;
            menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(60, 24);
            crearToolStripMenuItem.Text = "Crear";
            crearToolStripMenuItem.Click += crearToolStripMenuItem_Click;
            // 
            // cargarDatosToolStripMenuItem
            // 
            cargarDatosToolStripMenuItem.ForeColor = SystemColors.Control;
            cargarDatosToolStripMenuItem.Name = "cargarDatosToolStripMenuItem";
            cargarDatosToolStripMenuItem.Size = new Size(112, 24);
            cargarDatosToolStripMenuItem.Text = "Cargar datos";
            cargarDatosToolStripMenuItem.Click += cargarDatosToolStripMenuItem_Click;
            // 
            // actualizarDatosToolStripMenuItem
            // 
            actualizarDatosToolStripMenuItem.ForeColor = SystemColors.Control;
            actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            actualizarDatosToolStripMenuItem.Size = new Size(136, 24);
            actualizarDatosToolStripMenuItem.Text = "Actualizar datos";
            actualizarDatosToolStripMenuItem.Click += actualizarDatosToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.ForeColor = SystemColors.Control;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(80, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(53, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conectaToolStripMenuItem });
            opcionesToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(87, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // conectaToolStripMenuItem
            // 
            conectaToolStripMenuItem.BackColor = Color.Brown;
            conectaToolStripMenuItem.ForeColor = SystemColors.Control;
            conectaToolStripMenuItem.Name = "conectaToolStripMenuItem";
            conectaToolStripMenuItem.Size = new Size(224, 26);
            conectaToolStripMenuItem.Text = "Conecta";
            conectaToolStripMenuItem.Click += conectaToolStripMenuItem_Click;
            // 
            // bt_refrescar
            // 
            bt_refrescar.BackColor = Color.Brown;
            bt_refrescar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_refrescar.ForeColor = SystemColors.ButtonFace;
            bt_refrescar.Location = new Point(12, 369);
            bt_refrescar.Name = "bt_refrescar";
            bt_refrescar.Size = new Size(153, 49);
            bt_refrescar.TabIndex = 39;
            bt_refrescar.Text = "Refrescar";
            bt_refrescar.UseVisualStyleBackColor = false;
            bt_refrescar.Click += button1_Click;
            // 
            // Viewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 434);
            Controls.Add(bt_refrescar);
            Controls.Add(Lb_Titulo);
            Controls.Add(Lsb_Alumnos);
            Controls.Add(menuStrip1);
            Name = "Viewer";
            Text = "Viewer";
            Load += Viewer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TablapRUEBA;
        private DataGridViewTextBoxColumn Prueba;
        private DataGridViewTextBoxColumn Column1;
        private ListBox Lsb_Alumnos;
        private Label Lb_Titulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem cargarDatosToolStripMenuItem;
        private ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem conectaToolStripMenuItem;
        private Button bt_refrescar;
    }
}
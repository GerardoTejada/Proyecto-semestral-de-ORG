namespace CRUD
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
            Lb_CreacionTitulo = new Label();
            Lb_ID = new Label();
            Txb_Nombre = new TextBox();
            Lb_Nombre = new Label();
            label1 = new Label();
            Txb_Cedula = new TextBox();
            Lb_Cedula = new Label();
            Lb_Semestre = new Label();
            Jornada = new Label();
            comboBox1 = new ComboBox();
            Rb_Matutina = new RadioButton();
            Rb_Vespertina = new RadioButton();
            Cb_Semestre = new ComboBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            Lb_Contraseña = new Label();
            Bt_Registrar = new Button();
            Bt_Cancelar = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lb_CreacionTitulo
            // 
            Lb_CreacionTitulo.AutoSize = true;
            Lb_CreacionTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_CreacionTitulo.ForeColor = SystemColors.ButtonHighlight;
            Lb_CreacionTitulo.Location = new Point(60, 10);
            Lb_CreacionTitulo.Name = "Lb_CreacionTitulo";
            Lb_CreacionTitulo.Size = new Size(302, 41);
            Lb_CreacionTitulo.TabIndex = 0;
            Lb_CreacionTitulo.Text = "Creación de registro";
            Lb_CreacionTitulo.Click += label1_Click;
            // 
            // Lb_ID
            // 
            Lb_ID.AutoSize = true;
            Lb_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_ID.Location = new Point(76, 139);
            Lb_ID.Name = "Lb_ID";
            Lb_ID.Size = new Size(0, 20);
            Lb_ID.TabIndex = 1;
            // 
            // Txb_Nombre
            // 
            Txb_Nombre.Location = new Point(130, 108);
            Txb_Nombre.Name = "Txb_Nombre";
            Txb_Nombre.Size = new Size(204, 27);
            Txb_Nombre.TabIndex = 3;
            Txb_Nombre.TextChanged += textBox1_TextChanged_1;
            // 
            // Lb_Nombre
            // 
            Lb_Nombre.AutoSize = true;
            Lb_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Nombre.Location = new Point(57, 113);
            Lb_Nombre.Name = "Lb_Nombre";
            Lb_Nombre.Size = new Size(67, 20);
            Lb_Nombre.TabIndex = 4;
            Lb_Nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 242);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 6;
            label1.Text = "Carrera";
            // 
            // Txb_Cedula
            // 
            Txb_Cedula.Location = new Point(130, 310);
            Txb_Cedula.Name = "Txb_Cedula";
            Txb_Cedula.Size = new Size(204, 27);
            Txb_Cedula.TabIndex = 7;
            Txb_Cedula.TextChanged += textBox3_TextChanged;
            // 
            // Lb_Cedula
            // 
            Lb_Cedula.AutoSize = true;
            Lb_Cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Cedula.Location = new Point(57, 317);
            Lb_Cedula.Name = "Lb_Cedula";
            Lb_Cedula.Size = new Size(56, 20);
            Lb_Cedula.TabIndex = 8;
            Lb_Cedula.Text = "Cédula";
            Lb_Cedula.Click += Lb_Cedula_Click;
            // 
            // Lb_Semestre
            // 
            Lb_Semestre.AutoSize = true;
            Lb_Semestre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Semestre.Location = new Point(384, 108);
            Lb_Semestre.Name = "Lb_Semestre";
            Lb_Semestre.Size = new Size(74, 20);
            Lb_Semestre.TabIndex = 10;
            Lb_Semestre.Text = "Semestre";
            // 
            // Jornada
            // 
            Jornada.AutoSize = true;
            Jornada.Location = new Point(334, 227);
            Jornada.Name = "Jornada";
            Jornada.Size = new Size(0, 20);
            Jornada.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Licenciatura en Desarrollo y Gestion en Software", "Ingenieria industrial", "Licenciatura en Topografia" });
            comboBox1.Location = new Point(130, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Rb_Matutina
            // 
            Rb_Matutina.AutoSize = true;
            Rb_Matutina.Location = new Point(10, 31);
            Rb_Matutina.Name = "Rb_Matutina";
            Rb_Matutina.Size = new Size(94, 24);
            Rb_Matutina.TabIndex = 14;
            Rb_Matutina.TabStop = true;
            Rb_Matutina.Text = "Matutina";
            Rb_Matutina.UseVisualStyleBackColor = true;
            Rb_Matutina.CheckedChanged += Rb_Matutina_CheckedChanged;
            // 
            // Rb_Vespertina
            // 
            Rb_Vespertina.AutoSize = true;
            Rb_Vespertina.Location = new Point(10, 61);
            Rb_Vespertina.Name = "Rb_Vespertina";
            Rb_Vespertina.Size = new Size(104, 24);
            Rb_Vespertina.TabIndex = 15;
            Rb_Vespertina.TabStop = true;
            Rb_Vespertina.Text = "Vespertina";
            Rb_Vespertina.UseVisualStyleBackColor = true;
            Rb_Vespertina.CheckedChanged += Rb_Vespertina_CheckedChanged;
            // 
            // Cb_Semestre
            // 
            Cb_Semestre.FormattingEnabled = true;
            Cb_Semestre.Items.AddRange(new object[] { "1° ", "2°", "3°", "4°", "5°", "6°", "7°", "8°", "9°", "10°" });
            Cb_Semestre.Location = new Point(477, 105);
            Cb_Semestre.Name = "Cb_Semestre";
            Cb_Semestre.Size = new Size(204, 28);
            Cb_Semestre.TabIndex = 16;
            Cb_Semestre.SelectedIndexChanged += Cb_Semestre_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Rb_Matutina);
            groupBox1.Controls.Add(Rb_Vespertina);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(384, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 125);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jornada";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Lb_Contraseña
            // 
            Lb_Contraseña.AutoSize = true;
            Lb_Contraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Contraseña.Location = new Point(36, 182);
            Lb_Contraseña.Name = "Lb_Contraseña";
            Lb_Contraseña.Size = new Size(88, 20);
            Lb_Contraseña.TabIndex = 19;
            Lb_Contraseña.Text = "Contraseña";
            Lb_Contraseña.Click += Lb_Contraseña_Click;
            // 
            // Bt_Registrar
            // 
            Bt_Registrar.BackColor = Color.Brown;
            Bt_Registrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bt_Registrar.ForeColor = SystemColors.ButtonHighlight;
            Bt_Registrar.Location = new Point(384, 299);
            Bt_Registrar.Name = "Bt_Registrar";
            Bt_Registrar.Size = new Size(124, 48);
            Bt_Registrar.TabIndex = 20;
            Bt_Registrar.Text = "Registrar";
            Bt_Registrar.UseVisualStyleBackColor = false;
            Bt_Registrar.Click += Bt_Registrar_Click;
            // 
            // Bt_Cancelar
            // 
            Bt_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bt_Cancelar.Location = new Point(539, 299);
            Bt_Cancelar.Name = "Bt_Cancelar";
            Bt_Cancelar.Size = new Size(124, 48);
            Bt_Cancelar.TabIndex = 38;
            Bt_Cancelar.Text = "Cancelar";
            Bt_Cancelar.UseVisualStyleBackColor = true;
            Bt_Cancelar.Click += Bt_Cancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(Lb_CreacionTitulo);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 62);
            panel1.TabIndex = 39;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 404);
            Controls.Add(panel1);
            Controls.Add(Bt_Cancelar);
            Controls.Add(Bt_Registrar);
            Controls.Add(Lb_Contraseña);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Controls.Add(Cb_Semestre);
            Controls.Add(comboBox1);
            Controls.Add(Jornada);
            Controls.Add(Lb_Semestre);
            Controls.Add(Lb_Cedula);
            Controls.Add(Txb_Cedula);
            Controls.Add(label1);
            Controls.Add(Lb_Nombre);
            Controls.Add(Txb_Nombre);
            Controls.Add(Lb_ID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_CreacionTitulo;
        private Label Lb_ID;
        private TextBox Txb_Nombre;
        private Label Lb_Nombre;
        private Label label1;
        private TextBox Txb_Cedula;
        private Label Lb_Cedula;
        private Label Lb_Semestre;
        private Label Jornada;
        private ComboBox comboBox1;
        private RadioButton Rb_Matutina;
        private RadioButton Rb_Vespertina;
        private ComboBox Cb_Semestre;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label Lb_Contraseña;
        private Button Bt_Registrar;
        private Button Bt_Cancelar;
        private Panel panel1;
    }
}

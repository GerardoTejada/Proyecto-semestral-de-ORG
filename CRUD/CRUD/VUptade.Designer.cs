namespace CRUD
{
    partial class VUptade
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
            Bt_Actualizar = new Button();
            Lb_Contraseña = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            Rb_Matutina = new RadioButton();
            Rb_Vespertina = new RadioButton();
            Cb_Semestre = new ComboBox();
            comboBox1 = new ComboBox();
            Jornada = new Label();
            Lb_Semestre = new Label();
            Lb_Cedula = new Label();
            Txb_Cedula = new TextBox();
            label1 = new Label();
            Lb_Nombre = new Label();
            Txb_Nombre = new TextBox();
            Lb_ID = new Label();
            Lb_CreacionTitulo = new Label();
            Bt_Cancelar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_Actualizar
            // 
            Bt_Actualizar.BackColor = Color.Brown;
            Bt_Actualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bt_Actualizar.ForeColor = SystemColors.Control;
            Bt_Actualizar.Location = new Point(447, 283);
            Bt_Actualizar.Name = "Bt_Actualizar";
            Bt_Actualizar.Size = new Size(136, 49);
            Bt_Actualizar.TabIndex = 36;
            Bt_Actualizar.Text = "Actualizar";
            Bt_Actualizar.UseVisualStyleBackColor = false;
            Bt_Actualizar.Click += Bt_Actualizar_Click;
            // 
            // Lb_Contraseña
            // 
            Lb_Contraseña.AutoSize = true;
            Lb_Contraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Contraseña.Location = new Point(21, 164);
            Lb_Contraseña.Name = "Lb_Contraseña";
            Lb_Contraseña.Size = new Size(88, 20);
            Lb_Contraseña.TabIndex = 35;
            Lb_Contraseña.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Rb_Matutina);
            groupBox1.Controls.Add(Rb_Vespertina);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(437, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 125);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jornada";
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
            // 
            // Cb_Semestre
            // 
            Cb_Semestre.FormattingEnabled = true;
            Cb_Semestre.Items.AddRange(new object[] { "1° ", "2°", "3°", "4°", "5°", "6°", "7°", "8°", "9°", "10°" });
            Cb_Semestre.Location = new Point(528, 100);
            Cb_Semestre.Name = "Cb_Semestre";
            Cb_Semestre.Size = new Size(204, 28);
            Cb_Semestre.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Licenciatura en Desarrollo y Gestion en Software", "Ingenieria industrial", "Licenciatura en Topografia" });
            comboBox1.Location = new Point(147, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 31;
            // 
            // Jornada
            // 
            Jornada.AutoSize = true;
            Jornada.Location = new Point(296, 172);
            Jornada.Name = "Jornada";
            Jornada.Size = new Size(0, 20);
            Jornada.TabIndex = 30;
            // 
            // Lb_Semestre
            // 
            Lb_Semestre.AutoSize = true;
            Lb_Semestre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lb_Semestre.Location = new Point(437, 100);
            Lb_Semestre.Name = "Lb_Semestre";
            Lb_Semestre.Size = new Size(74, 20);
            Lb_Semestre.TabIndex = 29;
            Lb_Semestre.Text = "Semestre";
            // 
            // Lb_Cedula
            // 
            Lb_Cedula.AutoSize = true;
            Lb_Cedula.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lb_Cedula.Location = new Point(46, 297);
            Lb_Cedula.Name = "Lb_Cedula";
            Lb_Cedula.Size = new Size(56, 20);
            Lb_Cedula.TabIndex = 28;
            Lb_Cedula.Text = "Cédula";
            // 
            // Txb_Cedula
            // 
            Txb_Cedula.Location = new Point(147, 299);
            Txb_Cedula.Name = "Txb_Cedula";
            Txb_Cedula.Size = new Size(204, 27);
            Txb_Cedula.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(42, 227);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 26;
            label1.Text = "Carrera";
            // 
            // Lb_Nombre
            // 
            Lb_Nombre.AutoSize = true;
            Lb_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Nombre.Location = new Point(42, 104);
            Lb_Nombre.Name = "Lb_Nombre";
            Lb_Nombre.Size = new Size(67, 20);
            Lb_Nombre.TabIndex = 25;
            Lb_Nombre.Text = "Nombre";
            // 
            // Txb_Nombre
            // 
            Txb_Nombre.Location = new Point(147, 101);
            Txb_Nombre.Name = "Txb_Nombre";
            Txb_Nombre.Size = new Size(204, 27);
            Txb_Nombre.TabIndex = 24;
            // 
            // Lb_ID
            // 
            Lb_ID.AutoSize = true;
            Lb_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_ID.Location = new Point(67, 92);
            Lb_ID.Name = "Lb_ID";
            Lb_ID.Size = new Size(0, 20);
            Lb_ID.TabIndex = 22;
            // 
            // Lb_CreacionTitulo
            // 
            Lb_CreacionTitulo.AutoSize = true;
            Lb_CreacionTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_CreacionTitulo.ForeColor = SystemColors.Control;
            Lb_CreacionTitulo.Location = new Point(57, 10);
            Lb_CreacionTitulo.Name = "Lb_CreacionTitulo";
            Lb_CreacionTitulo.Size = new Size(278, 41);
            Lb_CreacionTitulo.TabIndex = 21;
            Lb_CreacionTitulo.Text = "Actualizar registro";
            // 
            // Bt_Cancelar
            // 
            Bt_Cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bt_Cancelar.Location = new Point(596, 283);
            Bt_Cancelar.Name = "Bt_Cancelar";
            Bt_Cancelar.Size = new Size(136, 49);
            Bt_Cancelar.TabIndex = 37;
            Bt_Cancelar.Text = "Cancelar";
            Bt_Cancelar.UseVisualStyleBackColor = true;
            Bt_Cancelar.Click += Bt_Cancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Lb_CreacionTitulo);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 62);
            panel1.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(34, 10);
            label2.Name = "label2";
            label2.Size = new Size(0, 41);
            label2.TabIndex = 22;
            label2.Click += label2_Click;
            // 
            // VUptade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 366);
            Controls.Add(Bt_Cancelar);
            Controls.Add(Bt_Actualizar);
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
            Controls.Add(panel1);
            Name = "VUptade";
            Text = "VUptade";
            Load += VUptade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_Actualizar;
        private Label Lb_Contraseña;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton Rb_Matutina;
        private RadioButton Rb_Vespertina;
        private ComboBox Cb_Semestre;
        private ComboBox comboBox1;
        private Label Jornada;
        private Label Lb_Semestre;
        private Label Lb_Cedula;
        private TextBox Txb_Cedula;
        private Label label1;
        private Label Lb_Nombre;
        private TextBox Txb_Nombre;
        private Label Lb_ID;
        private Label Lb_CreacionTitulo;
        private Button Bt_Cancelar;
        private Panel panel1;
        private Label label2;
    }
}
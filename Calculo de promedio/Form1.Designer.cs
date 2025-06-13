namespace Calculo_de_promedio
{
    partial class frmSistema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistema));
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.gbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAcciones.SuspendLayout();
            this.gbPromedio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.pictureBox1);
            this.gbRegistro.Controls.Add(this.lblError);
            this.gbRegistro.Controls.Add(this.txtNota3);
            this.gbRegistro.Controls.Add(this.txtNota2);
            this.gbRegistro.Controls.Add(this.txtNota1);
            this.gbRegistro.Controls.Add(this.lblNota3);
            this.gbRegistro.Controls.Add(this.lblNota2);
            this.gbRegistro.Controls.Add(this.lblNota1);
            this.gbRegistro.Controls.Add(this.groupBox3);
            this.gbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbRegistro.Location = new System.Drawing.Point(15, 14);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(517, 274);
            this.gbRegistro.TabIndex = 0;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro de Notas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Calculo_de_promedio.Properties.Resources.icons8_usuario_100;
            this.pictureBox1.Location = new System.Drawing.Point(411, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(21, 226);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(49, 20);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Error";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(114, 151);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(274, 26);
            this.txtNota3.TabIndex = 8;
            this.tlpAyuda.SetToolTip(this.txtNota3, "Ingresa valores entre 0 y 10");
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(114, 97);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(274, 26);
            this.txtNota2.TabIndex = 7;
            this.tlpAyuda.SetToolTip(this.txtNota2, "Ingresa valores entre 0 y 10");
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(114, 43);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(274, 26);
            this.txtNota1.TabIndex = 6;
            this.tlpAyuda.SetToolTip(this.txtNota1, "Ingresa valores entre 0 y 10");
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(21, 154);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(62, 20);
            this.lblNota3.TabIndex = 5;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(21, 100);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(62, 20);
            this.lblNota2.TabIndex = 4;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(21, 46);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(62, 20);
            this.lblNota1.TabIndex = 3;
            this.lblNota1.Text = "Nota 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(541, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 274);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnRegistro);
            this.gbAcciones.Controls.Add(this.btnSalir);
            this.gbAcciones.Controls.Add(this.btnPromedio);
            this.gbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbAcciones.Location = new System.Drawing.Point(548, 14);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(240, 274);
            this.gbAcciones.TabIndex = 2;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.White;
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Image = global::Calculo_de_promedio.Properties.Resources.icons8_escoba_50;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(3, 113);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(234, 70);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Nuevo Registro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Calculo_de_promedio.Properties.Resources.icons8_salida_321;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(234, 70);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.BackColor = System.Drawing.Color.White;
            this.btnPromedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPromedio.Image = global::Calculo_de_promedio.Properties.Resources.icons8_agregar_propiedad_32;
            this.btnPromedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromedio.Location = new System.Drawing.Point(3, 22);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(234, 68);
            this.btnPromedio.TabIndex = 0;
            this.btnPromedio.Text = "Agregar Promedio";
            this.btnPromedio.UseVisualStyleBackColor = false;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.txtPromedio);
            this.gbPromedio.Controls.Add(this.lblPromedio);
            this.gbPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPromedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbPromedio.Location = new System.Drawing.Point(15, 294);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(773, 144);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(214, 63);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(380, 26);
            this.txtPromedio.TabIndex = 10;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(21, 66);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(172, 20);
            this.lblPromedio.TabIndex = 9;
            this.lblPromedio.Text = "Promedio Obtenido :";
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.IsBalloon = true;
            this.tlpAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyuda.ToolTipTitle = "Mensaje de Ayuda";
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbRegistro);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSistema";
            this.Text = "Sistema de notas ITR";
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAcciones.ResumeLayout(false);
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}


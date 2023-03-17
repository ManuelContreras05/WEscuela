namespace wEstudiantes
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
            this.grbTipoPersona = new System.Windows.Forms.GroupBox();
            this.radEstudiante = new System.Windows.Forms.RadioButton();
            this.radProfesor = new System.Windows.Forms.RadioButton();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbTipoPersona.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipoPersona
            // 
            this.grbTipoPersona.Controls.Add(this.radEstudiante);
            this.grbTipoPersona.Controls.Add(this.radProfesor);
            this.grbTipoPersona.Location = new System.Drawing.Point(13, 13);
            this.grbTipoPersona.Name = "grbTipoPersona";
            this.grbTipoPersona.Size = new System.Drawing.Size(200, 78);
            this.grbTipoPersona.TabIndex = 0;
            this.grbTipoPersona.TabStop = false;
            this.grbTipoPersona.Text = "Tipo de persona";
            // 
            // radEstudiante
            // 
            this.radEstudiante.AutoSize = true;
            this.radEstudiante.Location = new System.Drawing.Point(16, 43);
            this.radEstudiante.Name = "radEstudiante";
            this.radEstudiante.Size = new System.Drawing.Size(75, 17);
            this.radEstudiante.TabIndex = 1;
            this.radEstudiante.TabStop = true;
            this.radEstudiante.Text = "Estudiante";
            this.radEstudiante.UseVisualStyleBackColor = true;
            this.radEstudiante.CheckedChanged += new System.EventHandler(this.radEstudiante_CheckedChanged);
            // 
            // radProfesor
            // 
            this.radProfesor.AutoSize = true;
            this.radProfesor.Location = new System.Drawing.Point(16, 20);
            this.radProfesor.Name = "radProfesor";
            this.radProfesor.Size = new System.Drawing.Size(64, 17);
            this.radProfesor.TabIndex = 0;
            this.radProfesor.TabStop = true;
            this.radProfesor.Text = "Profesor";
            this.radProfesor.UseVisualStyleBackColor = true;
            this.radProfesor.CheckedChanged += new System.EventHandler(this.radProfesor_CheckedChanged);
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(289, 21);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(109, 40);
            this.btnCapturarDatos.TabIndex = 1;
            this.btnCapturarDatos.Text = "Capturar datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click_1);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(289, 78);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(109, 40);
            this.btnMostrarDatos.TabIndex = 2;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtCalificacion);
            this.grbDatos.Controls.Add(this.lblCalificacion);
            this.grbDatos.Controls.Add(this.txtSueldo);
            this.grbDatos.Controls.Add(this.lblSueldo);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Location = new System.Drawing.Point(29, 182);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(369, 186);
            this.grbDatos.TabIndex = 2;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de la persona";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(82, 95);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(147, 20);
            this.txtCalificacion.TabIndex = 5;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(15, 98);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 4;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(65, 60);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(147, 20);
            this.txtSueldo.TabIndex = 3;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(15, 67);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.grbTipoPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbTipoPersona.ResumeLayout(false);
            this.grbTipoPersona.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoPersona;
        private System.Windows.Forms.RadioButton radEstudiante;
        private System.Windows.Forms.RadioButton radProfesor;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}


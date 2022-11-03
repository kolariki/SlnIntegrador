namespace WindowsMostrar
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
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.bntHabitaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(105, 12);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarMedicos.TabIndex = 0;
            this.btnMostrarMedicos.Text = "Medicos";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // gridDatos
            // 
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(32, 115);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.Size = new System.Drawing.Size(137, 150);
            this.gridDatos.TabIndex = 1;
            // 
            // lstMostrar
            // 
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.Location = new System.Drawing.Point(175, 127);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(109, 147);
            this.lstMostrar.TabIndex = 2;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(609, 12);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(75, 23);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.Location = new System.Drawing.Point(590, 115);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(109, 147);
            this.lstHabitaciones.TabIndex = 4;
            // 
            // bntHabitaciones
            // 
            this.bntHabitaciones.Location = new System.Drawing.Point(349, 12);
            this.bntHabitaciones.Name = "bntHabitaciones";
            this.bntHabitaciones.Size = new System.Drawing.Size(90, 23);
            this.bntHabitaciones.TabIndex = 5;
            this.bntHabitaciones.Text = "Habitaciones";
            this.bntHabitaciones.UseVisualStyleBackColor = true;
            this.bntHabitaciones.Click += new System.EventHandler(this.bntHabitaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntHabitaciones);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.lstMostrar);
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.ListBox lstMostrar;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.Button bntHabitaciones;
    }
}


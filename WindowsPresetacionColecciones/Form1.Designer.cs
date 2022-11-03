namespace WindowsPresetacionColecciones
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
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(323, 124);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(128, 56);
            this.btnMostrarMedicos.TabIndex = 0;
            this.btnMostrarMedicos.Text = "Mostrar Medicos";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(91, 195);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(240, 150);
            this.gridMedicos.TabIndex = 1;
            // 
            // lstMostrar
            // 
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.Location = new System.Drawing.Point(410, 195);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(187, 160);
            this.lstMostrar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMostrar);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.ListBox lstMostrar;
    }
}


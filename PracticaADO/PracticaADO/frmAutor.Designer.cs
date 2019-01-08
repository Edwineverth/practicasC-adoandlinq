namespace PracticaADO
{
    partial class frmAutor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DtgAutor = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgAutor
            // 
            this.DtgAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAutor.Location = new System.Drawing.Point(146, 122);
            this.DtgAutor.Name = "DtgAutor";
            this.DtgAutor.Size = new System.Drawing.Size(610, 254);
            this.DtgAutor.TabIndex = 0;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(810, 39);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 518);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.DtgAutor);
            this.Name = "frmAutor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgAutor;
        private System.Windows.Forms.Button btnReporte;
    }
}


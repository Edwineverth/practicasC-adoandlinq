namespace Interfaz
{
    partial class frmProveedor
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.MaskedTextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.cmbCiu = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(165, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(76, 252);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fax  *:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Teléfono  *:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ciudad  *:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Direccion  *:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Representante  *:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre  *:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cedula  *:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id  :";
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(116, 16);
            this.txtCed.Mask = "9999999999";
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(68, 20);
            this.txtCed.TabIndex = 31;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(119, 47);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(175, 20);
            this.txtNom.TabIndex = 32;
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(119, 75);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(175, 20);
            this.txtRep.TabIndex = 33;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(119, 106);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(175, 20);
            this.txtDir.TabIndex = 34;
            // 
            // cmbCiu
            // 
            this.cmbCiu.FormattingEnabled = true;
            this.cmbCiu.Items.AddRange(new object[] {
            "MACHALA",
            "HUAQUILLAS",
            "PASAJE",
            "SANTA ROSA",
            "ARENILLAS"});
            this.cmbCiu.Location = new System.Drawing.Point(119, 136);
            this.cmbCiu.Name = "cmbCiu";
            this.cmbCiu.Size = new System.Drawing.Size(121, 21);
            this.cmbCiu.TabIndex = 35;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(119, 168);
            this.txtTel.Mask = "999999999";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(65, 20);
            this.txtTel.TabIndex = 36;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(119, 199);
            this.txtFax.Mask = "999999999";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(65, 20);
            this.txtFax.TabIndex = 37;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(241, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(53, 20);
            this.txtId.TabIndex = 38;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 291);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.cmbCiu);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txtCed;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtRep;
        public System.Windows.Forms.TextBox txtDir;
        public System.Windows.Forms.ComboBox cmbCiu;
        public System.Windows.Forms.MaskedTextBox txtTel;
        public System.Windows.Forms.MaskedTextBox txtFax;
        public System.Windows.Forms.TextBox txtId;
    }
}
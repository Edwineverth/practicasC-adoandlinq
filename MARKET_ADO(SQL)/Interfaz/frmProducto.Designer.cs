namespace Interfaz
{
    partial class frmProducto
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPreP = new System.Windows.Forms.TextBox();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
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
            this.txtStA = new System.Windows.Forms.TextBox();
            this.txtStM = new System.Windows.Forms.TextBox();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.btnProvBus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(305, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(53, 20);
            this.txtId.TabIndex = 56;
            // 
            // txtPreP
            // 
            this.txtPreP.Location = new System.Drawing.Point(139, 135);
            this.txtPreP.Name = "txtPreP";
            this.txtPreP.Size = new System.Drawing.Size(80, 20);
            this.txtPreP.TabIndex = 52;
            // 
            // txtUn
            // 
            this.txtUn.Location = new System.Drawing.Point(139, 73);
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(220, 20);
            this.txtUn.TabIndex = 51;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(139, 45);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(220, 20);
            this.txtNom.TabIndex = 50;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(212, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(123, 233);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Stock Minimo  *:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Stock Anual  *:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Precio Prov.  *:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Proveedor  *:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Unidad de Medida  *:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre  *:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Categoria  *:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Id  :";
            // 
            // txtStA
            // 
            this.txtStA.Location = new System.Drawing.Point(139, 165);
            this.txtStA.Name = "txtStA";
            this.txtStA.Size = new System.Drawing.Size(80, 20);
            this.txtStA.TabIndex = 57;
            // 
            // txtStM
            // 
            this.txtStM.Location = new System.Drawing.Point(139, 194);
            this.txtStM.Name = "txtStM";
            this.txtStM.Size = new System.Drawing.Size(80, 20);
            this.txtStM.TabIndex = 58;
            // 
            // cbxCat
            // 
            this.cbxCat.DisplayMember = "ds";
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(139, 14);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(125, 21);
            this.cbxCat.TabIndex = 59;
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(139, 102);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(169, 20);
            this.txtProv.TabIndex = 60;
            // 
            // btnProvBus
            // 
            this.btnProvBus.Location = new System.Drawing.Point(314, 98);
            this.btnProvBus.Name = "btnProvBus";
            this.btnProvBus.Size = new System.Drawing.Size(45, 23);
            this.btnProvBus.TabIndex = 61;
            this.btnProvBus.Text = "...";
            this.btnProvBus.UseVisualStyleBackColor = true;
            this.btnProvBus.Click += new System.EventHandler(this.btnProvBus_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 280);
            this.Controls.Add(this.btnProvBus);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.txtStM);
            this.Controls.Add(this.txtStA);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPreP);
            this.Controls.Add(this.txtUn);
            this.Controls.Add(this.txtNom);
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
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtPreP;
        public System.Windows.Forms.TextBox txtUn;
        public System.Windows.Forms.TextBox txtNom;
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
        public System.Windows.Forms.TextBox txtStA;
        public System.Windows.Forms.TextBox txtStM;
        public System.Windows.Forms.ComboBox cbxCat;
        public System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Button btnProvBus;
    }
}
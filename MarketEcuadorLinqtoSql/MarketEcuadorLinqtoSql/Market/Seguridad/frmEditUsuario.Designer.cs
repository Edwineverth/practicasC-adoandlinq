namespace Market.Seguridad
{
    partial class frmEditUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUsuario));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_grabar = new System.Windows.Forms.ToolStripButton();
            this.tool_cancelar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_ruta = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pict_foto = new System.Windows.Forms.PictureBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_grabar,
            this.tool_cancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_grabar
            // 
            this.tool_grabar.AccessibleDescription = "c";
            this.tool_grabar.Image = ((System.Drawing.Image)(resources.GetObject("tool_grabar.Image")));
            this.tool_grabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_grabar.Name = "tool_grabar";
            this.tool_grabar.Size = new System.Drawing.Size(62, 22);
            this.tool_grabar.Text = "&Grabar";
            this.tool_grabar.Click += new System.EventHandler(this.tool_grabar_Click);
            // 
            // tool_cancelar
            // 
            this.tool_cancelar.AccessibleDescription = "c";
            this.tool_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("tool_cancelar.Image")));
            this.tool_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_cancelar.Name = "tool_cancelar";
            this.tool_cancelar.Size = new System.Drawing.Size(72, 22);
            this.tool_cancelar.Text = "&Regresar";
            this.tool_cancelar.Click += new System.EventHandler(this.tool_cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_ruta);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pict_foto);
            this.panel1.Controls.Add(this.txttelefono);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtclave);
            this.panel1.Controls.Add(this.txtlogin);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtcedula);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtidusuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 359);
            this.panel1.TabIndex = 3;
            // 
            // lb_ruta
            // 
            this.lb_ruta.AutoSize = true;
            this.lb_ruta.BackColor = System.Drawing.Color.White;
            this.lb_ruta.Location = new System.Drawing.Point(391, 22);
            this.lb_ruta.Name = "lb_ruta";
            this.lb_ruta.Size = new System.Drawing.Size(0, 15);
            this.lb_ruta.TabIndex = 26;
            this.lb_ruta.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(579, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 15);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Imagen Usuario";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pict_foto
            // 
            this.pict_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pict_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pict_foto.Location = new System.Drawing.Point(494, 34);
            this.pict_foto.Name = "pict_foto";
            this.pict_foto.Size = new System.Drawing.Size(280, 302);
            this.pict_foto.TabIndex = 22;
            this.pict_foto.TabStop = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(129, 141);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttelefono.MaxLength = 15;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(210, 21);
            this.txttelefono.TabIndex = 5;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(129, 109);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdireccion.MaxLength = 50;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(210, 21);
            this.txtdireccion.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dirección:";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(129, 197);
            this.txtclave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtclave.MaxLength = 50;
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(210, 21);
            this.txtclave.TabIndex = 7;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(129, 169);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlogin.MaxLength = 20;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(210, 21);
            this.txtlogin.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(129, 80);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(210, 21);
            this.txtnombre.TabIndex = 3;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(129, 49);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcedula.MaxLength = 10;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(87, 21);
            this.txtcedula.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Logín:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cédula:";
            // 
            // txtidusuario
            // 
            this.txtidusuario.BackColor = System.Drawing.Color.White;
            this.txtidusuario.Location = new System.Drawing.Point(129, 17);
            this.txtidusuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(87, 21);
            this.txtidusuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Usuario:";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            // 
            // frmEditUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEditUsuario";
            this.Text = "USUARIO";
            this.Load += new System.EventHandler(this.frmEditUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_grabar;
        private System.Windows.Forms.ToolStripButton tool_cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_ruta;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.PictureBox pict_foto;
        public System.Windows.Forms.TextBox txttelefono;
        public System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtclave;
        public System.Windows.Forms.TextBox txtlogin;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
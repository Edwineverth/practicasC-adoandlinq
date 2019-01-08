namespace Market.Facturacion
{
    partial class frmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txtIde_Ped = new System.Windows.Forms.TextBox();
            this.btnselecclocal = new System.Windows.Forms.Button();
            this.lb_nfact = new System.Windows.Forms.Label();
            this.lb_iva2 = new System.Windows.Forms.Label();
            this.lb_TOTAL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_monto2 = new System.Windows.Forms.Label();
            this.lb_IVA = new System.Windows.Forms.Label();
            this.lb_MONTO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lb_FECHA = new System.Windows.Forms.Label();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtidlocal = new System.Windows.Forms.TextBox();
            this.btnalmacenar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtidguia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_DATE = new System.Windows.Forms.Label();
            this.lb_vend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblidtrans = new System.Windows.Forms.Label();
            this.btnselecttransportista = new System.Windows.Forms.Button();
            this.lblTransportista = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Total
            // 
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Total.Location = new System.Drawing.Point(98, 76);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(69, 25);
            this.lbl_Total.TabIndex = 1;
            // 
            // txtIde_Ped
            // 
            this.txtIde_Ped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIde_Ped.Location = new System.Drawing.Point(104, 41);
            this.txtIde_Ped.Name = "txtIde_Ped";
            this.txtIde_Ped.ReadOnly = true;
            this.txtIde_Ped.Size = new System.Drawing.Size(66, 21);
            this.txtIde_Ped.TabIndex = 16;
            // 
            // btnselecclocal
            // 
            this.btnselecclocal.Location = new System.Drawing.Point(172, 105);
            this.btnselecclocal.Name = "btnselecclocal";
            this.btnselecclocal.Size = new System.Drawing.Size(33, 23);
            this.btnselecclocal.TabIndex = 15;
            this.btnselecclocal.Text = "...";
            this.btnselecclocal.UseVisualStyleBackColor = true;
            this.btnselecclocal.Click += new System.EventHandler(this.btselectlocalClick);
            // 
            // lb_nfact
            // 
            this.lb_nfact.AutoSize = true;
            this.lb_nfact.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nfact.Location = new System.Drawing.Point(7, 46);
            this.lb_nfact.Name = "lb_nfact";
            this.lb_nfact.Size = new System.Drawing.Size(94, 16);
            this.lb_nfact.TabIndex = 0;
            this.lb_nfact.Text = "Número Pedido";
            // 
            // lb_iva2
            // 
            this.lb_iva2.ForeColor = System.Drawing.Color.Black;
            this.lb_iva2.Location = new System.Drawing.Point(98, 42);
            this.lb_iva2.Name = "lb_iva2";
            this.lb_iva2.Size = new System.Drawing.Size(69, 24);
            this.lb_iva2.TabIndex = 3;
            // 
            // lb_TOTAL
            // 
            this.lb_TOTAL.AutoSize = true;
            this.lb_TOTAL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TOTAL.ForeColor = System.Drawing.Color.Black;
            this.lb_TOTAL.Location = new System.Drawing.Point(24, 76);
            this.lb_TOTAL.Name = "lb_TOTAL";
            this.lb_TOTAL.Size = new System.Drawing.Size(49, 15);
            this.lb_TOTAL.TabIndex = 0;
            this.lb_TOTAL.Text = "TOTAL";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.lbl_Total);
            this.groupBox1.Controls.Add(this.lb_iva2);
            this.groupBox1.Controls.Add(this.lb_TOTAL);
            this.groupBox1.Controls.Add(this.lb_monto2);
            this.groupBox1.Controls.Add(this.lb_IVA);
            this.groupBox1.Controls.Add(this.lb_MONTO);
            this.groupBox1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Location = new System.Drawing.Point(590, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // lb_monto2
            // 
            this.lb_monto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_monto2.ForeColor = System.Drawing.Color.Black;
            this.lb_monto2.Location = new System.Drawing.Point(101, 16);
            this.lb_monto2.Name = "lb_monto2";
            this.lb_monto2.Size = new System.Drawing.Size(66, 15);
            this.lb_monto2.TabIndex = 2;
            // 
            // lb_IVA
            // 
            this.lb_IVA.AutoSize = true;
            this.lb_IVA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IVA.ForeColor = System.Drawing.Color.Black;
            this.lb_IVA.Location = new System.Drawing.Point(40, 40);
            this.lb_IVA.Name = "lb_IVA";
            this.lb_IVA.Size = new System.Drawing.Size(33, 15);
            this.lb_IVA.TabIndex = 1;
            this.lb_IVA.Text = "I.V.A";
            // 
            // lb_MONTO
            // 
            this.lb_MONTO.AutoSize = true;
            this.lb_MONTO.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MONTO.ForeColor = System.Drawing.Color.Black;
            this.lb_MONTO.Location = new System.Drawing.Point(18, 16);
            this.lb_MONTO.Name = "lb_MONTO";
            this.lb_MONTO.Size = new System.Drawing.Size(55, 15);
            this.lb_MONTO.TabIndex = 0;
            this.lb_MONTO.Text = "MONTO";
            this.lb_MONTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(99, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Guia de Remision";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImprimir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(422, 491);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 41);
            this.btnImprimir.TabIndex = 37;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // lb_FECHA
            // 
            this.lb_FECHA.AutoSize = true;
            this.lb_FECHA.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FECHA.Location = new System.Drawing.Point(12, 79);
            this.lb_FECHA.Name = "lb_FECHA";
            this.lb_FECHA.Size = new System.Drawing.Size(43, 16);
            this.lb_FECHA.TabIndex = 2;
            this.lb_FECHA.Text = "Fecha";
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalcularCosto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularCosto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcularCosto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCosto.Location = new System.Drawing.Point(280, 492);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(123, 40);
            this.btnCalcularCosto.TabIndex = 35;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcularCosto.UseVisualStyleBackColor = false;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 269);
            this.panel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "GUIA DETALLE";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.PRECIO,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(19, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 224);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.docleclickcelda);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellendedit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellenter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ITEM";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CODIGO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESCRIPCION";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.Name = "Column4";
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtidlocal
            // 
            this.txtidlocal.Enabled = false;
            this.txtidlocal.Location = new System.Drawing.Point(104, 107);
            this.txtidlocal.Name = "txtidlocal";
            this.txtidlocal.Size = new System.Drawing.Size(66, 20);
            this.txtidlocal.TabIndex = 7;
            // 
            // btnalmacenar
            // 
            this.btnalmacenar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnalmacenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalmacenar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnalmacenar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalmacenar.Location = new System.Drawing.Point(144, 492);
            this.btnalmacenar.Name = "btnalmacenar";
            this.btnalmacenar.Size = new System.Drawing.Size(113, 41);
            this.btnalmacenar.TabIndex = 36;
            this.btnalmacenar.Text = "Almacenar";
            this.btnalmacenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnalmacenar.UseVisualStyleBackColor = false;
            this.btnalmacenar.Click += new System.EventHandler(this.btnAlmacenarclick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.txtidguia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtIde_Ped);
            this.groupBox3.Controls.Add(this.btnselecclocal);
            this.groupBox3.Controls.Add(this.lb_nfact);
            this.groupBox3.Controls.Add(this.lb_FECHA);
            this.groupBox3.Controls.Add(this.txtidlocal);
            this.groupBox3.Controls.Add(this.lbl_DATE);
            this.groupBox3.Controls.Add(this.lb_vend);
            this.groupBox3.Location = new System.Drawing.Point(529, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 162);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // txtidguia
            // 
            this.txtidguia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidguia.Location = new System.Drawing.Point(104, 11);
            this.txtidguia.Name = "txtidguia";
            this.txtidguia.ReadOnly = true;
            this.txtidguia.Size = new System.Drawing.Size(66, 21);
            this.txtidguia.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Numero Guia";
            // 
            // lbl_DATE
            // 
            this.lbl_DATE.Location = new System.Drawing.Point(90, 79);
            this.lbl_DATE.Name = "lbl_DATE";
            this.lbl_DATE.Size = new System.Drawing.Size(75, 13);
            this.lbl_DATE.TabIndex = 3;
            // 
            // lb_vend
            // 
            this.lb_vend.AutoSize = true;
            this.lb_vend.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vend.ForeColor = System.Drawing.Color.Black;
            this.lb_vend.Location = new System.Drawing.Point(12, 107);
            this.lb_vend.Name = "lb_vend";
            this.lb_vend.Size = new System.Drawing.Size(40, 16);
            this.lb_vend.TabIndex = 5;
            this.lb_vend.Text = "Local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, -33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "GENERACIÓN DE FACTURA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.lblidtrans);
            this.groupBox2.Controls.Add(this.btnselecttransportista);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTransportista);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 127);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // lblidtrans
            // 
            this.lblidtrans.Location = new System.Drawing.Point(120, 64);
            this.lblidtrans.Name = "lblidtrans";
            this.lblidtrans.Size = new System.Drawing.Size(37, 21);
            this.lblidtrans.TabIndex = 35;
            // 
            // btnselecttransportista
            // 
            this.btnselecttransportista.Location = new System.Drawing.Point(358, 66);
            this.btnselecttransportista.Name = "btnselecttransportista";
            this.btnselecttransportista.Size = new System.Drawing.Size(33, 23);
            this.btnselecttransportista.TabIndex = 15;
            this.btnselecttransportista.Text = "...";
            this.btnselecttransportista.UseVisualStyleBackColor = true;
            this.btnselecttransportista.Click += new System.EventHandler(this.btnselecttransportista_Click);
            // 
            // lblTransportista
            // 
            this.lblTransportista.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportista.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTransportista.Location = new System.Drawing.Point(113, 66);
            this.lblTransportista.Name = "lblTransportista";
            this.lblTransportista.Size = new System.Drawing.Size(209, 21);
            this.lblTransportista.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(33, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Transportista";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnalmacenar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Total;
        public System.Windows.Forms.TextBox txtIde_Ped;
        private System.Windows.Forms.Button btnselecclocal;
        private System.Windows.Forms.Label lb_nfact;
        private System.Windows.Forms.Label lb_iva2;
        private System.Windows.Forms.Label lb_TOTAL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_monto2;
        private System.Windows.Forms.Label lb_IVA;
        private System.Windows.Forms.Label lb_MONTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnalmacenar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_FECHA;
        public System.Windows.Forms.TextBox txtidlocal;
        private System.Windows.Forms.Label lbl_DATE;
        private System.Windows.Forms.Label lb_vend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnselecttransportista;
        public System.Windows.Forms.Label lblTransportista;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtidguia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Label lblidtrans;
        private System.Windows.Forms.Button button1;
    }
}
namespace Market.Seguridad
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Administrar Usuarios");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ver Usuarios");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Mi Perfil");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cambiar Contraseña");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Mi Usuario", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Seguridad", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Administrar Proveedores");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ver Horarios");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Administrar Producto");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Administrar Categoria");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Administrar Local");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Inventario", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Factura");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Transportista");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Facturacion", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Reporte Proveedores");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Reporte Producto");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Reportes", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Location = new System.Drawing.Point(276, 6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1197, 614);
            this.panelMenu.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualPDFToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualPDFToolStripMenuItem
            // 
            this.manualPDFToolStripMenuItem.Name = "manualPDFToolStripMenuItem";
            this.manualPDFToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.manualPDFToolStripMenuItem.Text = "Manual PDF";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.17343F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.82657F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelMenu, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.65116F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1480, 626);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.DarkRed;
            this.treeView1.Location = new System.Drawing.Point(6, 6);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo5";
            treeNode1.Text = "Administrar Usuarios";
            treeNode2.Name = "Nodo23";
            treeNode2.Text = "Ver Usuarios";
            treeNode3.Name = "Nodo0";
            treeNode3.Text = "Mi Perfil";
            treeNode4.Name = "Nodo3";
            treeNode4.Text = "Cambiar Contraseña";
            treeNode5.Name = "Nodo0";
            treeNode5.Text = "Mi Usuario";
            treeNode6.Name = "Nodo0";
            treeNode6.Text = "Seguridad";
            treeNode7.Name = "Nodo2";
            treeNode7.Text = "Administrar Proveedores";
            treeNode8.Name = "Nodo22";
            treeNode8.Text = "Ver Horarios";
            treeNode9.Name = "Nodo0";
            treeNode9.Text = "Administrar Producto";
            treeNode10.Name = "Nodo0";
            treeNode10.Text = "Administrar Categoria";
            treeNode11.Name = "Nodo0";
            treeNode11.Text = "Administrar Local";
            treeNode12.Name = "Nodo14";
            treeNode12.Text = "Inventario";
            treeNode13.Name = "Factura";
            treeNode13.Text = "Factura";
            treeNode14.Name = "Nodo0";
            treeNode14.Text = "Transportista";
            treeNode15.Name = "Factura";
            treeNode15.Text = "Facturacion";
            treeNode16.Name = "nodo1";
            treeNode16.Text = "Reporte Proveedores";
            treeNode17.Name = "Nodo3";
            treeNode17.Text = "Reporte Producto";
            treeNode18.Name = "Nodo0";
            treeNode18.Text = "Reportes";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode15,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(261, 614);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 665);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMenu";
            this.Text = "SISTEMARKET ECUADOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualPDFToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TreeView treeView1;
    }
}
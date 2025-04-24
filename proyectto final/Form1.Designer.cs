namespace proyectto_final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosDeProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lproductos = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texname = new System.Windows.Forms.TextBox();
            this.tedescription = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.textstock = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnelminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.modificarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incioToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.ordenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incioToolStripMenuItem
            // 
            this.incioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.acerdeToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.incioToolStripMenuItem.Name = "incioToolStripMenuItem";
            this.incioToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.incioToolStripMenuItem.Text = "Incio";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.rolToolStripMenuItem});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertarToolStripMenuItem.Text = "Agregar";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.insertarToolStripMenuItem_Click);
            // 
            // ordenToolStripMenuItem
            // 
            this.ordenToolStripMenuItem.Name = "ordenToolStripMenuItem";
            this.ordenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenToolStripMenuItem.Text = "Orden de Compra";
            this.ordenToolStripMenuItem.Click += new System.EventHandler(this.ordenToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // acerdeToolStripMenuItem
            // 
            this.acerdeToolStripMenuItem.Name = "acerdeToolStripMenuItem";
            this.acerdeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acerdeToolStripMenuItem.Text = "Acerde";
            this.acerdeToolStripMenuItem.Click += new System.EventHandler(this.acerdeToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadosDeProveedores,
            this.modificarProveedor});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // listadosDeProveedores
            // 
            this.listadosDeProveedores.Name = "listadosDeProveedores";
            this.listadosDeProveedores.Size = new System.Drawing.Size(201, 22);
            this.listadosDeProveedores.Text = "Listados de Proveedores";
            this.listadosDeProveedores.Click += new System.EventHandler(this.listadosDeProveedores_Click);
            // 
            // modificarProveedor
            // 
            this.modificarProveedor.Name = "modificarProveedor";
            this.modificarProveedor.Size = new System.Drawing.Size(201, 22);
            this.modificarProveedor.Text = "Modificar Proveedor";
            this.modificarProveedor.Click += new System.EventHandler(this.modificarProveedor_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lproductos});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // Lproductos
            // 
            this.Lproductos.Name = "Lproductos";
            this.Lproductos.Size = new System.Drawing.Size(180, 22);
            this.Lproductos.Text = "Listado Productos";
            this.Lproductos.Click += new System.EventHandler(this.Lproductos_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeProductos,
            this.modificarOrdenToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // ordenesDeProductos
            // 
            this.ordenesDeProductos.Name = "ordenesDeProductos";
            this.ordenesDeProductos.Size = new System.Drawing.Size(191, 22);
            this.ordenesDeProductos.Text = "Ordenes de productos";
            this.ordenesDeProductos.Click += new System.EventHandler(this.ordenesDeProductos_Click);
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(12, 182);
            this.dgvproductos.Name = "dgvproductos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductos.Size = new System.Drawing.Size(591, 215);
            this.dgvproductos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock";
            // 
            // texname
            // 
            this.texname.Location = new System.Drawing.Point(113, 59);
            this.texname.Name = "texname";
            this.texname.Size = new System.Drawing.Size(243, 20);
            this.texname.TabIndex = 12;
            // 
            // tedescription
            // 
            this.tedescription.Location = new System.Drawing.Point(113, 85);
            this.tedescription.Name = "tedescription";
            this.tedescription.Size = new System.Drawing.Size(243, 20);
            this.tedescription.TabIndex = 13;
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(113, 114);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(136, 20);
            this.textprecio.TabIndex = 14;
            // 
            // textstock
            // 
            this.textstock.Location = new System.Drawing.Point(113, 140);
            this.textstock.Name = "textstock";
            this.textstock.Size = new System.Drawing.Size(106, 20);
            this.textstock.TabIndex = 15;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(432, 34);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(432, 64);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 17;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnelminar
            // 
            this.btnelminar.Location = new System.Drawing.Point(432, 94);
            this.btnelminar.Name = "btnelminar";
            this.btnelminar.Size = new System.Drawing.Size(75, 23);
            this.btnelminar.TabIndex = 18;
            this.btnelminar.Text = "Eliminar";
            this.btnelminar.UseVisualStyleBackColor = true;
            this.btnelminar.Click += new System.EventHandler(this.btnelminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Producto";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(113, 34);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 20;
            // 
            // modificarOrdenToolStripMenuItem
            // 
            this.modificarOrdenToolStripMenuItem.Name = "modificarOrdenToolStripMenuItem";
            this.modificarOrdenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.modificarOrdenToolStripMenuItem.Text = "Modificar Orden";
            this.modificarOrdenToolStripMenuItem.Click += new System.EventHandler(this.modificarOrdenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 409);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnelminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.textstock);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.tedescription);
            this.Controls.Add(this.texname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texname;
        private System.Windows.Forms.TextBox tedescription;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.TextBox textstock;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnelminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.ToolStripMenuItem listadosDeProveedores;
        private System.Windows.Forms.ToolStripMenuItem modificarProveedor;
        private System.Windows.Forms.ToolStripMenuItem Lproductos;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeProductos;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOrdenToolStripMenuItem;
    }
}


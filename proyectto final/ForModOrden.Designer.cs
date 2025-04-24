namespace proyectto_final
{
    partial class ForModOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForModOrden));
            System.Windows.Forms.Label id_OrdenLabel;
            System.Windows.Forms.Label id_ProductoLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioLabel;
            this.inventarioDBDataSet = new proyectto_final.InventarioDBDataSet();
            this.orden_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_productosTableAdapter = new proyectto_final.InventarioDBDataSetTableAdapters.orden_productosTableAdapter();
            this.tableAdapterManager = new proyectto_final.InventarioDBDataSetTableAdapters.TableAdapterManager();
            this.orden_productosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orden_productosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orden_productosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_OrdenTextBox = new System.Windows.Forms.TextBox();
            this.id_ProductoTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            id_OrdenLabel = new System.Windows.Forms.Label();
            id_ProductoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_productosBindingNavigator)).BeginInit();
            this.orden_productosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioDBDataSet
            // 
            this.inventarioDBDataSet.DataSetName = "InventarioDBDataSet";
            this.inventarioDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orden_productosBindingSource
            // 
            this.orden_productosBindingSource.DataMember = "orden_productos";
            this.orden_productosBindingSource.DataSource = this.inventarioDBDataSet;
            // 
            // orden_productosTableAdapter
            // 
            this.orden_productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.orden_compraTableAdapter = null;
            this.tableAdapterManager.orden_productosTableAdapter = this.orden_productosTableAdapter;
            this.tableAdapterManager.producto_proveedoresTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proyectto_final.InventarioDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orden_productosBindingNavigator
            // 
            this.orden_productosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orden_productosBindingNavigator.BindingSource = this.orden_productosBindingSource;
            this.orden_productosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orden_productosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orden_productosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orden_productosBindingNavigatorSaveItem});
            this.orden_productosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orden_productosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orden_productosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orden_productosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orden_productosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orden_productosBindingNavigator.Name = "orden_productosBindingNavigator";
            this.orden_productosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orden_productosBindingNavigator.Size = new System.Drawing.Size(527, 25);
            this.orden_productosBindingNavigator.TabIndex = 0;
            this.orden_productosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // orden_productosBindingNavigatorSaveItem
            // 
            this.orden_productosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orden_productosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orden_productosBindingNavigatorSaveItem.Image")));
            this.orden_productosBindingNavigatorSaveItem.Name = "orden_productosBindingNavigatorSaveItem";
            this.orden_productosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orden_productosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.orden_productosBindingNavigatorSaveItem.Click += new System.EventHandler(this.orden_productosBindingNavigatorSaveItem_Click);
            // 
            // orden_productosDataGridView
            // 
            this.orden_productosDataGridView.AutoGenerateColumns = false;
            this.orden_productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.orden_productosDataGridView.DataSource = this.orden_productosBindingSource;
            this.orden_productosDataGridView.Location = new System.Drawing.Point(12, 160);
            this.orden_productosDataGridView.Name = "orden_productosDataGridView";
            this.orden_productosDataGridView.Size = new System.Drawing.Size(444, 220);
            this.orden_productosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Orden";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Orden";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // id_OrdenLabel
            // 
            id_OrdenLabel.AutoSize = true;
            id_OrdenLabel.Location = new System.Drawing.Point(24, 46);
            id_OrdenLabel.Name = "id_OrdenLabel";
            id_OrdenLabel.Size = new System.Drawing.Size(51, 13);
            id_OrdenLabel.TabIndex = 2;
            id_OrdenLabel.Text = "Id Orden:";
            // 
            // id_OrdenTextBox
            // 
            this.id_OrdenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_productosBindingSource, "Id_Orden", true));
            this.id_OrdenTextBox.Location = new System.Drawing.Point(95, 43);
            this.id_OrdenTextBox.Name = "id_OrdenTextBox";
            this.id_OrdenTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_OrdenTextBox.TabIndex = 3;
            // 
            // id_ProductoLabel
            // 
            id_ProductoLabel.AutoSize = true;
            id_ProductoLabel.Location = new System.Drawing.Point(24, 72);
            id_ProductoLabel.Name = "id_ProductoLabel";
            id_ProductoLabel.Size = new System.Drawing.Size(65, 13);
            id_ProductoLabel.TabIndex = 4;
            id_ProductoLabel.Text = "Id Producto:";
            // 
            // id_ProductoTextBox
            // 
            this.id_ProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_productosBindingSource, "Id_Producto", true));
            this.id_ProductoTextBox.Location = new System.Drawing.Point(95, 69);
            this.id_ProductoTextBox.Name = "id_ProductoTextBox";
            this.id_ProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ProductoTextBox.TabIndex = 5;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(24, 98);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 6;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_productosBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(95, 95);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 7;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(24, 124);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 8;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_productosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(95, 121);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 9;
            // 
            // ForModOrden
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 413);
            this.Controls.Add(id_OrdenLabel);
            this.Controls.Add(this.id_OrdenTextBox);
            this.Controls.Add(id_ProductoLabel);
            this.Controls.Add(this.id_ProductoTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.orden_productosDataGridView);
            this.Controls.Add(this.orden_productosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForModOrden";
            this.Text = "Modificar Orden Producto";
            this.Load += new System.EventHandler(this.ForModOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_productosBindingNavigator)).EndInit();
            this.orden_productosBindingNavigator.ResumeLayout(false);
            this.orden_productosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_productosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventarioDBDataSet inventarioDBDataSet;
        private System.Windows.Forms.BindingSource orden_productosBindingSource;
        private InventarioDBDataSetTableAdapters.orden_productosTableAdapter orden_productosTableAdapter;
        private InventarioDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orden_productosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orden_productosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView orden_productosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox id_OrdenTextBox;
        private System.Windows.Forms.TextBox id_ProductoTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
    }
}
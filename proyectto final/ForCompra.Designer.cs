namespace proyectto_final
{
    partial class ForCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForCompra));
            System.Windows.Forms.Label id_OrdenLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label id_ProveedorLabel;
            System.Windows.Forms.Label totalLabel;
            this.inventarioDBDataSet = new proyectto_final.InventarioDBDataSet();
            this.orden_compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_compraTableAdapter = new proyectto_final.InventarioDBDataSetTableAdapters.orden_compraTableAdapter();
            this.tableAdapterManager = new proyectto_final.InventarioDBDataSetTableAdapters.TableAdapterManager();
            this.orden_compraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.orden_compraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orden_compraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_OrdenTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_ProveedorTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            id_OrdenLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            id_ProveedorLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_compraBindingNavigator)).BeginInit();
            this.orden_compraBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_compraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioDBDataSet
            // 
            this.inventarioDBDataSet.DataSetName = "InventarioDBDataSet";
            this.inventarioDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orden_compraBindingSource
            // 
            this.orden_compraBindingSource.DataMember = "orden_compra";
            this.orden_compraBindingSource.DataSource = this.inventarioDBDataSet;
            // 
            // orden_compraTableAdapter
            // 
            this.orden_compraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.orden_compraTableAdapter = this.orden_compraTableAdapter;
            this.tableAdapterManager.orden_productosTableAdapter = null;
            this.tableAdapterManager.producto_proveedoresTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proyectto_final.InventarioDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orden_compraBindingNavigator
            // 
            this.orden_compraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orden_compraBindingNavigator.BindingSource = this.orden_compraBindingSource;
            this.orden_compraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orden_compraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orden_compraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orden_compraBindingNavigatorSaveItem});
            this.orden_compraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orden_compraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orden_compraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orden_compraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orden_compraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orden_compraBindingNavigator.Name = "orden_compraBindingNavigator";
            this.orden_compraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orden_compraBindingNavigator.Size = new System.Drawing.Size(503, 25);
            this.orden_compraBindingNavigator.TabIndex = 0;
            this.orden_compraBindingNavigator.Text = "bindingNavigator1";
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
            // orden_compraBindingNavigatorSaveItem
            // 
            this.orden_compraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orden_compraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orden_compraBindingNavigatorSaveItem.Image")));
            this.orden_compraBindingNavigatorSaveItem.Name = "orden_compraBindingNavigatorSaveItem";
            this.orden_compraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orden_compraBindingNavigatorSaveItem.Text = "Guardar datos";
            this.orden_compraBindingNavigatorSaveItem.Click += new System.EventHandler(this.orden_compraBindingNavigatorSaveItem_Click);
            // 
            // orden_compraDataGridView
            // 
            this.orden_compraDataGridView.AutoGenerateColumns = false;
            this.orden_compraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_compraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.orden_compraDataGridView.DataSource = this.orden_compraBindingSource;
            this.orden_compraDataGridView.Location = new System.Drawing.Point(26, 160);
            this.orden_compraDataGridView.Name = "orden_compraDataGridView";
            this.orden_compraDataGridView.Size = new System.Drawing.Size(451, 220);
            this.orden_compraDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Orden";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Orden";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Proveedor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Proveedor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // id_OrdenLabel
            // 
            id_OrdenLabel.AutoSize = true;
            id_OrdenLabel.Location = new System.Drawing.Point(23, 47);
            id_OrdenLabel.Name = "id_OrdenLabel";
            id_OrdenLabel.Size = new System.Drawing.Size(51, 13);
            id_OrdenLabel.TabIndex = 2;
            id_OrdenLabel.Text = "Id Orden:";
            // 
            // id_OrdenTextBox
            // 
            this.id_OrdenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_compraBindingSource, "Id_Orden", true));
            this.id_OrdenTextBox.Location = new System.Drawing.Point(100, 44);
            this.id_OrdenTextBox.Name = "id_OrdenTextBox";
            this.id_OrdenTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_OrdenTextBox.TabIndex = 3;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(23, 74);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orden_compraBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(100, 70);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 5;
            // 
            // id_ProveedorLabel
            // 
            id_ProveedorLabel.AutoSize = true;
            id_ProveedorLabel.Location = new System.Drawing.Point(23, 99);
            id_ProveedorLabel.Name = "id_ProveedorLabel";
            id_ProveedorLabel.Size = new System.Drawing.Size(71, 13);
            id_ProveedorLabel.TabIndex = 6;
            id_ProveedorLabel.Text = "Id Proveedor:";
            // 
            // id_ProveedorTextBox
            // 
            this.id_ProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_compraBindingSource, "Id_Proveedor", true));
            this.id_ProveedorTextBox.Location = new System.Drawing.Point(100, 96);
            this.id_ProveedorTextBox.Name = "id_ProveedorTextBox";
            this.id_ProveedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_ProveedorTextBox.TabIndex = 7;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(23, 125);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_compraBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(100, 122);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 9;
            // 
            // ForCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 400);
            this.Controls.Add(id_OrdenLabel);
            this.Controls.Add(this.id_OrdenTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(id_ProveedorLabel);
            this.Controls.Add(this.id_ProveedorTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.orden_compraDataGridView);
            this.Controls.Add(this.orden_compraBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.ForCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_compraBindingNavigator)).EndInit();
            this.orden_compraBindingNavigator.ResumeLayout(false);
            this.orden_compraBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_compraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventarioDBDataSet inventarioDBDataSet;
        private System.Windows.Forms.BindingSource orden_compraBindingSource;
        private InventarioDBDataSetTableAdapters.orden_compraTableAdapter orden_compraTableAdapter;
        private InventarioDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orden_compraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orden_compraBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView orden_compraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox id_OrdenTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox id_ProveedorTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectto_final
{
    public partial class ForCategoria : Form
    {
        public ForCategoria()
        {
            InitializeComponent();
        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventarioDBDataSet);

        }

        private void ForCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDBDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.inventarioDBDataSet.productos);
            // TODO: esta línea de código carga datos en la tabla 'inventarioDBDataSet.orden_compra' Puede moverla o quitarla según sea necesario.
            this.orden_compraTableAdapter.Fill(this.inventarioDBDataSet.orden_compra);
            // TODO: esta línea de código carga datos en la tabla 'inventarioDBDataSet.orden_productos' Puede moverla o quitarla según sea necesario.
            this.orden_productosTableAdapter.Fill(this.inventarioDBDataSet.orden_productos);
            // TODO: esta línea de código carga datos en la tabla 'inventarioDBDataSet.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.inventarioDBDataSet.categorias);

        }
    }
}

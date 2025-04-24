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
    public partial class ForCompra : Form
    {
        public ForCompra()
        {
            InitializeComponent();
        }

        private void orden_compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orden_compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventarioDBDataSet);

        }

        private void ForCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDBDataSet.orden_compra' Puede moverla o quitarla según sea necesario.
            this.orden_compraTableAdapter.Fill(this.inventarioDBDataSet.orden_compra);

        }
    }
}

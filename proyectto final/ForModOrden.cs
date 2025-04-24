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
    public partial class ForModOrden : Form
    {
        public ForModOrden()
        {
            InitializeComponent();
        }

        private void orden_productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orden_productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventarioDBDataSet);

        }

        private void ForModOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDBDataSet.orden_productos' Puede moverla o quitarla según sea necesario.
            this.orden_productosTableAdapter.Fill(this.inventarioDBDataSet.orden_productos);

        }
    }
}

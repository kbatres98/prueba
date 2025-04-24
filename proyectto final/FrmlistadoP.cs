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
    public partial class FrmListadoP : Form
    {
        public FrmListadoP()
        {
            InitializeComponent();
        }

        private void FrmListadoP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDBDataSet.Viewproductos' Puede moverla o quitarla según sea necesario.
            this.viewproductosTableAdapter.Fill(this.inventarioDBDataSet.Viewproductos);

        }

        private void viewproductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

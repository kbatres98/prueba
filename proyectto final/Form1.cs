using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace proyectto_final
{
    public partial class Form1 : Form
    {

        private const string local = @"Server=FRTEC-SISTEM\SQLEXPRESS;Database= InventarioDB;Integrated Security=True;"; //Debe buscar la coneccion de su maquina.
        private string connectionString = local;
      
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id_Producto, Nombre, Descripcion, Precio, Stock FROM productos ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    da.Fill(dt);
                    dgvproductos.DataSource = dt;   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void ClearTextBoxes()
        {
            tedescription.Clear();
            texname.Clear();
            textID.Clear();
            textprecio.Clear();
            textstock.Clear();
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textID.Text))
            {
                MessageBox.Show("Debes indicar un ID para actualizar.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE productos
                             SET nombre = @nombre,
                                 descripcion = @descripcion,
                                 precio = @precio,
                                 stock = @stock
                             WHERE Id_Producto = @Id_producto;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", texname.Text);
                cmd.Parameters.AddWithValue("@descripcion", tedescription.Text);
                cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(textprecio.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(textstock.Text));
                cmd.Parameters.AddWithValue("@Id_producto", Convert.ToInt32(textID.Text));

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Procustos actualizado correctamente.");
                        ClearTextBoxes();
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el ID para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
        }

        private void btnelminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textID.Text))
            {
                MessageBox.Show("Debes indicar un ID para eliminar.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM productos WHERE  =Id_producto @Id_Producto;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_producto:", textID.Text);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        ClearTextBoxes();
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el ID para eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvproductos.Rows[e.RowIndex].Cells["Id_producto"].Value != null)
            {
                textID.Text = dgvproductos.Rows[e.RowIndex].Cells["Id_producto"].Value.ToString();
              textstock.Text = dgvproductos.Rows[e.RowIndex].Cells["stock"].Value.ToString();
                textprecio.Text = dgvproductos.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            }
        }

        private void Lproductos_Click(object sender, EventArgs e)
        {
            FrmListadoP listadoProductos = new FrmListadoP();
            listadoProductos.ShowDialog();
        }

        private void listadosDeProveedores_Click(object sender, EventArgs e)
        {
            FrmlistadoPrve listproverdores = new FrmlistadoPrve();
            listproverdores.ShowDialog();
        }

        private void modificarProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores modificarProveedores = new FrmProveedores();
            modificarProveedores.ShowDialog();
        }

        private void ordenesDeProductos_Click(object sender, EventArgs e)
        {
            FrmOrden ordenesdecompra = new FrmOrden();
            ordenesdecompra.ShowDialog();
        }

        private void acerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 acercaDe = new Form2();
            acercaDe.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForAyuda ayuda = new ForAyuda();
            ayuda.ShowDialog();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForROl rol = new ForROl();
            rol.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForCategoria categoria = new ForCategoria();
            categoria.ShowDialog();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForCompra ordenC = new ForCompra();
            ordenC.ShowDialog();
        }

        private void modificarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForModOrden modificarOrden = new ForModOrden(); 
            modificarOrden.ShowDialog();
        }
    }
  }


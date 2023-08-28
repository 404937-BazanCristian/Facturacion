using Facturacion.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Vistas
{
    public partial class FormRegistrarFacturas : Form
    {
        Factura nueva;
        public FormRegistrarFacturas()
        {
            InitializeComponent();
            nueva = new Factura();
        }

        private void FormRegistrarFacturas_Load(object sender, EventArgs e)
        {
            dtp_fecha.Value = DateTime.Today;
            txt_cliente.Text = "Consumidor Final";
            txt_cantidad.Text = "1";
            NumeroFactura();
            CargarFormasPago();
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            string CadenaConeccion = @"Data Source=DESKTOP-5M7KLI1\SQLEXPRESS;Initial Catalog=Facturacion;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(CadenaConeccion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("sp_articulos", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            cbo_articulos.DataSource = tabla;
            cbo_articulos.ValueMember = tabla.Columns[0].ColumnName;
            cbo_articulos.DisplayMember = tabla.Columns[1].ColumnName;
            cbo_articulos.SelectedIndex = -1;
        }

        private void CargarFormasPago()
        {
            string CadenaConeccion = @"Data Source=DESKTOP-5M7KLI1\SQLEXPRESS;Initial Catalog=Facturacion;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(CadenaConeccion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("sp_formas_pago", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            cbo_formasPago.DataSource = tabla;
            cbo_formasPago.ValueMember = tabla.Columns[0].ColumnName;
            cbo_formasPago.DisplayMember = tabla.Columns[1].ColumnName;
            cbo_formasPago.SelectedIndex = -1;
        }

        private void NumeroFactura()
        {
            string CadenaConeccion = @"Data Source=DESKTOP-5M7KLI1\SQLEXPRESS;Initial Catalog=Facturacion;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(CadenaConeccion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("sp_siguiente_factura", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@siguiente", SqlDbType.Int);
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();

            int siguiente;
            try
            {
                siguiente = Convert.ToInt32(parametro.Value);
            }
            catch (Exception)
            {
                siguiente = 1;
            }
            label_numero.Text = label_numero.Text + siguiente.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (dtp_fecha.Value > DateTime.Today)
            {
                MessageBox.Show("Debe colocar una fecha válida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtp_fecha.Focus();
                return;
            }

            if (cbo_formasPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un metodo de pago", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_formasPago.Focus();
                return;
            }

            if (cbo_articulos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un articulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_articulos.Focus();
                return;
            }

            try
            {
                if (Convert.ToInt32(txt_cantidad.Text) < 1)
                {
                    MessageBox.Show("Debe colocar una cantidad válida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_cantidad.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe colocar una cantidad válida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cantidad.Focus();
                return;
            }

            foreach (DataGridViewRow fila in dgv_facturacion.Rows)
            {
                foreach (DetalleFactura det in nueva.DetallesFactura)
                {
                    if (fila.Cells["col_articulo"].Value.ToString() == cbo_articulos.Text && fila.Cells["col_id"].Value.ToString() == det.Articulo.Codigo.ToString())
                    {
                        det.Cantidad += Convert.ToInt32(txt_cantidad.Text);
                        fila.Cells[3].Value = Convert.ToInt32(fila.Cells[3].Value) + Convert.ToInt32(txt_cantidad.Text);
                        return;
                    }
                }
            }

            DataRowView item = (DataRowView)cbo_articulos.SelectedItem;

            int codigo = Convert.ToInt32(item.Row.ItemArray[0]);
            string nombre = item.Row.ItemArray[1].ToString();
            double precio = Convert.ToDouble(item.Row.ItemArray[2]);
            Articulo articulo = new Articulo(codigo, nombre, precio);

            int cantidad = Convert.ToInt32(txt_cantidad.Text);
            DetalleFactura detalle = new DetalleFactura(articulo, cantidad);

            nueva.AgregarDetalle(detalle);
            dgv_facturacion.Rows.Add(detalle.Articulo.Codigo, detalle.Articulo.Nombre, detalle.Articulo.PrecioUnitario, detalle.Cantidad, "Quitar");
        }

        private void dgv_facturacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_facturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.RowIndex != 0)
            {
                nueva.QuitarDetalle(e.RowIndex);
                dgv_facturacion.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}

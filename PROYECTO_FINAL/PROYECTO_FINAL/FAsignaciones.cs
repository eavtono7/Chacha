using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROYECTO_FINAL
{
    public partial class FAsignaciones : Form
    {

        private int cant { get; set; }
        private int cant1;

        public FAsignaciones()
        {
            InitializeComponent();
            dgvAsignaciones.Columns.Add("origen", "ORIGEN");
            dgvAsignaciones.Columns.Add("destino", "DESTINO");
            dgvAsignaciones.Columns.Add("producto", "PRODUCTO");
            dgvAsignaciones.Columns.Add("cantidad", "CANTIDAD");
            dgvAsignaciones.Columns.Add("fecha", "FECHA");

            Limpiar();
            Combobox();

        }

       /* public FAsignaciones(String text)
        {

            InitializeComponent();
            cbxOrigen.Text = "Origen:" + text;
            cbxDestino.Text = "Destino:" + text;
            cbxProducto.Text = "Producto:" + text;
            txtCantidad.Text = "Cantidad" + text;

        }*/

        void Combobox()
        {
            String query = String.Format("SELECT CodSucursal FROM sucursal", cbxOrigen.Text);
            MySqlCommand comando = new MySqlCommand(query, BDcomun.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            cbxOrigen.Items.Clear();
            if (reader.HasRows)
                while (reader.Read())
                    cbxOrigen.Items.Add(reader.GetString("CodSucursal"));


            String query2 = String.Format("SELECT CodSucursal FROM sucursal", cbxDestino.Text);
            MySqlCommand comando2 = new MySqlCommand(query2, BDcomun.ObtenerConexion());
            MySqlDataReader reader2 = comando2.ExecuteReader();
            cbxDestino.Items.Clear();
            if (reader2.HasRows)
                while (reader2.Read())
                    cbxDestino.Items.Add(reader2.GetString("CodSucursal"));



            String _query = String.Format("SELECT CodProducto FROM producto", cbxProducto.Text);
            MySqlCommand _comando = new MySqlCommand(_query, BDcomun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            cbxProducto.Items.Clear();
            if (_reader.HasRows)
                while (_reader.Read())
                    cbxProducto.Items.Add(_reader.GetString("CodProducto"));
        }

        void Limpiar()
        {
            cbxOrigen.Items.Clear();
            cbxDestino.Items.Clear();
            cbxProducto.Items.Clear();
            txtCantidad.Clear();
            dtpFecha.ResetText();
        }

        private void FAsignaciones_Load(object sender, EventArgs e)
        {
            dgvAsignaciones.AllowUserToAddRows = false;
            dgvStockActual.AllowUserToAddRows = false;
            StockActual(dgvStockActual);
        }

        public void StockActual(DataGridView dvg)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("SELECT NombreProducto, CantidadDetalle  FROM detallestock WHERE CodSucursal = 1"), BDcomun.ObtenerConexion());
                MySqlDataAdapter ds = new MySqlDataAdapter(comando);
                DataTable dr = new DataTable();
                ds.Fill(dr);
                dvg.DataSource = dr;
            }

            catch
            {
                MessageBox.Show("ERROR");
            }
        }


         public void intento()
         {
             String query = String.Format("SELECT CantidadDetalle FROM detallestock WHERE CodSucursal = '{0}' and CodProducto = '{1}'", cbxOrigen.Text, cbxProducto.Text);
             MySqlCommand comando = new MySqlCommand(query, BDcomun.ObtenerConexion());
             MySqlDataReader reader = comando.ExecuteReader();
                 while (reader.Read())
                     cant1= reader.GetInt32("CantidadDetalle");
         }

      /*  public static int Actualizar(producto pProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = BDcomun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update producto set NombreProducto='{0}', TipoProducto='{1}', Cantidad ='{2}' where CodProducto={3}",
                pProducto.NombreProducto, pProducto.TipoProducto, pProducto.Cantidad, pProducto.CodProducto), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }*/


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            intento();
            cant = Convert.ToInt32(txtCantidad.Text);
            if (cant < cant1)
            {

                if (string.IsNullOrWhiteSpace(cbxOrigen.Text) || string.IsNullOrWhiteSpace(cbxDestino.Text) || string.IsNullOrWhiteSpace(cbxProducto.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(dtpFecha.Text))

                    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    dtpFecha.Format = DateTimePickerFormat.Custom;
                    dtpFecha.CustomFormat = "yyyy/MM/dd";

                    dgvAsignaciones.Rows.Add(cbxOrigen.Text, cbxDestino.Text, cbxProducto.Text, txtCantidad.Text, dtpFecha.Text);

                    cbxOrigen.Text = "";
                    cbxDestino.Text = "";
                    cbxProducto.Text = "";
                    txtCantidad.Text = "";
                    dtpFecha.Text = "";
                }
            }
            else

                MessageBox.Show("No hay suficiente cantidad en el stock");
        }
        public int fila { get; set; }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAsignaciones.Rows.RemoveAt(fila); //borrando todos los datos de la fila seleccionada de acuerdo al valor de "fila"
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No hay ninguna columna seleccionada"); //Cuando se intenta borrar una fila que no se seleccionó
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            MySqlCommand comando;

            try
            {
                foreach (DataGridViewRow row in dgvAsignaciones.Rows)
                {
                    comando = new MySqlCommand("Insert into envio values (?CodOrigen, ?CodDestino, ?CodProducto, ?CantidadEnvio, ?FechaHora) ", BDcomun.ObtenerConexion());

                    comando.Parameters.Add("?CodOrigen", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["origen"].Value);
                    comando.Parameters.Add("CodDestino", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["destino"].Value);
                    comando.Parameters.Add("?CodProducto", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["producto"].Value);
                    comando.Parameters.Add("?CantidadEnvio", MySqlDbType.Int16).Value = Convert.ToInt16(row.Cells["cantidad"].Value);
                    comando.Parameters.Add("?FechaHora", MySqlDbType.Date).Value = Convert.ToDateTime(row.Cells["fecha"].Value);

                    comando.ExecuteNonQuery();

                }

                MessageBox.Show("Datos Registrados");

                dgvAsignaciones.Rows.Clear();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAsignaciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsignaciones.SelectedRows.Count == 1)
            {
                string fila = dgvAsignaciones.CurrentRow.Cells[0].Value.ToString();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }
    }
}

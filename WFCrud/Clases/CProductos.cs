using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WFCrud.Clases
{
    internal class CProductos
    {
        public void MostarProductos(DataGridView Tabla_Productos)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "SELECT * FROM Inventario.Productos";
                Tabla_Productos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Tabla_Productos.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se han mostrado los datos de la base de datos. Error: " + ex.ToString());
            }
        }

        public void GuardarProductos(TextBox Nombre, TextBox Precio, TextBox Descripcion, DateTime FechaCreacion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "INSERT INTO Productos (Nombre, Precio, Descripcion, FechaCreacion) " +
                               "VALUES (@Nombre, @Precio, @Descripcion, @FechaCreacion)";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@Nombre", Nombre.Text);
                myComand.Parameters.AddWithValue("@Precio", Precio.Text);
                myComand.Parameters.AddWithValue("@Descripcion", Descripcion.Text);
                myComand.Parameters.AddWithValue("@FechaCreacion", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                int rowsAffected = myComand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Se guardó exitosamente el Producto");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Producto");
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar los datos en la base de datos. Error: " + ex.ToString());
            }
        }

        public void SeleccionarProductos(DataGridView Tabla_Producto, TextBox id, TextBox Nombre, TextBox Descripcion, TextBox Precio, DateTime FechaCreacion)
        {
            try
            {
                id.Text = Tabla_Producto.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = Tabla_Producto.CurrentRow.Cells[1].Value.ToString();
                Descripcion.Text = Tabla_Producto.CurrentRow.Cells[3].Value.ToString();
                Precio.Text = Tabla_Producto.CurrentRow.Cells[2].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido seleccionar el dato de la base de datos. Error: " + ex.ToString());
            }
        }

        public void ModificarProductos(TextBox Codigo, TextBox Nombre, TextBox Precio, TextBox Descripcion, DateTime FechaCreacion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Descripcion = @Descripcion, FechaCreacion = @FechaCreacion WHERE IdProducto = @IdProducto";

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@Nombre", Nombre.Text);
                myCommand.Parameters.AddWithValue("@Precio", Precio.Text);
                myCommand.Parameters.AddWithValue("@Descripcion", Descripcion.Text);
                myCommand.Parameters.AddWithValue("@FechaCreacion", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                myCommand.Parameters.AddWithValue("@IdProducto", Codigo.Text);

                int rowsAffected = myCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Se actualizó el producto exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto");
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar los datos de la base de datos. Error: " + ex.ToString());
            }
        }

        public void EliminarProductos(TextBox Codigo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myComand.Parameters.AddWithValue("@IdProducto", Codigo.Text);

                int rowsAffected = myComand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Se eliminó exitosamente el Producto");
                }
                else
                {
                    MessageBox.Show("No se encontró el Producto con ese ID para eliminar");
                }

                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha eliminado el Producto de la base de datos. Error: " + ex.ToString());
            }
        }
    }
}

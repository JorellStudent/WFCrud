using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.MostarProductos(Tabla_Productos);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar(object sender, EventArgs e)
        {
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.EliminarProductos(txt_Codigo);
            objetoProducto.MostarProductos(Tabla_Productos);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.GuardarProductos(txt_Nombre,txt_Precio,txt_Descripcion, DateTime.Now);
            objetoProducto.MostarProductos(Tabla_Productos);
        }

        private void Tabla_Productos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.SeleccionarProductos(Tabla_Productos,txt_Codigo,txt_Nombre,txt_Precio,txt_Descripcion, DateTime.Now);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Clases.CProductos objetoProducto = new Clases.CProductos();
            objetoProducto.ModificarProductos(txt_Codigo, txt_Nombre, txt_Precio, txt_Descripcion, DateTime.Now);
            objetoProducto.MostarProductos(Tabla_Productos);
        }
    }
}

namespace WFCrud
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BOX_PRODUCTOS = new System.Windows.Forms.GroupBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.Label_Codigo = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.Label_Descripcion = new System.Windows.Forms.Label();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Tabla_Productos = new System.Windows.Forms.DataGridView();
            this.BOX_PRODUCTOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // BOX_PRODUCTOS
            // 
            this.BOX_PRODUCTOS.Controls.Add(this.btn_Editar);
            this.BOX_PRODUCTOS.Controls.Add(this.btn_Eliminar);
            this.BOX_PRODUCTOS.Controls.Add(this.btn_Guardar);
            this.BOX_PRODUCTOS.Controls.Add(this.Label_Codigo);
            this.BOX_PRODUCTOS.Controls.Add(this.txt_Descripcion);
            this.BOX_PRODUCTOS.Controls.Add(this.txt_Precio);
            this.BOX_PRODUCTOS.Controls.Add(this.txt_Nombre);
            this.BOX_PRODUCTOS.Controls.Add(this.txt_Codigo);
            this.BOX_PRODUCTOS.Controls.Add(this.Label_Descripcion);
            this.BOX_PRODUCTOS.Controls.Add(this.Label_Precio);
            this.BOX_PRODUCTOS.Controls.Add(this.Label_Nombre);
            this.BOX_PRODUCTOS.Location = new System.Drawing.Point(12, 12);
            this.BOX_PRODUCTOS.Name = "BOX_PRODUCTOS";
            this.BOX_PRODUCTOS.Size = new System.Drawing.Size(552, 226);
            this.BOX_PRODUCTOS.TabIndex = 0;
            this.BOX_PRODUCTOS.TabStop = false;
            this.BOX_PRODUCTOS.Text = "PRODUCTOS";
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(291, 55);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(205, 30);
            this.btn_Editar.TabIndex = 12;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(291, 91);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(205, 30);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(291, 19);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(205, 30);
            this.btn_Guardar.TabIndex = 10;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Label_Codigo
            // 
            this.Label_Codigo.AutoSize = true;
            this.Label_Codigo.Location = new System.Drawing.Point(32, 26);
            this.Label_Codigo.Name = "Label_Codigo";
            this.Label_Codigo.Size = new System.Drawing.Size(46, 13);
            this.Label_Codigo.TabIndex = 8;
            this.Label_Codigo.Text = "Código :";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(84, 75);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(155, 20);
            this.txt_Descripcion.TabIndex = 7;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(84, 101);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(155, 20);
            this.txt_Precio.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(84, 49);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(155, 20);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Location = new System.Drawing.Point(84, 23);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(155, 20);
            this.txt_Codigo.TabIndex = 4;
            // 
            // Label_Descripcion
            // 
            this.Label_Descripcion.AutoSize = true;
            this.Label_Descripcion.Location = new System.Drawing.Point(9, 82);
            this.Label_Descripcion.Name = "Label_Descripcion";
            this.Label_Descripcion.Size = new System.Drawing.Size(69, 13);
            this.Label_Descripcion.TabIndex = 2;
            this.Label_Descripcion.Text = "Descripción :";
            this.Label_Descripcion.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.Location = new System.Drawing.Point(32, 108);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(46, 13);
            this.Label_Precio.TabIndex = 1;
            this.Label_Precio.Text = "Precio : ";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(28, 52);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(50, 13);
            this.Label_Nombre.TabIndex = 0;
            this.Label_Nombre.Text = "Nombre :";
            this.Label_Nombre.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Tabla_Productos
            // 
            this.Tabla_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Tabla_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Tabla_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Productos.Location = new System.Drawing.Point(16, 244);
            this.Tabla_Productos.Name = "Tabla_Productos";
            this.Tabla_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Tabla_Productos.Size = new System.Drawing.Size(548, 300);
            this.Tabla_Productos.TabIndex = 1;
            this.Tabla_Productos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tabla_Productos_CellMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 553);
            this.Controls.Add(this.Tabla_Productos);
            this.Controls.Add(this.BOX_PRODUCTOS);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BOX_PRODUCTOS.ResumeLayout(false);
            this.BOX_PRODUCTOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BOX_PRODUCTOS;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label Label_Descripcion;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_Codigo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView Tabla_Productos;
    }
}


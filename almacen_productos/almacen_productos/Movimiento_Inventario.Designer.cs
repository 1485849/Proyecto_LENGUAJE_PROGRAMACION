namespace almacen_productos
{
    partial class Movimiento_Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFecha_Hora_Movimiento = new System.Windows.Forms.TextBox();
            this.CantidadMovida = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.tbCantidad_Movida = new System.Windows.Forms.TextBox();
            this.tbID_Producto = new System.Windows.Forms.TextBox();
            this.tbTipo_Movimiento = new System.Windows.Forms.TextBox();
            this.tbID_Movimiento = new System.Windows.Forms.TextBox();
            this.Destino = new System.Windows.Forms.Label();
            this.Origen = new System.Windows.Forms.Label();
            this.FechaHora = new System.Windows.Forms.Label();
            this.IDProducto = new System.Windows.Forms.Label();
            this.Tipo_Movimiento = new System.Windows.Forms.Label();
            this.IDMovimiento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFecha_Hora_Movimiento
            // 
            this.tbFecha_Hora_Movimiento.Location = new System.Drawing.Point(182, 180);
            this.tbFecha_Hora_Movimiento.Multiline = true;
            this.tbFecha_Hora_Movimiento.Name = "tbFecha_Hora_Movimiento";
            this.tbFecha_Hora_Movimiento.Size = new System.Drawing.Size(275, 20);
            this.tbFecha_Hora_Movimiento.TabIndex = 33;
            // 
            // CantidadMovida
            // 
            this.CantidadMovida.AutoSize = true;
            this.CantidadMovida.Location = new System.Drawing.Point(30, 150);
            this.CantidadMovida.Name = "CantidadMovida";
            this.CantidadMovida.Size = new System.Drawing.Size(87, 13);
            this.CantidadMovida.TabIndex = 32;
            this.CantidadMovida.Text = "Cantidad Movida";
            this.CantidadMovida.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnbuscar.Location = new System.Drawing.Point(327, 302);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 31;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFiltrar.Location = new System.Drawing.Point(213, 302);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 30;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.Location = new System.Drawing.Point(100, 302);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(182, 248);
            this.tbDestino.Multiline = true;
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(275, 20);
            this.tbDestino.TabIndex = 28;
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(182, 216);
            this.tbOrigen.Multiline = true;
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(275, 20);
            this.tbOrigen.TabIndex = 27;
            // 
            // tbCantidad_Movida
            // 
            this.tbCantidad_Movida.Location = new System.Drawing.Point(182, 143);
            this.tbCantidad_Movida.Multiline = true;
            this.tbCantidad_Movida.Name = "tbCantidad_Movida";
            this.tbCantidad_Movida.Size = new System.Drawing.Size(275, 20);
            this.tbCantidad_Movida.TabIndex = 26;
            // 
            // tbID_Producto
            // 
            this.tbID_Producto.Location = new System.Drawing.Point(182, 107);
            this.tbID_Producto.Multiline = true;
            this.tbID_Producto.Name = "tbID_Producto";
            this.tbID_Producto.Size = new System.Drawing.Size(275, 20);
            this.tbID_Producto.TabIndex = 25;
            // 
            // tbTipo_Movimiento
            // 
            this.tbTipo_Movimiento.Location = new System.Drawing.Point(182, 72);
            this.tbTipo_Movimiento.Multiline = true;
            this.tbTipo_Movimiento.Name = "tbTipo_Movimiento";
            this.tbTipo_Movimiento.Size = new System.Drawing.Size(275, 20);
            this.tbTipo_Movimiento.TabIndex = 24;
            // 
            // tbID_Movimiento
            // 
            this.tbID_Movimiento.Location = new System.Drawing.Point(182, 42);
            this.tbID_Movimiento.Multiline = true;
            this.tbID_Movimiento.Name = "tbID_Movimiento";
            this.tbID_Movimiento.Size = new System.Drawing.Size(275, 20);
            this.tbID_Movimiento.TabIndex = 23;
            // 
            // Destino
            // 
            this.Destino.AutoSize = true;
            this.Destino.Location = new System.Drawing.Point(30, 251);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(43, 13);
            this.Destino.TabIndex = 22;
            this.Destino.Text = "Destino";
            // 
            // Origen
            // 
            this.Origen.AutoSize = true;
            this.Origen.Location = new System.Drawing.Point(30, 223);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(38, 13);
            this.Origen.TabIndex = 21;
            this.Origen.Text = "Origen";
            // 
            // FechaHora
            // 
            this.FechaHora.AutoSize = true;
            this.FechaHora.Location = new System.Drawing.Point(30, 187);
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.Size = new System.Drawing.Size(74, 13);
            this.FechaHora.TabIndex = 20;
            this.FechaHora.Text = "Fecha y Hora ";
            // 
            // IDProducto
            // 
            this.IDProducto.AutoSize = true;
            this.IDProducto.Location = new System.Drawing.Point(30, 114);
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.Size = new System.Drawing.Size(64, 13);
            this.IDProducto.TabIndex = 19;
            this.IDProducto.Text = "ID Producto";
            // 
            // Tipo_Movimiento
            // 
            this.Tipo_Movimiento.AutoSize = true;
            this.Tipo_Movimiento.Location = new System.Drawing.Point(30, 79);
            this.Tipo_Movimiento.Name = "Tipo_Movimiento";
            this.Tipo_Movimiento.Size = new System.Drawing.Size(85, 13);
            this.Tipo_Movimiento.TabIndex = 18;
            this.Tipo_Movimiento.Text = "Tipo Movimiento";
            // 
            // IDMovimiento
            // 
            this.IDMovimiento.AutoSize = true;
            this.IDMovimiento.Location = new System.Drawing.Point(30, 45);
            this.IDMovimiento.Name = "IDMovimiento";
            this.IDMovimiento.Size = new System.Drawing.Size(75, 13);
            this.IDMovimiento.TabIndex = 17;
            this.IDMovimiento.Text = "ID Movimiento";
            // 
            // Movimiento_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(473, 343);
            this.Controls.Add(this.tbFecha_Hora_Movimiento);
            this.Controls.Add(this.CantidadMovida);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.tbOrigen);
            this.Controls.Add(this.tbCantidad_Movida);
            this.Controls.Add(this.tbID_Producto);
            this.Controls.Add(this.tbTipo_Movimiento);
            this.Controls.Add(this.tbID_Movimiento);
            this.Controls.Add(this.Destino);
            this.Controls.Add(this.Origen);
            this.Controls.Add(this.FechaHora);
            this.Controls.Add(this.IDProducto);
            this.Controls.Add(this.Tipo_Movimiento);
            this.Controls.Add(this.IDMovimiento);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Movimiento_Inventario";
            this.Text = "Movimiento_Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFecha_Hora_Movimiento;
        private System.Windows.Forms.Label CantidadMovida;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.TextBox tbCantidad_Movida;
        private System.Windows.Forms.TextBox tbID_Producto;
        private System.Windows.Forms.TextBox tbTipo_Movimiento;
        private System.Windows.Forms.TextBox tbID_Movimiento;
        private System.Windows.Forms.Label Destino;
        private System.Windows.Forms.Label Origen;
        private System.Windows.Forms.Label FechaHora;
        private System.Windows.Forms.Label IDProducto;
        private System.Windows.Forms.Label Tipo_Movimiento;
        private System.Windows.Forms.Label IDMovimiento;
    }
}
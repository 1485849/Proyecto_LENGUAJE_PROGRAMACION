namespace almacen_productos
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
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.btnRegistrarProveedores = new System.Windows.Forms.Button();
            this.btnSalidas_Inventario = new System.Windows.Forms.Button();
            this.btnMovimientos_Inventario = new System.Windows.Forms.Button();
            this.btnEntradas_Inventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProducto.Location = new System.Drawing.Point(19, 208);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(164, 68);
            this.btnRegistrarProducto.TabIndex = 17;
            this.btnRegistrarProducto.Text = "Registro Productos";
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnRegistrarProveedores
            // 
            this.btnRegistrarProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrarProveedores.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProveedores.Location = new System.Drawing.Point(169, 323);
            this.btnRegistrarProveedores.Name = "btnRegistrarProveedores";
            this.btnRegistrarProveedores.Size = new System.Drawing.Size(164, 68);
            this.btnRegistrarProveedores.TabIndex = 18;
            this.btnRegistrarProveedores.Text = "Registro Proveedores";
            this.btnRegistrarProveedores.UseVisualStyleBackColor = false;
            this.btnRegistrarProveedores.Click += new System.EventHandler(this.btnRegistrarProveedores_Click);
            // 
            // btnSalidas_Inventario
            // 
            this.btnSalidas_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalidas_Inventario.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas_Inventario.Location = new System.Drawing.Point(477, 323);
            this.btnSalidas_Inventario.Name = "btnSalidas_Inventario";
            this.btnSalidas_Inventario.Size = new System.Drawing.Size(164, 68);
            this.btnSalidas_Inventario.TabIndex = 19;
            this.btnSalidas_Inventario.Text = "Salidas_Inventario";
            this.btnSalidas_Inventario.UseVisualStyleBackColor = false;
            // 
            // btnMovimientos_Inventario
            // 
            this.btnMovimientos_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMovimientos_Inventario.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos_Inventario.Location = new System.Drawing.Point(607, 208);
            this.btnMovimientos_Inventario.Name = "btnMovimientos_Inventario";
            this.btnMovimientos_Inventario.Size = new System.Drawing.Size(164, 68);
            this.btnMovimientos_Inventario.TabIndex = 20;
            this.btnMovimientos_Inventario.Text = "Movimientos_Inventario";
            this.btnMovimientos_Inventario.UseVisualStyleBackColor = false;
            // 
            // btnEntradas_Inventario
            // 
            this.btnEntradas_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEntradas_Inventario.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas_Inventario.Location = new System.Drawing.Point(316, 208);
            this.btnEntradas_Inventario.Name = "btnEntradas_Inventario";
            this.btnEntradas_Inventario.Size = new System.Drawing.Size(164, 68);
            this.btnEntradas_Inventario.TabIndex = 21;
            this.btnEntradas_Inventario.Text = "Entradas_Inventario";
            this.btnEntradas_Inventario.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnEntradas_Inventario);
            this.Controls.Add(this.btnMovimientos_Inventario);
            this.Controls.Add(this.btnSalidas_Inventario);
            this.Controls.Add(this.btnRegistrarProveedores);
            this.Controls.Add(this.btnRegistrarProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.Button btnRegistrarProveedores;
        private System.Windows.Forms.Button btnSalidas_Inventario;
        private System.Windows.Forms.Button btnMovimientos_Inventario;
        private System.Windows.Forms.Button btnEntradas_Inventario;
    }
}


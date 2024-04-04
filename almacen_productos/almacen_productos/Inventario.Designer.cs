namespace almacen_productos
{
    partial class Inventario
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
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnMovimientoInventario = new System.Windows.Forms.Button();
            this.btnInventarioEntrada = new System.Windows.Forms.Button();
            this.btnInventarioSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnvolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnvolver.Location = new System.Drawing.Point(83, 315);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(115, 25);
            this.btnvolver.TabIndex = 7;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnMovimientoInventario
            // 
            this.btnMovimientoInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMovimientoInventario.ForeColor = System.Drawing.Color.Blue;
            this.btnMovimientoInventario.Location = new System.Drawing.Point(57, 238);
            this.btnMovimientoInventario.Name = "btnMovimientoInventario";
            this.btnMovimientoInventario.Size = new System.Drawing.Size(161, 43);
            this.btnMovimientoInventario.TabIndex = 6;
            this.btnMovimientoInventario.Text = "Mivimiento de Inventario";
            this.btnMovimientoInventario.UseVisualStyleBackColor = false;
            // 
            // btnInventarioEntrada
            // 
            this.btnInventarioEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInventarioEntrada.ForeColor = System.Drawing.Color.Blue;
            this.btnInventarioEntrada.Location = new System.Drawing.Point(57, 165);
            this.btnInventarioEntrada.Name = "btnInventarioEntrada";
            this.btnInventarioEntrada.Size = new System.Drawing.Size(161, 43);
            this.btnInventarioEntrada.TabIndex = 5;
            this.btnInventarioEntrada.Text = "Inventario de Entrada";
            this.btnInventarioEntrada.UseVisualStyleBackColor = false;
            // 
            // btnInventarioSalida
            // 
            this.btnInventarioSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInventarioSalida.ForeColor = System.Drawing.Color.Blue;
            this.btnInventarioSalida.Location = new System.Drawing.Point(57, 88);
            this.btnInventarioSalida.Name = "btnInventarioSalida";
            this.btnInventarioSalida.Size = new System.Drawing.Size(161, 43);
            this.btnInventarioSalida.TabIndex = 4;
            this.btnInventarioSalida.Text = "Inventario de salida";
            this.btnInventarioSalida.UseVisualStyleBackColor = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(281, 418);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnMovimientoInventario);
            this.Controls.Add(this.btnInventarioEntrada);
            this.Controls.Add(this.btnInventarioSalida);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnMovimientoInventario;
        private System.Windows.Forms.Button btnInventarioEntrada;
        private System.Windows.Forms.Button btnInventarioSalida;
    }
}
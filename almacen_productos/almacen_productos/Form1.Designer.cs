﻿namespace almacen_productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbcategoria = new System.Windows.Forms.TextBox();
            this.tbprecio = new System.Windows.Forms.TextBox();
            this.tbunidaddemedida = new System.Windows.Forms.TextBox();
            this.dateTimePickerfechavencimiento = new System.Windows.Forms.TextBox();
            this.tbcantidad = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unidad de Medida";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de Vencimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(315, 101);
            this.tbnombre.Multiline = true;
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(431, 26);
            this.tbnombre.TabIndex = 9;
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(315, 139);
            this.tbdescripcion.Multiline = true;
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(431, 27);
            this.tbdescripcion.TabIndex = 10;
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(315, 174);
            this.tbcodigo.Multiline = true;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(431, 27);
            this.tbcodigo.TabIndex = 11;
            // 
            // tbcategoria
            // 
            this.tbcategoria.Location = new System.Drawing.Point(315, 209);
            this.tbcategoria.Multiline = true;
            this.tbcategoria.Name = "tbcategoria";
            this.tbcategoria.Size = new System.Drawing.Size(431, 27);
            this.tbcategoria.TabIndex = 12;
            // 
            // tbprecio
            // 
            this.tbprecio.Location = new System.Drawing.Point(315, 245);
            this.tbprecio.Multiline = true;
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(431, 27);
            this.tbprecio.TabIndex = 13;
            // 
            // tbunidaddemedida
            // 
            this.tbunidaddemedida.Location = new System.Drawing.Point(315, 277);
            this.tbunidaddemedida.Multiline = true;
            this.tbunidaddemedida.Name = "tbunidaddemedida";
            this.tbunidaddemedida.Size = new System.Drawing.Size(431, 27);
            this.tbunidaddemedida.TabIndex = 14;
            // 
            // dateTimePickerfechavencimiento
            // 
            this.dateTimePickerfechavencimiento.Location = new System.Drawing.Point(315, 313);
            this.dateTimePickerfechavencimiento.Multiline = true;
            this.dateTimePickerfechavencimiento.Name = "dateTimePickerfechavencimiento";
            this.dateTimePickerfechavencimiento.Size = new System.Drawing.Size(431, 27);
            this.dateTimePickerfechavencimiento.TabIndex = 15;
            // 
            // tbcantidad
            // 
            this.tbcantidad.Location = new System.Drawing.Point(315, 349);
            this.tbcantidad.Multiline = true;
            this.tbcantidad.Name = "tbcantidad";
            this.tbcantidad.Size = new System.Drawing.Size(431, 27);
            this.tbcantidad.TabIndex = 16;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(315, 423);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(147, 38);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbcantidad);
            this.Controls.Add(this.dateTimePickerfechavencimiento);
            this.Controls.Add(this.tbunidaddemedida);
            this.Controls.Add(this.tbprecio);
            this.Controls.Add(this.tbcategoria);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox tbcategoria;
        private System.Windows.Forms.TextBox tbprecio;
        private System.Windows.Forms.TextBox tbunidaddemedida;
        private System.Windows.Forms.TextBox dateTimePickerfechavencimiento;
        private System.Windows.Forms.TextBox tbcantidad;
        private System.Windows.Forms.Button btnRegistrar;
    }
}


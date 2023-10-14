namespace Actividad_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveEliminar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.labelCostoTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Indigo;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombre.Location = new System.Drawing.Point(44, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Indigo;
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtPrecio.Location = new System.Drawing.Point(180, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(177, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtClaveEliminar
            // 
            this.txtClaveEliminar.BackColor = System.Drawing.Color.Indigo;
            this.txtClaveEliminar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtClaveEliminar.Location = new System.Drawing.Point(757, 46);
            this.txtClaveEliminar.Name = "txtClaveEliminar";
            this.txtClaveEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtClaveEliminar.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Location = new System.Drawing.Point(338, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.Location = new System.Drawing.Point(492, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ordenar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.button3.Location = new System.Drawing.Point(628, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.BackColor = System.Drawing.Color.Indigo;
            this.listBoxProductos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.Location = new System.Drawing.Point(44, 209);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(236, 160);
            this.listBoxProductos.TabIndex = 8;
            // 
            // labelCostoTotal
            // 
            this.labelCostoTotal.AutoSize = true;
            this.labelCostoTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCostoTotal.Location = new System.Drawing.Point(335, 289);
            this.labelCostoTotal.Name = "labelCostoTotal";
            this.labelCostoTotal.Size = new System.Drawing.Size(63, 13);
            this.labelCostoTotal.TabIndex = 9;
            this.labelCostoTotal.Text = "Costo total: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(754, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID producto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCostoTotal);
            this.Controls.Add(this.listBoxProductos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtClaveEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tiendita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.Label labelCostoTotal;
        private System.Windows.Forms.Label label3;
    }
}


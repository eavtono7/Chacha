namespace PROYECTO_FINAL
{
    partial class FPedidos
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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.bVolver = new System.Windows.Forms.Button();
            this.bRealizarPedido = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(421, 47);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(485, 218);
            this.dgvPedido.TabIndex = 29;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(780, 322);
            this.bVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(126, 26);
            this.bVolver.TabIndex = 28;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bRealizarPedido
            // 
            this.bRealizarPedido.Location = new System.Drawing.Point(437, 322);
            this.bRealizarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRealizarPedido.Name = "bRealizarPedido";
            this.bRealizarPedido.Size = new System.Drawing.Size(147, 26);
            this.bRealizarPedido.TabIndex = 27;
            this.bRealizarPedido.Text = "Realizar Pedido";
            this.bRealizarPedido.UseVisualStyleBackColor = true;
            this.bRealizarPedido.Click += new System.EventHandler(this.bRealizarPedido_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(260, 276);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(121, 26);
            this.bEliminar.TabIndex = 26;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(54, 276);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(121, 26);
            this.bAgregar.TabIndex = 25;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(111, 202);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(270, 22);
            this.dtFecha.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(164, 166);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(216, 22);
            this.tbCantidad.TabIndex = 21;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(164, 134);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(216, 24);
            this.cbProducto.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Producto";
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(121, 97);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(260, 24);
            this.cbDestino.TabIndex = 18;
            // 
            // cbOrigen
            // 
            this.cbOrigen.Enabled = false;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(121, 59);
            this.cbOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(260, 24);
            this.cbOrigen.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Destino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Origen";
            // 
            // FPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 384);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bRealizarPedido);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FPedidos";
            this.Text = "FPedidos";
            this.Load += new System.EventHandler(this.FPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bRealizarPedido;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
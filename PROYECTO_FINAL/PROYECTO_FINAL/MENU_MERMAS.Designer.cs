namespace PROYECTO_FINAL
{
    partial class MENU_MERMAS
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
            this.bt_cantidades = new System.Windows.Forms.Button();
            this.bt_mapa = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cantidades
            // 
            this.bt_cantidades.Location = new System.Drawing.Point(163, 160);
            this.bt_cantidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cantidades.Name = "bt_cantidades";
            this.bt_cantidades.Size = new System.Drawing.Size(227, 76);
            this.bt_cantidades.TabIndex = 0;
            this.bt_cantidades.Text = "CANTIDAD DE INGREDIENTES PERDIDOS";
            this.bt_cantidades.UseVisualStyleBackColor = true;
            this.bt_cantidades.Click += new System.EventHandler(this.bt_cantidades_Click);
            // 
            // bt_mapa
            // 
            this.bt_mapa.Location = new System.Drawing.Point(163, 67);
            this.bt_mapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_mapa.Name = "bt_mapa";
            this.bt_mapa.Size = new System.Drawing.Size(227, 76);
            this.bt_mapa.TabIndex = 0;
            this.bt_mapa.Text = "MAPA DE MERMAS";
            this.bt_mapa.UseVisualStyleBackColor = true;
            this.bt_mapa.Click += new System.EventHandler(this.bt_mapa_Click);
            // 
            // bt_volver
            // 
            this.bt_volver.Location = new System.Drawing.Point(425, 386);
            this.bt_volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(129, 23);
            this.bt_volver.TabIndex = 1;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = true;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "REGISTRO DE MERMAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MENU_MERMAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.bt_mapa);
            this.Controls.Add(this.bt_cantidades);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MENU_MERMAS";
            this.Text = "MENU_MERMAS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cantidades;
        private System.Windows.Forms.Button bt_mapa;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.Button button1;
    }
}
﻿namespace PROYECTO_FINAL
{
    partial class MENU_PERSONAL
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGISTRAR - ACTUALIZAR A PERSONAL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 77);
            this.button2.TabIndex = 0;
            this.button2.Text = "BUSCAR PERSONAL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_volver
            // 
            this.bt_volver.Location = new System.Drawing.Point(416, 321);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(121, 26);
            this.bt_volver.TabIndex = 0;
            this.bt_volver.Text = "VOLVER";
            this.bt_volver.UseVisualStyleBackColor = true;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // MENU_PERSONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 348);
            this.Controls.Add(this.bt_volver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MENU_PERSONAL";
            this.Text = "MENU_PERSONAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_volver;
    }
}
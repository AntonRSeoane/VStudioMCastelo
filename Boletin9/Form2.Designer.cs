﻿namespace Boletin9
{
    partial class Form2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnPulsar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AccessibleDescription = "lblNombre";
            this.lblNombre.AccessibleName = "lblNombre";
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Blue;
            this.lblNombre.Location = new System.Drawing.Point(116, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(167, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Introduzca el nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Blue;
            this.lblCorreo.Location = new System.Drawing.Point(116, 138);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(158, 18);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Dirección de correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(290, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(290, 138);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 20);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // btnPulsar
            // 
            this.btnPulsar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPulsar.Location = new System.Drawing.Point(12, 371);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(776, 67);
            this.btnPulsar.TabIndex = 4;
            this.btnPulsar.Text = "Púlsame";
            this.btnPulsar.UseVisualStyleBackColor = true;
            this.btnPulsar.Click += new System.EventHandler(this.btnPulsar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPulsar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form2";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnPulsar;
    }
}
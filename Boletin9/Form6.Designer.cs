namespace Boletin9
{
    partial class Form6
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
            this.Prod1 = new System.Windows.Forms.TextBox();
            this.Prod2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Oper = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicación = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prod1
            // 
            this.Prod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod1.Location = new System.Drawing.Point(42, 80);
            this.Prod1.Multiline = true;
            this.Prod1.Name = "Prod1";
            this.Prod1.Size = new System.Drawing.Size(186, 249);
            this.Prod1.TabIndex = 0;
            // 
            // Prod2
            // 
            this.Prod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod2.Location = new System.Drawing.Point(317, 80);
            this.Prod2.Multiline = true;
            this.Prod2.Name = "Prod2";
            this.Prod2.Size = new System.Drawing.Size(186, 249);
            this.Prod2.TabIndex = 1;
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(585, 80);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(186, 249);
            this.resultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // Oper
            // 
            this.Oper.AutoSize = true;
            this.Oper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oper.Location = new System.Drawing.Point(246, 185);
            this.Oper.Name = "Oper";
            this.Oper.Size = new System.Drawing.Size(0, 37);
            this.Oper.TabIndex = 4;
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(12, 380);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(186, 58);
            this.suma.TabIndex = 5;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(204, 380);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(186, 58);
            this.resta.TabIndex = 6;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicación
            // 
            this.multiplicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicación.Location = new System.Drawing.Point(393, 380);
            this.multiplicación.Name = "multiplicación";
            this.multiplicación.Size = new System.Drawing.Size(186, 58);
            this.multiplicación.TabIndex = 7;
            this.multiplicación.Text = "X";
            this.multiplicación.UseVisualStyleBackColor = true;
            this.multiplicación.Click += new System.EventHandler(this.multiplicación_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(585, 380);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(186, 58);
            this.division.TabIndex = 8;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicación);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.Oper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.Prod2);
            this.Controls.Add(this.Prod1);
            this.Name = "Form6";
            this.Text = "Ejercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Prod1;
        private System.Windows.Forms.TextBox Prod2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Oper;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicación;
        private System.Windows.Forms.Button division;
    }
}
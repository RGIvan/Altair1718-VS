namespace Estrella
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
            this.btnRellenar = new System.Windows.Forms.Button();
            this.btnGirar = new System.Windows.Forms.Button();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRellenar
            // 
            this.btnRellenar.Location = new System.Drawing.Point(12, 10);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(75, 23);
            this.btnRellenar.TabIndex = 0;
            this.btnRellenar.Text = "Rellenar";
            this.btnRellenar.UseVisualStyleBackColor = true;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnGirar
            // 
            this.btnGirar.Location = new System.Drawing.Point(93, 10);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(75, 23);
            this.btnGirar.TabIndex = 1;
            this.btnGirar.Text = "Girar";
            this.btnGirar.UseVisualStyleBackColor = true;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(174, 10);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(78, 20);
            this.txtGiro.TabIndex = 2;
            this.txtGiro.Text = "0";
            this.txtGiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 404);
            this.Controls.Add(this.txtGiro);
            this.Controls.Add(this.btnGirar);
            this.Controls.Add(this.btnRellenar);
            this.Name = "Form1";
            this.Text = "Polígono estrellado";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.TextBox txtGiro;
    }
}


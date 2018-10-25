namespace Prueba
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
            this.Pane1 = new System.Windows.Forms.Panel();
            this.rellenar = new System.Windows.Forms.Button();
            this.vaciar = new System.Windows.Forms.Button();
            this.lineas = new System.Windows.Forms.Button();
            this.linea = new System.Windows.Forms.Button();
            this.rec = new System.Windows.Forms.Button();
            this.pol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pane1
            // 
            this.Pane1.BackColor = System.Drawing.Color.GhostWhite;
            this.Pane1.Location = new System.Drawing.Point(15, 14);
            this.Pane1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Pane1.Name = "Pane1";
            this.Pane1.Size = new System.Drawing.Size(856, 463);
            this.Pane1.TabIndex = 0;
            // 
            // rellenar
            // 
            this.rellenar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rellenar.Location = new System.Drawing.Point(784, 501);
            this.rellenar.Name = "rellenar";
            this.rellenar.Size = new System.Drawing.Size(87, 29);
            this.rellenar.TabIndex = 4;
            this.rellenar.Text = "Rellenar";
            this.rellenar.UseVisualStyleBackColor = true;
            this.rellenar.Click += new System.EventHandler(this.rellenar_Click);
            // 
            // vaciar
            // 
            this.vaciar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaciar.Location = new System.Drawing.Point(678, 501);
            this.vaciar.Name = "vaciar";
            this.vaciar.Size = new System.Drawing.Size(87, 29);
            this.vaciar.TabIndex = 5;
            this.vaciar.Text = "Vaciar";
            this.vaciar.UseVisualStyleBackColor = true;
            this.vaciar.Click += new System.EventHandler(this.vaciar_Click);
            // 
            // lineas
            // 
            this.lineas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineas.Location = new System.Drawing.Point(15, 501);
            this.lineas.Name = "lineas";
            this.lineas.Size = new System.Drawing.Size(87, 29);
            this.lineas.TabIndex = 6;
            this.lineas.Text = "Líneas";
            this.lineas.UseVisualStyleBackColor = true;
            this.lineas.Click += new System.EventHandler(this.lineas_Click);
            // 
            // linea
            // 
            this.linea.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linea.Location = new System.Drawing.Point(126, 501);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(87, 29);
            this.linea.TabIndex = 7;
            this.linea.Text = "Línea";
            this.linea.UseVisualStyleBackColor = true;
            this.linea.Click += new System.EventHandler(this.linea_Click);
            // 
            // rec
            // 
            this.rec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(241, 501);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(99, 29);
            this.rec.TabIndex = 8;
            this.rec.Text = "Rectángulo";
            this.rec.UseVisualStyleBackColor = true;
            this.rec.Click += new System.EventHandler(this.rec_Click);
            // 
            // pol
            // 
            this.pol.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol.Location = new System.Drawing.Point(365, 501);
            this.pol.Name = "pol";
            this.pol.Size = new System.Drawing.Size(87, 29);
            this.pol.TabIndex = 9;
            this.pol.Text = "Polígono";
            this.pol.UseVisualStyleBackColor = true;
            this.pol.Click += new System.EventHandler(this.pol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 552);
            this.Controls.Add(this.pol);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.lineas);
            this.Controls.Add(this.vaciar);
            this.Controls.Add(this.rellenar);
            this.Controls.Add(this.Pane1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Formas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pane1;
        private System.Windows.Forms.Button rellenar;
        private System.Windows.Forms.Button vaciar;
        private System.Windows.Forms.Button lineas;
        private System.Windows.Forms.Button linea;
        private System.Windows.Forms.Button rec;
        private System.Windows.Forms.Button pol;
    }
}


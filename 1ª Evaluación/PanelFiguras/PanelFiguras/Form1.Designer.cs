namespace PanelFiguras
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
            this.panel = new System.Windows.Forms.Panel();
            this.cbColores = new System.Windows.Forms.CheckBox();
            this.cbRelleno = new System.Windows.Forms.CheckBox();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.rbElipse = new System.Windows.Forms.RadioButton();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.panel.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightCyan;
            this.panel.Controls.Add(this.cbColores);
            this.panel.Controls.Add(this.cbRelleno);
            this.panel.Controls.Add(this.rbRectangulo);
            this.panel.Controls.Add(this.rbElipse);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 100);
            this.panel.TabIndex = 1;
            // 
            // cbColores
            // 
            this.cbColores.AutoSize = true;
            this.cbColores.Location = new System.Drawing.Point(14, 71);
            this.cbColores.Name = "cbColores";
            this.cbColores.Size = new System.Drawing.Size(127, 17);
            this.cbColores.TabIndex = 3;
            this.cbColores.Text = "Mostrar menú colores";
            this.cbColores.UseVisualStyleBackColor = true;
            this.cbColores.CheckedChanged += new System.EventHandler(this.cbColores_CheckedChanged);
            // 
            // cbRelleno
            // 
            this.cbRelleno.AutoSize = true;
            this.cbRelleno.Location = new System.Drawing.Point(101, 15);
            this.cbRelleno.Name = "cbRelleno";
            this.cbRelleno.Size = new System.Drawing.Size(62, 17);
            this.cbRelleno.TabIndex = 2;
            this.cbRelleno.Text = "Relleno";
            this.cbRelleno.UseVisualStyleBackColor = true;
            this.cbRelleno.CheckedChanged += new System.EventHandler(this.cbRelleno_CheckedChanged);
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Location = new System.Drawing.Point(14, 37);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbRectangulo.TabIndex = 1;
            this.rbRectangulo.TabStop = true;
            this.rbRectangulo.Text = "Rectángulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            this.rbRectangulo.CheckedChanged += new System.EventHandler(this.rbRectangulo_CheckedChanged);
            // 
            // rbElipse
            // 
            this.rbElipse.AutoSize = true;
            this.rbElipse.Location = new System.Drawing.Point(14, 14);
            this.rbElipse.Name = "rbElipse";
            this.rbElipse.Size = new System.Drawing.Size(53, 17);
            this.rbElipse.TabIndex = 0;
            this.rbElipse.TabStop = true;
            this.rbElipse.Text = "Elipse";
            this.rbElipse.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            this.gbColor.BackColor = System.Drawing.Color.Honeydew;
            this.gbColor.Controls.Add(this.rbVerde);
            this.gbColor.Controls.Add(this.rbAzul);
            this.gbColor.Controls.Add(this.rbRojo);
            this.gbColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbColor.Location = new System.Drawing.Point(12, 118);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(200, 129);
            this.gbColor.TabIndex = 4;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.Location = new System.Drawing.Point(14, 91);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(53, 17);
            this.rbVerde.TabIndex = 2;
            this.rbVerde.TabStop = true;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            this.rbVerde.CheckedChanged += new System.EventHandler(this.rbVerde_CheckedChanged);
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.Location = new System.Drawing.Point(14, 60);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(45, 17);
            this.rbAzul.TabIndex = 1;
            this.rbAzul.TabStop = true;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            this.rbAzul.CheckedChanged += new System.EventHandler(this.rbAzul_CheckedChanged);
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(14, 28);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(47, 17);
            this.rbRojo.TabIndex = 0;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            this.rbRojo.CheckedChanged += new System.EventHandler(this.rbRojo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(580, 257);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Panel Figuras";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.CheckBox cbColores;
        private System.Windows.Forms.CheckBox cbRelleno;
        private System.Windows.Forms.RadioButton rbRectangulo;
        private System.Windows.Forms.RadioButton rbElipse;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbVerde;
        private System.Windows.Forms.RadioButton rbAzul;
        private System.Windows.Forms.RadioButton rbRojo;
    }
}


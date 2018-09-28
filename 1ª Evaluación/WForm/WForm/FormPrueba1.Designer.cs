namespace WForm
{
    partial class FormPrueba1
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbCaja = new System.Windows.Forms.TextBox();
            this.rgbMujer = new System.Windows.Forms.RadioButton();
            this.rgbHombre = new System.Windows.Forms.RadioButton();
            this.lbCabecera = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(51, 136);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(68, 18);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(109, 203);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(143, 31);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbCaja
            // 
            this.txbCaja.Location = new System.Drawing.Point(121, 132);
            this.txbCaja.Name = "txbCaja";
            this.txbCaja.Size = new System.Drawing.Size(119, 25);
            this.txbCaja.TabIndex = 2;
            // 
            // rgbMujer
            // 
            this.rgbMujer.AutoSize = true;
            this.rgbMujer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rgbMujer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbMujer.Location = new System.Drawing.Point(298, 115);
            this.rgbMujer.Name = "rgbMujer";
            this.rgbMujer.Size = new System.Drawing.Size(67, 22);
            this.rgbMujer.TabIndex = 3;
            this.rgbMujer.TabStop = true;
            this.rgbMujer.Text = "Mujer";
            this.rgbMujer.UseVisualStyleBackColor = false;
            // 
            // rgbHombre
            // 
            this.rgbHombre.AutoSize = true;
            this.rgbHombre.BackColor = System.Drawing.Color.DarkOrange;
            this.rgbHombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbHombre.Location = new System.Drawing.Point(298, 167);
            this.rgbHombre.Name = "rgbHombre";
            this.rgbHombre.Size = new System.Drawing.Size(82, 22);
            this.rgbHombre.TabIndex = 4;
            this.rgbHombre.TabStop = true;
            this.rgbHombre.Text = "Hombre";
            this.rgbHombre.UseVisualStyleBackColor = false;
            // 
            // lbCabecera
            // 
            this.lbCabecera.BackColor = System.Drawing.Color.Beige;
            this.lbCabecera.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabecera.Location = new System.Drawing.Point(38, 25);
            this.lbCabecera.Name = "lbCabecera";
            this.lbCabecera.Size = new System.Drawing.Size(347, 51);
            this.lbCabecera.TabIndex = 5;
            this.lbCabecera.Text = "Hola";
            this.lbCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrueba1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(489, 414);
            this.Controls.Add(this.lbCabecera);
            this.Controls.Add(this.rgbHombre);
            this.Controls.Add(this.rgbMujer);
            this.Controls.Add(this.txbCaja);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbNombre);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrueba1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.FormPrueba1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbCaja;
        private System.Windows.Forms.RadioButton rgbMujer;
        private System.Windows.Forms.RadioButton rgbHombre;
        private System.Windows.Forms.Label lbCabecera;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}


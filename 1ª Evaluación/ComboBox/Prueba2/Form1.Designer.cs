namespace Prueba2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtNombreColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEligeColor = new System.Windows.Forms.Button();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbColor
            // 
            this.lbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbColor.Location = new System.Drawing.Point(103, 67);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(300, 120);
            this.lbColor.TabIndex = 5;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(103, 222);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(300, 30);
            this.cbColor.TabIndex = 16;
            this.cbColor.Text = "Elige un color";
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Location = new System.Drawing.Point(160, 307);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(100, 29);
            this.txtNombreColor.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre Color";
            // 
            // btnEligeColor
            // 
            this.btnEligeColor.Location = new System.Drawing.Point(278, 307);
            this.btnEligeColor.Name = "btnEligeColor";
            this.btnEligeColor.Size = new System.Drawing.Size(146, 29);
            this.btnEligeColor.TabIndex = 19;
            this.btnEligeColor.Text = "Elige Color";
            this.btnEligeColor.UseVisualStyleBackColor = true;
            this.btnEligeColor.Click += new System.EventHandler(this.btnEligeColor_Click);
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(278, 354);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(195, 33);
            this.btnAnyadir.TabIndex = 20;
            this.btnAnyadir.Text = "Añadir al Combo";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(160, 359);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 29);
            this.txtPrecio.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.btnEligeColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreColor);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEligeColor;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}


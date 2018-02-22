namespace ProyWin_Roales_Iván
{
    partial class UIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbComida = new System.Windows.Forms.ToolStripButton();
            this.tsbRestaurante = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(110, 110);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuarios,
            this.tsbComida,
            this.tsbRestaurante});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(885, 131);
            this.toolStrip1.TabIndex = 2;
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuarios.Image")));
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(114, 128);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbComida
            // 
            this.tsbComida.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbComida.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbComida.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbComida.Image = ((System.Drawing.Image)(resources.GetObject("tsbComida.Image")));
            this.tsbComida.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbComida.Name = "tsbComida";
            this.tsbComida.Size = new System.Drawing.Size(114, 128);
            this.tsbComida.Tag = "";
            this.tsbComida.Text = "Comida";
            this.tsbComida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbComida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbRestaurante
            // 
            this.tsbRestaurante.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbRestaurante.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbRestaurante.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbRestaurante.Image = ((System.Drawing.Image)(resources.GetObject("tsbRestaurante.Image")));
            this.tsbRestaurante.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbRestaurante.Name = "tsbRestaurante";
            this.tsbRestaurante.Size = new System.Drawing.Size(124, 128);
            this.tsbRestaurante.Text = "Restaurante";
            this.tsbRestaurante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbRestaurante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 501);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UIPrincipal";
            this.Text = "UIPrincipal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbComida;
        private System.Windows.Forms.ToolStripButton tsbRestaurante;
    }
}
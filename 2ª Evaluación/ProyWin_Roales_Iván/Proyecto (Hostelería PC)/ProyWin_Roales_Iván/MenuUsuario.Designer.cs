namespace InterfazUsuario
{
    partial class MenuUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbProductos = new System.Windows.Forms.ToolStripButton();
            this.tsbRestaurante = new System.Windows.Forms.ToolStripButton();
            this.btnVolver = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(110, 110);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuarios,
            this.tsbProductos,
            this.tsbRestaurante});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(491, 139);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "UIUsuario";
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuarios.Image")));
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(184, 136);
            this.tsbUsuarios.Text = "Modificar usuario";
            this.tsbUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
            // 
            // tsbProductos
            // 
            this.tsbProductos.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbProductos.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbProductos.Image = ((System.Drawing.Image)(resources.GetObject("tsbProductos.Image")));
            this.tsbProductos.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbProductos.Name = "tsbProductos";
            this.tsbProductos.Size = new System.Drawing.Size(114, 136);
            this.tsbProductos.Tag = "";
            this.tsbProductos.Text = "Productos";
            this.tsbProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbProductos.Click += new System.EventHandler(this.tsbProductos_Click);
            // 
            // tsbRestaurante
            // 
            this.tsbRestaurante.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbRestaurante.ForeColor = System.Drawing.Color.DarkRed;
            this.tsbRestaurante.Image = ((System.Drawing.Image)(resources.GetObject("tsbRestaurante.Image")));
            this.tsbRestaurante.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsbRestaurante.Name = "tsbRestaurante";
            this.tsbRestaurante.Size = new System.Drawing.Size(134, 136);
            this.tsbRestaurante.Text = "Restaurantes";
            this.tsbRestaurante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbRestaurante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRestaurante.Click += new System.EventHandler(this.tsbRestaurante_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Maroon;
            this.btnVolver.Location = new System.Drawing.Point(404, 148);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(491, 183);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuUsuario";
            this.Text = "Menú Usuario";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbProductos;
        private System.Windows.Forms.ToolStripButton tsbRestaurante;
        private System.Windows.Forms.Button btnVolver;
    }
}
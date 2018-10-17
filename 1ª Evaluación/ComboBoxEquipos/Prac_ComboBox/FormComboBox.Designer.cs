namespace Prac_ComboBox
{
    partial class FormComboBox
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrir1 = new System.Windows.Forms.Button();
            this.btnAnyadir1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIndex1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar1 = new System.Windows.Forms.Button();
            this.lbNumEquipos1 = new System.Windows.Forms.Label();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.tEquipo1 = new System.Windows.Forms.TextBox();
            this.cbEquipos1 = new System.Windows.Forms.ComboBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.opFileDlgAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.lbPtos = new System.Windows.Forms.Label();
            this.lbPG = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.txtPG = new System.Windows.Forms.TextBox();
            this.lbPE = new System.Windows.Forms.Label();
            this.txtPE = new System.Windows.Forms.TextBox();
            this.lbPP = new System.Windows.Forms.Label();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPP);
            this.groupBox1.Controls.Add(this.lbPP);
            this.groupBox1.Controls.Add(this.txtPE);
            this.groupBox1.Controls.Add(this.lbPE);
            this.groupBox1.Controls.Add(this.txtPG);
            this.groupBox1.Controls.Add(this.txtPuntos);
            this.groupBox1.Controls.Add(this.lbPG);
            this.groupBox1.Controls.Add(this.lbPtos);
            this.groupBox1.Controls.Add(this.btnAbrir1);
            this.groupBox1.Controls.Add(this.btnAnyadir1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbIndex1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsertar1);
            this.groupBox1.Controls.Add(this.lbNumEquipos1);
            this.groupBox1.Controls.Add(this.btnEliminar1);
            this.groupBox1.Controls.Add(this.tEquipo1);
            this.groupBox1.Controls.Add(this.cbEquipos1);
            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 360);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Combo Sencillo";
            // 
            // btnAbrir1
            // 
            this.btnAbrir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir1.Location = new System.Drawing.Point(302, 316);
            this.btnAbrir1.Name = "btnAbrir1";
            this.btnAbrir1.Size = new System.Drawing.Size(87, 29);
            this.btnAbrir1.TabIndex = 32;
            this.btnAbrir1.Text = "Abrir";
            this.btnAbrir1.UseVisualStyleBackColor = true;
            this.btnAbrir1.Click += new System.EventHandler(this.btnAbrir1_Click);
            // 
            // btnAnyadir1
            // 
            this.btnAnyadir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnyadir1.Location = new System.Drawing.Point(116, 316);
            this.btnAnyadir1.Name = "btnAnyadir1";
            this.btnAnyadir1.Size = new System.Drawing.Size(87, 29);
            this.btnAnyadir1.TabIndex = 31;
            this.btnAnyadir1.Text = "Añadir";
            this.btnAnyadir1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 14);
            this.label4.TabIndex = 30;
            this.label4.Text = "Equipo seleccionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "Equipo";
            // 
            // lbIndex1
            // 
            this.lbIndex1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbIndex1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex1.Location = new System.Drawing.Point(15, 203);
            this.lbIndex1.MaxLength = 8;
            this.lbIndex1.Name = "lbIndex1";
            this.lbIndex1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbIndex1.Size = new System.Drawing.Size(82, 49);
            this.lbIndex1.TabIndex = 27;
            this.lbIndex1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nº de Equipos";
            // 
            // btnInsertar1
            // 
            this.btnInsertar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar1.Location = new System.Drawing.Point(209, 316);
            this.btnInsertar1.Name = "btnInsertar1";
            this.btnInsertar1.Size = new System.Drawing.Size(87, 29);
            this.btnInsertar1.TabIndex = 25;
            this.btnInsertar1.Text = "Insertar";
            this.btnInsertar1.UseVisualStyleBackColor = true;
            this.btnInsertar1.Click += new System.EventHandler(this.btnInsertar1_Click);
            // 
            // lbNumEquipos1
            // 
            this.lbNumEquipos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbNumEquipos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumEquipos1.Location = new System.Drawing.Point(67, 65);
            this.lbNumEquipos1.Name = "lbNumEquipos1";
            this.lbNumEquipos1.Size = new System.Drawing.Size(63, 25);
            this.lbNumEquipos1.TabIndex = 24;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar1.Location = new System.Drawing.Point(23, 316);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(87, 29);
            this.btnEliminar1.TabIndex = 23;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // tEquipo1
            // 
            this.tEquipo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tEquipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEquipo1.Location = new System.Drawing.Point(103, 203);
            this.tEquipo1.MaxLength = 8;
            this.tEquipo1.Name = "tEquipo1";
            this.tEquipo1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tEquipo1.Size = new System.Drawing.Size(243, 49);
            this.tEquipo1.TabIndex = 22;
            // 
            // cbEquipos1
            // 
            this.cbEquipos1.DropDownHeight = 206;
            this.cbEquipos1.DropDownWidth = 114;
            this.cbEquipos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEquipos1.FormattingEnabled = true;
            this.cbEquipos1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbEquipos1.IntegralHeight = false;
            this.cbEquipos1.ItemHeight = 24;
            this.cbEquipos1.Items.AddRange(new object[] {
            "Sevilla",
            "Carmona"});
            this.cbEquipos1.Location = new System.Drawing.Point(66, 125);
            this.cbEquipos1.MaxDropDownItems = 5;
            this.cbEquipos1.Name = "cbEquipos1";
            this.cbEquipos1.Size = new System.Drawing.Size(250, 32);
            this.cbEquipos1.TabIndex = 21;
            this.cbEquipos1.SelectedIndexChanged += new System.EventHandler(this.cbEquipos1_SelectedIndexChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Lime;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(104, 422);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(174, 26);
            this.rb1.TabIndex = 23;
            this.rb1.TabStop = true;
            this.rb1.Text = "Combo Sencillo";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Lime;
            this.rb2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(431, 422);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(250, 26);
            this.rb2.TabIndex = 24;
            this.rb2.Text = "Combo enlazado a Lista";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // opFileDlgAbrirArchivo
            // 
            this.opFileDlgAbrirArchivo.FileName = "opFileDlgAbrirArchivo";
            // 
            // lbPtos
            // 
            this.lbPtos.AutoSize = true;
            this.lbPtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPtos.Location = new System.Drawing.Point(20, 272);
            this.lbPtos.Name = "lbPtos";
            this.lbPtos.Size = new System.Drawing.Size(32, 14);
            this.lbPtos.TabIndex = 33;
            this.lbPtos.Text = "Ptos";
            // 
            // lbPG
            // 
            this.lbPG.AutoSize = true;
            this.lbPG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPG.Location = new System.Drawing.Point(105, 272);
            this.lbPG.Name = "lbPG";
            this.lbPG.Size = new System.Drawing.Size(22, 14);
            this.lbPG.TabIndex = 34;
            this.lbPG.Text = "PG";
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(58, 269);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(38, 20);
            this.txtPuntos.TabIndex = 35;
            // 
            // txtPG
            // 
            this.txtPG.Location = new System.Drawing.Point(135, 269);
            this.txtPG.Name = "txtPG";
            this.txtPG.Size = new System.Drawing.Size(38, 20);
            this.txtPG.TabIndex = 36;
            // 
            // lbPE
            // 
            this.lbPE.AutoSize = true;
            this.lbPE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPE.Location = new System.Drawing.Point(181, 272);
            this.lbPE.Name = "lbPE";
            this.lbPE.Size = new System.Drawing.Size(20, 14);
            this.lbPE.TabIndex = 37;
            this.lbPE.Text = "PE";
            // 
            // txtPE
            // 
            this.txtPE.Location = new System.Drawing.Point(209, 269);
            this.txtPE.Name = "txtPE";
            this.txtPE.Size = new System.Drawing.Size(38, 20);
            this.txtPE.TabIndex = 38;
            // 
            // lbPP
            // 
            this.lbPP.AutoSize = true;
            this.lbPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPP.Location = new System.Drawing.Point(257, 272);
            this.lbPP.Name = "lbPP";
            this.lbPP.Size = new System.Drawing.Size(21, 14);
            this.lbPP.TabIndex = 39;
            this.lbPP.Text = "PP";
            // 
            // txtPP
            // 
            this.txtPP.Location = new System.Drawing.Point(284, 269);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(38, 20);
            this.txtPP.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(332, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 41;
            this.label5.Text = "PP";
            // 
            // FormComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(797, 555);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormComboBox";
            this.Text = "Ejemplo ComboBox";
            this.Load += new System.EventHandler(this.FormComboBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tEquipo1;
        private System.Windows.Forms.ComboBox cbEquipos1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Label lbNumEquipos1;
        private System.Windows.Forms.Button btnInsertar1;
        private System.Windows.Forms.Button btnAnyadir1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbIndex1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog opFileDlgAbrirArchivo;
        private System.Windows.Forms.Button btnAbrir1;
        private System.Windows.Forms.Label lbPtos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.Label lbPP;
        private System.Windows.Forms.TextBox txtPE;
        private System.Windows.Forms.Label lbPE;
        private System.Windows.Forms.TextBox txtPG;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label lbPG;
    }
}


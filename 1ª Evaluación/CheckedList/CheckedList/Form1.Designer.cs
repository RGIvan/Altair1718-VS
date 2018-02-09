namespace CheckedList
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDosClics = new System.Windows.Forms.RadioButton();
            this.rbtnUnClic = new System.Windows.Forms.RadioButton();
            this.multiColumn = new System.Windows.Forms.CheckBox();
            this.ordenAlfabetico = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del equipo a añadir";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(94, 105);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(184, 31);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir Equipo";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "A la vez",
            "Antonio, F.C.",
            "Betis",
            "Cádiz",
            "erer",
            "Osa suna",
            "Sevilla"});
            this.checkedListBox1.Location = new System.Drawing.Point(94, 150);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(451, 130);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(94, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(184, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar selección";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvertir.Location = new System.Drawing.Point(94, 352);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(184, 31);
            this.btnInvertir.TabIndex = 5;
            this.btnInvertir.Text = "Invertir selección";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.rbtnDosClics);
            this.groupBox1.Controls.Add(this.rbtnUnClic);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(94, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clics";
            // 
            // rbtnDosClics
            // 
            this.rbtnDosClics.AutoSize = true;
            this.rbtnDosClics.Location = new System.Drawing.Point(12, 51);
            this.rbtnDosClics.Name = "rbtnDosClics";
            this.rbtnDosClics.Size = new System.Drawing.Size(97, 22);
            this.rbtnDosClics.TabIndex = 1;
            this.rbtnDosClics.TabStop = true;
            this.rbtnDosClics.Text = "Dos clics";
            this.rbtnDosClics.UseVisualStyleBackColor = true;
            this.rbtnDosClics.CheckedChanged += new System.EventHandler(this.rbtnDosClics_CheckedChanged);
            // 
            // rbtnUnClic
            // 
            this.rbtnUnClic.AutoSize = true;
            this.rbtnUnClic.Location = new System.Drawing.Point(12, 23);
            this.rbtnUnClic.Name = "rbtnUnClic";
            this.rbtnUnClic.Size = new System.Drawing.Size(78, 22);
            this.rbtnUnClic.TabIndex = 0;
            this.rbtnUnClic.TabStop = true;
            this.rbtnUnClic.Text = "Un clic";
            this.rbtnUnClic.UseVisualStyleBackColor = true;
            this.rbtnUnClic.CheckedChanged += new System.EventHandler(this.rbtnUnClic_CheckedChanged);
            // 
            // multiColumn
            // 
            this.multiColumn.AutoSize = true;
            this.multiColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiColumn.Location = new System.Drawing.Point(360, 409);
            this.multiColumn.Name = "multiColumn";
            this.multiColumn.Size = new System.Drawing.Size(118, 22);
            this.multiColumn.TabIndex = 7;
            this.multiColumn.Text = "Multicolumn";
            this.multiColumn.UseVisualStyleBackColor = true;
            this.multiColumn.CheckedChanged += new System.EventHandler(this.multiColumn_CheckedChanged);
            // 
            // ordenAlfabetico
            // 
            this.ordenAlfabetico.AutoSize = true;
            this.ordenAlfabetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenAlfabetico.Location = new System.Drawing.Point(360, 460);
            this.ordenAlfabetico.Name = "ordenAlfabetico";
            this.ordenAlfabetico.Size = new System.Drawing.Size(151, 22);
            this.ordenAlfabetico.TabIndex = 8;
            this.ordenAlfabetico.Text = "Orden alfabético";
            this.ordenAlfabetico.UseVisualStyleBackColor = true;
            this.ordenAlfabetico.CheckedChanged += new System.EventHandler(this.ordenAlfabetico_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 536);
            this.Controls.Add(this.ordenAlfabetico);
            this.Controls.Add(this.multiColumn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "CheckedList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDosClics;
        private System.Windows.Forms.RadioButton rbtnUnClic;
        private System.Windows.Forms.CheckBox multiColumn;
        private System.Windows.Forms.CheckBox ordenAlfabetico;
    }
}


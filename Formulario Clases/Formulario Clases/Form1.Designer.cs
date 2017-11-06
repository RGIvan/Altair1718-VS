namespace Formulario_Clases
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.cbTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkGet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkSet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbTipo,
            this.txtTipo,
            this.chkGet,
            this.chkSet});
            this.dataGridView.Location = new System.Drawing.Point(128, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(443, 208);
            this.dataGridView.TabIndex = 0;
            // 
            // txtClase
            // 
            this.txtClase.Location = new System.Drawing.Point(232, 30);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(154, 20);
            this.txtClase.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la clase:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(182, 279);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(111, 43);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(413, 279);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 43);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(67, 328);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(573, 284);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // cbTipo
            // 
            this.cbTipo.FillWeight = 99.97683F;
            this.cbTipo.HeaderText = "Tipo";
            this.cbTipo.Items.AddRange(new object[] {
            "int",
            "boolean"});
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Width = 150;
            // 
            // txtTipo
            // 
            this.txtTipo.FillWeight = 96.97749F;
            this.txtTipo.HeaderText = "Nombre";
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Width = 150;
            // 
            // chkGet
            // 
            this.chkGet.FillWeight = 101.5228F;
            this.chkGet.HeaderText = "GET";
            this.chkGet.Name = "chkGet";
            this.chkGet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkGet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkGet.Width = 50;
            // 
            // chkSet
            // 
            this.chkSet.FillWeight = 101.5229F;
            this.chkSet.HeaderText = "SET";
            this.chkSet.Name = "chkSet";
            this.chkSet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkSet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkSet.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 621);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "GenerCod C#";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkGet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSet;
    }
}


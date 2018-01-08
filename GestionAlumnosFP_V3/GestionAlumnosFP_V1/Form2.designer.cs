namespace GestionAlumnosFP_V1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCabecera = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelControles = new System.Windows.Forms.Panel();
            this.btnGestionGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrupos = new System.Windows.Forms.ComboBox();
            this.btnAnadirGrupo = new System.Windows.Forms.Button();
            this.dataSet1 = new GestionAlumnosFP_V1.DataSet1();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new GestionAlumnosFP_V1.DataSet1TableAdapters.AlumnosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCabecera
            // 
            this.lbCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabecera.Location = new System.Drawing.Point(35, 20);
            this.lbCabecera.Name = "lbCabecera";
            this.lbCabecera.Size = new System.Drawing.Size(520, 23);
            this.lbCabecera.TabIndex = 9;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(35, 50);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(926, 342);
            this.dgv.TabIndex = 10;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = ">";
            this.Column1.ToolTipText = "Editar Registro";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 40;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelControles.Controls.Add(this.btnGestionGrupo);
            this.panelControles.Controls.Add(this.label1);
            this.panelControles.Controls.Add(this.cbGrupos);
            this.panelControles.Controls.Add(this.btnAnadirGrupo);
            this.panelControles.Location = new System.Drawing.Point(35, 420);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(925, 107);
            this.panelControles.TabIndex = 24;
            // 
            // btnGestionGrupo
            // 
            this.btnGestionGrupo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionGrupo.Location = new System.Drawing.Point(675, 27);
            this.btnGestionGrupo.Name = "btnGestionGrupo";
            this.btnGestionGrupo.Size = new System.Drawing.Size(206, 45);
            this.btnGestionGrupo.TabIndex = 25;
            this.btnGestionGrupo.Text = "Gestionar Alumno";
            this.btnGestionGrupo.UseVisualStyleBackColor = true;
            this.btnGestionGrupo.Click += new System.EventHandler(this.btnGestionGrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Grupos";
            // 
            // cbGrupos
            // 
            this.cbGrupos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupos.Location = new System.Drawing.Point(331, 49);
            this.cbGrupos.Name = "cbGrupos";
            this.cbGrupos.Size = new System.Drawing.Size(284, 30);
            this.cbGrupos.TabIndex = 12;
            this.cbGrupos.SelectedIndexChanged += new System.EventHandler(this.cbGrupos_SelectedIndexChanged);
            // 
            // btnAnadirGrupo
            // 
            this.btnAnadirGrupo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirGrupo.Location = new System.Drawing.Point(45, 27);
            this.btnAnadirGrupo.Name = "btnAnadirGrupo";
            this.btnAnadirGrupo.Size = new System.Drawing.Size(206, 45);
            this.btnAnadirGrupo.TabIndex = 21;
            this.btnAnadirGrupo.Text = "Añadir Grupo";
            this.btnAnadirGrupo.UseVisualStyleBackColor = true;
            this.btnAnadirGrupo.Click += new System.EventHandler(this.btnAnadirAlumno_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.dataSet1;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 551);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbCabecera);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Gestión de Grupos de FP (V3)";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCabecera;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGrupos;
        private System.Windows.Forms.Button btnAnadirGrupo;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private DataSet1TableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button btnGestionGrupo;
    }
}


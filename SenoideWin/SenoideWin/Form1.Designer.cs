namespace SenoideWin
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
            this.trkbAmplitud = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelDibujo = new System.Windows.Forms.Panel();
            this.nudCiclos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDesfase = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGrosor = new System.Windows.Forms.ComboBox();
            this.lbColorTrazo2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbAzul = new System.Windows.Forms.RadioButton();
            this.chbVerde = new System.Windows.Forms.RadioButton();
            this.chbNegro = new System.Windows.Forms.RadioButton();
            this.chbBlanco = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbColorTrazo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkbAmplitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiclos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesfase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkbAmplitud
            // 
            this.trkbAmplitud.LargeChange = 1;
            this.trkbAmplitud.Location = new System.Drawing.Point(24, 30);
            this.trkbAmplitud.Maximum = 400;
            this.trkbAmplitud.Name = "trkbAmplitud";
            this.trkbAmplitud.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkbAmplitud.Size = new System.Drawing.Size(45, 230);
            this.trkbAmplitud.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amplitud";
            // 
            // PanelDibujo
            // 
            this.PanelDibujo.BackColor = System.Drawing.Color.White;
            this.PanelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDibujo.Location = new System.Drawing.Point(110, 39);
            this.PanelDibujo.Name = "PanelDibujo";
            this.PanelDibujo.Size = new System.Drawing.Size(624, 489);
            this.PanelDibujo.TabIndex = 2;
            this.PanelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDibujo_Paint);
            // 
            // nudCiclos
            // 
            this.nudCiclos.DecimalPlaces = 1;
            this.nudCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCiclos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCiclos.Location = new System.Drawing.Point(18, 318);
            this.nudCiclos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCiclos.Name = "nudCiclos";
            this.nudCiclos.Size = new System.Drawing.Size(66, 26);
            this.nudCiclos.TabIndex = 3;
            this.nudCiclos.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nº ciclos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "ºDesfase";
            // 
            // nudDesfase
            // 
            this.nudDesfase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDesfase.Location = new System.Drawing.Point(18, 405);
            this.nudDesfase.Name = "nudDesfase";
            this.nudDesfase.Size = new System.Drawing.Size(66, 26);
            this.nudDesfase.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Offset";
            // 
            // nudOffset
            // 
            this.nudOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOffset.Location = new System.Drawing.Point(18, 502);
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(66, 26);
            this.nudOffset.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbColorTrazo);
            this.groupBox1.Controls.Add(this.cbGrosor);
            this.groupBox1.Controls.Add(this.lbColorTrazo2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(756, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 189);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trazo";
            // 
            // cbGrosor
            // 
            this.cbGrosor.BackColor = System.Drawing.SystemColors.Control;
            this.cbGrosor.FormattingEnabled = true;
            this.cbGrosor.Location = new System.Drawing.Point(19, 63);
            this.cbGrosor.Name = "cbGrosor";
            this.cbGrosor.Size = new System.Drawing.Size(60, 26);
            this.cbGrosor.TabIndex = 12;
            this.cbGrosor.Text = "2,5";
            // 
            // lbColorTrazo2
            // 
            this.lbColorTrazo2.AutoSize = true;
            this.lbColorTrazo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColorTrazo2.Location = new System.Drawing.Point(24, 114);
            this.lbColorTrazo2.Name = "lbColorTrazo2";
            this.lbColorTrazo2.Size = new System.Drawing.Size(50, 18);
            this.lbColorTrazo2.TabIndex = 11;
            this.lbColorTrazo2.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grosor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbAzul);
            this.groupBox2.Controls.Add(this.chbVerde);
            this.groupBox2.Controls.Add(this.chbNegro);
            this.groupBox2.Controls.Add(this.chbBlanco);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(756, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 169);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fondo";
            // 
            // chbAzul
            // 
            this.chbAzul.AutoSize = true;
            this.chbAzul.BackColor = System.Drawing.Color.Blue;
            this.chbAzul.ForeColor = System.Drawing.Color.Black;
            this.chbAzul.Location = new System.Drawing.Point(10, 120);
            this.chbAzul.Name = "chbAzul";
            this.chbAzul.Size = new System.Drawing.Size(58, 22);
            this.chbAzul.TabIndex = 1;
            this.chbAzul.TabStop = true;
            this.chbAzul.Text = "Azul";
            this.chbAzul.UseVisualStyleBackColor = false;
            this.chbAzul.CheckedChanged += new System.EventHandler(this.chbAzul_CheckedChanged);
            // 
            // chbVerde
            // 
            this.chbVerde.AutoSize = true;
            this.chbVerde.BackColor = System.Drawing.Color.Lime;
            this.chbVerde.Location = new System.Drawing.Point(10, 92);
            this.chbVerde.Name = "chbVerde";
            this.chbVerde.Size = new System.Drawing.Size(69, 22);
            this.chbVerde.TabIndex = 1;
            this.chbVerde.TabStop = true;
            this.chbVerde.Text = "Verde";
            this.chbVerde.UseVisualStyleBackColor = false;
            this.chbVerde.CheckedChanged += new System.EventHandler(this.chbVerde_CheckedChanged);
            // 
            // chbNegro
            // 
            this.chbNegro.AutoSize = true;
            this.chbNegro.BackColor = System.Drawing.Color.Black;
            this.chbNegro.ForeColor = System.Drawing.Color.White;
            this.chbNegro.Location = new System.Drawing.Point(10, 64);
            this.chbNegro.Name = "chbNegro";
            this.chbNegro.Size = new System.Drawing.Size(72, 22);
            this.chbNegro.TabIndex = 1;
            this.chbNegro.TabStop = true;
            this.chbNegro.Text = "Negro";
            this.chbNegro.UseVisualStyleBackColor = false;
            this.chbNegro.CheckedChanged += new System.EventHandler(this.chbNegro_CheckedChanged);
            // 
            // chbBlanco
            // 
            this.chbBlanco.AutoSize = true;
            this.chbBlanco.BackColor = System.Drawing.Color.White;
            this.chbBlanco.Location = new System.Drawing.Point(10, 36);
            this.chbBlanco.Name = "chbBlanco";
            this.chbBlanco.Size = new System.Drawing.Size(78, 22);
            this.chbBlanco.TabIndex = 0;
            this.chbBlanco.TabStop = true;
            this.chbBlanco.Text = "Blanco";
            this.chbBlanco.UseVisualStyleBackColor = false;
            this.chbBlanco.CheckedChanged += new System.EventHandler(this.chbBlanco_CheckedChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(766, 448);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(82, 29);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(756, 493);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(102, 35);
            this.btnDibujar.TabIndex = 12;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lbColorTrazo
            // 
            this.lbColorTrazo.BackColor = System.Drawing.Color.Black;
            this.lbColorTrazo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbColorTrazo.Location = new System.Drawing.Point(22, 140);
            this.lbColorTrazo.Name = "lbColorTrazo";
            this.lbColorTrazo.Size = new System.Drawing.Size(55, 22);
            this.lbColorTrazo.TabIndex = 13;
            this.lbColorTrazo.Click += new System.EventHandler(this.lbColorTrazo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(875, 569);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudOffset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDesfase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCiclos);
            this.Controls.Add(this.PanelDibujo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkbAmplitud);
            this.Name = "Form1";
            this.Text = "Formulario Senoides";
            ((System.ComponentModel.ISupportInitialize)(this.trkbAmplitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiclos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesfase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkbAmplitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelDibujo;
        private System.Windows.Forms.NumericUpDown nudCiclos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDesfase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbColorTrazo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGrosor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton chbBlanco;
        private System.Windows.Forms.RadioButton chbAzul;
        private System.Windows.Forms.RadioButton chbVerde;
        private System.Windows.Forms.RadioButton chbNegro;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbColorTrazo;
    }
}


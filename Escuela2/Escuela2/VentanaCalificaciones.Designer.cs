namespace Escuela2
{
    partial class VentanaCalificaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbcalificacion2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbmateria2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbalumno2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvinfo2 = new System.Windows.Forms.DataGridView();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mostrar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txbcalificacion2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbmateria2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbalumno2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar calificacion";
            // 
            // txbcalificacion2
            // 
            this.txbcalificacion2.Location = new System.Drawing.Point(283, 102);
            this.txbcalificacion2.Name = "txbcalificacion2";
            this.txbcalificacion2.Size = new System.Drawing.Size(233, 22);
            this.txbcalificacion2.TabIndex = 5;
            this.txbcalificacion2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calificacion";
            // 
            // txbmateria2
            // 
            this.txbmateria2.Location = new System.Drawing.Point(457, 34);
            this.txbmateria2.Name = "txbmateria2";
            this.txbmateria2.Size = new System.Drawing.Size(235, 22);
            this.txbmateria2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia";
            // 
            // txbalumno2
            // 
            this.txbalumno2.Location = new System.Drawing.Point(103, 34);
            this.txbalumno2.Name = "txbalumno2";
            this.txbalumno2.Size = new System.Drawing.Size(220, 22);
            this.txbalumno2.TabIndex = 1;
            this.txbalumno2.TextChanged += new System.EventHandler(this.txbalumno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // dgvinfo2
            // 
            this.dgvinfo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alumno,
            this.Materia,
            this.Calificacion});
            this.dgvinfo2.Location = new System.Drawing.Point(119, 245);
            this.dgvinfo2.Name = "dgvinfo2";
            this.dgvinfo2.Size = new System.Drawing.Size(344, 150);
            this.dgvinfo2.TabIndex = 1;
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.Name = "Alumno";
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 104);
            this.button1.TabIndex = 2;
            this.button1.Text = "Siguiente ventana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 68);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registrarse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(551, 132);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(91, 68);
            this.Mostrar.TabIndex = 7;
            this.Mostrar.Text = "Mostrar datos en la tabla";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // VentanaCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvinfo2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaCalificaciones";
            this.Text = "VentanaCalificaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbcalificacion2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbmateria2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbalumno2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvinfo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Mostrar;
    }
}
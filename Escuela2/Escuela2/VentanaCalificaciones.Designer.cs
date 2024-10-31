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
            this.Mostrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1007, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar calificacion";
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(735, 162);
            this.Mostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(121, 84);
            this.Mostrar.TabIndex = 7;
            this.Mostrar.Text = "Mostrar datos en la tabla";
            this.Mostrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 84);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registrarse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbcalificacion2
            // 
            this.txbcalificacion2.Location = new System.Drawing.Point(377, 126);
            this.txbcalificacion2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbcalificacion2.Name = "txbcalificacion2";
            this.txbcalificacion2.Size = new System.Drawing.Size(309, 26);
            this.txbcalificacion2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calificacion";
            // 
            // txbmateria2
            // 
            this.txbmateria2.Location = new System.Drawing.Point(609, 42);
            this.txbmateria2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbmateria2.Name = "txbmateria2";
            this.txbmateria2.Size = new System.Drawing.Size(312, 26);
            this.txbmateria2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia";
            // 
            // txbalumno2
            // 
            this.txbalumno2.Location = new System.Drawing.Point(137, 42);
            this.txbalumno2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbalumno2.Name = "txbalumno2";
            this.txbalumno2.Size = new System.Drawing.Size(292, 26);
            this.txbalumno2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
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
            this.dgvinfo2.Location = new System.Drawing.Point(159, 302);
            this.dgvinfo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvinfo2.Name = "dgvinfo2";
            this.dgvinfo2.RowHeadersWidth = 51;
            this.dgvinfo2.Size = new System.Drawing.Size(459, 185);
            this.dgvinfo2.TabIndex = 1;
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.MinimumWidth = 6;
            this.Alumno.Name = "Alumno";
            this.Alumno.Width = 125;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.Width = 125;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.MinimumWidth = 6;
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(736, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 128);
            this.button1.TabIndex = 2;
            this.button1.Text = "Siguiente ventana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvinfo2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
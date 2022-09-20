namespace Escuela2
{
    partial class VentanaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMateria));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btonsiguiente = new System.Windows.Forms.Button();
            this.btondatos = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.PictureBox();
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.Id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbcreditos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbhoras = new System.Windows.Forms.ComboBox();
            this.txbmateria = new System.Windows.Forms.TextBox();
            this.txbxidmateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnregistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Universidad Politecnica De Tecamac";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btonsiguiente);
            this.groupBox1.Controls.Add(this.btondatos);
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Controls.Add(this.dgvinfo);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.cbcreditos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbhoras);
            this.groupBox1.Controls.Add(this.txbmateria);
            this.groupBox1.Controls.Add(this.txbxidmateria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 361);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de la materia";
            // 
            // btonsiguiente
            // 
            this.btonsiguiente.Location = new System.Drawing.Point(655, 270);
            this.btonsiguiente.Name = "btonsiguiente";
            this.btonsiguiente.Size = new System.Drawing.Size(107, 62);
            this.btonsiguiente.TabIndex = 12;
            this.btonsiguiente.Text = "Siguiente ventana";
            this.btonsiguiente.UseVisualStyleBackColor = true;
            this.btonsiguiente.Click += new System.EventHandler(this.btonsiguiente_Click_1);
            // 
            // btondatos
            // 
            this.btondatos.Location = new System.Drawing.Point(528, 270);
            this.btondatos.Name = "btondatos";
            this.btondatos.Size = new System.Drawing.Size(107, 62);
            this.btondatos.TabIndex = 11;
            this.btondatos.Text = "Mostrar datos en la tabla";
            this.btondatos.UseVisualStyleBackColor = true;
            this.btondatos.Click += new System.EventHandler(this.btondatos_Click_1);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.Image = global::Escuela2.Properties.Resources.registrarse;
            this.btnregistrar.Location = new System.Drawing.Point(586, 194);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(118, 70);
            this.btnregistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.TabStop = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // dgvinfo
            // 
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_materia,
            this.Materia,
            this.Horas,
            this.Creditos});
            this.dgvinfo.Location = new System.Drawing.Point(33, 184);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.Size = new System.Drawing.Size(443, 150);
            this.dgvinfo.TabIndex = 9;
            // 
            // Id_materia
            // 
            this.Id_materia.HeaderText = "Id_materia";
            this.Id_materia.Name = "Id_materia";
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            // 
            // Creditos
            // 
            this.Creditos.HeaderText = "Creditos";
            this.Creditos.Name = "Creditos";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(188, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(291, 22);
            this.textBox3.TabIndex = 8;
            // 
            // cbcreditos
            // 
            this.cbcreditos.FormattingEnabled = true;
            this.cbcreditos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbcreditos.Location = new System.Drawing.Point(497, 83);
            this.cbcreditos.Name = "cbcreditos";
            this.cbcreditos.Size = new System.Drawing.Size(39, 24);
            this.cbcreditos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Creditos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Materia";
            // 
            // cbhoras
            // 
            this.cbhoras.FormattingEnabled = true;
            this.cbhoras.Items.AddRange(new object[] {
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cbhoras.Location = new System.Drawing.Point(244, 86);
            this.cbhoras.Name = "cbhoras";
            this.cbhoras.Size = new System.Drawing.Size(40, 24);
            this.cbhoras.TabIndex = 4;
            // 
            // txbmateria
            // 
            this.txbmateria.Location = new System.Drawing.Point(497, 42);
            this.txbmateria.Name = "txbmateria";
            this.txbmateria.Size = new System.Drawing.Size(100, 22);
            this.txbmateria.TabIndex = 3;
            // 
            // txbxidmateria
            // 
            this.txbxidmateria.Location = new System.Drawing.Point(157, 45);
            this.txbxidmateria.Name = "txbxidmateria";
            this.txbxidmateria.Size = new System.Drawing.Size(138, 22);
            this.txbxidmateria.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Horas impartidas a la semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id de la materia";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Escuela2.Properties.Resources.logo_estado;
            this.pictureBox2.Location = new System.Drawing.Point(725, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Escuela2.Properties.Resources.logo_upt;
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(880, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaMateria";
            this.Text = "Materia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnregistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbhoras;
        private System.Windows.Forms.TextBox txbmateria;
        private System.Windows.Forms.TextBox txbxidmateria;
        private System.Windows.Forms.PictureBox btnregistrar;
        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbcreditos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btonsiguiente;
        private System.Windows.Forms.Button btondatos;
    }
}
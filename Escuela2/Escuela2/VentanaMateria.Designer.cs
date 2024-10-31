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
            this.label1.Location = new System.Drawing.Point(253, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 36);
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
            this.groupBox1.Location = new System.Drawing.Point(51, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1073, 444);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de la materia";
            // 
            // btonsiguiente
            // 
            this.btonsiguiente.Location = new System.Drawing.Point(873, 332);
            this.btonsiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btonsiguiente.Name = "btonsiguiente";
            this.btonsiguiente.Size = new System.Drawing.Size(143, 76);
            this.btonsiguiente.TabIndex = 12;
            this.btonsiguiente.Text = "Siguiente ventana";
            this.btonsiguiente.UseVisualStyleBackColor = true;
            this.btonsiguiente.Click += new System.EventHandler(this.btonsiguiente_Click_1);
            // 
            // btondatos
            // 
            this.btondatos.Location = new System.Drawing.Point(704, 332);
            this.btondatos.Margin = new System.Windows.Forms.Padding(4);
            this.btondatos.Name = "btondatos";
            this.btondatos.Size = new System.Drawing.Size(143, 76);
            this.btondatos.TabIndex = 11;
            this.btondatos.Text = "Mostrar datos en la tabla";
            this.btondatos.UseVisualStyleBackColor = true;
            this.btondatos.Click += new System.EventHandler(this.btondatos_Click_1);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.Image = global::Escuela2.Properties.Resources.registrarse;
            this.btnregistrar.Location = new System.Drawing.Point(781, 239);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(157, 86);
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
            this.dgvinfo.Location = new System.Drawing.Point(44, 226);
            this.dgvinfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.RowHeadersWidth = 51;
            this.dgvinfo.Size = new System.Drawing.Size(591, 185);
            this.dgvinfo.TabIndex = 9;
            // 
            // Id_materia
            // 
            this.Id_materia.HeaderText = "Id_materia";
            this.Id_materia.MinimumWidth = 6;
            this.Id_materia.Name = "Id_materia";
            this.Id_materia.Width = 125;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.Width = 125;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.MinimumWidth = 6;
            this.Horas.Name = "Horas";
            this.Horas.Width = 125;
            // 
            // Creditos
            // 
            this.Creditos.HeaderText = "Creditos";
            this.Creditos.MinimumWidth = 6;
            this.Creditos.Name = "Creditos";
            this.Creditos.Width = 125;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(251, 169);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(387, 26);
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
            this.cbcreditos.Location = new System.Drawing.Point(663, 102);
            this.cbcreditos.Margin = new System.Windows.Forms.Padding(4);
            this.cbcreditos.Name = "cbcreditos";
            this.cbcreditos.Size = new System.Drawing.Size(51, 28);
            this.cbcreditos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Creditos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
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
            this.cbhoras.Location = new System.Drawing.Point(325, 106);
            this.cbhoras.Margin = new System.Windows.Forms.Padding(4);
            this.cbhoras.Name = "cbhoras";
            this.cbhoras.Size = new System.Drawing.Size(52, 28);
            this.cbhoras.TabIndex = 4;
            // 
            // txbmateria
            // 
            this.txbmateria.Location = new System.Drawing.Point(663, 52);
            this.txbmateria.Margin = new System.Windows.Forms.Padding(4);
            this.txbmateria.Name = "txbmateria";
            this.txbmateria.Size = new System.Drawing.Size(132, 26);
            this.txbmateria.TabIndex = 3;
            // 
            // txbxidmateria
            // 
            this.txbxidmateria.Location = new System.Drawing.Point(209, 55);
            this.txbxidmateria.Margin = new System.Windows.Forms.Padding(4);
            this.txbxidmateria.Name = "txbxidmateria";
            this.txbxidmateria.Size = new System.Drawing.Size(183, 26);
            this.txbxidmateria.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Horas impartidas a la semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id de la materia";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Escuela2.Properties.Resources.logo_estado;
            this.pictureBox2.Location = new System.Drawing.Point(967, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Escuela2.Properties.Resources.logo_upt;
            this.pictureBox1.Location = new System.Drawing.Point(51, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1173, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
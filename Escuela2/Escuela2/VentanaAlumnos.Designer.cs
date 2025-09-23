namespace Escuela2
{
    partial class Alumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edad1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.entidad = new System.Windows.Forms.ComboBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.masc = new System.Windows.Forms.RadioButton();
            this.femen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edad1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(367, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingreso de alumnos";
            // 
            // matricula
            // 
            this.matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula.Location = new System.Drawing.Point(256, 124);
            this.matricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(172, 26);
            this.matricula.TabIndex = 3;
            this.matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(256, 166);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(172, 26);
            this.nombre.TabIndex = 4;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Edad";
            // 
            // edad1
            // 
            this.edad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad1.Location = new System.Drawing.Point(256, 204);
            this.edad1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edad1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.edad1.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.edad1.Name = "edad1";
            this.edad1.Size = new System.Drawing.Size(63, 26);
            this.edad1.TabIndex = 6;
            this.edad1.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Entidad de nacimiento";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(711, 128);
            this.telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(203, 22);
            this.telefono.TabIndex = 9;
            // 
            // entidad
            // 
            this.entidad.FormattingEnabled = true;
            this.entidad.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacan",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Queretaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatan",
            "Zacatecas"});
            this.entidad.Location = new System.Drawing.Point(711, 169);
            this.entidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entidad.Name = "entidad";
            this.entidad.Size = new System.Drawing.Size(228, 24);
            this.entidad.TabIndex = 10;
            // 
            // Ingresar
            // 
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(711, 207);
            this.Ingresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(100, 39);
            this.Ingresar.TabIndex = 11;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.ingresar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masc);
            this.groupBox1.Controls.Add(this.femen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 250);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(199, 137);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // masc
            // 
            this.masc.AutoSize = true;
            this.masc.Location = new System.Drawing.Point(39, 84);
            this.masc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.masc.Name = "masc";
            this.masc.Size = new System.Drawing.Size(106, 24);
            this.masc.TabIndex = 13;
            this.masc.TabStop = true;
            this.masc.Text = "Masculino";
            this.masc.UseVisualStyleBackColor = true;
            // 
            // femen
            // 
            this.femen.AutoSize = true;
            this.femen.Location = new System.Drawing.Point(39, 38);
            this.femen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.femen.Name = "femen";
            this.femen.Size = new System.Drawing.Size(103, 24);
            this.femen.TabIndex = 13;
            this.femen.TabStop = true;
            this.femen.Text = "Femenino";
            this.femen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Datos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 416);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(980, 282);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siguiente ventana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datos
            // 
            this.Datos.Location = new System.Drawing.Point(215, 22);
            this.Datos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(609, 248);
            this.Datos.TabIndex = 0;
            this.Datos.Text = "";
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1067, 740);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.entidad);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edad1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.edad1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edad1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.ComboBox entidad;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton masc;
        private System.Windows.Forms.RadioButton femen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox Datos;
        private System.Windows.Forms.Button button1;
    }
}
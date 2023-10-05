namespace Alumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.edad1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.masculino = new System.Windows.Forms.GroupBox();
            this.masc = new System.Windows.Forms.RadioButton();
            this.femen = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.entidad = new System.Windows.Forms.ComboBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Datos = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edad1)).BeginInit();
            this.masculino.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(117, 134);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(117, 165);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(201, 26);
            this.nombre.TabIndex = 4;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // edad1
            // 
            this.edad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad1.Location = new System.Drawing.Point(117, 202);
            this.edad1.Margin = new System.Windows.Forms.Padding(4);
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
            this.edad1.Size = new System.Drawing.Size(229, 26);
            this.edad1.TabIndex = 5;
            this.edad1.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // masculino
            // 
            this.masculino.Controls.Add(this.masc);
            this.masculino.Controls.Add(this.femen);
            this.masculino.Location = new System.Drawing.Point(29, 251);
            this.masculino.Margin = new System.Windows.Forms.Padding(4);
            this.masculino.Name = "masculino";
            this.masculino.Padding = new System.Windows.Forms.Padding(4);
            this.masculino.Size = new System.Drawing.Size(269, 133);
            this.masculino.TabIndex = 7;
            this.masculino.TabStop = false;
            this.masculino.Text = "Sexo";
            // 
            // masc
            // 
            this.masc.AutoSize = true;
            this.masc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masc.Location = new System.Drawing.Point(72, 86);
            this.masc.Margin = new System.Windows.Forms.Padding(4);
            this.masc.Name = "masc";
            this.masc.Size = new System.Drawing.Size(106, 24);
            this.masc.TabIndex = 8;
            this.masc.TabStop = true;
            this.masc.Text = "Masculino";
            this.masc.UseVisualStyleBackColor = true;
            // 
            // femen
            // 
            this.femen.AutoSize = true;
            this.femen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femen.Location = new System.Drawing.Point(72, 31);
            this.femen.Margin = new System.Windows.Forms.Padding(4);
            this.femen.Name = "femen";
            this.femen.Size = new System.Drawing.Size(103, 24);
            this.femen.TabIndex = 8;
            this.femen.TabStop = true;
            this.femen.Text = "Femenino";
            this.femen.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(728, 130);
            this.telefono.Margin = new System.Windows.Forms.Padding(4);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(192, 26);
            this.telefono.TabIndex = 9;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(498, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Entidad de nacimiento";
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
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.entidad.Location = new System.Drawing.Point(728, 170);
            this.entidad.Margin = new System.Windows.Forms.Padding(4);
            this.entidad.Name = "entidad";
            this.entidad.Size = new System.Drawing.Size(248, 24);
            this.entidad.TabIndex = 11;
            this.entidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ingresar
            // 
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(716, 218);
            this.Ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(100, 28);
            this.Ingresar.TabIndex = 12;
            this.Ingresar.Text = "Ingresar alumno";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Datos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 402);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(933, 282);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del alumno";
            // 
            // Datos
            // 
            this.Datos.Enabled = false;
            this.Datos.Location = new System.Drawing.Point(183, 26);
            this.Datos.Margin = new System.Windows.Forms.Padding(4);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(575, 230);
            this.Datos.TabIndex = 0;
            this.Datos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 718);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.entidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edad1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edad1)).EndInit();
            this.masculino.ResumeLayout(false);
            this.masculino.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.NumericUpDown edad1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox masculino;
        private System.Windows.Forms.RadioButton masc;
        private System.Windows.Forms.RadioButton femen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox entidad;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox Datos;
    }
}


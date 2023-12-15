namespace ParesoImpares
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PasarPares = new System.Windows.Forms.Button();
            this.PasarImpares = new System.Windows.Forms.Button();
            this.ListaOriginal = new System.Windows.Forms.ListBox();
            this.ListaNumeros = new System.Windows.Forms.ListView();
            this.Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListaOriginal);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista original";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Limpiar);
            this.groupBox2.Controls.Add(this.ListaNumeros);
            this.groupBox2.Location = new System.Drawing.Point(401, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 446);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numeros";
            // 
            // PasarPares
            // 
            this.PasarPares.Location = new System.Drawing.Point(275, 179);
            this.PasarPares.Name = "PasarPares";
            this.PasarPares.Size = new System.Drawing.Size(112, 35);
            this.PasarPares.TabIndex = 2;
            this.PasarPares.Text = "Pares >>";
            this.PasarPares.UseVisualStyleBackColor = true;
            this.PasarPares.Click += new System.EventHandler(this.PasarPares_Click);
            // 
            // PasarImpares
            // 
            this.PasarImpares.Location = new System.Drawing.Point(275, 220);
            this.PasarImpares.Name = "PasarImpares";
            this.PasarImpares.Size = new System.Drawing.Size(112, 35);
            this.PasarImpares.TabIndex = 3;
            this.PasarImpares.Text = "<< Impares";
            this.PasarImpares.UseVisualStyleBackColor = true;
            this.PasarImpares.Click += new System.EventHandler(this.PasarImpares_Click);
            // 
            // ListaOriginal
            // 
            this.ListaOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaOriginal.FormattingEnabled = true;
            this.ListaOriginal.ItemHeight = 20;
            this.ListaOriginal.Items.AddRange(new object[] {
            "2",
            "4",
            "10",
            "12",
            "14",
            "18",
            "20",
            "24",
            "28",
            "40"});
            this.ListaOriginal.Location = new System.Drawing.Point(6, 21);
            this.ListaOriginal.Name = "ListaOriginal";
            this.ListaOriginal.Size = new System.Drawing.Size(234, 364);
            this.ListaOriginal.TabIndex = 0;
            // 
            // ListaNumeros
            // 
            this.ListaNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaNumeros.HideSelection = false;
            this.ListaNumeros.Location = new System.Drawing.Point(7, 22);
            this.ListaNumeros.Name = "ListaNumeros";
            this.ListaNumeros.Size = new System.Drawing.Size(249, 365);
            this.ListaNumeros.TabIndex = 0;
            this.ListaNumeros.UseCompatibleStateImageBehavior = false;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(82, 405);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(112, 35);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 482);
            this.Controls.Add(this.PasarImpares);
            this.Controls.Add(this.PasarPares);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pares o impares";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PasarPares;
        private System.Windows.Forms.Button PasarImpares;
        private System.Windows.Forms.ListBox ListaOriginal;
        private System.Windows.Forms.ListView ListaNumeros;
        private System.Windows.Forms.Button Limpiar;
    }
}


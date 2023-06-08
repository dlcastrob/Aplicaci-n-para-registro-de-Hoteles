namespace Mad
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contraTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fechaInicioDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.comboBox1.Location = new System.Drawing.Point(271, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usTB
            // 
            this.usTB.Location = new System.Drawing.Point(271, 135);
            this.usTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usTB.Name = "usTB";
            this.usTB.Size = new System.Drawing.Size(164, 22);
            this.usTB.TabIndex = 2;
            this.usTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contraTB
            // 
            this.contraTB.Location = new System.Drawing.Point(271, 186);
            this.contraTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contraTB.Name = "contraTB";
            this.contraTB.Size = new System.Drawing.Size(164, 22);
            this.contraTB.TabIndex = 3;
            this.contraTB.UseSystemPasswordChar = true;
            this.contraTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 320);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Nueva cuenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 320);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "Prueba";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fechaInicioDTP
            // 
            this.fechaInicioDTP.Location = new System.Drawing.Point(271, 245);
            this.fechaInicioDTP.Margin = new System.Windows.Forms.Padding(4);
            this.fechaInicioDTP.Name = "fechaInicioDTP";
            this.fechaInicioDTP.Size = new System.Drawing.Size(177, 22);
            this.fechaInicioDTP.TabIndex = 4;
            this.fechaInicioDTP.ValueChanged += new System.EventHandler(this.fechaInicioDTP_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese fecha actual";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(506, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Recuperar contraseña";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 412);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaInicioDTP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contraTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contraTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker fechaInicioDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
    }
}


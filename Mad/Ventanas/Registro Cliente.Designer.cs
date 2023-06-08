namespace Mad.Ventanas
{
    partial class Cliente
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
            this.telCelRC = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.telCasaRC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.colRC = new System.Windows.Forms.TextBox();
            this.numExtRC = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.calleRC = new System.Windows.Forms.TextBox();
            this.fechaNacRc = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.matRC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.patRC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nonRC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.correoRC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comoRC = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rfcRC = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.estadoCivRC = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // telCelRC
            // 
            this.telCelRC.Location = new System.Drawing.Point(493, 290);
            this.telCelRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telCelRC.Mask = "000-000-0000";
            this.telCelRC.Name = "telCelRC";
            this.telCelRC.Size = new System.Drawing.Size(200, 22);
            this.telCelRC.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(349, 294);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Telefono celular";
            // 
            // telCasaRC
            // 
            this.telCasaRC.Location = new System.Drawing.Point(153, 288);
            this.telCasaRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telCasaRC.Mask = "(999)000-0000";
            this.telCasaRC.Name = "telCasaRC";
            this.telCasaRC.Size = new System.Drawing.Size(164, 22);
            this.telCasaRC.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefono de casa";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(789, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Colonia";
            // 
            // colRC
            // 
            this.colRC.Location = new System.Drawing.Point(924, 239);
            this.colRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colRC.Name = "colRC";
            this.colRC.Size = new System.Drawing.Size(164, 22);
            this.colRC.TabIndex = 10;
            this.colRC.TextChanged += new System.EventHandler(this.colRC_TextChanged);
            // 
            // numExtRC
            // 
            this.numExtRC.Location = new System.Drawing.Point(493, 244);
            this.numExtRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numExtRC.Mask = "99999";
            this.numExtRC.Name = "numExtRC";
            this.numExtRC.Size = new System.Drawing.Size(200, 22);
            this.numExtRC.TabIndex = 9;
            this.numExtRC.ValidatingType = typeof(int);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "No. exterior";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Calle";
            // 
            // calleRC
            // 
            this.calleRC.Location = new System.Drawing.Point(153, 241);
            this.calleRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calleRC.Name = "calleRC";
            this.calleRC.Size = new System.Drawing.Size(164, 22);
            this.calleRC.TabIndex = 8;
            this.calleRC.TextChanged += new System.EventHandler(this.calleRC_TextChanged);
            // 
            // fechaNacRc
            // 
            this.fechaNacRc.Location = new System.Drawing.Point(493, 193);
            this.fechaNacRc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaNacRc.Name = "fechaNacRc";
            this.fechaNacRc.Size = new System.Drawing.Size(200, 22);
            this.fechaNacRc.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Fecha de nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(789, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Apellido materno";
            // 
            // matRC
            // 
            this.matRC.Location = new System.Drawing.Point(924, 127);
            this.matRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matRC.Name = "matRC";
            this.matRC.Size = new System.Drawing.Size(164, 22);
            this.matRC.TabIndex = 4;
            this.matRC.TextChanged += new System.EventHandler(this.matRC_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Apellido paterno";
            // 
            // patRC
            // 
            this.patRC.Location = new System.Drawing.Point(493, 127);
            this.patRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patRC.Name = "patRC";
            this.patRC.Size = new System.Drawing.Size(200, 22);
            this.patRC.TabIndex = 3;
            this.patRC.TextChanged += new System.EventHandler(this.patRC_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre(s)";
            // 
            // nonRC
            // 
            this.nonRC.Location = new System.Drawing.Point(153, 135);
            this.nonRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonRC.Name = "nonRC";
            this.nonRC.Size = new System.Drawing.Size(164, 22);
            this.nonRC.TabIndex = 2;
            this.nonRC.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Correo";
            // 
            // correoRC
            // 
            this.correoRC.Location = new System.Drawing.Point(155, 350);
            this.correoRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.correoRC.Name = "correoRC";
            this.correoRC.ShortcutsEnabled = false;
            this.correoRC.Size = new System.Drawing.Size(164, 22);
            this.correoRC.TabIndex = 13;
            this.correoRC.UseSystemPasswordChar = true;
            this.correoRC.TextChanged += new System.EventHandler(this.correoRC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Como conocio el hotel";
            // 
            // comoRC
            // 
            this.comoRC.FormattingEnabled = true;
            this.comoRC.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.comoRC.Location = new System.Drawing.Point(181, 18);
            this.comoRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comoRC.Name = "comoRC";
            this.comoRC.Size = new System.Drawing.Size(164, 24);
            this.comoRC.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "RFC";
            // 
            // rfcRC
            // 
            this.rfcRC.Location = new System.Drawing.Point(155, 193);
            this.rfcRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rfcRC.Mask = "99999";
            this.rfcRC.Name = "rfcRC";
            this.rfcRC.Size = new System.Drawing.Size(164, 22);
            this.rfcRC.TabIndex = 5;
            this.rfcRC.ValidatingType = typeof(int);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(789, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Estado civil";
            // 
            // estadoCivRC
            // 
            this.estadoCivRC.FormattingEnabled = true;
            this.estadoCivRC.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.estadoCivRC.Location = new System.Drawing.Point(924, 190);
            this.estadoCivRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadoCivRC.Name = "estadoCivRC";
            this.estadoCivRC.Size = new System.Drawing.Size(164, 24);
            this.estadoCivRC.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(349, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Estado civil";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.comboBox3.Location = new System.Drawing.Point(493, 346);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 24);
            this.comboBox3.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Registrar cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.estadoCivRC);
            this.Controls.Add(this.telCelRC);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.telCasaRC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.colRC);
            this.Controls.Add(this.numExtRC);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.calleRC);
            this.Controls.Add(this.fechaNacRc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rfcRC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.matRC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.patRC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nonRC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.correoRC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comoRC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox telCelRC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox telCasaRC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox colRC;
        private System.Windows.Forms.MaskedTextBox numExtRC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox calleRC;
        private System.Windows.Forms.DateTimePicker fechaNacRc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox matRC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox patRC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nonRC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox correoRC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comoRC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox rfcRC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox estadoCivRC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
    }
}
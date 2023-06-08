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
            this.telCelRC.Location = new System.Drawing.Point(370, 236);
            this.telCelRC.Margin = new System.Windows.Forms.Padding(2);
            this.telCelRC.Mask = "000-000-0000";
            this.telCelRC.Name = "telCelRC";
            this.telCelRC.Size = new System.Drawing.Size(151, 20);
            this.telCelRC.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(262, 239);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 74;
            this.label17.Text = "Telefono celular";
            // 
            // telCasaRC
            // 
            this.telCasaRC.Location = new System.Drawing.Point(115, 234);
            this.telCasaRC.Margin = new System.Windows.Forms.Padding(2);
            this.telCasaRC.Mask = "(999)000-0000";
            this.telCasaRC.Name = "telCasaRC";
            this.telCasaRC.Size = new System.Drawing.Size(124, 20);
            this.telCasaRC.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Telefono de casa";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(592, 197);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Colonia";
            // 
            // colRC
            // 
            this.colRC.Location = new System.Drawing.Point(693, 194);
            this.colRC.Margin = new System.Windows.Forms.Padding(2);
            this.colRC.Name = "colRC";
            this.colRC.Size = new System.Drawing.Size(124, 20);
            this.colRC.TabIndex = 10;
            this.colRC.TextChanged += new System.EventHandler(this.colRC_TextChanged);
            // 
            // numExtRC
            // 
            this.numExtRC.Location = new System.Drawing.Point(370, 198);
            this.numExtRC.Margin = new System.Windows.Forms.Padding(2);
            this.numExtRC.Mask = "99999";
            this.numExtRC.Name = "numExtRC";
            this.numExtRC.Size = new System.Drawing.Size(151, 20);
            this.numExtRC.TabIndex = 9;
            this.numExtRC.ValidatingType = typeof(int);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(261, 201);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "No. exterior";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 198);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Calle";
            // 
            // calleRC
            // 
            this.calleRC.Location = new System.Drawing.Point(115, 196);
            this.calleRC.Margin = new System.Windows.Forms.Padding(2);
            this.calleRC.Name = "calleRC";
            this.calleRC.Size = new System.Drawing.Size(124, 20);
            this.calleRC.TabIndex = 8;
            this.calleRC.TextChanged += new System.EventHandler(this.calleRC_TextChanged);
            // 
            // fechaNacRc
            // 
            this.fechaNacRc.Location = new System.Drawing.Point(370, 157);
            this.fechaNacRc.Margin = new System.Windows.Forms.Padding(2);
            this.fechaNacRc.Name = "fechaNacRc";
            this.fechaNacRc.Size = new System.Drawing.Size(151, 20);
            this.fechaNacRc.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 161);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Fecha de nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Apellido materno";
            // 
            // matRC
            // 
            this.matRC.Location = new System.Drawing.Point(693, 103);
            this.matRC.Margin = new System.Windows.Forms.Padding(2);
            this.matRC.Name = "matRC";
            this.matRC.Size = new System.Drawing.Size(124, 20);
            this.matRC.TabIndex = 4;
            this.matRC.TextChanged += new System.EventHandler(this.matRC_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Apellido paterno";
            // 
            // patRC
            // 
            this.patRC.Location = new System.Drawing.Point(370, 103);
            this.patRC.Margin = new System.Windows.Forms.Padding(2);
            this.patRC.Name = "patRC";
            this.patRC.Size = new System.Drawing.Size(151, 20);
            this.patRC.TabIndex = 3;
            this.patRC.TextChanged += new System.EventHandler(this.patRC_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Nombre(s)";
            // 
            // nonRC
            // 
            this.nonRC.Location = new System.Drawing.Point(115, 110);
            this.nonRC.Margin = new System.Windows.Forms.Padding(2);
            this.nonRC.Name = "nonRC";
            this.nonRC.Size = new System.Drawing.Size(124, 20);
            this.nonRC.TabIndex = 2;
            this.nonRC.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Correo";
            // 
            // correoRC
            // 
            this.correoRC.Location = new System.Drawing.Point(116, 284);
            this.correoRC.Margin = new System.Windows.Forms.Padding(2);
            this.correoRC.Name = "correoRC";
            this.correoRC.ShortcutsEnabled = false;
            this.correoRC.Size = new System.Drawing.Size(124, 20);
            this.correoRC.TabIndex = 13;
            this.correoRC.UseSystemPasswordChar = true;
            this.correoRC.TextChanged += new System.EventHandler(this.correoRC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Como conocio el hotel";
            // 
            // comoRC
            // 
            this.comoRC.FormattingEnabled = true;
            this.comoRC.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.comoRC.Location = new System.Drawing.Point(136, 15);
            this.comoRC.Margin = new System.Windows.Forms.Padding(2);
            this.comoRC.Name = "comoRC";
            this.comoRC.Size = new System.Drawing.Size(124, 21);
            this.comoRC.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "RFC";
            // 
            // rfcRC
            // 
            this.rfcRC.Location = new System.Drawing.Point(116, 157);
            this.rfcRC.Margin = new System.Windows.Forms.Padding(2);
            this.rfcRC.Mask = "99999";
            this.rfcRC.Name = "rfcRC";
            this.rfcRC.Size = new System.Drawing.Size(124, 20);
            this.rfcRC.TabIndex = 5;
            this.rfcRC.ValidatingType = typeof(int);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(592, 151);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 76;
            this.label18.Text = "Estado civil";
            // 
            // estadoCivRC
            // 
            this.estadoCivRC.FormattingEnabled = true;
            this.estadoCivRC.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.estadoCivRC.Location = new System.Drawing.Point(693, 154);
            this.estadoCivRC.Margin = new System.Windows.Forms.Padding(2);
            this.estadoCivRC.Name = "estadoCivRC";
            this.estadoCivRC.Size = new System.Drawing.Size(124, 21);
            this.estadoCivRC.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(262, 284);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 78;
            this.label19.Text = "Estado civil";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.comboBox3.Location = new System.Drawing.Point(370, 281);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(370, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 79;
            this.button1.Text = "Registrar cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 380);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
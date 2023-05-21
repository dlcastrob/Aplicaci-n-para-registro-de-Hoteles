namespace Mad.Ventanas
{
    partial class correoRU
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contraRU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoUsRUCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nomRU = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.patRU = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.matRU = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numNomRU = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fechaNacRU = new System.Windows.Forms.DateTimePicker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.calleRU = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numExtRU = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.colRU = new System.Windows.Forms.TextBox();
            this.telCasaRU = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telCelRU = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.correoRU1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 524);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Nueva cuenta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contraseña";
            // 
            // contraRU
            // 
            this.contraRU.Location = new System.Drawing.Point(117, 339);
            this.contraRU.Margin = new System.Windows.Forms.Padding(2);
            this.contraRU.Name = "contraRU";
            this.contraRU.ShortcutsEnabled = false;
            this.contraRU.Size = new System.Drawing.Size(151, 20);
            this.contraRU.TabIndex = 12;
            this.contraRU.UseSystemPasswordChar = true;
            this.contraRU.TextChanged += new System.EventHandler(this.contraRU_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de usuario";
            // 
            // tipoUsRUCB
            // 
            this.tipoUsRUCB.FormattingEnabled = true;
            this.tipoUsRUCB.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.tipoUsRUCB.Location = new System.Drawing.Point(117, 32);
            this.tipoUsRUCB.Margin = new System.Windows.Forms.Padding(2);
            this.tipoUsRUCB.Name = "tipoUsRUCB";
            this.tipoUsRUCB.Size = new System.Drawing.Size(151, 21);
            this.tipoUsRUCB.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Enabled = false;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(115, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "•Minimo 8 caracteres";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Enabled = false;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(115, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "•Minimo 1 mayuscula";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Enabled = false;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(118, 433);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "•Minimo 1 minuscula";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Enabled = false;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(118, 456);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "•Minimo 1 caracter especial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 301);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nombre(s)";
            // 
            // nomRU
            // 
            this.nomRU.Location = new System.Drawing.Point(116, 106);
            this.nomRU.Margin = new System.Windows.Forms.Padding(2);
            this.nomRU.Name = "nomRU";
            this.nomRU.Size = new System.Drawing.Size(152, 20);
            this.nomRU.TabIndex = 1;
            this.nomRU.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Apellido paterno";
            // 
            // patRU
            // 
            this.patRU.Location = new System.Drawing.Point(414, 107);
            this.patRU.Margin = new System.Windows.Forms.Padding(2);
            this.patRU.Name = "patRU";
            this.patRU.Size = new System.Drawing.Size(151, 20);
            this.patRU.TabIndex = 2;
            this.patRU.TextChanged += new System.EventHandler(this.patRU_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Apellido materno";
            // 
            // matRU
            // 
            this.matRU.Location = new System.Drawing.Point(706, 103);
            this.matRU.Margin = new System.Windows.Forms.Padding(2);
            this.matRU.Name = "matRU";
            this.matRU.Size = new System.Drawing.Size(124, 20);
            this.matRU.TabIndex = 3;
            this.matRU.TextChanged += new System.EventHandler(this.matRU_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 159);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "No. nomina";
            // 
            // numNomRU
            // 
            this.numNomRU.Location = new System.Drawing.Point(117, 159);
            this.numNomRU.Margin = new System.Windows.Forms.Padding(2);
            this.numNomRU.Mask = "99999";
            this.numNomRU.Name = "numNomRU";
            this.numNomRU.Size = new System.Drawing.Size(151, 20);
            this.numNomRU.TabIndex = 4;
            this.numNomRU.ValidatingType = typeof(int);
            this.numNomRU.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.numNomRU_MaskInputRejected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 163);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Fecha de nacimiento";
            // 
            // fechaNacRU
            // 
            this.fechaNacRU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacRU.Location = new System.Drawing.Point(414, 158);
            this.fechaNacRU.Margin = new System.Windows.Forms.Padding(2);
            this.fechaNacRU.MaxDate = new System.DateTime(2023, 5, 21, 16, 52, 52, 0);
            this.fechaNacRU.Name = "fechaNacRU";
            this.fechaNacRU.Size = new System.Drawing.Size(151, 20);
            this.fechaNacRU.TabIndex = 5;
            this.fechaNacRU.Value = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            this.fechaNacRU.ValueChanged += new System.EventHandler(this.fechaNacRU_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 213);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Calle";
            // 
            // calleRU
            // 
            this.calleRU.Location = new System.Drawing.Point(116, 210);
            this.calleRU.Margin = new System.Windows.Forms.Padding(2);
            this.calleRU.Name = "calleRU";
            this.calleRU.Size = new System.Drawing.Size(152, 20);
            this.calleRU.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(305, 214);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "No. exterior";
            // 
            // numExtRU
            // 
            this.numExtRU.Location = new System.Drawing.Point(414, 211);
            this.numExtRU.Margin = new System.Windows.Forms.Padding(2);
            this.numExtRU.Mask = "99999";
            this.numExtRU.Name = "numExtRU";
            this.numExtRU.Size = new System.Drawing.Size(151, 20);
            this.numExtRU.TabIndex = 7;
            this.numExtRU.ValidatingType = typeof(int);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(608, 210);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Colonia";
            // 
            // colRU
            // 
            this.colRU.Location = new System.Drawing.Point(697, 211);
            this.colRU.Margin = new System.Windows.Forms.Padding(2);
            this.colRU.Name = "colRU";
            this.colRU.Size = new System.Drawing.Size(124, 20);
            this.colRU.TabIndex = 8;
            // 
            // telCasaRU
            // 
            this.telCasaRU.Location = new System.Drawing.Point(116, 249);
            this.telCasaRU.Margin = new System.Windows.Forms.Padding(2);
            this.telCasaRU.Mask = "(999)000-0000";
            this.telCasaRU.Name = "telCasaRU";
            this.telCasaRU.Size = new System.Drawing.Size(152, 20);
            this.telCasaRU.TabIndex = 9;
            this.telCasaRU.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Telefono de casa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // telCelRU
            // 
            this.telCelRU.Location = new System.Drawing.Point(414, 250);
            this.telCelRU.Margin = new System.Windows.Forms.Padding(2);
            this.telCelRU.Mask = "000-000-0000";
            this.telCelRU.Name = "telCelRU";
            this.telCelRU.Size = new System.Drawing.Size(151, 20);
            this.telCelRU.TabIndex = 10;
            this.telCelRU.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telCelRU_MaskInputRejected);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(304, 253);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Telefono celular";
            // 
            // correoRU1
            // 
            this.correoRU1.Location = new System.Drawing.Point(117, 298);
            this.correoRU1.Margin = new System.Windows.Forms.Padding(2);
            this.correoRU1.Name = "correoRU1";
            this.correoRU1.Size = new System.Drawing.Size(152, 20);
            this.correoRU1.TabIndex = 11;
            this.correoRU1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // correoRU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 609);
            this.Controls.Add(this.correoRU1);
            this.Controls.Add(this.telCelRU);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.telCasaRU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.colRU);
            this.Controls.Add(this.numExtRU);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.calleRU);
            this.Controls.Add(this.fechaNacRU);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numNomRU);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.matRU);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.patRU);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nomRU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contraRU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoUsRUCB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "correoRU";
            this.Text = "Registro de usuario";
            this.Load += new System.EventHandler(this.Nueva_Cuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contraRU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipoUsRUCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nomRU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox patRU;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox matRU;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox numNomRU;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker fechaNacRU;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox calleRU;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox numExtRU;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox colRU;
        private System.Windows.Forms.MaskedTextBox telCasaRU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox telCelRU;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox correoRU1;
    }
}
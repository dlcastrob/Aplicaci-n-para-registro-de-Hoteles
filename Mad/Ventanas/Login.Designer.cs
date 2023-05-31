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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Operativo"});
            this.comboBox1.Location = new System.Drawing.Point(366, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Nueva cuenta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.button19);
            this.panel20.Location = new System.Drawing.Point(3, 405);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(191, 34);
            this.panel20.TabIndex = 17;
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Image = global::Mad.Properties.Resources.ventas;
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(-10, -5);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(207, 42);
            this.button19.TabIndex = 1;
            this.button19.Text = "Ventas";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.button18);
            this.panel19.Location = new System.Drawing.Point(3, 365);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(191, 34);
            this.panel19.TabIndex = 16;
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Image = global::Mad.Properties.Resources.reserv;
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(-10, -2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(204, 45);
            this.button18.TabIndex = 1;
            this.button18.Text = "Reservar";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.button17);
            this.panel18.Location = new System.Drawing.Point(3, 325);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(191, 34);
            this.panel18.TabIndex = 15;
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Image = global::Mad.Properties.Resources.cancel;
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.Location = new System.Drawing.Point(-12, -3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(205, 39);
            this.button17.TabIndex = 1;
            this.button17.Text = "Cancelar";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button16);
            this.panel17.Location = new System.Drawing.Point(3, 285);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(191, 34);
            this.panel17.TabIndex = 15;
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Image = global::Mad.Properties.Resources.RepHotel;
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.Location = new System.Drawing.Point(-12, -3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(211, 41);
            this.button16.TabIndex = 1;
            this.button16.Text = "Reporte ocupacion";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.button15);
            this.panel16.Location = new System.Drawing.Point(3, 245);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(191, 34);
            this.panel16.TabIndex = 14;
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Image = global::Mad.Properties.Resources.home;
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(-10, -2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(208, 39);
            this.button15.TabIndex = 1;
            this.button15.Text = "Login";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.button14);
            this.panel15.Location = new System.Drawing.Point(3, 205);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(191, 34);
            this.panel15.TabIndex = 2;
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Image = global::Mad.Properties.Resources.historial;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(-4, -6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(198, 43);
            this.button14.TabIndex = 1;
            this.button14.Text = "Historial";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.button13);
            this.panel14.Location = new System.Drawing.Point(3, 165);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(191, 34);
            this.panel14.TabIndex = 2;
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = global::Mad.Properties.Resources.status;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(-12, -2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(205, 46);
            this.button13.TabIndex = 1;
            this.button13.Text = "Estatus habitacion";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button12);
            this.panel13.Location = new System.Drawing.Point(3, 125);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(191, 34);
            this.panel13.TabIndex = 13;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = global::Mad.Properties.Resources.registrarhotel;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(-8, -5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(203, 46);
            this.button12.TabIndex = 1;
            this.button12.Text = "Registra hotel";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.button11);
            this.panel12.Location = new System.Drawing.Point(3, 85);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(191, 34);
            this.panel12.TabIndex = 13;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::Mad.Properties.Resources.registrarcliente;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(-12, -2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(209, 40);
            this.button11.TabIndex = 1;
            this.button11.Text = "Registra cliente";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 34);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Mad.Properties.Resources.registrar_usuario;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-9, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "      Registra usuario";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 36);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Mad.Properties.Resources.icons8_menu_25;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(46, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "       MENU";
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebarContainer.Controls.Add(this.panel1);
            this.sidebarContainer.Controls.Add(this.panel2);
            this.sidebarContainer.Controls.Add(this.panel12);
            this.sidebarContainer.Controls.Add(this.panel13);
            this.sidebarContainer.Controls.Add(this.panel14);
            this.sidebarContainer.Controls.Add(this.panel15);
            this.sidebarContainer.Controls.Add(this.panel16);
            this.sidebarContainer.Controls.Add(this.panel17);
            this.sidebarContainer.Controls.Add(this.panel18);
            this.sidebarContainer.Controls.Add(this.panel19);
            this.sidebarContainer.Controls.Add(this.panel20);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(200, 450);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(70, 450);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(200, 450);
            this.sidebarContainer.TabIndex = 9;
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.sidebarContainer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Login";
            this.panel20.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebarContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Timer SideBarTimer;
    }
}



namespace Mad.Ventanas
{
    partial class CHECKOUT
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
            this.PAGAR = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.IN = new System.Windows.Forms.Button();
            this.OUT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sidebarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO DE RESERVACION";
            // 
            // PAGAR
            // 
            this.PAGAR.AutoSize = true;
            this.PAGAR.Location = new System.Drawing.Point(300, 365);
            this.PAGAR.Name = "PAGAR";
            this.PAGAR.Size = new System.Drawing.Size(58, 17);
            this.PAGAR.TabIndex = 0;
            this.PAGAR.Text = "TOTAL:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(522, 47);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.DESCRIPCION,
            this.MONTO});
            this.dataGridView1.Location = new System.Drawing.Point(294, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 197);
            this.dataGridView1.TabIndex = 2;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.MinimumWidth = 6;
            this.TIPO.Name = "TIPO";
            this.TIPO.Width = 125;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 6;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Width = 125;
            // 
            // MONTO
            // 
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.MinimumWidth = 6;
            this.MONTO.Name = "MONTO";
            this.MONTO.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 362);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 525);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "PAGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 17);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID Cliente";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(522, 93);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(361, 22);
            this.textBox3.TabIndex = 20;
            // 
            // label4
            // 
            /*
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID Reservacion";*/
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 468);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ingrese Num de tarjeta";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(480, 460);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(160, 22);
            this.textBox6.TabIndex = 26;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 436);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Forma de pago";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Tarjeta Credito",
            "Tarjeta Debito",
            "Efectivo"});
            this.comboBox4.Location = new System.Drawing.Point(480, 426);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(160, 24);
            this.comboBox4.TabIndex = 24;
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
            this.sidebarContainer.Controls.Add(this.IN);
            this.sidebarContainer.Controls.Add(this.OUT);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(200, 550);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(69, 450);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(200, 550);
            this.sidebarContainer.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 36);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Mad.Properties.Resources.icons8_menu_25;
            this.pictureBox1.Location = new System.Drawing.Point(9, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(45, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "       MENU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 34);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Mad.Properties.Resources.registrar_usuario;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-9, -2);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 43);
            this.button5.TabIndex = 9;
            this.button5.Text = "      Registra usuario";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.button11);
            this.panel12.Location = new System.Drawing.Point(3, 80);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(209, 39);
            this.button11.TabIndex = 10;
            this.button11.Text = "Registra cliente";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button12);
            this.panel13.Location = new System.Drawing.Point(3, 118);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(203, 46);
            this.button12.TabIndex = 11;
            this.button12.Text = "Registra hotel";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.button13);
            this.panel14.Location = new System.Drawing.Point(3, 156);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(205, 46);
            this.button13.TabIndex = 12;
            this.button13.Text = "Estatus habitacion";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.button14);
            this.panel15.Location = new System.Drawing.Point(3, 194);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(197, 43);
            this.button14.TabIndex = 13;
            this.button14.Text = "Historial";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.button15);
            this.panel16.Location = new System.Drawing.Point(3, 232);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button15.Location = new System.Drawing.Point(-11, -2);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(208, 39);
            this.button15.TabIndex = 14;
            this.button15.Text = "Login";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button16);
            this.panel17.Location = new System.Drawing.Point(3, 270);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button16.Location = new System.Drawing.Point(-12, -2);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(211, 41);
            this.button16.TabIndex = 15;
            this.button16.Text = "Reporte ocupacion";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.button17);
            this.panel18.Location = new System.Drawing.Point(3, 308);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button17.Location = new System.Drawing.Point(-12, -2);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(205, 39);
            this.button17.TabIndex = 16;
            this.button17.Text = "Cancelar";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.button18);
            this.panel19.Location = new System.Drawing.Point(3, 346);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button18.Location = new System.Drawing.Point(-11, -2);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(204, 46);
            this.button18.TabIndex = 17;
            this.button18.Text = "Reservar";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.button19);
            this.panel20.Location = new System.Drawing.Point(3, 384);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button19.Location = new System.Drawing.Point(-11, -5);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(207, 42);
            this.button19.TabIndex = 18;
            this.button19.Text = "Ventas";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // IN
            // 
            this.IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IN.ForeColor = System.Drawing.Color.Transparent;
            this.IN.Image = global::Mad.Properties.Resources.ventas;
            this.IN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IN.Location = new System.Drawing.Point(3, 423);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(207, 42);
            this.IN.TabIndex = 22;
            this.IN.Text = "CHECK IN";
            this.IN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IN.UseVisualStyleBackColor = true;
            this.IN.Click += new System.EventHandler(this.IN_Click);
            // 
            // OUT
            // 
            this.OUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OUT.ForeColor = System.Drawing.Color.White;
            this.OUT.Image = global::Mad.Properties.Resources.ventas;
            this.OUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OUT.Location = new System.Drawing.Point(3, 471);
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(207, 42);
            this.OUT.TabIndex = 23;
            this.OUT.Text = "CHECK OUT";
            this.OUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OUT.UseVisualStyleBackColor = true;
            this.OUT.Click += new System.EventHandler(this.OUT_Click);
            // 
            // CHECKOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 561);
            this.Controls.Add(this.sidebarContainer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PAGAR);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CHECKOUT";
            this.Text = "CHECKOUT";
            this.Load += new System.EventHandler(this.CHECKOUT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sidebarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PAGAR;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button IN;
        private System.Windows.Forms.Button OUT;
    }
}

namespace Mad.Ventanas
{
    partial class Form2
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
            this.nContraTB = new System.Windows.Forms.TextBox();
            this.okNCTB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nContraTB
            // 
            this.nContraTB.Location = new System.Drawing.Point(143, 177);
            this.nContraTB.Margin = new System.Windows.Forms.Padding(4);
            this.nContraTB.Name = "nContraTB";
            this.nContraTB.Size = new System.Drawing.Size(197, 22);
            this.nContraTB.TabIndex = 1;
            // 
            // okNCTB
            // 
            this.okNCTB.Location = new System.Drawing.Point(187, 228);
            this.okNCTB.Margin = new System.Windows.Forms.Padding(4);
            this.okNCTB.Name = "okNCTB";
            this.okNCTB.Size = new System.Drawing.Size(100, 28);
            this.okNCTB.TabIndex = 2;
            this.okNCTB.Text = "Aceptar";
            this.okNCTB.UseVisualStyleBackColor = true;
            this.okNCTB.Click += new System.EventHandler(this.okNCTB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una nueva contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "A que usuario se le hara el cambio?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okNCTB);
            this.Controls.Add(this.nContraTB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Nueva contraseña";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nContraTB;
        private System.Windows.Forms.Button okNCTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
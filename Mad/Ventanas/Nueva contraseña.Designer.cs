
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
            this.SuspendLayout();
            // 
            // nContraTB
            // 
            this.nContraTB.Location = new System.Drawing.Point(107, 123);
            this.nContraTB.Name = "nContraTB";
            this.nContraTB.Size = new System.Drawing.Size(149, 20);
            this.nContraTB.TabIndex = 0;
            // 
            // okNCTB
            // 
            this.okNCTB.Location = new System.Drawing.Point(140, 185);
            this.okNCTB.Name = "okNCTB";
            this.okNCTB.Size = new System.Drawing.Size(75, 23);
            this.okNCTB.TabIndex = 1;
            this.okNCTB.Text = "Aceptar";
            this.okNCTB.UseVisualStyleBackColor = true;
            this.okNCTB.Click += new System.EventHandler(this.okNCTB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese una nueva contraseña";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okNCTB);
            this.Controls.Add(this.nContraTB);
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
    }
}
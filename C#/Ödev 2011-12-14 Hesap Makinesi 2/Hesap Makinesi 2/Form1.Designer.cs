namespace Hesap_Makinesi_2
{
    partial class Form1
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnKarekok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(12, 12);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(78, 20);
            this.txtSayi1.TabIndex = 0;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(96, 12);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(78, 20);
            this.txtSayi2.TabIndex = 1;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(12, 38);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(50, 36);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(68, 38);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(50, 36);
            this.btnCikart.TabIndex = 3;
            this.btnCikart.Text = "-";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(124, 38);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 36);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(12, 80);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(50, 36);
            this.btnCarp.TabIndex = 3;
            this.btnCarp.Text = "×";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(68, 80);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(50, 36);
            this.btnBol.TabIndex = 3;
            this.btnBol.Text = "÷";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnKarekok
            // 
            this.btnKarekok.Location = new System.Drawing.Point(124, 80);
            this.btnKarekok.Name = "btnKarekok";
            this.btnKarekok.Size = new System.Drawing.Size(50, 36);
            this.btnKarekok.TabIndex = 3;
            this.btnKarekok.Text = "√";
            this.btnKarekok.UseVisualStyleBackColor = true;
            this.btnKarekok.Click += new System.EventHandler(this.btnKarekok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 128);
            this.Controls.Add(this.btnKarekok);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnKarekok;
    }
}


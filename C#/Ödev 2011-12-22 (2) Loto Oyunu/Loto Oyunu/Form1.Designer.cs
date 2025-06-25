namespace Loto_Oyunu
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
            this.txtSayi3 = new System.Windows.Forms.TextBox();
            this.txtSayi4 = new System.Windows.Forms.TextBox();
            this.txtSayi5 = new System.Windows.Forms.TextBox();
            this.txtSayi6 = new System.Windows.Forms.TextBox();
            this.btnMakOynat = new System.Windows.Forms.Button();
            this.btnHafCekilisi = new System.Windows.Forms.Button();
            this.btnKacTaneTuttu = new System.Windows.Forms.Button();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi3 = new System.Windows.Forms.Label();
            this.lblSayi4 = new System.Windows.Forms.Label();
            this.lblSayi5 = new System.Windows.Forms.Label();
            this.lblSayi6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(12, 41);
            this.txtSayi1.MaxLength = 2;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(34, 20);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi6_KeyPress);
            this.txtSayi1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSayi6_KeyUp);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(52, 41);
            this.txtSayi2.MaxLength = 2;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(34, 20);
            this.txtSayi2.TabIndex = 0;
            this.txtSayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi6_KeyPress);
            this.txtSayi2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSayi6_KeyUp);
            // 
            // txtSayi3
            // 
            this.txtSayi3.Location = new System.Drawing.Point(92, 41);
            this.txtSayi3.MaxLength = 2;
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(34, 20);
            this.txtSayi3.TabIndex = 0;
            this.txtSayi3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi6_KeyPress);
            this.txtSayi3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSayi6_KeyUp);
            // 
            // txtSayi4
            // 
            this.txtSayi4.Location = new System.Drawing.Point(132, 41);
            this.txtSayi4.MaxLength = 2;
            this.txtSayi4.Name = "txtSayi4";
            this.txtSayi4.Size = new System.Drawing.Size(34, 20);
            this.txtSayi4.TabIndex = 0;
            this.txtSayi4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi6_KeyPress);
            this.txtSayi4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSayi6_KeyUp);
            // 
            // txtSayi5
            // 
            this.txtSayi5.Location = new System.Drawing.Point(172, 41);
            this.txtSayi5.MaxLength = 2;
            this.txtSayi5.Name = "txtSayi5";
            this.txtSayi5.Size = new System.Drawing.Size(34, 20);
            this.txtSayi5.TabIndex = 0;
            this.txtSayi5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi6_KeyPress);
            this.txtSayi5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSayi6_KeyUp);
            // 
            // txtSayi6
            // 
            this.txtSayi6.Location = new System.Drawing.Point(212, 41);
            this.txtSayi6.MaxLength = 2;
            this.txtSayi6.Name = "txtSayi6";
            this.txtSayi6.Size = new System.Drawing.Size(34, 20);
            this.txtSayi6.TabIndex = 0;
            this.txtSayi6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi6_KeyPress);
            this.txtSayi6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSayi6_KeyUp);
            // 
            // btnMakOynat
            // 
            this.btnMakOynat.Location = new System.Drawing.Point(12, 15);
            this.btnMakOynat.Name = "btnMakOynat";
            this.btnMakOynat.Size = new System.Drawing.Size(114, 20);
            this.btnMakOynat.TabIndex = 1;
            this.btnMakOynat.Text = "Makineye Oynat";
            this.btnMakOynat.UseVisualStyleBackColor = true;
            this.btnMakOynat.Click += new System.EventHandler(this.btnMakOynat_Click);
            // 
            // btnHafCekilisi
            // 
            this.btnHafCekilisi.Enabled = false;
            this.btnHafCekilisi.Location = new System.Drawing.Point(12, 67);
            this.btnHafCekilisi.Name = "btnHafCekilisi";
            this.btnHafCekilisi.Size = new System.Drawing.Size(114, 20);
            this.btnHafCekilisi.TabIndex = 2;
            this.btnHafCekilisi.Text = "Haftanın Çekilişi";
            this.btnHafCekilisi.UseVisualStyleBackColor = true;
            this.btnHafCekilisi.Click += new System.EventHandler(this.btnHafCekilisi_Click);
            // 
            // btnKacTaneTuttu
            // 
            this.btnKacTaneTuttu.Enabled = false;
            this.btnKacTaneTuttu.Location = new System.Drawing.Point(132, 67);
            this.btnKacTaneTuttu.Name = "btnKacTaneTuttu";
            this.btnKacTaneTuttu.Size = new System.Drawing.Size(114, 20);
            this.btnKacTaneTuttu.TabIndex = 2;
            this.btnKacTaneTuttu.Text = "Kaç Tane Tuttu";
            this.btnKacTaneTuttu.UseVisualStyleBackColor = true;
            this.btnKacTaneTuttu.Click += new System.EventHandler(this.btnKacTaneTuttu_Click);
            // 
            // lblSayi1
            // 
            this.lblSayi1.BackColor = System.Drawing.Color.White;
            this.lblSayi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi1.Location = new System.Drawing.Point(12, 90);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(34, 20);
            this.lblSayi1.TabIndex = 3;
            this.lblSayi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi2
            // 
            this.lblSayi2.BackColor = System.Drawing.Color.White;
            this.lblSayi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi2.Location = new System.Drawing.Point(52, 90);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(34, 20);
            this.lblSayi2.TabIndex = 3;
            this.lblSayi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi3
            // 
            this.lblSayi3.BackColor = System.Drawing.Color.White;
            this.lblSayi3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi3.Location = new System.Drawing.Point(92, 90);
            this.lblSayi3.Name = "lblSayi3";
            this.lblSayi3.Size = new System.Drawing.Size(34, 20);
            this.lblSayi3.TabIndex = 3;
            this.lblSayi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi4
            // 
            this.lblSayi4.BackColor = System.Drawing.Color.White;
            this.lblSayi4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi4.Location = new System.Drawing.Point(132, 90);
            this.lblSayi4.Name = "lblSayi4";
            this.lblSayi4.Size = new System.Drawing.Size(34, 20);
            this.lblSayi4.TabIndex = 3;
            this.lblSayi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi5
            // 
            this.lblSayi5.BackColor = System.Drawing.Color.White;
            this.lblSayi5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi5.Location = new System.Drawing.Point(172, 90);
            this.lblSayi5.Name = "lblSayi5";
            this.lblSayi5.Size = new System.Drawing.Size(34, 20);
            this.lblSayi5.TabIndex = 3;
            this.lblSayi5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi6
            // 
            this.lblSayi6.BackColor = System.Drawing.Color.White;
            this.lblSayi6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi6.Location = new System.Drawing.Point(212, 90);
            this.lblSayi6.Name = "lblSayi6";
            this.lblSayi6.Size = new System.Drawing.Size(34, 20);
            this.lblSayi6.TabIndex = 3;
            this.lblSayi6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 119);
            this.Controls.Add(this.lblSayi6);
            this.Controls.Add(this.lblSayi5);
            this.Controls.Add(this.lblSayi4);
            this.Controls.Add(this.lblSayi3);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.btnKacTaneTuttu);
            this.Controls.Add(this.btnHafCekilisi);
            this.Controls.Add(this.btnMakOynat);
            this.Controls.Add(this.txtSayi6);
            this.Controls.Add(this.txtSayi5);
            this.Controls.Add(this.txtSayi4);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayısal Loto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi3;
        private System.Windows.Forms.TextBox txtSayi4;
        private System.Windows.Forms.TextBox txtSayi5;
        private System.Windows.Forms.TextBox txtSayi6;
        private System.Windows.Forms.Button btnMakOynat;
        private System.Windows.Forms.Button btnHafCekilisi;
        private System.Windows.Forms.Button btnKacTaneTuttu;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi3;
        private System.Windows.Forms.Label lblSayi4;
        private System.Windows.Forms.Label lblSayi5;
        private System.Windows.Forms.Label lblSayi6;
    }
}


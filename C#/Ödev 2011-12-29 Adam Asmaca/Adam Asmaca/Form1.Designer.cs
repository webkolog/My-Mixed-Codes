namespace Adam_Asmaca
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOyna = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblKelimeSayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 93);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(12, 111);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(75, 23);
            this.btnOyna.TabIndex = 1;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 159);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(504, 47);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Location = new System.Drawing.Point(263, 116);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(33, 13);
            this.lblHak.TabIndex = 3;
            this.lblHak.Text = "Hak: ";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(333, 116);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(38, 13);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "Puan: ";
            // 
            // lblKelimeSayisi
            // 
            this.lblKelimeSayisi.AutoSize = true;
            this.lblKelimeSayisi.Location = new System.Drawing.Point(174, 116);
            this.lblKelimeSayisi.Name = "lblKelimeSayisi";
            this.lblKelimeSayisi.Size = new System.Drawing.Size(44, 13);
            this.lblKelimeSayisi.TabIndex = 4;
            this.lblKelimeSayisi.Text = "Kelime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kelime:";
            // 
            // btnYenile
            // 
            this.btnYenile.Enabled = false;
            this.btnYenile.Location = new System.Drawing.Point(93, 111);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKelimeSayisi);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BilgeAdam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblKelimeSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYenile;
    }
}


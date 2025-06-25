namespace Ay_Bulucu
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
            this.txtAyNo = new System.Windows.Forms.TextBox();
            this.btnAyBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAyNo
            // 
            this.txtAyNo.Location = new System.Drawing.Point(48, 33);
            this.txtAyNo.Name = "txtAyNo";
            this.txtAyNo.Size = new System.Drawing.Size(82, 20);
            this.txtAyNo.TabIndex = 0;
            // 
            // btnAyBul
            // 
            this.btnAyBul.Location = new System.Drawing.Point(48, 59);
            this.btnAyBul.Name = "btnAyBul";
            this.btnAyBul.Size = new System.Drawing.Size(82, 33);
            this.btnAyBul.TabIndex = 1;
            this.btnAyBul.Text = "Ay Bul";
            this.btnAyBul.UseVisualStyleBackColor = true;
            this.btnAyBul.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 131);
            this.Controls.Add(this.btnAyBul);
            this.Controls.Add(this.txtAyNo);
            this.Name = "Form1";
            this.Text = "Ay Bul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAyNo;
        private System.Windows.Forms.Button btnAyBul;
    }
}


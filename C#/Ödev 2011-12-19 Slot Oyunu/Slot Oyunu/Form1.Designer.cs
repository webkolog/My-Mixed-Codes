namespace Slot_Oyunu
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKrediAl = new System.Windows.Forms.Button();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.btnOyna = new System.Windows.Forms.Button();
            this.lblSayi3 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kredi Satın Al:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "$";
            // 
            // btnKrediAl
            // 
            this.btnKrediAl.Location = new System.Drawing.Point(111, 132);
            this.btnKrediAl.Name = "btnKrediAl";
            this.btnKrediAl.Size = new System.Drawing.Size(93, 20);
            this.btnKrediAl.TabIndex = 13;
            this.btnKrediAl.Text = "Kredi Al";
            this.btnKrediAl.UseVisualStyleBackColor = true;
            this.btnKrediAl.Click += new System.EventHandler(this.btnKrediAl_Click);
            // 
            // txtKredi
            // 
            this.txtKredi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKredi.Location = new System.Drawing.Point(12, 132);
            this.txtKredi.MaxLength = 3;
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(80, 20);
            this.txtKredi.TabIndex = 12;
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(12, 166);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(80, 28);
            this.btnOyna.TabIndex = 11;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // lblSayi3
            // 
            this.lblSayi3.BackColor = System.Drawing.Color.Red;
            this.lblSayi3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi3.Location = new System.Drawing.Point(144, 42);
            this.lblSayi3.Name = "lblSayi3";
            this.lblSayi3.Size = new System.Drawing.Size(60, 60);
            this.lblSayi3.TabIndex = 8;
            this.lblSayi3.Text = "7";
            this.lblSayi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi2
            // 
            this.lblSayi2.BackColor = System.Drawing.Color.Red;
            this.lblSayi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(78, 42);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(60, 60);
            this.lblSayi2.TabIndex = 9;
            this.lblSayi2.Text = "7";
            this.lblSayi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi1
            // 
            this.lblSayi1.BackColor = System.Drawing.Color.Red;
            this.lblSayi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayi1.ForeColor = System.Drawing.Color.Black;
            this.lblSayi1.Location = new System.Drawing.Point(12, 42);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(60, 60);
            this.lblSayi1.TabIndex = 10;
            this.lblSayi1.Text = "7";
            this.lblSayi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Location = new System.Drawing.Point(12, 9);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(52, 13);
            this.lblKasa.TabIndex = 7;
            this.lblKasa.Text = "Kasa: 0 $";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKrediAl);
            this.Controls.Add(this.txtKredi);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.lblSayi3);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.lblKasa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKrediAl;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Label lblSayi3;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Timer timer1;
    }
}


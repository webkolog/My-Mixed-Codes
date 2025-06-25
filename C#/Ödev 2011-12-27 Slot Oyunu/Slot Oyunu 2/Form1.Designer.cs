namespace Slot_Oyunu_2
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
            this.btnOyna = new System.Windows.Forms.Button();
            this.btnKrediAl = new System.Windows.Forms.Button();
            this.lblKasa = new System.Windows.Forms.Label();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.lblTL = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.Enabled = false;
            this.btnOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyna.Location = new System.Drawing.Point(290, 313);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(130, 33);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Text = "BAŞLAT";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // btnKrediAl
            // 
            this.btnKrediAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKrediAl.Location = new System.Drawing.Point(290, 353);
            this.btnKrediAl.Name = "btnKrediAl";
            this.btnKrediAl.Size = new System.Drawing.Size(130, 33);
            this.btnKrediAl.TabIndex = 0;
            this.btnKrediAl.Text = "KREDİ AL";
            this.btnKrediAl.UseVisualStyleBackColor = true;
            this.btnKrediAl.Click += new System.EventHandler(this.btnKrediAl_Click);
            // 
            // lblKasa
            // 
            this.lblKasa.BackColor = System.Drawing.Color.Black;
            this.lblKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.ForeColor = System.Drawing.Color.Lime;
            this.lblKasa.Location = new System.Drawing.Point(104, 321);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(165, 21);
            this.lblKasa.TabIndex = 1;
            this.lblKasa.Text = "0 TL";
            this.lblKasa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKredi
            // 
            this.txtKredi.BackColor = System.Drawing.Color.Black;
            this.txtKredi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKredi.ForeColor = System.Drawing.Color.Lime;
            this.txtKredi.Location = new System.Drawing.Point(108, 361);
            this.txtKredi.MaxLength = 3;
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(130, 19);
            this.txtKredi.TabIndex = 2;
            this.txtKredi.Text = "0";
            this.txtKredi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKredi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKredi_MouseClick);
            this.txtKredi.TextChanged += new System.EventHandler(this.txtKredi_TextChanged);
            // 
            // lblTL
            // 
            this.lblTL.BackColor = System.Drawing.Color.Black;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTL.ForeColor = System.Drawing.Color.Lime;
            this.lblTL.Location = new System.Drawing.Point(237, 361);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(32, 21);
            this.lblTL.TabIndex = 1;
            this.lblTL.Text = "TL";
            this.lblTL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.Transparent;
            this.picBox1.Location = new System.Drawing.Point(13, 112);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(128, 128);
            this.picBox1.TabIndex = 3;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BackColor = System.Drawing.Color.Transparent;
            this.picBox2.Location = new System.Drawing.Point(152, 112);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(128, 128);
            this.picBox2.TabIndex = 3;
            this.picBox2.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.BackColor = System.Drawing.Color.Transparent;
            this.picBox3.Location = new System.Drawing.Point(291, 112);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(128, 128);
            this.picBox3.TabIndex = 3;
            this.picBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Slot_Oyunu_2.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(432, 397);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.txtKredi);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.lblKasa);
            this.Controls.Add(this.btnKrediAl);
            this.Controls.Add(this.btnOyna);
            this.MaximumSize = new System.Drawing.Size(448, 435);
            this.MinimumSize = new System.Drawing.Size(448, 435);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ali Baba\'nın Slot Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Button btnKrediAl;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace Yarış_Oyunu
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picAraba1 = new System.Windows.Forms.PictureBox();
            this.picAraba2 = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.btnYaristir = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAraba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAraba2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picAraba1
            // 
            this.picAraba1.BackColor = System.Drawing.Color.Transparent;
            this.picAraba1.Image = global::Yarış_Oyunu.Properties.Resources._12413709111282372036Anonymous_BMW_Z4_top_view_svg_thumb;
            this.picAraba1.ImageLocation = "";
            this.picAraba1.Location = new System.Drawing.Point(12, 136);
            this.picAraba1.Name = "picAraba1";
            this.picAraba1.Size = new System.Drawing.Size(100, 47);
            this.picAraba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAraba1.TabIndex = 0;
            this.picAraba1.TabStop = false;
            this.picAraba1.Tag = "Mavi Araba";
            // 
            // picAraba2
            // 
            this.picAraba2.BackColor = System.Drawing.Color.Transparent;
            this.picAraba2.Image = global::Yarış_Oyunu.Properties.Resources.green_car_top_view_th;
            this.picAraba2.ImageLocation = "";
            this.picAraba2.Location = new System.Drawing.Point(12, 226);
            this.picAraba2.Name = "picAraba2";
            this.picAraba2.Size = new System.Drawing.Size(100, 47);
            this.picAraba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAraba2.TabIndex = 0;
            this.picAraba2.TabStop = false;
            this.picAraba2.Tag = "Yeşil Araba";
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFinish.ForeColor = System.Drawing.Color.Black;
            this.lblFinish.Location = new System.Drawing.Point(753, 120);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(11, 167);
            this.lblFinish.TabIndex = 1;
            // 
            // btnYaristir
            // 
            this.btnYaristir.Location = new System.Drawing.Point(593, 12);
            this.btnYaristir.Name = "btnYaristir";
            this.btnYaristir.Size = new System.Drawing.Size(97, 31);
            this.btnYaristir.TabIndex = 2;
            this.btnYaristir.Text = "Yarıştır";
            this.btnYaristir.UseVisualStyleBackColor = true;
            this.btnYaristir.Click += new System.EventHandler(this.btnYaristir_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Enabled = false;
            this.btnYenile.Location = new System.Drawing.Point(696, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(97, 31);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yarış_Oyunu.Properties.Resources.Road1;
            this.ClientSize = new System.Drawing.Size(805, 412);
            this.Controls.Add(this.picAraba2);
            this.Controls.Add(this.picAraba1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnYaristir);
            this.Controls.Add(this.lblFinish);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama Yarışı";
            ((System.ComponentModel.ISupportInitialize)(this.picAraba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAraba2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picAraba1;
        private System.Windows.Forms.PictureBox picAraba2;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button btnYaristir;
        private System.Windows.Forms.Button btnYenile;
    }
}


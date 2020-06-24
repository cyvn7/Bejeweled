namespace Bejeweled
{
    partial class Bejeweled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bejeweled));
            this.start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.punkty = new System.Windows.Forms.Label();
            this.p_glowny = new System.Windows.Forms.Panel();
            this.zd_punkty = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.start.Font = new System.Drawing.Font("KG Blank Space Solid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.start.Location = new System.Drawing.Point(12, 184);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(160, 43);
            this.start.TabIndex = 65;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Purple;
            this.groupBox1.Controls.Add(this.punkty);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(159, 49);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PUNKTY";
            // 
            // punkty
            // 
            this.punkty.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punkty.ForeColor = System.Drawing.Color.BlueViolet;
            this.punkty.Location = new System.Drawing.Point(6, 15);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(147, 29);
            this.punkty.TabIndex = 0;
            this.punkty.Text = "0";
            this.punkty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_glowny
            // 
            this.p_glowny.BackColor = System.Drawing.Color.DarkOrchid;
            this.p_glowny.Location = new System.Drawing.Point(179, 12);
            this.p_glowny.Name = "p_glowny";
            this.p_glowny.Size = new System.Drawing.Size(302, 301);
            this.p_glowny.TabIndex = 67;
            this.p_glowny.Paint += new System.Windows.Forms.PaintEventHandler(this.p_glowny_Paint);
            // 
            // zd_punkty
            // 
            this.zd_punkty.AutoSize = true;
            this.zd_punkty.BackColor = System.Drawing.Color.Transparent;
            this.zd_punkty.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zd_punkty.ForeColor = System.Drawing.Color.Transparent;
            this.zd_punkty.Location = new System.Drawing.Point(67, 258);
            this.zd_punkty.Name = "zd_punkty";
            this.zd_punkty.Size = new System.Drawing.Size(0, 32);
            this.zd_punkty.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bejeweled.Properties.Resources.bonus_points;
            this.pictureBox1.Location = new System.Drawing.Point(43, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox57.Image")));
            this.pictureBox57.Location = new System.Drawing.Point(12, 12);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(161, 109);
            this.pictureBox57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox57.TabIndex = 64;
            this.pictureBox57.TabStop = false;
            // 
            // Bejeweled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(493, 361);
            this.Controls.Add(this.zd_punkty);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p_glowny);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pictureBox57);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 400);
            this.MinimumSize = new System.Drawing.Size(509, 400);
            this.Name = "Bejeweled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejeweled";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox57;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label punkty;
        private System.Windows.Forms.Panel p_glowny;
        private System.Windows.Forms.Label zd_punkty;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


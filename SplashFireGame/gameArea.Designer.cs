namespace SplashFireGame
{
    partial class gameArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameArea));
            this.nmBullet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbGun = new System.Windows.Forms.PictureBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.fireBtn = new System.Windows.Forms.Button();
            this.btnPlyAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).BeginInit();
            this.SuspendLayout();
            // 
            // nmBullet
            // 
            this.nmBullet.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmBullet.Location = new System.Drawing.Point(24, 231);
            this.nmBullet.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmBullet.Name = "nmBullet";
            this.nmBullet.Size = new System.Drawing.Size(120, 32);
            this.nmBullet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "No of Bullet";
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(24, 269);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 55);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbGun
            // 
            this.pbGun.Image = ((System.Drawing.Image)(resources.GetObject("pbGun.Image")));
            this.pbGun.Location = new System.Drawing.Point(248, 50);
            this.pbGun.Name = "pbGun";
            this.pbGun.Size = new System.Drawing.Size(304, 213);
            this.pbGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGun.TabIndex = 3;
            this.pbGun.TabStop = false;
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(230, 285);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(76, 39);
            this.btnSpin.TabIndex = 4;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // fireBtn
            // 
            this.fireBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireBtn.Location = new System.Drawing.Point(230, 336);
            this.fireBtn.Name = "fireBtn";
            this.fireBtn.Size = new System.Drawing.Size(76, 34);
            this.fireBtn.TabIndex = 5;
            this.fireBtn.Text = "Fire";
            this.fireBtn.UseVisualStyleBackColor = true;
            this.fireBtn.Click += new System.EventHandler(this.fireBtn_Click);
            // 
            // btnPlyAgain
            // 
            this.btnPlyAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlyAgain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlyAgain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlyAgain.Location = new System.Drawing.Point(71, 389);
            this.btnPlyAgain.Name = "btnPlyAgain";
            this.btnPlyAgain.Size = new System.Drawing.Size(139, 32);
            this.btnPlyAgain.TabIndex = 6;
            this.btnPlyAgain.Text = "Play Again";
            this.btnPlyAgain.UseVisualStyleBackColor = false;
            this.btnPlyAgain.Click += new System.EventHandler(this.btnPlyAgain_Click);
            // 
            // gameArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlyAgain);
            this.Controls.Add(this.fireBtn);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pbGun);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmBullet);
            this.Name = "gameArea";
            this.Text = "gameArea";
            this.Load += new System.EventHandler(this.gameArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmBullet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pbGun;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button fireBtn;
        private System.Windows.Forms.Button btnPlyAgain;
    }
}
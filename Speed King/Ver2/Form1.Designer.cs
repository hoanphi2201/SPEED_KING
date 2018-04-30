namespace Ver2
{
    partial class SpeedKing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeedKing));
            this.pcbBackGround1 = new System.Windows.Forms.PictureBox();
            this.pcbBackGround2 = new System.Windows.Forms.PictureBox();
            this.xePlayer = new System.Windows.Forms.PictureBox();
            this.XeComPuter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackGround1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackGround2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XeComPuter)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBackGround1
            // 
            this.pcbBackGround1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pcbBackGround1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbBackGround1.BackgroundImage")));
            this.pcbBackGround1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbBackGround1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbBackGround1.InitialImage")));
            this.pcbBackGround1.Location = new System.Drawing.Point(-11, -2);
            this.pcbBackGround1.Name = "pcbBackGround1";
            this.pcbBackGround1.Size = new System.Drawing.Size(650, 820);
            this.pcbBackGround1.TabIndex = 0;
            this.pcbBackGround1.TabStop = false;
            this.pcbBackGround1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbBackGround2
            // 
            this.pcbBackGround2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pcbBackGround2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbBackGround2.BackgroundImage")));
            this.pcbBackGround2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbBackGround2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbBackGround2.InitialImage")));
            this.pcbBackGround2.Location = new System.Drawing.Point(-11, -2);
            this.pcbBackGround2.Name = "pcbBackGround2";
            this.pcbBackGround2.Size = new System.Drawing.Size(650, 820);
            this.pcbBackGround2.TabIndex = 3;
            this.pcbBackGround2.TabStop = false;
            // 
            // xePlayer
            // 
            this.xePlayer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.xePlayer.Image = ((System.Drawing.Image)(resources.GetObject("xePlayer.Image")));
            this.xePlayer.Location = new System.Drawing.Point(130, 77);
            this.xePlayer.Name = "xePlayer";
            this.xePlayer.Size = new System.Drawing.Size(79, 156);
            this.xePlayer.TabIndex = 4;
            this.xePlayer.TabStop = false;
            // 
            // XeComPuter
            // 
            this.XeComPuter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.XeComPuter.Image = ((System.Drawing.Image)(resources.GetObject("XeComPuter.Image")));
            this.XeComPuter.Location = new System.Drawing.Point(329, 543);
            this.XeComPuter.Name = "XeComPuter";
            this.XeComPuter.Size = new System.Drawing.Size(79, 156);
            this.XeComPuter.TabIndex = 5;
            this.XeComPuter.TabStop = false;
            this.XeComPuter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.XeComPuter_PreviewKeyDown);
            // 
            // SpeedKing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 742);
            this.Controls.Add(this.XeComPuter);
            this.Controls.Add(this.xePlayer);
            this.Controls.Add(this.pcbBackGround2);
            this.Controls.Add(this.pcbBackGround1);
            this.Name = "SpeedKing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeedKing";
            this.Load += new System.EventHandler(this.SpeedKing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackGround1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackGround2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XeComPuter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBackGround1;
        private System.Windows.Forms.PictureBox pcbBackGround2;
        private System.Windows.Forms.PictureBox xePlayer;
        private System.Windows.Forms.PictureBox XeComPuter;
    }
}


namespace Year2Conn
{
    partial class Cv2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cv2));
            this.btnOrigin = new System.Windows.Forms.Button();
            this.btnGrScl1 = new System.Windows.Forms.Button();
            this.btnGrScl2 = new System.Windows.Forms.Button();
            this.btnOpnPic = new System.Windows.Forms.Button();
            this.picb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrigin
            // 
            this.btnOrigin.Location = new System.Drawing.Point(12, 12);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(165, 46);
            this.btnOrigin.TabIndex = 0;
            this.btnOrigin.Text = "Origin";
            this.btnOrigin.UseVisualStyleBackColor = true;
            // 
            // btnGrScl1
            // 
            this.btnGrScl1.Location = new System.Drawing.Point(183, 12);
            this.btnGrScl1.Name = "btnGrScl1";
            this.btnGrScl1.Size = new System.Drawing.Size(165, 46);
            this.btnGrScl1.TabIndex = 1;
            this.btnGrScl1.Text = "Gray scale1";
            this.btnGrScl1.UseVisualStyleBackColor = true;
            // 
            // btnGrScl2
            // 
            this.btnGrScl2.Location = new System.Drawing.Point(354, 12);
            this.btnGrScl2.Name = "btnGrScl2";
            this.btnGrScl2.Size = new System.Drawing.Size(165, 46);
            this.btnGrScl2.TabIndex = 2;
            this.btnGrScl2.Text = "Gray scale2";
            this.btnGrScl2.UseVisualStyleBackColor = true;
            // 
            // btnOpnPic
            // 
            this.btnOpnPic.Location = new System.Drawing.Point(525, 12);
            this.btnOpnPic.Name = "btnOpnPic";
            this.btnOpnPic.Size = new System.Drawing.Size(165, 46);
            this.btnOpnPic.TabIndex = 3;
            this.btnOpnPic.Text = "Open picture";
            this.btnOpnPic.UseVisualStyleBackColor = true;
            // 
            // picb
            // 
            this.picb.Image = ((System.Drawing.Image)(resources.GetObject("picb.Image")));
            this.picb.Location = new System.Drawing.Point(13, 64);
            this.picb.Name = "picb";
            this.picb.Size = new System.Drawing.Size(677, 385);
            this.picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb.TabIndex = 4;
            this.picb.TabStop = false;
            // 
            // Cv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 462);
            this.Controls.Add(this.picb);
            this.Controls.Add(this.btnOpnPic);
            this.Controls.Add(this.btnGrScl2);
            this.Controls.Add(this.btnGrScl1);
            this.Controls.Add(this.btnOrigin);
            this.Name = "Cv2";
            this.Text = "Cv2";
            this.Load += new System.EventHandler(this.Cv2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.Button btnGrScl1;
        private System.Windows.Forms.Button btnGrScl2;
        private System.Windows.Forms.Button btnOpnPic;
        private System.Windows.Forms.PictureBox picb;
    }
}
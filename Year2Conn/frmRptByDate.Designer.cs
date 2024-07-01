namespace Year2Conn
{
    partial class frmRptByDate
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpLdate = new System.Windows.Forms.DateTimePicker();
            this.dtpFdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "ວັນທີ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Saysettha OT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(507, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "ຄົ້ນຫາ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "ຫາ";
            // 
            // dtpLdate
            // 
            this.dtpLdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLdate.Location = new System.Drawing.Point(334, 45);
            this.dtpLdate.Name = "dtpLdate";
            this.dtpLdate.Size = new System.Drawing.Size(143, 22);
            this.dtpLdate.TabIndex = 7;
            // 
            // dtpFdate
            // 
            this.dtpFdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFdate.Location = new System.Drawing.Point(130, 44);
            this.dtpFdate.Name = "dtpFdate";
            this.dtpFdate.Size = new System.Drawing.Size(138, 22);
            this.dtpFdate.TabIndex = 6;
            // 
            // frmRptByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 149);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLdate);
            this.Controls.Add(this.dtpFdate);
            this.Name = "frmRptByDate";
            this.Text = "frmRptByDate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpLdate;
        private System.Windows.Forms.DateTimePicker dtpFdate;
    }
}
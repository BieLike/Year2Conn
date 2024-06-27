namespace Year2Conn
{
    partial class frmRptData
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
            this.crvData = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptData1 = new Year2Conn.rptData();
            this.dtpFdate = new System.Windows.Forms.DateTimePicker();
            this.dtpLdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crvData
            // 
            this.crvData.ActiveViewIndex = 0;
            this.crvData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvData.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvData.Location = new System.Drawing.Point(-2, 108);
            this.crvData.Name = "crvData";
            this.crvData.ReportSource = this.rptData1;
            this.crvData.Size = new System.Drawing.Size(1266, 611);
            this.crvData.TabIndex = 0;
            this.crvData.Load += new System.EventHandler(this.crvData_Load);
            // 
            // dtpFdate
            // 
            this.dtpFdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFdate.Location = new System.Drawing.Point(63, 42);
            this.dtpFdate.Name = "dtpFdate";
            this.dtpFdate.Size = new System.Drawing.Size(138, 22);
            this.dtpFdate.TabIndex = 1;
            // 
            // dtpLdate
            // 
            this.dtpLdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLdate.Location = new System.Drawing.Point(267, 43);
            this.dtpLdate.Name = "dtpLdate";
            this.dtpLdate.Size = new System.Drawing.Size(143, 22);
            this.dtpLdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ຫາ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Saysettha OT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(440, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "ຄົ້ນຫາ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ວັນທີ";
            // 
            // frmRptData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 751);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLdate);
            this.Controls.Add(this.dtpFdate);
            this.Controls.Add(this.crvData);
            this.Name = "frmRptData";
            this.Text = "frmRptData";
            this.Load += new System.EventHandler(this.frmRptData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvData;
        private rptData rptData1;
        private System.Windows.Forms.DateTimePicker dtpFdate;
        private System.Windows.Forms.DateTimePicker dtpLdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
    }
}
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
            this.SuspendLayout();
            // 
            // crvData
            // 
            this.crvData.ActiveViewIndex = 0;
            this.crvData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvData.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvData.Location = new System.Drawing.Point(0, 0);
            this.crvData.Name = "crvData";
            this.crvData.ReportSource = this.rptData1;
            this.crvData.Size = new System.Drawing.Size(1298, 751);
            this.crvData.TabIndex = 0;
            this.crvData.Load += new System.EventHandler(this.crvData_Load);
            // 
            // frmRptData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 751);
            this.Controls.Add(this.crvData);
            this.Name = "frmRptData";
            this.Text = "frmRptData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvData;
        private rptData rptData1;
    }
}
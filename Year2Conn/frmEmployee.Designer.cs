namespace Year2Conn
{
    partial class frmEmployee
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
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(123, 114);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFname.Multiline = true;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(296, 47);
            this.txtFname.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(123, 193);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(296, 47);
            this.txtPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(49, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ຊື່ຜູ້ໃຊ້";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(49, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "ລະຫັດ";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.SystemColors.Window;
            this.lb1.Location = new System.Drawing.Point(197, 40);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(149, 31);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "ຈັດການພະນັກງານ";
            // 
            // dgvEmp
            // 
            this.dgvEmp.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(174, 54);
            this.dgvEmp.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersWidth = 51;
            this.dgvEmp.RowTemplate.Height = 24;
            this.dgvEmp.Size = new System.Drawing.Size(652, 510);
            this.dgvEmp.TabIndex = 5;
            this.dgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellClick);
            this.dgvEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellContentClick);
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Items.AddRange(new object[] {
            "ພະນັກງານຂາຍ",
            "ພະນັກງານຈັດຊື້"});
            this.cmbAuthor.Location = new System.Drawing.Point(123, 279);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(296, 39);
            this.cmbAuthor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(54, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "ໜ້າທີ່";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(152, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "ບັນທຶກ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(282, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 39);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "ແກ້ໄຂ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(436, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 39);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "ອອກ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(152, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "ລຶບ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cmbAuthor);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(921, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 510);
            this.panel1.TabIndex = 12;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1631, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmp);
            this.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmp;
    }
}
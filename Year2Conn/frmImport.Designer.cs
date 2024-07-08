namespace Year2Conn
{
    partial class frmImport
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.btnCheckItem = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBillNum = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(210, 64);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(321, 35);
            this.cmbSupplier.TabIndex = 0;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຜູ້ສະໜອງສິນຄ້າ";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(632, 26);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(855, 291);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellValueChanged);
            this.dgvProduct.Click += new System.EventHandler(this.dgvProduct_Click);
            // 
            // dgvImport
            // 
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Location = new System.Drawing.Point(632, 323);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.RowHeadersWidth = 51;
            this.dgvImport.RowTemplate.Height = 24;
            this.dgvImport.Size = new System.Drawing.Size(855, 291);
            this.dgvImport.TabIndex = 3;
            this.dgvImport.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImport_CellValueChanged);
            // 
            // btnCheckItem
            // 
            this.btnCheckItem.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckItem.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCheckItem.Location = new System.Drawing.Point(32, 147);
            this.btnCheckItem.Name = "btnCheckItem";
            this.btnCheckItem.Size = new System.Drawing.Size(532, 47);
            this.btnCheckItem.TabIndex = 4;
            this.btnCheckItem.Text = "ກວດສອບສິນຄ້າໃນຮ້ານ";
            this.btnCheckItem.UseVisualStyleBackColor = true;
            this.btnCheckItem.Click += new System.EventHandler(this.btnCheckItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(305, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ສັ່ງຊື້ສິນຄ້າ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(32, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(233, 47);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "ຍົກເລີກສິນຄ້າ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(360, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "ເລກທີໃບບິນ :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbBillNum
            // 
            this.lbBillNum.AutoSize = true;
            this.lbBillNum.Font = new System.Drawing.Font("Phetsarath OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillNum.ForeColor = System.Drawing.SystemColors.Window;
            this.lbBillNum.Location = new System.Drawing.Point(489, 462);
            this.lbBillNum.Name = "lbBillNum";
            this.lbBillNum.Size = new System.Drawing.Size(75, 24);
            this.lbBillNum.TabIndex = 8;
            this.lbBillNum.Text = "BillNum";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.LimeGreen;
            this.btnImport.Font = new System.Drawing.Font("Phetsarath OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnImport.Location = new System.Drawing.Point(32, 331);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(532, 47);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "ນຳເຂົ້າສິນຄ້າ";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.btnCheckItem);
            this.panel1.Controls.Add(this.lbBillNum);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Font = new System.Drawing.Font("Phetsarath OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(14, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 588);
            this.panel1.TabIndex = 11;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1620, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvImport);
            this.Controls.Add(this.dgvProduct);
            this.Font = new System.Drawing.Font("Phetsarath OT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.Button btnCheckItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBillNum;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel1;
    }
}
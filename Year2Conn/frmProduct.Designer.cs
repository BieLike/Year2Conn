namespace Year2Conn
{
    partial class frmProduct
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
            this.gbBtn = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatN = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.gbBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBtn
            // 
            this.gbBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(116)))));
            this.gbBtn.Controls.Add(this.label8);
            this.gbBtn.Controls.Add(this.txtCondition);
            this.gbBtn.Controls.Add(this.label7);
            this.gbBtn.Controls.Add(this.label5);
            this.gbBtn.Controls.Add(this.label6);
            this.gbBtn.Controls.Add(this.cmbCat);
            this.gbBtn.Controls.Add(this.cmbUnit);
            this.gbBtn.Controls.Add(this.label4);
            this.gbBtn.Controls.Add(this.label3);
            this.gbBtn.Controls.Add(this.label2);
            this.gbBtn.Controls.Add(this.label1);
            this.gbBtn.Controls.Add(this.txtCatN);
            this.gbBtn.Controls.Add(this.txtQty);
            this.gbBtn.Controls.Add(this.txtPrice);
            this.gbBtn.Controls.Add(this.txtProduct);
            this.gbBtn.Controls.Add(this.txtProductID);
            this.gbBtn.Controls.Add(this.btnDelete);
            this.gbBtn.Controls.Add(this.btnEdit);
            this.gbBtn.Controls.Add(this.btnExit);
            this.gbBtn.Controls.Add(this.btnSave);
            this.gbBtn.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.gbBtn.Location = new System.Drawing.Point(311, 13);
            this.gbBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBtn.Name = "gbBtn";
            this.gbBtn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBtn.Size = new System.Drawing.Size(1049, 306);
            this.gbBtn.TabIndex = 0;
            this.gbBtn.TabStop = false;
            this.gbBtn.Text = "ຈັດການຂໍ້ມູນສິນຄ້າ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(369, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "ເງື່ອນໄຂສັ່ງຊື້";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(497, 165);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(242, 37);
            this.txtCondition.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(27, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "ຊື່ປະເພດສິນຄ້າ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(409, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "ປະເພດ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(402, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "ຫົວໜ່ວຍ";
            // 
            // cmbCat
            // 
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(497, 44);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(242, 35);
            this.cmbCat.TabIndex = 14;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(497, 105);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(242, 35);
            this.cmbUnit.TabIndex = 13;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(48, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "ຈຳນວນ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(41, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "ຊື່ສິນຄ້າ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(194, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "ລາຄາ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "ລະຫັດສິນຄ້າ";
            // 
            // txtCatN
            // 
            this.txtCatN.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatN.Location = new System.Drawing.Point(160, 245);
            this.txtCatN.Name = "txtCatN";
            this.txtCatN.Size = new System.Drawing.Size(555, 37);
            this.txtCatN.TabIndex = 8;
            this.txtCatN.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(132, 159);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(56, 37);
            this.txtQty.TabIndex = 7;
            this.txtQty.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(264, 159);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(93, 37);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(132, 101);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(225, 37);
            this.txtProduct.TabIndex = 5;
            this.txtProduct.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("IDAutomationHC39M", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(132, 37);
            this.txtProductID.Multiline = true;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(225, 39);
            this.txtProductID.TabIndex = 4;
            this.txtProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(773, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "ລຶບ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(891, 81);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 44);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ແກ້ໄຂ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(984, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "ອອກ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Font = new System.Drawing.Font("Saysettha OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(773, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ບັນທຶກ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(311, 332);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1049, 327);
            this.DGV.TabIndex = 1;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGV_MouseClick);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1644, 671);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.gbBtn);
            this.Font = new System.Drawing.Font("Saysettha OT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Activated += new System.EventHandler(this.frmProduct_Activated);
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.gbBtn.ResumeLayout(false);
            this.gbBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCatN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCondition;
    }
}
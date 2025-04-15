namespace lession2_231401
{
    partial class frmEditProduct
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
            label1 = new Label();
            txtProductID = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            cboCategoryID = new ComboBox();
            label4 = new Label();
            cboSupplierID = new ComboBox();
            label5 = new Label();
            txtUnitPrice = new TextBox();
            label6 = new Label();
            txtQuantityPerUnit = new TextBox();
            btnAdd = new Button();
            bntEdit = new Button();
            btnDel = new Button();
            btnExit = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 47);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "ID sản phẩm";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(231, 35);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(172, 27);
            txtProductID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 106);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(231, 84);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(487, 42);
            txtProductName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 164);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 4;
            label3.Text = "Loại sản phẩm:";
            // 
            // cboCategoryID
            // 
            cboCategoryID.FormattingEnabled = true;
            cboCategoryID.Location = new Point(231, 161);
            cboCategoryID.Name = "cboCategoryID";
            cboCategoryID.Size = new Size(483, 28);
            cboCategoryID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 227);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Nhà sản xuất:";
            // 
            // cboSupplierID
            // 
            cboSupplierID.FormattingEnabled = true;
            cboSupplierID.Location = new Point(236, 224);
            cboSupplierID.Name = "cboSupplierID";
            cboSupplierID.Size = new Size(482, 28);
            cboSupplierID.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 283);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 8;
            label5.Text = "Giá sản phẩm:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(239, 283);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(167, 27);
            txtUnitPrice.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 339);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 10;
            label6.Text = "Sô lượng/Đơn vị";
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.Location = new Point(239, 339);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(479, 27);
            txtQuantityPerUnit.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MistyRose;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(231, 434);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 60);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // bntEdit
            // 
            bntEdit.BackColor = Color.MistyRose;
            bntEdit.Image = Properties.Resources.edit;
            bntEdit.ImageAlign = ContentAlignment.MiddleLeft;
            bntEdit.Location = new Point(380, 434);
            bntEdit.Name = "bntEdit";
            bntEdit.Size = new Size(132, 60);
            bntEdit.TabIndex = 13;
            bntEdit.Text = "Sửa";
            bntEdit.UseVisualStyleBackColor = false;
            bntEdit.Click += bntEdit_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.MistyRose;
            btnDel.Image = Properties.Resources.delete;
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(527, 434);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(132, 60);
            btnDel.TabIndex = 14;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientInactiveCaption;
            btnExit.Image = Properties.Resources.exit_closethesession_close_6317;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1063, 434);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 60);
            btnExit.TabIndex = 17;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Image = Properties.Resources.cancel_stop_exit_1583;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(916, 434);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 60);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Bisque;
            btnSave.Image = Properties.Resources.Save_37110;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(767, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 60);
            btnSave.TabIndex = 15;
            btnSave.Text = "Ghi";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 740);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDel);
            Controls.Add(bntEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantityPerUnit);
            Controls.Add(label6);
            Controls.Add(txtUnitPrice);
            Controls.Add(label5);
            Controls.Add(cboSupplierID);
            Controls.Add(label4);
            Controls.Add(cboCategoryID);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(txtProductID);
            Controls.Add(label1);
            Name = "frmEditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hiệu chỉnh dữ liệu";
            Load += frmEditProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductID;
        private Label label2;
        private TextBox txtProductName;
        private Label label3;
        private ComboBox cboCategoryID;
        private Label label4;
        private ComboBox cboSupplierID;
        private Label label5;
        private TextBox txtUnitPrice;
        private Label label6;
        private TextBox txtQuantityPerUnit;
        private Button btnAdd;
        private Button bntEdit;
        private Button btnDel;
        private Button btnExit;
        private Button btnCancel;
        private Button btnSave;
    }
}
namespace lession2_231401
{
    partial class frmEditProduct_SQL
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
            btnExit = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnDel = new Button();
            bntEdit = new Button();
            btnAdd = new Button();
            txtQuantityPerUnit = new TextBox();
            label6 = new Label();
            txtUnitPrice = new TextBox();
            label5 = new Label();
            cboSupplierID = new ComboBox();
            label4 = new Label();
            cboCategoryID = new ComboBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            txtProductID = new TextBox();
            label1 = new Label();
            bntTestDelegate = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientInactiveCaption;
            btnExit.Image = Properties.Resources.exit_closethesession_close_6317;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1068, 433);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 60);
            btnExit.TabIndex = 35;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(921, 433);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 60);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Bisque;
            btnSave.Image = Properties.Resources.Save_37110;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(772, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 60);
            btnSave.TabIndex = 33;
            btnSave.Text = "Ghi";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.MistyRose;
            btnDel.Image = Properties.Resources.delete;
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(532, 433);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(132, 60);
            btnDel.TabIndex = 32;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // bntEdit
            // 
            bntEdit.BackColor = Color.MistyRose;
            bntEdit.Image = Properties.Resources.edit;
            bntEdit.ImageAlign = ContentAlignment.MiddleLeft;
            bntEdit.Location = new Point(385, 433);
            bntEdit.Name = "bntEdit";
            bntEdit.Size = new Size(132, 60);
            bntEdit.TabIndex = 31;
            bntEdit.Text = "Sửa";
            bntEdit.UseVisualStyleBackColor = false;
            bntEdit.Click += bntEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MistyRose;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(236, 433);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 60);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.Location = new Point(244, 338);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(479, 27);
            txtQuantityPerUnit.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 338);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 28;
            label6.Text = "Sô lượng/Đơn vị";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(244, 282);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(167, 27);
            txtUnitPrice.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 282);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 26;
            label5.Text = "Giá sản phẩm:";
            // 
            // cboSupplierID
            // 
            cboSupplierID.FormattingEnabled = true;
            cboSupplierID.Location = new Point(241, 223);
            cboSupplierID.Name = "cboSupplierID";
            cboSupplierID.Size = new Size(482, 28);
            cboSupplierID.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 226);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 24;
            label4.Text = "Nhà sản xuất:";
            // 
            // cboCategoryID
            // 
            cboCategoryID.FormattingEnabled = true;
            cboCategoryID.Location = new Point(236, 160);
            cboCategoryID.Name = "cboCategoryID";
            cboCategoryID.Size = new Size(483, 28);
            cboCategoryID.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 163);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 22;
            label3.Text = "Loại sản phẩm:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(236, 83);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(487, 42);
            txtProductName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 105);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 20;
            label2.Text = "Tên sản phẩm:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(236, 34);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(172, 27);
            txtProductID.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 46);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 18;
            label1.Text = "ID sản phẩm";
            // 
            // bntTestDelegate
            // 
            bntTestDelegate.Location = new Point(226, 515);
            bntTestDelegate.Name = "bntTestDelegate";
            bntTestDelegate.Size = new Size(158, 45);
            bntTestDelegate.TabIndex = 36;
            bntTestDelegate.Text = "Test Delegate";
            bntTestDelegate.UseVisualStyleBackColor = true;
            bntTestDelegate.Click += bntTestDelegate_Click;
            // 
            // frmEditProduct_SQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1276, 594);
            Controls.Add(bntTestDelegate);
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
            Name = "frmEditProduct_SQL";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sửa sản phẩm";
            Load += frmEditProduct_SQL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDel;
        private Button bntEdit;
        private Button btnAdd;
        private TextBox txtQuantityPerUnit;
        private Label label6;
        private TextBox txtUnitPrice;
        private Label label5;
        private ComboBox cboSupplierID;
        private Label label4;
        private ComboBox cboCategoryID;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtProductID;
        private Label label1;
        private Button bntTestDelegate;
    }
}
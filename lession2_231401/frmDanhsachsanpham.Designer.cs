namespace lession2_231401
{
    partial class frmDanhsachsanpham
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
            cboCategory = new ComboBox();
            label2 = new Label();
            cboSupplier = new ComboBox();
            txtSearch = new TextBox();
            btnTimkiem = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            cboPageSize = new ComboBox();
            label5 = new Label();
            cboPage = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Lọc theo danh mục:";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(185, 17);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(371, 28);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 62);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 2;
            label2.Text = "Danh mục nhà SX";
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(185, 61);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(371, 28);
            cboSupplier.TabIndex = 3;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(584, 17);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(516, 71);
            txtSearch.TabIndex = 4;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.AutoEllipsis = true;
            btnTimkiem.BackColor = Color.LightSalmon;
            btnTimkiem.Location = new Point(1152, 16);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(159, 72);
            btnTimkiem.TabIndex = 5;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = false;
            btnTimkiem.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1322, 579);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(52, 734);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 7;
            label3.Text = "Tổng số lượng:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(305, 733);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 8;
            label4.Text = "Số lượng trên trang:";
            // 
            // cboPageSize
            // 
            cboPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboPageSize.FormattingEnabled = true;
            cboPageSize.Location = new Point(469, 727);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(104, 28);
            cboPageSize.TabIndex = 9;
            cboPageSize.SelectedIndexChanged += cboPageSize_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(642, 730);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 10;
            label5.Text = "Trang hiện tại:";
            // 
            // cboPage
            // 
            cboPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboPage.FormattingEnabled = true;
            cboPage.Location = new Point(762, 727);
            cboPage.Name = "cboPage";
            cboPage.Size = new Size(151, 28);
            cboPage.TabIndex = 11;
            cboPage.SelectedIndexChanged += cboPage_SelectedIndexChanged;
            // 
            // frmDanhsachsanpham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 790);
            Controls.Add(cboPage);
            Controls.Add(label5);
            Controls.Add(cboPageSize);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnTimkiem);
            Controls.Add(txtSearch);
            Controls.Add(cboSupplier);
            Controls.Add(label2);
            Controls.Add(cboCategory);
            Controls.Add(label1);
            Name = "frmDanhsachsanpham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            WindowState = FormWindowState.Maximized;
            Load += frmDanhsachsanpham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCategory;
        private Label label2;
        private ComboBox cboSupplier;
        private TextBox txtSearch;
        private Button btnTimkiem;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox cboPage;
        private ComboBox cboPageSize;
    }
}
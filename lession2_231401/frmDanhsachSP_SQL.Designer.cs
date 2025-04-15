namespace lession2_231401
{
    partial class frmDanhsachSP_SQL
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
            cboPage = new ComboBox();
            label5 = new Label();
            cboPageSize = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnTimkiem = new Button();
            txtSearch = new TextBox();
            cboSupplier = new ComboBox();
            label2 = new Label();
            cboCategory = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cboPage
            // 
            cboPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboPage.FormattingEnabled = true;
            cboPage.Location = new Point(761, 737);
            cboPage.Name = "cboPage";
            cboPage.Size = new Size(151, 28);
            cboPage.TabIndex = 23;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(641, 740);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 22;
            label5.Text = "Trang hiện tại:";
            // 
            // cboPageSize
            // 
            cboPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboPageSize.FormattingEnabled = true;
            cboPageSize.Location = new Point(468, 737);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(104, 28);
            cboPageSize.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(304, 743);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 20;
            label4.Text = "Số lượng trên trang:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(51, 744);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 19;
            label3.Text = "Tổng số lượng:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1322, 579);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.AutoEllipsis = true;
            btnTimkiem.BackColor = Color.Gold;
            btnTimkiem.Location = new Point(1151, 26);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(159, 72);
            btnTimkiem.TabIndex = 17;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = false;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = SystemColors.Info;
            txtSearch.Location = new Point(583, 27);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(516, 71);
            txtSearch.TabIndex = 16;
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(184, 71);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(371, 28);
            cboSupplier.TabIndex = 15;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(26, 72);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 14;
            label2.Text = "Danh mục nhà SX";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(184, 27);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(371, 28);
            cboCategory.TabIndex = 13;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 12;
            label1.Text = "Lọc theo danh mục:";
            // 
            // frmDanhsachSP_SQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
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
            Name = "frmDanhsachSP_SQL";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDanhsachSP_SQL";
            Load += frmDanhsachSP_SQL_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPage;
        private Label label5;
        private ComboBox cboPageSize;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnTimkiem;
        private TextBox txtSearch;
        private ComboBox cboSupplier;
        private Label label2;
        private ComboBox cboCategory;
        private Label label1;
    }
}
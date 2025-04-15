namespace lession2_231401
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuTestConnection = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            mnuDanhmucCategory = new ToolStripMenuItem();
            mnuDanhmucSupplier = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripButton = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            mnuQLSP2 = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1282, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, toolStripSeparator3, mnuTestConnection, toolStripSeparator2, toolStripMenuItem5, mnuQLSP2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(99, 24);
            toolStripMenuItem1.Text = "Menu chính";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(250, 26);
            toolStripMenuItem4.Text = "Quản lý sản phẩm";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(247, 6);
            // 
            // mnuTestConnection
            // 
            mnuTestConnection.Name = "mnuTestConnection";
            mnuTestConnection.Size = new Size(250, 26);
            mnuTestConnection.Text = "Test Ketnoi";
            mnuTestConnection.Click += mnuTestConnection_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(247, 6);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(250, 26);
            toolStripMenuItem5.Text = "Thoát";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { mnuDanhmucCategory, mnuDanhmucSupplier });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(90, 24);
            toolStripMenuItem2.Text = "Danh mục";
            // 
            // mnuDanhmucCategory
            // 
            mnuDanhmucCategory.Name = "mnuDanhmucCategory";
            mnuDanhmucCategory.Size = new Size(257, 26);
            mnuDanhmucCategory.Text = "Danh mục Loại hàng hóa";
            mnuDanhmucCategory.Click += mnuDanhmucCategory_Click;
            // 
            // mnuDanhmucSupplier
            // 
            mnuDanhmucSupplier.Name = "mnuDanhmucSupplier";
            mnuDanhmucSupplier.Size = new Size(257, 26);
            mnuDanhmucSupplier.Text = "Danh mục Nhà cung cấp";
            mnuDanhmucSupplier.Click += mnuDanhmucSupplier_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(87, 24);
            toolStripMenuItem3.Text = "Giới thiệu";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { openToolStripButton, saveToolStripButton, toolStripSeparator1, printToolStripButton });
            toolStrip.Location = new Point(0, 30);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1282, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Black;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(29, 24);
            openToolStripButton.Text = "Open";
            openToolStripButton.Click += OpenFile;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Black;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(29, 24);
            saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Black;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(29, 24);
            printToolStripButton.Text = "Print";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 671);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(1282, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // mnuQLSP2
            // 
            mnuQLSP2.Name = "mnuQLSP2";
            mnuQLSP2.Size = new Size(250, 26);
            mnuQLSP2.Text = "Quản lý sản phẩm (SQL)";
            mnuQLSP2.Click += mnuQLSP2_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.daihocGiaDinh;
            ClientSize = new Size(1282, 697);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demo lession 2- Quản lý sản phẩm";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        private StatusStrip statusStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolTip toolTip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem mnuDanhmucCategory;
        private ToolStripMenuItem mnuDanhmucSupplier;
        private ToolStripMenuItem mnuTestConnection;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuQLSP2;
    }
}




namespace lession2_231401
{
    partial class testformSQL
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
            bntConnection = new Button();
            SuspendLayout();
            // 
            // bntConnection
            // 
            bntConnection.Location = new Point(93, 114);
            bntConnection.Name = "bntConnection";
            bntConnection.Size = new Size(151, 52);
            bntConnection.TabIndex = 0;
            bntConnection.Text = "Test kết nối";
            bntConnection.UseVisualStyleBackColor = true;
            bntConnection.Click += bntConnection_Click;
            // 
            // testformSQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 349);
            Controls.Add(bntConnection);
            Name = "testformSQL";
            Text = "testformSQL";
            ResumeLayout(false);
        }

        #endregion

        private Button bntConnection;
    }
}
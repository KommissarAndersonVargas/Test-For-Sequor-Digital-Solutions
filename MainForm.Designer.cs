namespace SequorTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.b
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bottomPanel = new Panel();
            SendInfoButton = new Button();
            SearchButton = new Button();
            displayTilesPnlLayout = new FlowLayoutPanel();
            upPanel = new Panel();
            SearchTxtBox = new TextBox();
            backPanel = new Panel();
            pictureBox1 = new PictureBox();
            bottomPanel.SuspendLayout();
            upPanel.SuspendLayout();
            backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.LightSteelBlue;
            bottomPanel.Controls.Add(SendInfoButton);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 390);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(877, 60);
            bottomPanel.TabIndex = 1;
            // 
            // SendInfoButton
            // 
            SendInfoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendInfoButton.FlatAppearance.BorderSize = 2;
            SendInfoButton.FlatStyle = FlatStyle.Flat;
            SendInfoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendInfoButton.Location = new Point(789, 14);
            SendInfoButton.Name = "SendInfoButton";
            SendInfoButton.Size = new Size(85, 43);
            SendInfoButton.TabIndex = 4;
            SendInfoButton.Text = "SEND";
            SendInfoButton.UseVisualStyleBackColor = true;
            SendInfoButton.Click += SendInfoButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Image = Properties.Resources.search_zoom;
            SearchButton.Location = new Point(282, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(46, 40);
            SearchButton.TabIndex = 2;
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // displayTilesPnlLayout
            // 
            displayTilesPnlLayout.AutoScroll = true;
            displayTilesPnlLayout.Dock = DockStyle.Left;
            displayTilesPnlLayout.FlowDirection = FlowDirection.TopDown;
            displayTilesPnlLayout.Location = new Point(0, 0);
            displayTilesPnlLayout.Name = "displayTilesPnlLayout";
            displayTilesPnlLayout.Size = new Size(468, 330);
            displayTilesPnlLayout.TabIndex = 4;
            displayTilesPnlLayout.WrapContents = false;
            // 
            // upPanel
            // 
            upPanel.BackColor = Color.LightSteelBlue;
            upPanel.Controls.Add(SearchTxtBox);
            upPanel.Controls.Add(SearchButton);
            upPanel.Dock = DockStyle.Top;
            upPanel.Location = new Point(0, 0);
            upPanel.Name = "upPanel";
            upPanel.Size = new Size(877, 60);
            upPanel.TabIndex = 5;
            // 
            // SearchTxtBox
            // 
            SearchTxtBox.Location = new Point(15, 12);
            SearchTxtBox.Multiline = true;
            SearchTxtBox.Name = "SearchTxtBox";
            SearchTxtBox.Size = new Size(258, 42);
            SearchTxtBox.TabIndex = 3;
            // 
            // backPanel
            // 
            backPanel.BackColor = Color.White;
            backPanel.Controls.Add(pictureBox1);
            backPanel.Controls.Add(displayTilesPnlLayout);
            backPanel.Dock = DockStyle.Fill;
            backPanel.Location = new Point(0, 60);
            backPanel.Name = "backPanel";
            backPanel.Size = new Size(877, 330);
            backPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.sequor_mes;
            pictureBox1.Location = new Point(590, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(877, 450);
            Controls.Add(backPanel);
            Controls.Add(upPanel);
            Controls.Add(bottomPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            bottomPanel.ResumeLayout(false);
            upPanel.ResumeLayout(false);
            upPanel.PerformLayout();
            backPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel bottomPanel;
        private Button SearchButton;
        private Button SendInfoButton;
        private FlowLayoutPanel displayTilesPnlLayout;
        private Panel upPanel;
        private Panel backPanel;
        private PictureBox pictureBox1;
        private TextBox SearchTxtBox;
    }
}

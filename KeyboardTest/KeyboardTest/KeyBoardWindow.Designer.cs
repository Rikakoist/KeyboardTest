namespace KeyboardTest
{
    partial class KeyBoardWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyBoardWindow));
            this.CodeResultLabel = new System.Windows.Forms.Label();
            this.KeyCodeLabel = new System.Windows.Forms.Label();
            this.ValueResultLabel = new System.Windows.Forms.Label();
            this.DataResultLabel = new System.Windows.Forms.Label();
            this.KeyValueLabel = new System.Windows.Forms.Label();
            this.KeyDataLabel = new System.Windows.Forms.Label();
            this.KeyboardsTabControl = new System.Windows.Forms.TabControl();
            this.WinKeyboardTabPage = new System.Windows.Forms.TabPage();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ButtonHistory = new System.Windows.Forms.TextBox();
            this.ESC = new System.Windows.Forms.Button();
            this.KeyboardsTabControl.SuspendLayout();
            this.WinKeyboardTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeResultLabel
            // 
            this.CodeResultLabel.AutoSize = true;
            this.CodeResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.CodeResultLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeResultLabel.Location = new System.Drawing.Point(455, 433);
            this.CodeResultLabel.Name = "CodeResultLabel";
            this.CodeResultLabel.Size = new System.Drawing.Size(124, 27);
            this.CodeResultLabel.TabIndex = 0;
            this.CodeResultLabel.Text = "CodeResult";
            // 
            // KeyCodeLabel
            // 
            this.KeyCodeLabel.AutoSize = true;
            this.KeyCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeyCodeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyCodeLabel.Location = new System.Drawing.Point(357, 433);
            this.KeyCodeLabel.Name = "KeyCodeLabel";
            this.KeyCodeLabel.Size = new System.Drawing.Size(63, 27);
            this.KeyCodeLabel.TabIndex = 0;
            this.KeyCodeLabel.Text = "Code";
            // 
            // ValueResultLabel
            // 
            this.ValueResultLabel.AutoSize = true;
            this.ValueResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ValueResultLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueResultLabel.Location = new System.Drawing.Point(455, 517);
            this.ValueResultLabel.Name = "ValueResultLabel";
            this.ValueResultLabel.Size = new System.Drawing.Size(126, 27);
            this.ValueResultLabel.TabIndex = 0;
            this.ValueResultLabel.Text = "ValueResult";
            // 
            // DataResultLabel
            // 
            this.DataResultLabel.AutoSize = true;
            this.DataResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataResultLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataResultLabel.Location = new System.Drawing.Point(455, 475);
            this.DataResultLabel.Name = "DataResultLabel";
            this.DataResultLabel.Size = new System.Drawing.Size(119, 27);
            this.DataResultLabel.TabIndex = 0;
            this.DataResultLabel.Text = "DataResult";
            // 
            // KeyValueLabel
            // 
            this.KeyValueLabel.AutoSize = true;
            this.KeyValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeyValueLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyValueLabel.Location = new System.Drawing.Point(359, 517);
            this.KeyValueLabel.Name = "KeyValueLabel";
            this.KeyValueLabel.Size = new System.Drawing.Size(65, 27);
            this.KeyValueLabel.TabIndex = 0;
            this.KeyValueLabel.Text = "Value";
            // 
            // KeyDataLabel
            // 
            this.KeyDataLabel.AutoSize = true;
            this.KeyDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeyDataLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyDataLabel.Location = new System.Drawing.Point(364, 475);
            this.KeyDataLabel.Name = "KeyDataLabel";
            this.KeyDataLabel.Size = new System.Drawing.Size(58, 27);
            this.KeyDataLabel.TabIndex = 0;
            this.KeyDataLabel.Text = "Data";
            // 
            // KeyboardsTabControl
            // 
            this.KeyboardsTabControl.Controls.Add(this.WinKeyboardTabPage);
            this.KeyboardsTabControl.Location = new System.Drawing.Point(12, 12);
            this.KeyboardsTabControl.Name = "KeyboardsTabControl";
            this.KeyboardsTabControl.SelectedIndex = 0;
            this.KeyboardsTabControl.Size = new System.Drawing.Size(960, 407);
            this.KeyboardsTabControl.TabIndex = 1;
            // 
            // WinKeyboardTabPage
            // 
            this.WinKeyboardTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WinKeyboardTabPage.BackgroundImage")));
            this.WinKeyboardTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WinKeyboardTabPage.Controls.Add(this.ESC);
            this.WinKeyboardTabPage.Location = new System.Drawing.Point(4, 22);
            this.WinKeyboardTabPage.Name = "WinKeyboardTabPage";
            this.WinKeyboardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.WinKeyboardTabPage.Size = new System.Drawing.Size(952, 381);
            this.WinKeyboardTabPage.TabIndex = 0;
            this.WinKeyboardTabPage.Text = "Windows";
            this.WinKeyboardTabPage.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(16, 510);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 34);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.Location = new System.Drawing.Point(683, 421);
            this.ButtonHistory.Multiline = true;
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.ReadOnly = true;
            this.ButtonHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ButtonHistory.Size = new System.Drawing.Size(289, 128);
            this.ButtonHistory.TabIndex = 0;
            this.ButtonHistory.TabStop = false;
            // 
            // ESC
            // 
            this.ESC.Location = new System.Drawing.Point(32, 88);
            this.ESC.Name = "ESC";
            this.ESC.Size = new System.Drawing.Size(35, 35);
            this.ESC.TabIndex = 0;
            this.ESC.TabStop = false;
            this.ESC.Text = "27";
            this.ESC.UseVisualStyleBackColor = true;
            // 
            // KeyBoardWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ButtonHistory);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.KeyboardsTabControl);
            this.Controls.Add(this.KeyDataLabel);
            this.Controls.Add(this.KeyValueLabel);
            this.Controls.Add(this.KeyCodeLabel);
            this.Controls.Add(this.DataResultLabel);
            this.Controls.Add(this.ValueResultLabel);
            this.Controls.Add(this.CodeResultLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "KeyBoardWindow";
            this.Opacity = 0.95D;
            this.Text = "Keyboard Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitApp);
            this.Load += new System.EventHandler(this.Init);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowKeyCode);
            this.KeyboardsTabControl.ResumeLayout(false);
            this.WinKeyboardTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodeResultLabel;
        private System.Windows.Forms.Label KeyCodeLabel;
        private System.Windows.Forms.Label ValueResultLabel;
        private System.Windows.Forms.Label DataResultLabel;
        private System.Windows.Forms.Label KeyValueLabel;
        private System.Windows.Forms.Label KeyDataLabel;
        private System.Windows.Forms.TabControl KeyboardsTabControl;
        private System.Windows.Forms.TabPage WinKeyboardTabPage;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox ButtonHistory;
        private System.Windows.Forms.Button ESC;
    }
}


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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ESC = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ButtonHistory = new System.Windows.Forms.TextBox();
            this.DropHistory = new System.Windows.Forms.TextBox();
            this.Console = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.argBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdList = new System.Windows.Forms.ComboBox();
            this.warning = new System.Windows.Forms.Label();
            this.importJson = new System.Windows.Forms.TextBox();
            this.drawOnly = new System.Windows.Forms.Button();
            this.importConfigAndDraw = new System.Windows.Forms.Button();
            this.importConfig = new System.Windows.Forms.TextBox();
            this.KeyboardsTabControl.SuspendLayout();
            this.WinKeyboardTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeResultLabel
            // 
            this.CodeResultLabel.AutoSize = true;
            this.CodeResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.CodeResultLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeResultLabel.Location = new System.Drawing.Point(235, 450);
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
            this.KeyCodeLabel.Location = new System.Drawing.Point(137, 450);
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
            this.ValueResultLabel.Location = new System.Drawing.Point(235, 534);
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
            this.DataResultLabel.Location = new System.Drawing.Point(235, 492);
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
            this.KeyValueLabel.Location = new System.Drawing.Point(139, 534);
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
            this.KeyDataLabel.Location = new System.Drawing.Point(144, 492);
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
            this.KeyboardsTabControl.Size = new System.Drawing.Size(1012, 425);
            this.KeyboardsTabControl.TabIndex = 1;
            // 
            // WinKeyboardTabPage
            // 
            this.WinKeyboardTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WinKeyboardTabPage.BackgroundImage")));
            this.WinKeyboardTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WinKeyboardTabPage.Controls.Add(this.ESC);
            this.WinKeyboardTabPage.Controls.Add(this.panel1);
            this.WinKeyboardTabPage.Location = new System.Drawing.Point(4, 22);
            this.WinKeyboardTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.WinKeyboardTabPage.Name = "WinKeyboardTabPage";
            this.WinKeyboardTabPage.Size = new System.Drawing.Size(1004, 399);
            this.WinKeyboardTabPage.TabIndex = 0;
            this.WinKeyboardTabPage.Text = "Windows";
            this.WinKeyboardTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 399);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // ESC
            // 
            this.ESC.Location = new System.Drawing.Point(35, 90);
            this.ESC.Name = "ESC";
            this.ESC.Size = new System.Drawing.Size(35, 35);
            this.ESC.TabIndex = 0;
            this.ESC.TabStop = false;
            this.ESC.Text = "27";
            this.ESC.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(16, 515);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 34);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.Location = new System.Drawing.Point(713, 448);
            this.ButtonHistory.Multiline = true;
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.ReadOnly = true;
            this.ButtonHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ButtonHistory.Size = new System.Drawing.Size(289, 128);
            this.ButtonHistory.TabIndex = 0;
            this.ButtonHistory.TabStop = false;
            // 
            // DropHistory
            // 
            this.DropHistory.Location = new System.Drawing.Point(418, 448);
            this.DropHistory.Multiline = true;
            this.DropHistory.Name = "DropHistory";
            this.DropHistory.ReadOnly = true;
            this.DropHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DropHistory.Size = new System.Drawing.Size(289, 128);
            this.DropHistory.TabIndex = 3;
            this.DropHistory.TabStop = false;
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(713, 582);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Console.Size = new System.Drawing.Size(289, 128);
            this.Console.TabIndex = 5;
            this.Console.TabStop = false;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(418, 582);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(289, 128);
            this.Output.TabIndex = 6;
            this.Output.TabStop = false;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(941, 717);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(61, 21);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // argBox
            // 
            this.argBox.Location = new System.Drawing.Point(843, 716);
            this.argBox.Name = "argBox";
            this.argBox.Size = new System.Drawing.Size(92, 21);
            this.argBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 200);
            this.label1.TabIndex = 10;
            this.label1.Text = "Help---\r\nsetButtonSize(int,int)\r\nsetButtonStartPos(int,int)\r\nsetButtonIDStart(int" +
    ")\r\nsetButtonDis(int)\r\nsetBatchNum(int)\r\nstart()\r\nreset()\r\n";
            // 
            // cmdList
            // 
            this.cmdList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdList.FormattingEnabled = true;
            this.cmdList.Items.AddRange(new object[] {
            "setButtonSize",
            "setButtonStartPos",
            "setButtonIDStart",
            "setButtonDis",
            "setBatchNum",
            "start",
            "reset"});
            this.cmdList.Location = new System.Drawing.Point(713, 716);
            this.cmdList.Name = "cmdList";
            this.cmdList.Size = new System.Drawing.Size(124, 20);
            this.cmdList.TabIndex = 12;
            this.cmdList.Text = "--SELECT--";
            this.cmdList.SelectedIndexChanged += new System.EventHandler(this.CmdList_SelectedIndexChanged);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(465, 741);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(537, 44);
            this.warning.TabIndex = 13;
            this.warning.Text = "PROGRAM MAY BE CRASH DUE TO THIS CMD AND WRONG ARG\r\nMAKE SURE ARG INPUT IS LIKE \"" +
    "123,123\"\r\n";
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.warning.Visible = false;
            // 
            // importJson
            // 
            this.importJson.Location = new System.Drawing.Point(266, 700);
            this.importJson.Name = "importJson";
            this.importJson.Size = new System.Drawing.Size(100, 21);
            this.importJson.TabIndex = 14;
            // 
            // drawOnly
            // 
            this.drawOnly.Location = new System.Drawing.Point(279, 725);
            this.drawOnly.Name = "drawOnly";
            this.drawOnly.Size = new System.Drawing.Size(75, 23);
            this.drawOnly.TabIndex = 15;
            this.drawOnly.Text = "DrawOnly";
            this.drawOnly.UseVisualStyleBackColor = true;
            this.drawOnly.Click += new System.EventHandler(this.DrawOnly_Click);
            // 
            // importConfigAndDraw
            // 
            this.importConfigAndDraw.Location = new System.Drawing.Point(266, 660);
            this.importConfigAndDraw.Name = "importConfigAndDraw";
            this.importConfigAndDraw.Size = new System.Drawing.Size(101, 23);
            this.importConfigAndDraw.TabIndex = 17;
            this.importConfigAndDraw.Text = "ImportConfig";
            this.importConfigAndDraw.UseVisualStyleBackColor = true;
            this.importConfigAndDraw.Click += new System.EventHandler(this.ImportConfigAndDraw_Click);
            // 
            // importConfig
            // 
            this.importConfig.Location = new System.Drawing.Point(266, 633);
            this.importConfig.Name = "importConfig";
            this.importConfig.Size = new System.Drawing.Size(100, 21);
            this.importConfig.TabIndex = 16;
            // 
            // KeyBoardWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1035, 801);
            this.Controls.Add(this.importConfigAndDraw);
            this.Controls.Add(this.importConfig);
            this.Controls.Add(this.drawOnly);
            this.Controls.Add(this.importJson);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.cmdList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.argBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.DropHistory);
            this.Controls.Add(this.ButtonHistory);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.KeyboardsTabControl);
            this.Controls.Add(this.KeyDataLabel);
            this.Controls.Add(this.KeyValueLabel);
            this.Controls.Add(this.KeyCodeLabel);
            this.Controls.Add(this.DataResultLabel);
            this.Controls.Add(this.ValueResultLabel);
            this.Controls.Add(this.CodeResultLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DropHistory;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox argBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdList;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.TextBox importJson;
        private System.Windows.Forms.Button drawOnly;
        private System.Windows.Forms.Button importConfigAndDraw;
        private System.Windows.Forms.TextBox importConfig;
    }
}


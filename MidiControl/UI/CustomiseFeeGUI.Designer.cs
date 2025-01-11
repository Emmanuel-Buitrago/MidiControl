namespace MidiControl
{
    partial class CustomiseFeeGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.chkStartToTray = new System.Windows.Forms.CheckBox();
            this.chkLoadLastProfileOnStart = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboToolbarPosition = new System.Windows.Forms.ComboBox();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkConfirmDeleteProfile = new System.Windows.Forms.CheckBox();
            this.chkConfirmDeleteKeybind = new System.Windows.Forms.CheckBox();
            this.pnlInterface = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTheme);
            this.groupBox1.Controls.Add(this.cboToolbarPosition);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkLoadLastProfileOnStart);
            this.groupBox1.Controls.Add(this.chkStartToTray);
            this.groupBox1.Controls.Add(this.chkAlwaysOnTop);
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(307, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(8, 52);
            this.chkAlwaysOnTop.Margin = new System.Windows.Forms.Padding(4);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(180, 20);
            this.chkAlwaysOnTop.TabIndex = 1;
            this.chkAlwaysOnTop.Text = "Keep main window on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // chkStartToTray
            // 
            this.chkStartToTray.AutoSize = true;
            this.chkStartToTray.Location = new System.Drawing.Point(8, 23);
            this.chkStartToTray.Margin = new System.Windows.Forms.Padding(4);
            this.chkStartToTray.Name = "chkStartToTray";
            this.chkStartToTray.Size = new System.Drawing.Size(141, 20);
            this.chkStartToTray.TabIndex = 0;
            this.chkStartToTray.Text = "Start to system tray";
            this.chkStartToTray.UseVisualStyleBackColor = true;
            // 
            // chkLoadLastProfileOnStart
            // 
            this.chkLoadLastProfileOnStart.AutoSize = true;
            this.chkLoadLastProfileOnStart.Location = new System.Drawing.Point(8, 80);
            this.chkLoadLastProfileOnStart.Margin = new System.Windows.Forms.Padding(4);
            this.chkLoadLastProfileOnStart.Name = "chkLoadLastProfileOnStart";
            this.chkLoadLastProfileOnStart.Size = new System.Drawing.Size(219, 20);
            this.chkLoadLastProfileOnStart.TabIndex = 2;
            this.chkLoadLastProfileOnStart.Text = "Load last-used profile on startup";
            this.chkLoadLastProfileOnStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toolbar position:";
            // 
            // cboToolbarPosition
            // 
            this.cboToolbarPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToolbarPosition.FormattingEnabled = true;
            this.cboToolbarPosition.Items.AddRange(new object[] {
            "Top",
            "Bottom"});
            this.cboToolbarPosition.Location = new System.Drawing.Point(125, 145);
            this.cboToolbarPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cboToolbarPosition.Name = "cboToolbarPosition";
            this.cboToolbarPosition.Size = new System.Drawing.Size(172, 24);
            this.cboToolbarPosition.TabIndex = 4;
            // 
            // cboTheme
            // 
            this.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Items.AddRange(new object[] {
            "Default (light)",
            "Dark",
            "Office 2007 Blue"});
            this.cboTheme.Location = new System.Drawing.Point(125, 112);
            this.cboTheme.Margin = new System.Windows.Forms.Padding(4);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(172, 24);
            this.cboTheme.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Theme:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkConfirmDeleteKeybind);
            this.groupBox2.Controls.Add(this.chkConfirmDeleteProfile);
            this.groupBox2.Location = new System.Drawing.Point(16, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(307, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmations";
            // 
            // chkConfirmDeleteProfile
            // 
            this.chkConfirmDeleteProfile.AutoSize = true;
            this.chkConfirmDeleteProfile.Location = new System.Drawing.Point(8, 52);
            this.chkConfirmDeleteProfile.Margin = new System.Windows.Forms.Padding(4);
            this.chkConfirmDeleteProfile.Name = "chkConfirmDeleteProfile";
            this.chkConfirmDeleteProfile.Size = new System.Drawing.Size(214, 20);
            this.chkConfirmDeleteProfile.TabIndex = 3;
            this.chkConfirmDeleteProfile.Text = "Confirm before deleting profiles";
            this.chkConfirmDeleteProfile.UseVisualStyleBackColor = true;
            // 
            // chkConfirmDeleteKeybind
            // 
            this.chkConfirmDeleteKeybind.AutoSize = true;
            this.chkConfirmDeleteKeybind.Location = new System.Drawing.Point(8, 23);
            this.chkConfirmDeleteKeybind.Margin = new System.Windows.Forms.Padding(4);
            this.chkConfirmDeleteKeybind.Name = "chkConfirmDeleteKeybind";
            this.chkConfirmDeleteKeybind.Size = new System.Drawing.Size(225, 20);
            this.chkConfirmDeleteKeybind.TabIndex = 2;
            this.chkConfirmDeleteKeybind.Text = "Confirm before deleting keybinds";
            this.chkConfirmDeleteKeybind.UseVisualStyleBackColor = true;
            // 
            // pnlInterface
            // 
            this.pnlInterface.AutoScroll = true;
            this.pnlInterface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInterface.Controls.Add(this.groupBox2);
            this.pnlInterface.Controls.Add(this.groupBox1);
            this.pnlInterface.Location = new System.Drawing.Point(174, 15);
            this.pnlInterface.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInterface.Name = "pnlInterface";
            this.pnlInterface.Size = new System.Drawing.Size(340, 302);
            this.pnlInterface.TabIndex = 17;
            this.pnlInterface.Tag = "interface";
            // 
            // CustomiseFeeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 370);
            this.Controls.Add(this.pnlInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(354, 371);
            this.Name = "CustomiseFeeGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlInterface.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.ComboBox cboToolbarPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkLoadLastProfileOnStart;
        private System.Windows.Forms.CheckBox chkStartToTray;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkConfirmDeleteKeybind;
        private System.Windows.Forms.CheckBox chkConfirmDeleteProfile;
        private System.Windows.Forms.Panel pnlInterface;
    }
}
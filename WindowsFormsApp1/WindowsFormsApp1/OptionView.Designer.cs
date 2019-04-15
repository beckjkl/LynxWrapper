namespace WindowsFormsApp1
{
    partial class OptionsView
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
            this.components = new System.ComponentModel.Container();
            this.BasePath = new System.Windows.Forms.Label();
            this.SelectBasePathButton = new System.Windows.Forms.Button();
            this.NameTemplate = new System.Windows.Forms.Label();
            this.templatePathExplanationButton = new System.Windows.Forms.Button();
            this.BrowsePath = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectSeltecPathButton = new System.Windows.Forms.Button();
            this.SelectResultPathButton = new System.Windows.Forms.Button();
            this.FoundLynxVersion = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EventFolderGroup = new System.Windows.Forms.GroupBox();
            this.InvalidTemplateSign = new System.Windows.Forms.PictureBox();
            this.SeltecGroup = new System.Windows.Forms.GroupBox();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.LynxVersionBox = new System.Windows.Forms.ComboBox();
            this.TTOptions = new System.Windows.Forms.ToolTip(this.components);
            this.BackupGroup = new System.Windows.Forms.GroupBox();
            this.SelectBackupBasePathButton = new System.Windows.Forms.Button();
            this.BackupPath = new System.Windows.Forms.Label();
            this.SetBackupCheck = new System.Windows.Forms.CheckBox();
            this.BackupBasePathBox = new System.Windows.Forms.TextBox();
            this.StartLynxCheck = new System.Windows.Forms.CheckBox();
            this.ChangeSeltecSettingsBox = new System.Windows.Forms.CheckBox();
            this.BasePathBox = new System.Windows.Forms.TextBox();
            this.TemplatePathBox = new System.Windows.Forms.TextBox();
            this.SeltecPathBox = new System.Windows.Forms.TextBox();
            this.ShowSeltecRacesBox = new System.Windows.Forms.CheckBox();
            this.ChangeResultPathCheck = new System.Windows.Forms.CheckBox();
            this.ResultPathBox = new System.Windows.Forms.TextBox();
            this.EventFolderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidTemplateSign)).BeginInit();
            this.SeltecGroup.SuspendLayout();
            this.ResultGroup.SuspendLayout();
            this.BackupGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasePath
            // 
            this.BasePath.AutoSize = true;
            this.BasePath.Location = new System.Drawing.Point(43, 29);
            this.BasePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BasePath.Name = "BasePath";
            this.BasePath.Size = new System.Drawing.Size(100, 20);
            this.BasePath.TabIndex = 1;
            this.BasePath.Text = "Basisordner";
            // 
            // SelectBasePathButton
            // 
            this.SelectBasePathButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectBasePathButton.Location = new System.Drawing.Point(552, 22);
            this.SelectBasePathButton.Name = "SelectBasePathButton";
            this.SelectBasePathButton.Size = new System.Drawing.Size(127, 34);
            this.SelectBasePathButton.TabIndex = 2;
            this.SelectBasePathButton.Text = "Auswählen";
            this.SelectBasePathButton.UseVisualStyleBackColor = false;
            this.SelectBasePathButton.Click += new System.EventHandler(this.SelectBasePath_Click);
            // 
            // NameTemplate
            // 
            this.NameTemplate.AutoSize = true;
            this.NameTemplate.Location = new System.Drawing.Point(43, 69);
            this.NameTemplate.Name = "NameTemplate";
            this.NameTemplate.Size = new System.Drawing.Size(125, 20);
            this.NameTemplate.TabIndex = 4;
            this.NameTemplate.Text = "Namensvorlage";
            // 
            // templatePathExplanationButton
            // 
            this.templatePathExplanationButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.templatePathExplanationButton.Location = new System.Drawing.Point(552, 62);
            this.templatePathExplanationButton.Name = "templatePathExplanationButton";
            this.templatePathExplanationButton.Size = new System.Drawing.Size(127, 34);
            this.templatePathExplanationButton.TabIndex = 4;
            this.templatePathExplanationButton.Text = "Erklärung";
            this.templatePathExplanationButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pfad";
            // 
            // SelectSeltecPathButton
            // 
            this.SelectSeltecPathButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectSeltecPathButton.Location = new System.Drawing.Point(552, 22);
            this.SelectSeltecPathButton.Name = "SelectSeltecPathButton";
            this.SelectSeltecPathButton.Size = new System.Drawing.Size(127, 34);
            this.SelectSeltecPathButton.TabIndex = 6;
            this.SelectSeltecPathButton.Text = "Auswählen";
            this.SelectSeltecPathButton.UseVisualStyleBackColor = false;
            this.SelectSeltecPathButton.Click += new System.EventHandler(this.SelectSeltecPathButton_Click);
            // 
            // SelectResultPathButton
            // 
            this.SelectResultPathButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectResultPathButton.Location = new System.Drawing.Point(552, 52);
            this.SelectResultPathButton.Name = "SelectResultPathButton";
            this.SelectResultPathButton.Size = new System.Drawing.Size(127, 34);
            this.SelectResultPathButton.TabIndex = 10;
            this.SelectResultPathButton.Text = "Auswählen";
            this.SelectResultPathButton.UseVisualStyleBackColor = false;
            this.SelectResultPathButton.Click += new System.EventHandler(this.SelectResultPathButton_Click);
            // 
            // FoundLynxVersion
            // 
            this.FoundLynxVersion.AutoSize = true;
            this.FoundLynxVersion.Location = new System.Drawing.Point(12, 495);
            this.FoundLynxVersion.Name = "FoundLynxVersion";
            this.FoundLynxVersion.Size = new System.Drawing.Size(111, 20);
            this.FoundLynxVersion.TabIndex = 18;
            this.FoundLynxVersion.Text = "Lynx Version:";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OkButton.Location = new System.Drawing.Point(413, 541);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(128, 34);
            this.OkButton.TabIndex = 14;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton.Location = new System.Drawing.Point(564, 541);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 34);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Abbrechen";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EventFolderGroup
            // 
            this.EventFolderGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventFolderGroup.BackColor = System.Drawing.SystemColors.Control;
            this.EventFolderGroup.Controls.Add(this.InvalidTemplateSign);
            this.EventFolderGroup.Controls.Add(this.BasePathBox);
            this.EventFolderGroup.Controls.Add(this.BasePath);
            this.EventFolderGroup.Controls.Add(this.NameTemplate);
            this.EventFolderGroup.Controls.Add(this.TemplatePathBox);
            this.EventFolderGroup.Controls.Add(this.SelectBasePathButton);
            this.EventFolderGroup.Controls.Add(this.templatePathExplanationButton);
            this.EventFolderGroup.Location = new System.Drawing.Point(12, 12);
            this.EventFolderGroup.Name = "EventFolderGroup";
            this.EventFolderGroup.Size = new System.Drawing.Size(687, 103);
            this.EventFolderGroup.TabIndex = 23;
            this.EventFolderGroup.TabStop = false;
            this.EventFolderGroup.Text = "Ordnerstruktur für Events";
            this.EventFolderGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // InvalidTemplateSign
            // 
            this.InvalidTemplateSign.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Download;
            this.InvalidTemplateSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InvalidTemplateSign.InitialImage = global::WindowsFormsApp1.Properties.Resources.Download;
            this.InvalidTemplateSign.Location = new System.Drawing.Point(168, 62);
            this.InvalidTemplateSign.Name = "InvalidTemplateSign";
            this.InvalidTemplateSign.Size = new System.Drawing.Size(32, 32);
            this.InvalidTemplateSign.TabIndex = 7;
            this.InvalidTemplateSign.TabStop = false;
            this.TTOptions.SetToolTip(this.InvalidTemplateSign, "Die Namensvorlage kann nicht verarbeitet werden.\r\nBitte Korrigieren.\r\nFür mehr In" +
        "formationen siehe \"Erklärung\".");
            // 
            // SeltecGroup
            // 
            this.SeltecGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeltecGroup.Controls.Add(this.label1);
            this.SeltecGroup.Controls.Add(this.SeltecPathBox);
            this.SeltecGroup.Controls.Add(this.SelectSeltecPathButton);
            this.SeltecGroup.Controls.Add(this.ShowSeltecRacesBox);
            this.SeltecGroup.Location = new System.Drawing.Point(12, 121);
            this.SeltecGroup.Name = "SeltecGroup";
            this.SeltecGroup.Size = new System.Drawing.Size(687, 89);
            this.SeltecGroup.TabIndex = 7;
            this.SeltecGroup.TabStop = false;
            this.SeltecGroup.Text = "Seltec-Laufvorlagen";
            // 
            // ResultGroup
            // 
            this.ResultGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultGroup.Controls.Add(this.ChangeResultPathCheck);
            this.ResultGroup.Controls.Add(this.SelectResultPathButton);
            this.ResultGroup.Controls.Add(this.ResultPathBox);
            this.ResultGroup.Location = new System.Drawing.Point(12, 216);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(687, 105);
            this.ResultGroup.TabIndex = 24;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "Ergebnisse (.lif)";
            // 
            // LynxVersionBox
            // 
            this.LynxVersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LynxVersionBox.FormattingEnabled = true;
            this.LynxVersionBox.Location = new System.Drawing.Point(218, 498);
            this.LynxVersionBox.Name = "LynxVersionBox";
            this.LynxVersionBox.Size = new System.Drawing.Size(323, 28);
            this.LynxVersionBox.TabIndex = 13;
            // 
            // BackupGroup
            // 
            this.BackupGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupGroup.Controls.Add(this.BackupPath);
            this.BackupGroup.Controls.Add(this.SetBackupCheck);
            this.BackupGroup.Controls.Add(this.SelectBackupBasePathButton);
            this.BackupGroup.Controls.Add(this.BackupBasePathBox);
            this.BackupGroup.Location = new System.Drawing.Point(12, 327);
            this.BackupGroup.Name = "BackupGroup";
            this.BackupGroup.Size = new System.Drawing.Size(687, 105);
            this.BackupGroup.TabIndex = 25;
            this.BackupGroup.TabStop = false;
            this.BackupGroup.Text = "Backup";
            // 
            // SelectBackupBasePathButton
            // 
            this.SelectBackupBasePathButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectBackupBasePathButton.Location = new System.Drawing.Point(552, 52);
            this.SelectBackupBasePathButton.Name = "SelectBackupBasePathButton";
            this.SelectBackupBasePathButton.Size = new System.Drawing.Size(127, 34);
            this.SelectBackupBasePathButton.TabIndex = 10;
            this.SelectBackupBasePathButton.Text = "Auswählen";
            this.SelectBackupBasePathButton.UseVisualStyleBackColor = false;
            this.SelectBackupBasePathButton.Click += new System.EventHandler(this.SelectBackupBasePathButton_Click);
            // 
            // BackupPath
            // 
            this.BackupPath.AutoSize = true;
            this.BackupPath.Location = new System.Drawing.Point(43, 59);
            this.BackupPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackupPath.Name = "BackupPath";
            this.BackupPath.Size = new System.Drawing.Size(162, 20);
            this.BackupPath.TabIndex = 8;
            this.BackupPath.Text = "Backup-Basisordner";
            // 
            // SetBackupCheck
            // 
            this.SetBackupCheck.AutoSize = true;
            this.SetBackupCheck.Checked = global::WindowsFormsApp1.Properties.Settings.Default.TempSetBackupPath;
            this.SetBackupCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "TempSetBackupPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SetBackupCheck.Location = new System.Drawing.Point(47, 26);
            this.SetBackupCheck.Name = "SetBackupCheck";
            this.SetBackupCheck.Size = new System.Drawing.Size(205, 24);
            this.SetBackupCheck.TabIndex = 8;
            this.SetBackupCheck.Text = "Backup-Pfad einrichten";
            this.SetBackupCheck.UseVisualStyleBackColor = true;
            // 
            // BackupBasePathBox
            // 
            this.BackupBasePathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempBackupPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BackupBasePathBox.Location = new System.Drawing.Point(206, 56);
            this.BackupBasePathBox.Name = "BackupBasePathBox";
            this.BackupBasePathBox.Size = new System.Drawing.Size(323, 27);
            this.BackupBasePathBox.TabIndex = 9;
            this.BackupBasePathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.TempBackupPath;
            // 
            // StartLynxCheck
            // 
            this.StartLynxCheck.AutoSize = true;
            this.StartLynxCheck.Checked = global::WindowsFormsApp1.Properties.Settings.Default.TempStartLynx;
            this.StartLynxCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "TempStartLynx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StartLynxCheck.Location = new System.Drawing.Point(12, 468);
            this.StartLynxCheck.Name = "StartLynxCheck";
            this.StartLynxCheck.Size = new System.Drawing.Size(272, 24);
            this.StartLynxCheck.TabIndex = 12;
            this.StartLynxCheck.Text = "Lynx nach Eventauswahl starten";
            this.StartLynxCheck.UseVisualStyleBackColor = true;
            // 
            // ChangeSeltecSettingsBox
            // 
            this.ChangeSeltecSettingsBox.AutoSize = true;
            this.ChangeSeltecSettingsBox.Checked = global::WindowsFormsApp1.Properties.Settings.Default.TempSetLynxSettings;
            this.ChangeSeltecSettingsBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "TempSetLynxSettings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChangeSeltecSettingsBox.Location = new System.Drawing.Point(12, 438);
            this.ChangeSeltecSettingsBox.Name = "ChangeSeltecSettingsBox";
            this.ChangeSeltecSettingsBox.Size = new System.Drawing.Size(542, 24);
            this.ChangeSeltecSettingsBox.TabIndex = 11;
            this.ChangeSeltecSettingsBox.Text = "Lynx-Einstellungen anpassen (Hinweis: Erfordert Neustart von Lynx)";
            this.ChangeSeltecSettingsBox.ThreeState = true;
            this.ChangeSeltecSettingsBox.UseVisualStyleBackColor = true;
            // 
            // BasePathBox
            // 
            this.BasePathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempEventBasePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BasePathBox.Location = new System.Drawing.Point(206, 26);
            this.BasePathBox.Name = "BasePathBox";
            this.BasePathBox.Size = new System.Drawing.Size(323, 27);
            this.BasePathBox.TabIndex = 1;
            this.BasePathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.TempEventBasePath;
            this.BasePathBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TemplatePathBox
            // 
            this.TemplatePathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempEventPathTemplate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TemplatePathBox.Location = new System.Drawing.Point(206, 66);
            this.TemplatePathBox.Name = "TemplatePathBox";
            this.TemplatePathBox.Size = new System.Drawing.Size(323, 27);
            this.TemplatePathBox.TabIndex = 3;
            this.TemplatePathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.TempEventPathTemplate;
            this.TemplatePathBox.TextChanged += new System.EventHandler(this.TemplatePathBox_TextChanged);
            // 
            // SeltecPathBox
            // 
            this.SeltecPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempSeltecPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SeltecPathBox.Location = new System.Drawing.Point(206, 26);
            this.SeltecPathBox.Name = "SeltecPathBox";
            this.SeltecPathBox.Size = new System.Drawing.Size(323, 27);
            this.SeltecPathBox.TabIndex = 5;
            this.SeltecPathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.TempSeltecPath;
            this.SeltecPathBox.TextChanged += new System.EventHandler(this.TestTextBox_TextChanged);
            // 
            // ShowSeltecRacesBox
            // 
            this.ShowSeltecRacesBox.AutoSize = true;
            this.ShowSeltecRacesBox.Checked = global::WindowsFormsApp1.Properties.Settings.Default.TempActivateSeltecRead;
            this.ShowSeltecRacesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowSeltecRacesBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "TempActivateSeltecRead", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ShowSeltecRacesBox.Location = new System.Drawing.Point(47, 59);
            this.ShowSeltecRacesBox.Name = "ShowSeltecRacesBox";
            this.ShowSeltecRacesBox.Size = new System.Drawing.Size(351, 24);
            this.ShowSeltecRacesBox.TabIndex = 7;
            this.ShowSeltecRacesBox.Text = "Seltec-Laufvorlagen einlesen und anzeigen";
            this.ShowSeltecRacesBox.UseVisualStyleBackColor = true;
            // 
            // ChangeResultPathCheck
            // 
            this.ChangeResultPathCheck.AutoSize = true;
            this.ChangeResultPathCheck.Checked = global::WindowsFormsApp1.Properties.Settings.Default.TempChangeResultPath;
            this.ChangeResultPathCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChangeResultPathCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "TempChangeResultPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChangeResultPathCheck.Location = new System.Drawing.Point(47, 26);
            this.ChangeResultPathCheck.Name = "ChangeResultPathCheck";
            this.ChangeResultPathCheck.Size = new System.Drawing.Size(390, 24);
            this.ChangeResultPathCheck.TabIndex = 8;
            this.ChangeResultPathCheck.Text = "Ergebnisse unter einem anderen Pfad speichern";
            this.ChangeResultPathCheck.UseVisualStyleBackColor = true;
            this.ChangeResultPathCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ResultPathBox
            // 
            this.ResultPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempResultPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResultPathBox.Location = new System.Drawing.Point(206, 56);
            this.ResultPathBox.Name = "ResultPathBox";
            this.ResultPathBox.Size = new System.Drawing.Size(323, 27);
            this.ResultPathBox.TabIndex = 9;
            this.ResultPathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.TempResultPath;
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(713, 596);
            this.Controls.Add(this.BackupGroup);
            this.Controls.Add(this.LynxVersionBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.FoundLynxVersion);
            this.Controls.Add(this.StartLynxCheck);
            this.Controls.Add(this.ChangeSeltecSettingsBox);
            this.Controls.Add(this.EventFolderGroup);
            this.Controls.Add(this.SeltecGroup);
            this.Controls.Add(this.ResultGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsView";
            this.Text = "Optionen";
            this.Load += new System.EventHandler(this.OptionsView_Load);
            this.EventFolderGroup.ResumeLayout(false);
            this.EventFolderGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidTemplateSign)).EndInit();
            this.SeltecGroup.ResumeLayout(false);
            this.SeltecGroup.PerformLayout();
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            this.BackupGroup.ResumeLayout(false);
            this.BackupGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BasePath;
        private System.Windows.Forms.TextBox BasePathBox;
        private System.Windows.Forms.Button SelectBasePathButton;
        private System.Windows.Forms.Label NameTemplate;
        private System.Windows.Forms.TextBox TemplatePathBox;
        private System.Windows.Forms.Button templatePathExplanationButton;
        private System.Windows.Forms.FolderBrowserDialog BrowsePath;
        private System.Windows.Forms.TextBox SeltecPathBox;
        private System.Windows.Forms.CheckBox ShowSeltecRacesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectSeltecPathButton;
        private System.Windows.Forms.CheckBox ChangeSeltecSettingsBox;
        private System.Windows.Forms.CheckBox StartLynxCheck;
        private System.Windows.Forms.CheckBox ChangeResultPathCheck;
        private System.Windows.Forms.TextBox ResultPathBox;
        private System.Windows.Forms.Button SelectResultPathButton;
        private System.Windows.Forms.Label FoundLynxVersion;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox EventFolderGroup;
        private System.Windows.Forms.GroupBox SeltecGroup;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.ComboBox LynxVersionBox;
        private System.Windows.Forms.PictureBox InvalidTemplateSign;
        private System.Windows.Forms.ToolTip TTOptions;
        private System.Windows.Forms.GroupBox BackupGroup;
        private System.Windows.Forms.Label BackupPath;
        private System.Windows.Forms.CheckBox SetBackupCheck;
        private System.Windows.Forms.Button SelectBackupBasePathButton;
        private System.Windows.Forms.TextBox BackupBasePathBox;
    }
}
﻿namespace WindowsFormsApp1
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
            this.BasePath = new System.Windows.Forms.Label();
            this.SelectBasePathButton = new System.Windows.Forms.Button();
            this.NameTemplate = new System.Windows.Forms.Label();
            this.templatePathExplanationButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectSeltecPathButton = new System.Windows.Forms.Button();
            this.SelectResultPathButton = new System.Windows.Forms.Button();
            this.FoundLynxVersion = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LynxVersionBox = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ChangeSeltecSettingsBox = new System.Windows.Forms.CheckBox();
            this.BasePathBox = new System.Windows.Forms.TextBox();
            this.TemplatePathBox = new System.Windows.Forms.TextBox();
            this.SeltecPathBox = new System.Windows.Forms.TextBox();
            this.ShowSeltecRacesBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ResultPathBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.SelectBasePathButton.TabIndex = 3;
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
            this.templatePathExplanationButton.TabIndex = 6;
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
            this.SelectSeltecPathButton.TabIndex = 11;
            this.SelectSeltecPathButton.Text = "Auswählen";
            this.SelectSeltecPathButton.UseVisualStyleBackColor = false;
            // 
            // SelectResultPathButton
            // 
            this.SelectResultPathButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectResultPathButton.Location = new System.Drawing.Point(552, 52);
            this.SelectResultPathButton.Name = "SelectResultPathButton";
            this.SelectResultPathButton.Size = new System.Drawing.Size(127, 34);
            this.SelectResultPathButton.TabIndex = 17;
            this.SelectResultPathButton.Text = "Auswählen";
            this.SelectResultPathButton.UseVisualStyleBackColor = false;
            // 
            // FoundLynxVersion
            // 
            this.FoundLynxVersion.AutoSize = true;
            this.FoundLynxVersion.Location = new System.Drawing.Point(12, 390);
            this.FoundLynxVersion.Name = "FoundLynxVersion";
            this.FoundLynxVersion.Size = new System.Drawing.Size(111, 20);
            this.FoundLynxVersion.TabIndex = 18;
            this.FoundLynxVersion.Text = "Lynx Version:";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OkButton.Location = new System.Drawing.Point(413, 425);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(128, 34);
            this.OkButton.TabIndex = 21;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton.Location = new System.Drawing.Point(563, 425);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 34);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Abbrechen";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.BasePathBox);
            this.groupBox1.Controls.Add(this.BasePath);
            this.groupBox1.Controls.Add(this.NameTemplate);
            this.groupBox1.Controls.Add(this.TemplatePathBox);
            this.groupBox1.Controls.Add(this.SelectBasePathButton);
            this.groupBox1.Controls.Add(this.templatePathExplanationButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 103);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordnerstruktur für Events";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SeltecPathBox);
            this.groupBox2.Controls.Add(this.SelectSeltecPathButton);
            this.groupBox2.Controls.Add(this.ShowSeltecRacesBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 89);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seltec-Laufvorlagen";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.SelectResultPathButton);
            this.groupBox3.Controls.Add(this.ResultPathBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(687, 105);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnisse (.lif)";
            // 
            // LynxVersionBox
            // 
            this.LynxVersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LynxVersionBox.FormattingEnabled = true;
            this.LynxVersionBox.Items.AddRange(new object[] {
            "10.04",
            "10.09",
            "7.04"});
            this.LynxVersionBox.Location = new System.Drawing.Point(218, 387);
            this.LynxVersionBox.Name = "LynxVersionBox";
            this.LynxVersionBox.Size = new System.Drawing.Size(323, 28);
            this.LynxVersionBox.TabIndex = 25;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::WindowsFormsApp1.Properties.Settings.Default.TempStartLynx;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "TempStartLynx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(12, 357);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(272, 24);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Lynx nach Eventauswahl starten";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ChangeSeltecSettingsBox
            // 
            this.ChangeSeltecSettingsBox.AutoSize = true;
            this.ChangeSeltecSettingsBox.Checked = global::WindowsFormsApp1.Properties.Settings.Default.TempSetLynxSettings;
            this.ChangeSeltecSettingsBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "TempSetLynxSettings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChangeSeltecSettingsBox.Location = new System.Drawing.Point(12, 327);
            this.ChangeSeltecSettingsBox.Name = "ChangeSeltecSettingsBox";
            this.ChangeSeltecSettingsBox.Size = new System.Drawing.Size(542, 24);
            this.ChangeSeltecSettingsBox.TabIndex = 12;
            this.ChangeSeltecSettingsBox.Text = "Lynx-Einstellungen anpassen (Hinweis: Erfordert Neustart von Lynx)";
            this.ChangeSeltecSettingsBox.UseVisualStyleBackColor = true;
            // 
            // BasePathBox
            // 
            this.BasePathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempEventBasePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BasePathBox.Location = new System.Drawing.Point(206, 26);
            this.BasePathBox.Name = "BasePathBox";
            this.BasePathBox.Size = new System.Drawing.Size(323, 27);
            this.BasePathBox.TabIndex = 2;
            this.BasePathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.TempEventBasePath;
            this.BasePathBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TemplatePathBox
            // 
            this.TemplatePathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempEventPathTemplate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TemplatePathBox.Location = new System.Drawing.Point(206, 66);
            this.TemplatePathBox.Name = "TemplatePathBox";
            this.TemplatePathBox.Size = new System.Drawing.Size(323, 27);
            this.TemplatePathBox.TabIndex = 5;
            this.TemplatePathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.TempEventPathTemplate;
            // 
            // SeltecPathBox
            // 
            this.SeltecPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempSeltecPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SeltecPathBox.Location = new System.Drawing.Point(206, 26);
            this.SeltecPathBox.Name = "SeltecPathBox";
            this.SeltecPathBox.Size = new System.Drawing.Size(323, 27);
            this.SeltecPathBox.TabIndex = 7;
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
            this.ShowSeltecRacesBox.TabIndex = 8;
            this.ShowSeltecRacesBox.Text = "Seltec-Laufvorlagen einlesen und anzeigen";
            this.ShowSeltecRacesBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::WindowsFormsApp1.Properties.Settings.Default.TempChangeResultPath;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "TempChangeResultPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(47, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(390, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Ergebnisse unter einem anderen Pfad speichern";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ResultPathBox
            // 
            this.ResultPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "TempResultPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResultPathBox.Location = new System.Drawing.Point(206, 56);
            this.ResultPathBox.Name = "ResultPathBox";
            this.ResultPathBox.Size = new System.Drawing.Size(323, 27);
            this.ResultPathBox.TabIndex = 16;
            this.ResultPathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.TempResultPath;
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(713, 471);
            this.Controls.Add(this.LynxVersionBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.FoundLynxVersion);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ChangeSeltecSettingsBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsView";
            this.Text = "Optionen";
            this.Load += new System.EventHandler(this.OptionsView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox SeltecPathBox;
        private System.Windows.Forms.CheckBox ShowSeltecRacesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectSeltecPathButton;
        private System.Windows.Forms.CheckBox ChangeSeltecSettingsBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox ResultPathBox;
        private System.Windows.Forms.Button SelectResultPathButton;
        private System.Windows.Forms.Label FoundLynxVersion;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox LynxVersionBox;
    }
}
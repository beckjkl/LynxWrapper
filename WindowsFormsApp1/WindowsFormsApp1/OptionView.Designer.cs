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
            this.Topic1 = new System.Windows.Forms.Label();
            this.BasePath = new System.Windows.Forms.Label();
            this.BasePathBox = new System.Windows.Forms.TextBox();
            this.SelectBasePathButton = new System.Windows.Forms.Button();
            this.NameTemplate = new System.Windows.Forms.Label();
            this.TemplatePathBox = new System.Windows.Forms.TextBox();
            this.templatePathExplanationButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SeltecPathBox = new System.Windows.Forms.TextBox();
            this.ShowSeltecRacesBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Topic2 = new System.Windows.Forms.Label();
            this.SelectSeltecPathButton = new System.Windows.Forms.Button();
            this.ChangeSeltecSettingsBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Topic3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ResultPathBox = new System.Windows.Forms.TextBox();
            this.SelectResultPathButton = new System.Windows.Forms.Button();
            this.FoundLynxVersion = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Topic1
            // 
            this.Topic1.AutoSize = true;
            this.Topic1.Location = new System.Drawing.Point(39, 36);
            this.Topic1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Topic1.Name = "Topic1";
            this.Topic1.Size = new System.Drawing.Size(169, 17);
            this.Topic1.TabIndex = 0;
            this.Topic1.Text = "Ordnerstruktur für Events";
            this.Topic1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BasePath
            // 
            this.BasePath.AutoSize = true;
            this.BasePath.Location = new System.Drawing.Point(80, 81);
            this.BasePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BasePath.Name = "BasePath";
            this.BasePath.Size = new System.Drawing.Size(84, 17);
            this.BasePath.TabIndex = 1;
            this.BasePath.Text = "Basisordner";
            // 
            // BasePathBox
            // 
            this.BasePathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "Eventpath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BasePathBox.Location = new System.Drawing.Point(243, 78);
            this.BasePathBox.Name = "BasePathBox";
            this.BasePathBox.Size = new System.Drawing.Size(323, 23);
            this.BasePathBox.TabIndex = 2;
            this.BasePathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.Eventpath;
            this.BasePathBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SelectBasePathButton
            // 
            this.SelectBasePathButton.BackColor = System.Drawing.SystemColors.Control;
            this.SelectBasePathButton.Location = new System.Drawing.Point(612, 71);
            this.SelectBasePathButton.Name = "SelectBasePathButton";
            this.SelectBasePathButton.Size = new System.Drawing.Size(127, 44);
            this.SelectBasePathButton.TabIndex = 3;
            this.SelectBasePathButton.Text = "Auswählen";
            this.SelectBasePathButton.UseVisualStyleBackColor = false;
            this.SelectBasePathButton.Click += new System.EventHandler(this.SelectBasePath_Click);
            // 
            // NameTemplate
            // 
            this.NameTemplate.AutoSize = true;
            this.NameTemplate.Location = new System.Drawing.Point(80, 142);
            this.NameTemplate.Name = "NameTemplate";
            this.NameTemplate.Size = new System.Drawing.Size(107, 17);
            this.NameTemplate.TabIndex = 4;
            this.NameTemplate.Text = "Namensvorlage";
            // 
            // TemplatePathBox
            // 
            this.TemplatePathBox.Location = new System.Drawing.Point(243, 139);
            this.TemplatePathBox.Name = "TemplatePathBox";
            this.TemplatePathBox.Size = new System.Drawing.Size(323, 23);
            this.TemplatePathBox.TabIndex = 5;
            // 
            // templatePathExplanationButton
            // 
            this.templatePathExplanationButton.BackColor = System.Drawing.SystemColors.Control;
            this.templatePathExplanationButton.Location = new System.Drawing.Point(612, 130);
            this.templatePathExplanationButton.Name = "templatePathExplanationButton";
            this.templatePathExplanationButton.Size = new System.Drawing.Size(127, 44);
            this.templatePathExplanationButton.TabIndex = 6;
            this.templatePathExplanationButton.Text = "Erklärung";
            this.templatePathExplanationButton.UseVisualStyleBackColor = false;
            // 
            // SeltecPathBox
            // 
            this.SeltecPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "Eventpath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SeltecPathBox.Location = new System.Drawing.Point(243, 242);
            this.SeltecPathBox.Name = "SeltecPathBox";
            this.SeltecPathBox.Size = new System.Drawing.Size(323, 23);
            this.SeltecPathBox.TabIndex = 7;
            this.SeltecPathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.Eventpath;
            this.SeltecPathBox.TextChanged += new System.EventHandler(this.TestTextBox_TextChanged);
            // 
            // ShowSeltecRacesBox
            // 
            this.ShowSeltecRacesBox.AutoSize = true;
            this.ShowSeltecRacesBox.Checked = true;
            this.ShowSeltecRacesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowSeltecRacesBox.Location = new System.Drawing.Point(83, 286);
            this.ShowSeltecRacesBox.Name = "ShowSeltecRacesBox";
            this.ShowSeltecRacesBox.Size = new System.Drawing.Size(301, 21);
            this.ShowSeltecRacesBox.TabIndex = 8;
            this.ShowSeltecRacesBox.Text = "Seltec-Laufvorlagen einlesen und anzeigen";
            this.ShowSeltecRacesBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pfad";
            // 
            // Topic2
            // 
            this.Topic2.AutoSize = true;
            this.Topic2.Location = new System.Drawing.Point(39, 203);
            this.Topic2.Name = "Topic2";
            this.Topic2.Size = new System.Drawing.Size(135, 17);
            this.Topic2.TabIndex = 10;
            this.Topic2.Text = "Seltec-Laufvorlagen";
            // 
            // SelectSeltecPathButton
            // 
            this.SelectSeltecPathButton.BackColor = System.Drawing.SystemColors.Control;
            this.SelectSeltecPathButton.Location = new System.Drawing.Point(612, 231);
            this.SelectSeltecPathButton.Name = "SelectSeltecPathButton";
            this.SelectSeltecPathButton.Size = new System.Drawing.Size(127, 44);
            this.SelectSeltecPathButton.TabIndex = 11;
            this.SelectSeltecPathButton.Text = "Auswählen";
            this.SelectSeltecPathButton.UseVisualStyleBackColor = false;
            // 
            // ChangeSeltecSettingsBox
            // 
            this.ChangeSeltecSettingsBox.AutoSize = true;
            this.ChangeSeltecSettingsBox.Location = new System.Drawing.Point(42, 470);
            this.ChangeSeltecSettingsBox.Name = "ChangeSeltecSettingsBox";
            this.ChangeSeltecSettingsBox.Size = new System.Drawing.Size(456, 21);
            this.ChangeSeltecSettingsBox.TabIndex = 12;
            this.ChangeSeltecSettingsBox.Text = "Lynx-Einstellungen anpassen (Hinweis: Erfordert Neustart von Lynx)";
            this.ChangeSeltecSettingsBox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(42, 525);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(230, 21);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Lynx nach Eventauswahl starten";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Topic3
            // 
            this.Topic3.AutoSize = true;
            this.Topic3.Location = new System.Drawing.Point(48, 330);
            this.Topic3.Name = "Topic3";
            this.Topic3.Size = new System.Drawing.Size(146, 17);
            this.Topic3.TabIndex = 14;
            this.Topic3.Text = "Ergebnissdateien (.lif)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(83, 364);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(333, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Ergebnisse unter einem anderen Pfad speichern";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ResultPathBox
            // 
            this.ResultPathBox.Location = new System.Drawing.Point(243, 410);
            this.ResultPathBox.Name = "ResultPathBox";
            this.ResultPathBox.Size = new System.Drawing.Size(323, 23);
            this.ResultPathBox.TabIndex = 16;
            // 
            // SelectResultPathButton
            // 
            this.SelectResultPathButton.BackColor = System.Drawing.SystemColors.Control;
            this.SelectResultPathButton.Location = new System.Drawing.Point(612, 399);
            this.SelectResultPathButton.Name = "SelectResultPathButton";
            this.SelectResultPathButton.Size = new System.Drawing.Size(127, 44);
            this.SelectResultPathButton.TabIndex = 17;
            this.SelectResultPathButton.Text = "Auswählen";
            this.SelectResultPathButton.UseVisualStyleBackColor = false;
            // 
            // FoundLynxVersion
            // 
            this.FoundLynxVersion.AutoSize = true;
            this.FoundLynxVersion.Location = new System.Drawing.Point(39, 570);
            this.FoundLynxVersion.Name = "FoundLynxVersion";
            this.FoundLynxVersion.Size = new System.Drawing.Size(170, 17);
            this.FoundLynxVersion.TabIndex = 18;
            this.FoundLynxVersion.Text = "Erkannte Lynx Versionen:\r\n";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(243, 570);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(323, 148);
            this.checkedListBox1.TabIndex = 20;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.Control;
            this.OkButton.Location = new System.Drawing.Point(59, 740);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(128, 34);
            this.OkButton.TabIndex = 21;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(611, 740);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 34);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Abbrechen";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(760, 794);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.FoundLynxVersion);
            this.Controls.Add(this.SelectResultPathButton);
            this.Controls.Add(this.ResultPathBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Topic3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ChangeSeltecSettingsBox);
            this.Controls.Add(this.SelectSeltecPathButton);
            this.Controls.Add(this.Topic2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowSeltecRacesBox);
            this.Controls.Add(this.SeltecPathBox);
            this.Controls.Add(this.templatePathExplanationButton);
            this.Controls.Add(this.TemplatePathBox);
            this.Controls.Add(this.NameTemplate);
            this.Controls.Add(this.SelectBasePathButton);
            this.Controls.Add(this.BasePathBox);
            this.Controls.Add(this.BasePath);
            this.Controls.Add(this.Topic1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsView";
            this.Text = "Optionen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Topic1;
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
        private System.Windows.Forms.Label Topic2;
        private System.Windows.Forms.Button SelectSeltecPathButton;
        private System.Windows.Forms.CheckBox ChangeSeltecSettingsBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label Topic3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox ResultPathBox;
        private System.Windows.Forms.Button SelectResultPathButton;
        private System.Windows.Forms.Label FoundLynxVersion;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
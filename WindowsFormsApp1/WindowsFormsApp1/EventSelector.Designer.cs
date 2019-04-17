namespace WindowsFormsApp1
{
    partial class EventSelector
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
            this.TopLevelDesc = new System.Windows.Forms.Label();
            this.SelectNewEvent = new System.Windows.Forms.RadioButton();
            this.SelectExistingEvent = new System.Windows.Forms.RadioButton();
            this.EventName = new System.Windows.Forms.Label();
            this.PathNewEvent = new System.Windows.Forms.Label();
            this.SelectNewEventPath = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PathOpenEvent = new System.Windows.Forms.Label();
            this.SelectExistingEventPath = new System.Windows.Forms.Button();
            this.BrowsePath = new System.Windows.Forms.FolderBrowserDialog();
            this.EventNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EventFullPathBox = new System.Windows.Forms.TextBox();
            this.SelectedEventBox = new System.Windows.Forms.TextBox();
            this.EventPathBox = new System.Windows.Forms.TextBox();
            this.SelectNoEvent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TopLevelDesc
            // 
            this.TopLevelDesc.AutoSize = true;
            this.TopLevelDesc.Location = new System.Drawing.Point(13, 9);
            this.TopLevelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopLevelDesc.Name = "TopLevelDesc";
            this.TopLevelDesc.Size = new System.Drawing.Size(288, 20);
            this.TopLevelDesc.TabIndex = 0;
            this.TopLevelDesc.Text = "Welches Event soll angezeigt werden";
            // 
            // SelectNewEvent
            // 
            this.SelectNewEvent.AutoSize = true;
            this.SelectNewEvent.Location = new System.Drawing.Point(45, 32);
            this.SelectNewEvent.Name = "SelectNewEvent";
            this.SelectNewEvent.Size = new System.Drawing.Size(188, 24);
            this.SelectNewEvent.TabIndex = 1;
            this.SelectNewEvent.TabStop = true;
            this.SelectNewEvent.Text = "Neues Event anlegen";
            this.SelectNewEvent.UseVisualStyleBackColor = true;
            this.SelectNewEvent.CheckedChanged += new System.EventHandler(this.SelectNewEvent_CheckedChanged);
            // 
            // SelectExistingEvent
            // 
            this.SelectExistingEvent.AutoSize = true;
            this.SelectExistingEvent.Location = new System.Drawing.Point(45, 173);
            this.SelectExistingEvent.Name = "SelectExistingEvent";
            this.SelectExistingEvent.Size = new System.Drawing.Size(226, 24);
            this.SelectExistingEvent.TabIndex = 2;
            this.SelectExistingEvent.TabStop = true;
            this.SelectExistingEvent.Text = "Bestehendes Event öffnen";
            this.SelectExistingEvent.UseVisualStyleBackColor = true;
            this.SelectExistingEvent.CheckedChanged += new System.EventHandler(this.SelectExistingEvent_CheckedChanged);
            // 
            // EventName
            // 
            this.EventName.AutoSize = true;
            this.EventName.Location = new System.Drawing.Point(101, 65);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(92, 20);
            this.EventName.TabIndex = 5;
            this.EventName.Text = "Eventname";
            // 
            // PathNewEvent
            // 
            this.PathNewEvent.AutoSize = true;
            this.PathNewEvent.Location = new System.Drawing.Point(101, 98);
            this.PathNewEvent.Name = "PathNewEvent";
            this.PathNewEvent.Size = new System.Drawing.Size(84, 20);
            this.PathNewEvent.TabIndex = 6;
            this.PathNewEvent.Text = "Basispfad";
            // 
            // SelectNewEventPath
            // 
            this.SelectNewEventPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectNewEventPath.Enabled = false;
            this.SelectNewEventPath.Location = new System.Drawing.Point(583, 89);
            this.SelectNewEventPath.Name = "SelectNewEventPath";
            this.SelectNewEventPath.Size = new System.Drawing.Size(128, 39);
            this.SelectNewEventPath.TabIndex = 8;
            this.SelectNewEventPath.Text = "Auswählen";
            this.SelectNewEventPath.UseVisualStyleBackColor = false;
            this.SelectNewEventPath.Click += new System.EventHandler(this.SelectNewEventPath_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OkButton.Location = new System.Drawing.Point(427, 291);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(128, 34);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton.Location = new System.Drawing.Point(583, 291);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 34);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Abbrechen";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PathOpenEvent
            // 
            this.PathOpenEvent.AutoSize = true;
            this.PathOpenEvent.Location = new System.Drawing.Point(101, 206);
            this.PathOpenEvent.Name = "PathOpenEvent";
            this.PathOpenEvent.Size = new System.Drawing.Size(43, 20);
            this.PathOpenEvent.TabIndex = 11;
            this.PathOpenEvent.Text = "Pfad";
            // 
            // SelectExistingEventPath
            // 
            this.SelectExistingEventPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectExistingEventPath.Enabled = false;
            this.SelectExistingEventPath.Location = new System.Drawing.Point(583, 199);
            this.SelectExistingEventPath.Name = "SelectExistingEventPath";
            this.SelectExistingEventPath.Size = new System.Drawing.Size(128, 34);
            this.SelectExistingEventPath.TabIndex = 13;
            this.SelectExistingEventPath.Text = "Auswählen";
            this.SelectExistingEventPath.UseVisualStyleBackColor = false;
            this.SelectExistingEventPath.Click += new System.EventHandler(this.button4_Click);
            // 
            // BrowsePath
            // 
            this.BrowsePath.HelpRequest += new System.EventHandler(this.BrowseBasePath_HelpRequest);
            // 
            // EventNameBox
            // 
            this.EventNameBox.Enabled = false;
            this.EventNameBox.Location = new System.Drawing.Point(232, 62);
            this.EventNameBox.Name = "EventNameBox";
            this.EventNameBox.Size = new System.Drawing.Size(323, 27);
            this.EventNameBox.TabIndex = 4;
            this.EventNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ablagepfad";
            // 
            // EventFullPathBox
            // 
            this.EventFullPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "FullEventPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventFullPathBox.Enabled = false;
            this.EventFullPathBox.Location = new System.Drawing.Point(232, 128);
            this.EventFullPathBox.Name = "EventFullPathBox";
            this.EventFullPathBox.ReadOnly = true;
            this.EventFullPathBox.Size = new System.Drawing.Size(323, 27);
            this.EventFullPathBox.TabIndex = 15;
            this.EventFullPathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.FullEventPath;
            // 
            // SelectedEventBox
            // 
            this.SelectedEventBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "ExistingEventPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SelectedEventBox.Enabled = false;
            this.SelectedEventBox.Location = new System.Drawing.Point(232, 203);
            this.SelectedEventBox.Name = "SelectedEventBox";
            this.SelectedEventBox.Size = new System.Drawing.Size(323, 27);
            this.SelectedEventBox.TabIndex = 12;
            this.SelectedEventBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.ExistingEventPath;
            this.SelectedEventBox.TextChanged += new System.EventHandler(this.SelectedEventBox_TextChanged);
            // 
            // EventPathBox
            // 
            this.EventPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "Eventpath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventPathBox.Enabled = false;
            this.EventPathBox.Location = new System.Drawing.Point(232, 95);
            this.EventPathBox.Name = "EventPathBox";
            this.EventPathBox.Size = new System.Drawing.Size(323, 27);
            this.EventPathBox.TabIndex = 7;
            this.EventPathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.Eventpath;
            this.EventPathBox.TextChanged += new System.EventHandler(this.EventPathBox_TextChanged);
            // 
            // SelectNoEvent
            // 
            this.SelectNoEvent.AutoSize = true;
            this.SelectNoEvent.Checked = global::WindowsFormsApp1.Properties.Settings.Default.SelectNoEvent;
            this.SelectNoEvent.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsFormsApp1.Properties.Settings.Default, "SelectNoEvent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SelectNoEvent.Location = new System.Drawing.Point(45, 246);
            this.SelectNoEvent.Name = "SelectNoEvent";
            this.SelectNoEvent.Size = new System.Drawing.Size(155, 24);
            this.SelectNoEvent.TabIndex = 3;
            this.SelectNoEvent.TabStop = true;
            this.SelectNoEvent.Text = "Kein Event laden";
            this.SelectNoEvent.UseVisualStyleBackColor = true;
            this.SelectNoEvent.CheckedChanged += new System.EventHandler(this.SelectNoEvent_CheckedChanged);
            // 
            // EventSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(729, 341);
            this.Controls.Add(this.EventFullPathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectExistingEventPath);
            this.Controls.Add(this.SelectedEventBox);
            this.Controls.Add(this.PathOpenEvent);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SelectNewEventPath);
            this.Controls.Add(this.EventPathBox);
            this.Controls.Add(this.PathNewEvent);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.EventNameBox);
            this.Controls.Add(this.SelectNoEvent);
            this.Controls.Add(this.SelectExistingEvent);
            this.Controls.Add(this.SelectNewEvent);
            this.Controls.Add(this.TopLevelDesc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventSelector";
            this.Text = "Eventauswahl";
            this.Load += new System.EventHandler(this.EventSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopLevelDesc;
        private System.Windows.Forms.RadioButton SelectNewEvent;
        private System.Windows.Forms.RadioButton SelectExistingEvent;
        private System.Windows.Forms.RadioButton SelectNoEvent;
        private System.Windows.Forms.TextBox EventNameBox;
        private System.Windows.Forms.Label EventName;
        private System.Windows.Forms.Label PathNewEvent;
        private System.Windows.Forms.TextBox EventPathBox;
        private System.Windows.Forms.Button SelectNewEventPath;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label PathOpenEvent;
        private System.Windows.Forms.TextBox SelectedEventBox;
        private System.Windows.Forms.Button SelectExistingEventPath;
        private System.Windows.Forms.FolderBrowserDialog BrowsePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EventFullPathBox;
    }
}
﻿namespace WindowsFormsApp1
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
            this.SelectNoEvent = new System.Windows.Forms.RadioButton();
            this.EventName = new System.Windows.Forms.Label();
            this.PathNewEvent = new System.Windows.Forms.Label();
            this.SelectNewEventPath = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PathOpenEvent = new System.Windows.Forms.Label();
            this.SelectedEventBox = new System.Windows.Forms.TextBox();
            this.SelectExistingEventPath = new System.Windows.Forms.Button();
            this.BrowsePath = new System.Windows.Forms.FolderBrowserDialog();
            this.EventPathBox = new System.Windows.Forms.TextBox();
            this.EventNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EventFullPathBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TopLevelDesc
            // 
            this.TopLevelDesc.AutoSize = true;
            this.TopLevelDesc.Location = new System.Drawing.Point(20, 20);
            this.TopLevelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopLevelDesc.Name = "TopLevelDesc";
            this.TopLevelDesc.Size = new System.Drawing.Size(243, 17);
            this.TopLevelDesc.TabIndex = 0;
            this.TopLevelDesc.Text = "Welches Event soll angezeigt werden";
            // 
            // SelectNewEvent
            // 
            this.SelectNewEvent.AutoSize = true;
            this.SelectNewEvent.Location = new System.Drawing.Point(45, 60);
            this.SelectNewEvent.Name = "SelectNewEvent";
            this.SelectNewEvent.Size = new System.Drawing.Size(162, 21);
            this.SelectNewEvent.TabIndex = 1;
            this.SelectNewEvent.TabStop = true;
            this.SelectNewEvent.Text = "Neues Event anlegen";
            this.SelectNewEvent.UseVisualStyleBackColor = true;
            this.SelectNewEvent.CheckedChanged += new System.EventHandler(this.SelectNewEvent_CheckedChanged);
            // 
            // SelectExistingEvent
            // 
            this.SelectExistingEvent.AutoSize = true;
            this.SelectExistingEvent.Location = new System.Drawing.Point(45, 247);
            this.SelectExistingEvent.Name = "SelectExistingEvent";
            this.SelectExistingEvent.Size = new System.Drawing.Size(193, 21);
            this.SelectExistingEvent.TabIndex = 2;
            this.SelectExistingEvent.TabStop = true;
            this.SelectExistingEvent.Text = "Bestehendes Event öffnen";
            this.SelectExistingEvent.UseVisualStyleBackColor = true;
            this.SelectExistingEvent.CheckedChanged += new System.EventHandler(this.SelectExistingEvent_CheckedChanged);
            // 
            // SelectNoEvent
            // 
            this.SelectNoEvent.AutoSize = true;
            this.SelectNoEvent.Location = new System.Drawing.Point(45, 360);
            this.SelectNoEvent.Name = "SelectNoEvent";
            this.SelectNoEvent.Size = new System.Drawing.Size(133, 21);
            this.SelectNoEvent.TabIndex = 3;
            this.SelectNoEvent.TabStop = true;
            this.SelectNoEvent.Text = "Kein Event laden";
            this.SelectNoEvent.UseVisualStyleBackColor = true;
            this.SelectNoEvent.CheckedChanged += new System.EventHandler(this.SelectNoEvent_CheckedChanged);
            // 
            // EventName
            // 
            this.EventName.AutoSize = true;
            this.EventName.Location = new System.Drawing.Point(111, 102);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(79, 17);
            this.EventName.TabIndex = 5;
            this.EventName.Text = "Eventname";
            // 
            // PathNewEvent
            // 
            this.PathNewEvent.AutoSize = true;
            this.PathNewEvent.Location = new System.Drawing.Point(109, 156);
            this.PathNewEvent.Name = "PathNewEvent";
            this.PathNewEvent.Size = new System.Drawing.Size(70, 17);
            this.PathNewEvent.TabIndex = 6;
            this.PathNewEvent.Text = "Basispfad";
            // 
            // SelectNewEventPath
            // 
            this.SelectNewEventPath.BackColor = System.Drawing.SystemColors.Control;
            this.SelectNewEventPath.Enabled = false;
            this.SelectNewEventPath.Location = new System.Drawing.Point(728, 147);
            this.SelectNewEventPath.Name = "SelectNewEventPath";
            this.SelectNewEventPath.Size = new System.Drawing.Size(117, 39);
            this.SelectNewEventPath.TabIndex = 8;
            this.SelectNewEventPath.Text = "Auswählen";
            this.SelectNewEventPath.UseVisualStyleBackColor = false;
            this.SelectNewEventPath.Click += new System.EventHandler(this.SelectNewEventPath_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.Control;
            this.OkButton.Location = new System.Drawing.Point(90, 429);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(128, 34);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(717, 429);
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
            this.PathOpenEvent.Location = new System.Drawing.Point(111, 302);
            this.PathOpenEvent.Name = "PathOpenEvent";
            this.PathOpenEvent.Size = new System.Drawing.Size(37, 17);
            this.PathOpenEvent.TabIndex = 11;
            this.PathOpenEvent.Text = "Pfad";
            // 
            // SelectedEventBox
            // 
            this.SelectedEventBox.Enabled = false;
            this.SelectedEventBox.Location = new System.Drawing.Point(232, 301);
            this.SelectedEventBox.Name = "SelectedEventBox";
            this.SelectedEventBox.Size = new System.Drawing.Size(450, 23);
            this.SelectedEventBox.TabIndex = 12;
            // 
            // SelectExistingEventPath
            // 
            this.SelectExistingEventPath.BackColor = System.Drawing.SystemColors.Control;
            this.SelectExistingEventPath.Enabled = false;
            this.SelectExistingEventPath.Location = new System.Drawing.Point(728, 294);
            this.SelectExistingEventPath.Name = "SelectExistingEventPath";
            this.SelectExistingEventPath.Size = new System.Drawing.Size(117, 39);
            this.SelectExistingEventPath.TabIndex = 13;
            this.SelectExistingEventPath.Text = "Auswählen";
            this.SelectExistingEventPath.UseVisualStyleBackColor = false;
            this.SelectExistingEventPath.Click += new System.EventHandler(this.button4_Click);
            // 
            // BrowsePath
            // 
            this.BrowsePath.HelpRequest += new System.EventHandler(this.BrowseBasePath_HelpRequest);
            // 
            // EventPathBox
            // 
            this.EventPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "Eventpath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventPathBox.Enabled = false;
            this.EventPathBox.Location = new System.Drawing.Point(232, 153);
            this.EventPathBox.Name = "EventPathBox";
            this.EventPathBox.Size = new System.Drawing.Size(450, 23);
            this.EventPathBox.TabIndex = 7;
            this.EventPathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.Eventpath;
            // 
            // EventNameBox
            // 
            this.EventNameBox.Enabled = false;
            this.EventNameBox.Location = new System.Drawing.Point(232, 102);
            this.EventNameBox.Name = "EventNameBox";
            this.EventNameBox.Size = new System.Drawing.Size(450, 23);
            this.EventNameBox.TabIndex = 4;
            this.EventNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ablagepfad";
            // 
            // EventFullPathBox
            // 
            this.EventFullPathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "FullEventPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventFullPathBox.Enabled = false;
            this.EventFullPathBox.Location = new System.Drawing.Point(232, 203);
            this.EventFullPathBox.Name = "EventFullPathBox";
            this.EventFullPathBox.ReadOnly = true;
            this.EventFullPathBox.Size = new System.Drawing.Size(450, 23);
            this.EventFullPathBox.TabIndex = 15;
            this.EventFullPathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.FullEventPath;
            // 
            // EventSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(866, 482);
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
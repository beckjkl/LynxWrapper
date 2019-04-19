namespace WindowsFormsApp1
{
    partial class LynxWrapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LynxWrapper));
            this.RaceListView = new System.Windows.Forms.ListView();
            this.Race = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OptionsButton = new System.Windows.Forms.Button();
            this.EventSelectButton = new System.Windows.Forms.Button();
            this.NewRaceSingleCheck = new System.Windows.Forms.CheckBox();
            this.NewRaceMultiCheck = new System.Windows.Forms.CheckBox();
            this.RaceNotJudgedCheck = new System.Windows.Forms.CheckBox();
            this.RaceJudgedCheck = new System.Windows.Forms.CheckBox();
            this.TTEventview = new System.Windows.Forms.ToolTip(this.components);
            this.PlanedRaceCheck = new System.Windows.Forms.CheckBox();
            this.EventWatcher = new System.IO.FileSystemWatcher();
            this.Resultwatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.EventWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resultwatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceListView
            // 
            this.RaceListView.AllowColumnReorder = true;
            this.RaceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Race,
            this.status,
            this.LastModified});
            resources.ApplyResources(this.RaceListView, "RaceListView");
            this.RaceListView.MultiSelect = false;
            this.RaceListView.Name = "RaceListView";
            this.RaceListView.ShowItemToolTips = true;
            this.RaceListView.UseCompatibleStateImageBehavior = false;
            this.RaceListView.View = System.Windows.Forms.View.Details;
            this.RaceListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Race
            // 
            resources.ApplyResources(this.Race, "Race");
            // 
            // status
            // 
            resources.ApplyResources(this.status, "status");
            // 
            // LastModified
            // 
            resources.ApplyResources(this.LastModified, "LastModified");
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.OptionsButton, "OptionsButton");
            this.OptionsButton.Name = "OptionsButton";
            this.TTEventview.SetToolTip(this.OptionsButton, resources.GetString("OptionsButton.ToolTip"));
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.Options_Click);
            // 
            // EventSelectButton
            // 
            resources.ApplyResources(this.EventSelectButton, "EventSelectButton");
            this.EventSelectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EventSelectButton.Name = "EventSelectButton";
            this.TTEventview.SetToolTip(this.EventSelectButton, resources.GetString("EventSelectButton.ToolTip"));
            this.EventSelectButton.UseVisualStyleBackColor = false;
            this.EventSelectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewRaceSingleCheck
            // 
            resources.ApplyResources(this.NewRaceSingleCheck, "NewRaceSingleCheck");
            this.NewRaceSingleCheck.BackColor = System.Drawing.Color.Yellow;
            this.NewRaceSingleCheck.Checked = true;
            this.NewRaceSingleCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewRaceSingleCheck.Name = "NewRaceSingleCheck";
            this.TTEventview.SetToolTip(this.NewRaceSingleCheck, resources.GetString("NewRaceSingleCheck.ToolTip"));
            this.NewRaceSingleCheck.UseVisualStyleBackColor = false;
            this.NewRaceSingleCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NewRaceMultiCheck
            // 
            resources.ApplyResources(this.NewRaceMultiCheck, "NewRaceMultiCheck");
            this.NewRaceMultiCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NewRaceMultiCheck.Checked = true;
            this.NewRaceMultiCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewRaceMultiCheck.Name = "NewRaceMultiCheck";
            this.TTEventview.SetToolTip(this.NewRaceMultiCheck, resources.GetString("NewRaceMultiCheck.ToolTip"));
            this.NewRaceMultiCheck.UseVisualStyleBackColor = false;
            this.NewRaceMultiCheck.CheckedChanged += new System.EventHandler(this.NewRaceMulti_CheckedChanged);
            // 
            // RaceNotJudgedCheck
            // 
            resources.ApplyResources(this.RaceNotJudgedCheck, "RaceNotJudgedCheck");
            this.RaceNotJudgedCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RaceNotJudgedCheck.Checked = true;
            this.RaceNotJudgedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RaceNotJudgedCheck.Name = "RaceNotJudgedCheck";
            this.TTEventview.SetToolTip(this.RaceNotJudgedCheck, resources.GetString("RaceNotJudgedCheck.ToolTip"));
            this.RaceNotJudgedCheck.UseVisualStyleBackColor = false;
            // 
            // RaceJudgedCheck
            // 
            resources.ApplyResources(this.RaceJudgedCheck, "RaceJudgedCheck");
            this.RaceJudgedCheck.BackColor = System.Drawing.Color.Lime;
            this.RaceJudgedCheck.Checked = true;
            this.RaceJudgedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RaceJudgedCheck.Name = "RaceJudgedCheck";
            this.TTEventview.SetToolTip(this.RaceJudgedCheck, resources.GetString("RaceJudgedCheck.ToolTip"));
            this.RaceJudgedCheck.UseVisualStyleBackColor = false;
            this.RaceJudgedCheck.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // PlanedRaceCheck
            // 
            resources.ApplyResources(this.PlanedRaceCheck, "PlanedRaceCheck");
            this.PlanedRaceCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PlanedRaceCheck.Name = "PlanedRaceCheck";
            this.PlanedRaceCheck.UseVisualStyleBackColor = false;
            // 
            // EventWatcher
            // 
            this.EventWatcher.EnableRaisingEvents = true;
            this.EventWatcher.Filter = global::WindowsFormsApp1.Properties.Settings.Default.EventComponents;
            this.EventWatcher.Path = global::WindowsFormsApp1.Properties.Settings.Default.ActiveEventPath;
            this.EventWatcher.SynchronizingObject = this;
            this.EventWatcher.Changed += new System.IO.FileSystemEventHandler(this.EventWatcher_Changed);
            // 
            // Resultwatcher
            // 
            this.Resultwatcher.EnableRaisingEvents = true;
            this.Resultwatcher.Filter = "*.lif";
            this.Resultwatcher.Path = global::WindowsFormsApp1.Properties.Settings.Default.ResultPath;
            this.Resultwatcher.SynchronizingObject = this;
            this.Resultwatcher.Changed += new System.IO.FileSystemEventHandler(this.Resultwatcher_Changed);
            // 
            // LynxWrapper
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.PlanedRaceCheck);
            this.Controls.Add(this.RaceJudgedCheck);
            this.Controls.Add(this.RaceNotJudgedCheck);
            this.Controls.Add(this.NewRaceMultiCheck);
            this.Controls.Add(this.NewRaceSingleCheck);
            this.Controls.Add(this.EventSelectButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.RaceListView);
            this.Name = "LynxWrapper";
            this.Load += new System.EventHandler(this.LynxWrapper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resultwatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView RaceListView;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button EventSelectButton;
        private System.Windows.Forms.CheckBox NewRaceSingleCheck;
        private System.Windows.Forms.CheckBox NewRaceMultiCheck;
        private System.Windows.Forms.CheckBox RaceNotJudgedCheck;
        private System.Windows.Forms.CheckBox RaceJudgedCheck;
        private System.Windows.Forms.ToolTip TTEventview;
        private System.Windows.Forms.ColumnHeader Race;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader LastModified;
        private System.IO.FileSystemWatcher EventWatcher;
        private System.Windows.Forms.CheckBox PlanedRaceCheck;
        private System.IO.FileSystemWatcher Resultwatcher;
    }
}


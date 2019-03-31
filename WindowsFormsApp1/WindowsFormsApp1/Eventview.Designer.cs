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
            this.RaceList = new System.Windows.Forms.ListView();
            this.Race = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Options = new System.Windows.Forms.Button();
            this.EventSelect = new System.Windows.Forms.Button();
            this.NewRaceSingle = new System.Windows.Forms.CheckBox();
            this.NewRaceMulti = new System.Windows.Forms.CheckBox();
            this.RaceNotJudged = new System.Windows.Forms.CheckBox();
            this.RaceJudged = new System.Windows.Forms.CheckBox();
            this.TTEventview = new System.Windows.Forms.ToolTip(this.components);
            this.EventWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.EventWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceList
            // 
            this.RaceList.AllowColumnReorder = true;
            resources.ApplyResources(this.RaceList, "RaceList");
            this.RaceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Race,
            this.status,
            this.LastModified});
            this.RaceList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("RaceList.Groups"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("RaceList.Groups1"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("RaceList.Groups2"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("RaceList.Groups3")))});
            this.RaceList.MultiSelect = false;
            this.RaceList.Name = "RaceList";
            this.RaceList.ShowItemToolTips = true;
            this.RaceList.UseCompatibleStateImageBehavior = false;
            this.RaceList.View = System.Windows.Forms.View.Details;
            this.RaceList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // Options
            // 
            resources.ApplyResources(this.Options, "Options");
            this.Options.Name = "Options";
            this.TTEventview.SetToolTip(this.Options, resources.GetString("Options.ToolTip"));
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // EventSelect
            // 
            resources.ApplyResources(this.EventSelect, "EventSelect");
            this.EventSelect.Name = "EventSelect";
            this.TTEventview.SetToolTip(this.EventSelect, resources.GetString("EventSelect.ToolTip"));
            this.EventSelect.UseVisualStyleBackColor = true;
            this.EventSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewRaceSingle
            // 
            resources.ApplyResources(this.NewRaceSingle, "NewRaceSingle");
            this.NewRaceSingle.BackColor = System.Drawing.Color.Yellow;
            this.NewRaceSingle.Checked = true;
            this.NewRaceSingle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewRaceSingle.Name = "NewRaceSingle";
            this.TTEventview.SetToolTip(this.NewRaceSingle, resources.GetString("NewRaceSingle.ToolTip"));
            this.NewRaceSingle.UseVisualStyleBackColor = false;
            this.NewRaceSingle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NewRaceMulti
            // 
            resources.ApplyResources(this.NewRaceMulti, "NewRaceMulti");
            this.NewRaceMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NewRaceMulti.Checked = true;
            this.NewRaceMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewRaceMulti.Name = "NewRaceMulti";
            this.TTEventview.SetToolTip(this.NewRaceMulti, resources.GetString("NewRaceMulti.ToolTip"));
            this.NewRaceMulti.UseVisualStyleBackColor = false;
            this.NewRaceMulti.CheckedChanged += new System.EventHandler(this.NewRaceMulti_CheckedChanged);
            // 
            // RaceNotJudged
            // 
            resources.ApplyResources(this.RaceNotJudged, "RaceNotJudged");
            this.RaceNotJudged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RaceNotJudged.Checked = true;
            this.RaceNotJudged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RaceNotJudged.Name = "RaceNotJudged";
            this.TTEventview.SetToolTip(this.RaceNotJudged, resources.GetString("RaceNotJudged.ToolTip"));
            this.RaceNotJudged.UseVisualStyleBackColor = false;
            // 
            // RaceJudged
            // 
            resources.ApplyResources(this.RaceJudged, "RaceJudged");
            this.RaceJudged.BackColor = System.Drawing.Color.Lime;
            this.RaceJudged.Checked = true;
            this.RaceJudged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RaceJudged.Name = "RaceJudged";
            this.TTEventview.SetToolTip(this.RaceJudged, resources.GetString("RaceJudged.ToolTip"));
            this.RaceJudged.UseVisualStyleBackColor = false;
            this.RaceJudged.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // EventWatcher
            // 
            this.EventWatcher.EnableRaisingEvents = true;
            this.EventWatcher.Filter = global::WindowsFormsApp1.Properties.Settings.Default.EventComponents;
            this.EventWatcher.Path = global::WindowsFormsApp1.Properties.Settings.Default.Eventpath;
            this.EventWatcher.SynchronizingObject = this;
            this.EventWatcher.Changed += new System.IO.FileSystemEventHandler(this.EventWatcher_Changed);
            // 
            // LynxWrapper
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RaceJudged);
            this.Controls.Add(this.RaceNotJudged);
            this.Controls.Add(this.NewRaceMulti);
            this.Controls.Add(this.NewRaceSingle);
            this.Controls.Add(this.EventSelect);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.RaceList);
            this.Name = "LynxWrapper";
            this.Load += new System.EventHandler(this.LynxWrapper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView RaceList;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button EventSelect;
        private System.Windows.Forms.CheckBox NewRaceSingle;
        private System.Windows.Forms.CheckBox NewRaceMulti;
        private System.Windows.Forms.CheckBox RaceNotJudged;
        private System.Windows.Forms.CheckBox RaceJudged;
        private System.Windows.Forms.ToolTip TTEventview;
        private System.Windows.Forms.ColumnHeader Race;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader LastModified;
        private System.IO.FileSystemWatcher EventWatcher;
    }
}


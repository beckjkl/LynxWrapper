namespace WindowsFormsApp1
{
    partial class OptionView
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
            this.label1 = new System.Windows.Forms.Label();
            this.BasePath = new System.Windows.Forms.Label();
            this.BasePathBox = new System.Windows.Forms.TextBox();
            this.SelectBasePath = new System.Windows.Forms.Button();
            this.NameMask = new System.Windows.Forms.Label();
            this.NameMaskBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TestTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordnerstruktur für Events";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BasePath
            // 
            this.BasePath.AutoSize = true;
            this.BasePath.Location = new System.Drawing.Point(80, 81);
            this.BasePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BasePath.Name = "BasePath";
            this.BasePath.Size = new System.Drawing.Size(100, 20);
            this.BasePath.TabIndex = 1;
            this.BasePath.Text = "Basisordner";
            // 
            // BasePathBox
            // 
            this.BasePathBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "Eventpath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BasePathBox.Location = new System.Drawing.Point(243, 78);
            this.BasePathBox.Name = "BasePathBox";
            this.BasePathBox.Size = new System.Drawing.Size(323, 27);
            this.BasePathBox.TabIndex = 2;
            this.BasePathBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.Eventpath;
            this.BasePathBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SelectBasePath
            // 
            this.SelectBasePath.Location = new System.Drawing.Point(612, 71);
            this.SelectBasePath.Name = "SelectBasePath";
            this.SelectBasePath.Size = new System.Drawing.Size(127, 44);
            this.SelectBasePath.TabIndex = 3;
            this.SelectBasePath.Text = "Auswählen";
            this.SelectBasePath.UseVisualStyleBackColor = true;
            this.SelectBasePath.Click += new System.EventHandler(this.SelectBasePath_Click);
            // 
            // NameMask
            // 
            this.NameMask.AutoSize = true;
            this.NameMask.Location = new System.Drawing.Point(80, 142);
            this.NameMask.Name = "NameMask";
            this.NameMask.Size = new System.Drawing.Size(125, 20);
            this.NameMask.TabIndex = 4;
            this.NameMask.Text = "Namensvorlage";
            // 
            // NameMaskBox
            // 
            this.NameMaskBox.Location = new System.Drawing.Point(243, 139);
            this.NameMaskBox.Name = "NameMaskBox";
            this.NameMaskBox.Size = new System.Drawing.Size(323, 27);
            this.NameMaskBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Erklärung";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestTextBox
            // 
            this.TestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "Eventpath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TestTextBox.Location = new System.Drawing.Point(264, 265);
            this.TestTextBox.Name = "TestTextBox";
            this.TestTextBox.Size = new System.Drawing.Size(174, 27);
            this.TestTextBox.TabIndex = 7;
            this.TestTextBox.Text = global::WindowsFormsApp1.Properties.Settings.Default.Eventpath;
            // 
            // OptionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 507);
            this.Controls.Add(this.TestTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameMaskBox);
            this.Controls.Add(this.NameMask);
            this.Controls.Add(this.SelectBasePath);
            this.Controls.Add(this.BasePathBox);
            this.Controls.Add(this.BasePath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OptionView";
            this.Text = "OptionView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BasePath;
        private System.Windows.Forms.TextBox BasePathBox;
        private System.Windows.Forms.Button SelectBasePath;
        private System.Windows.Forms.Label NameMask;
        private System.Windows.Forms.TextBox NameMaskBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TestTextBox;
    }
}
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
            this.SelectNoEvent = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EventName = new System.Windows.Forms.Label();
            this.PathNewEvent = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PathOpenEvent = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // TopLevelDesc
            // 
            this.TopLevelDesc.AutoSize = true;
            this.TopLevelDesc.Location = new System.Drawing.Point(20, 20);
            this.TopLevelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopLevelDesc.Name = "TopLevelDesc";
            this.TopLevelDesc.Size = new System.Drawing.Size(299, 20);
            this.TopLevelDesc.TabIndex = 0;
            this.TopLevelDesc.Text = "Welches Event soll bearbeitete werden";
            // 
            // SelectNewEvent
            // 
            this.SelectNewEvent.AutoSize = true;
            this.SelectNewEvent.Location = new System.Drawing.Point(45, 60);
            this.SelectNewEvent.Name = "SelectNewEvent";
            this.SelectNewEvent.Size = new System.Drawing.Size(188, 24);
            this.SelectNewEvent.TabIndex = 1;
            this.SelectNewEvent.TabStop = true;
            this.SelectNewEvent.Text = "Neues Event anlegen";
            this.SelectNewEvent.UseVisualStyleBackColor = true;
            // 
            // SelectExistingEvent
            // 
            this.SelectExistingEvent.AutoSize = true;
            this.SelectExistingEvent.Location = new System.Drawing.Point(57, 231);
            this.SelectExistingEvent.Name = "SelectExistingEvent";
            this.SelectExistingEvent.Size = new System.Drawing.Size(226, 24);
            this.SelectExistingEvent.TabIndex = 2;
            this.SelectExistingEvent.TabStop = true;
            this.SelectExistingEvent.Text = "Bestehendes Event öffnen";
            this.SelectExistingEvent.UseVisualStyleBackColor = true;
            // 
            // SelectNoEvent
            // 
            this.SelectNoEvent.AutoSize = true;
            this.SelectNoEvent.Location = new System.Drawing.Point(57, 360);
            this.SelectNoEvent.Name = "SelectNoEvent";
            this.SelectNoEvent.Size = new System.Drawing.Size(174, 24);
            this.SelectNoEvent.TabIndex = 3;
            this.SelectNoEvent.TabStop = true;
            this.SelectNoEvent.Text = "Ohne Event starten";
            this.SelectNoEvent.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 27);
            this.textBox1.TabIndex = 4;
            // 
            // EventName
            // 
            this.EventName.AutoSize = true;
            this.EventName.Location = new System.Drawing.Point(106, 105);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(92, 20);
            this.EventName.TabIndex = 5;
            this.EventName.Text = "Eventname";
            // 
            // PathNewEvent
            // 
            this.PathNewEvent.AutoSize = true;
            this.PathNewEvent.Location = new System.Drawing.Point(109, 160);
            this.PathNewEvent.Name = "PathNewEvent";
            this.PathNewEvent.Size = new System.Drawing.Size(43, 20);
            this.PathNewEvent.TabIndex = 6;
            this.PathNewEvent.Text = "Pfad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(450, 27);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(90, 429);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(128, 34);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(717, 429);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 34);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Abbrechen";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // PathOpenEvent
            // 
            this.PathOpenEvent.AutoSize = true;
            this.PathOpenEvent.Location = new System.Drawing.Point(111, 285);
            this.PathOpenEvent.Name = "PathOpenEvent";
            this.PathOpenEvent.Size = new System.Drawing.Size(43, 20);
            this.PathOpenEvent.TabIndex = 11;
            this.PathOpenEvent.Text = "Pfad";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(450, 27);
            this.textBox3.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(728, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EventSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 482);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.PathOpenEvent);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PathNewEvent);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SelectNoEvent);
            this.Controls.Add(this.SelectExistingEvent);
            this.Controls.Add(this.SelectNewEvent);
            this.Controls.Add(this.TopLevelDesc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventSelector";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EventSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopLevelDesc;
        private System.Windows.Forms.RadioButton SelectNewEvent;
        private System.Windows.Forms.RadioButton SelectExistingEvent;
        private System.Windows.Forms.RadioButton SelectNoEvent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EventName;
        private System.Windows.Forms.Label PathNewEvent;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label PathOpenEvent;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LynxWrapper : Form
    {
        public LynxWrapper()
        {
            InitializeComponent();
        }

        private void LynxWrapper_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.ActiveEventPath = "";
            EventWatcher.Created += EventWatcher_Created;
            EventWatcher.Deleted += EventWatcher_Deleted;
            Resultwatcher.Created += Resultwatcher_Changed;
            Resultwatcher.Deleted += Resultwatcher_Changed;
            PictueDataWatcher.Created += PictueDataWatcher_Created;
            PictueDataWatcher.Deleted += PictueDataWatcher_Deleted;
            Resultwatcher.Created += Resultwatcher_Created;
            Resultwatcher.Deleted += Resultwatcher_Deleted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.InitialSettingsDone)
            {
                MessageBox.Show("Bitte zuerst die Einstellungen anpassen.", "Fehler: Einstellungen nicht gesetzt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Selector = new EventSelector();
            Selector.ShowDialog();
            EventWatcher.Path = Properties.Settings.Default.ActiveEventPath;
            Resultwatcher.Path = Properties.Settings.Default.ResultPath;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Changes the state of an Item or create it if it doesn't exist
        private ListViewItem ChangeItemState(object sender, System.IO.FileSystemEventArgs e, int State)
        {
            FileSystemWatcher ChangedObject = (FileSystemWatcher)sender;
            string FileName = e.Name.Split('.')[0];
            var LastChangeTime = System.IO.File.GetLastWriteTime(e.FullPath);

            string[] StateTexts = new string[] { "Geplant", "Neu (Single User)", "Neu (Multi User)", "Nicht ausgewertet", "Ausgewertet" };
            Color[] StateColors = new Color[] { Color.White, Color.Yellow, Color.FromArgb(192, 0, 192), Color.FromArgb(192, 0, 0), Color.Lime };
            CheckBox[] StateEnablers = new CheckBox[] { PlanedRaceCheck, NewRaceSingleCheck, NewRaceMultiCheck, RaceNotJudgedCheck, RaceJudgedCheck };

            ListViewItem[] Candidates = RaceListView.Items.Find(Name, false);
            ListViewItem FoundItem = null;
            switch (Candidates.Length)
            {
                case 0:
                    FoundItem = new ListViewItem();
                    FoundItem.Name = Name;
                    FoundItem.Text = Name.Split('(')[0];
                    FoundItem.SubItems.Add("");
                    FoundItem.SubItems.Add("");
                    RaceListView.Items.Add(FoundItem);
                    break;
                case 1:
                    FoundItem = Candidates[0];
                    break;
                default:
                    MessageBox.Show("DEBUG: None-Unique ListviewItem: " + Name, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                    //Add logging?
                    break;
            }
            if(!(FoundItem.Tag == null))
            {
                State = Math.Max(State, (int)FoundItem.Tag);
                //Replace with Analysis from State Graph later
            }
            if(State == 5)
            {
                FoundItem.Remove();
            }     
            FoundItem.Tag = State;
            FoundItem.SubItems[1].Text = StateTexts[State];
            FoundItem.SubItems[1].BackColor = StateColors[State];
            FoundItem.SubItems[2].Text = LastChangeTime.ToShortDateString() + " " + LastChangeTime.ToShortTimeString();
            return FoundItem;
        }

        private void EventWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            ChangeItemState(sender,  e, 1);
        }

        private void EventWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            ChangeItemState(sender, e, 1);
        }

        private void EventWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            ChangeItemState(sender, e, 0);
        }

        private void PictueDataWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            ChangeItemState(sender, e, 3);
        }

        private void PictueDataWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            ChangeItemState(sender, e, 3);
        }

        private void PictueDataWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            ChangeItemState(sender, e, 1);
        }

        private void Options_Click(object sender, EventArgs e)
        {
            var optionViewer = new OptionsView();
            optionViewer.ShowDialog();
        }

        private void Resultwatcher_Changed(object sender, FileSystemEventArgs e)
        {
            ListViewItem FoundItem = ChangeItemState(sender, e, 4);
            if (FoundItem == null) { return; }
            FoundItem.ToolTipText = ParseLif(e.FullPath);
        }

        private void Resultwatcher_Created(object sender, FileSystemEventArgs e)
        {
            ListViewItem FoundItem = ChangeItemState(sender, e, 4);
            if (FoundItem == null){ return; }
            FoundItem.ToolTipText = ParseLif(e.FullPath);
        }

        private void Resultwatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            ListViewItem FoundItem = ChangeItemState(sender, e, 4);
            if (FoundItem == null) { return; }
            FoundItem.ToolTipText = "";
        }

        private string ParseLif(string File)
        {
            string ResultToolTip = "";
            string[] ResultText = new string[] { "" };
            try { ResultText = System.IO.File.ReadAllLines(File); } catch (IOException ex) {
                return "";
            }
            foreach(string Line in ResultText)
            {
                if (! (Line[0] == ','))
                {
                    continue;
                }
                var SplitLine = Line.Split(',');
                if(SplitLine.Length < 9)
                {
                    continue;
                }
                ResultToolTip += SplitLine[1] + "\t|" + SplitLine[2] + "\t|" + SplitLine[3] + "\t|" + SplitLine[4] + "\t|" + SplitLine[5] + "\t|" + SplitLine[8] + "\n";
            }
            return ResultToolTip;
        }

        private void HideEventByState(int State, bool Checked)
        {
            foreach(ListViewItem Item in RaceListView.Items)
            {
                if((int)Item.Tag == State)
                {
                    
                }
            }
        }

        private void PlanedRaceCheck_CheckedChanged(object sender, EventArgs e)
        {           
            HideEventByState(0, ((CheckBox)sender).Checked);
        }

        private void NewRaceSingle_CheckedChanged(object sender, EventArgs e)
        {
            //            MessageBox.Show("DEBUG: " + EventWatcher.Path + "; " + Resultwatcher.Path + "; " + Properties.Settings.Default.ActiveEventPath, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            HideEventByState(1, ((CheckBox)sender).Checked);
        }

        private void NewRaceMulti_CheckedChanged(object sender, EventArgs e)
        {
            HideEventByState(2, ((CheckBox)sender).Checked);
        }

        private void RaceNotJudgedCheck_CheckedChanged(object sender, EventArgs e)
        {
            HideEventByState(3, ((CheckBox)sender).Checked);
        }

        private void RaceJudged_CheckedChanged(object sender, EventArgs e)
        {
            HideEventByState(4, ((CheckBox)sender).Checked);
        }
    }
}

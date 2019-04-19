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
            EventWatcher.Created += EventWatcher_Changed;
            EventWatcher.Deleted += EventWatcher_Changed;
            Resultwatcher.Created += Resultwatcher_Changed;
            Resultwatcher.Deleted += Resultwatcher_Changed;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
//            MessageBox.Show("DEBUG: " + EventWatcher.Path + "; " + Resultwatcher.Path + "; " + Properties.Settings.Default.ActiveEventPath, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NewRaceMulti_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Changes the state of an Item or create it if it doesn't exist
        private ListViewItem ChangeItemState(string Name, int State, System.DateTime LastChangeTime)
        {
            string[] StateTexts = new string[] { "Geplant", "Neu (single User)", "Neu (Multi User)", "Nicht ausgewertet", "Ausgewertet" };
            Color[] StateColors = new Color[] { Color.White, Color.Yellow, Color.FromArgb(192, 0, 192), Color.FromArgb(192, 0, 0), Color.Lime };

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
            FileSystemWatcher ChangedObject = (FileSystemWatcher) sender;
            string FileName = e.Name.Split('.')[0];
            var LastChangeTime = System.IO.File.GetLastWriteTime(e.FullPath);
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:

                    if (e.FullPath.EndsWith(".evt"))
                    {
                        ChangeItemState(FileName, 1, LastChangeTime);
                    }

                    if (e.FullPath.EndsWith(".i01"))
                    {
                        ChangeItemState(FileName, 3, LastChangeTime);
                    }

                    break;

                case WatcherChangeTypes.Deleted:
                    if (e.FullPath.EndsWith(".evt"))
                    {
                        ChangeItemState(FileName, 0, LastChangeTime);
                    }

                    if (e.FullPath.EndsWith(".i01"))
                    {
                        ChangeItemState(FileName, 1, LastChangeTime);
                    }
                    break;

                case WatcherChangeTypes.Changed:
                    ChangeItemState(FileName, 1, LastChangeTime);
                    break;
                
                default:
                    break;
            }
        }

        private void Options_Click(object sender, EventArgs e)
        {
            var optionViewer = new OptionsView();
            optionViewer.ShowDialog();
        }

        private void Resultwatcher_Changed(object sender, FileSystemEventArgs e)
        {
            FileSystemWatcher ChangedObject = (FileSystemWatcher)sender;
            string FileName = e.Name.Split('.')[0];
            var LastChangeTime = System.IO.File.GetLastWriteTime(e.FullPath);
            int State = 5;
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
                    State = 4;
                    break;

                case WatcherChangeTypes.Changed:
                    State = 4;
                    break;

                case WatcherChangeTypes.Deleted:
                    State = 3;
                    break;

                default:
                    break;
            }
            ListViewItem FoundItem = ChangeItemState(FileName, State, LastChangeTime);
            if(FoundItem == null)
            {
                return;
            }
            if (State == 3)
            {
                FoundItem.ToolTipText = "";
                return;
            }
            FoundItem.ToolTipText = ParseLif(Path.Combine(ChangedObject.Path, e.Name));
            //Parse Results
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
    }
}

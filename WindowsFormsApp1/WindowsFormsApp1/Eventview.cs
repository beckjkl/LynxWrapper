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
            var selector = new EventSelector();
            selector.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewRaceMulti_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EventWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            FileSystemWatcher ChangedObject = (FileSystemWatcher) sender;
            string FileName = e.Name.Split('.')[0];
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
                    if (System.Text.RegularExpressions.Regex.IsMatch(e.FullPath, @".*\.evt"))
                    {
                        ListViewItem NewRace = new ListViewItem();
                        NewRace.Text = FileName;
                        NewRace.UseItemStyleForSubItems = false;
                        NewRace.Name = FileName;
                        NewRace.SubItems.Add("Neu (Single User)");
                        NewRace.SubItems.Add(System.IO.File.GetLastWriteTime(e.FullPath).ToShortDateString() + " " + System.IO.File.GetLastWriteTime(e.FullPath).ToShortTimeString());
                        NewRace.SubItems[1].BackColor = Color.Yellow;
                        RaceListView.Items.Add(NewRace);
                    }

                    if (System.Text.RegularExpressions.Regex.IsMatch(e.FullPath, @".*\.i01"))
                    {
                        ListViewItem ChangedRace_addi01 = RaceListView.Items.Find(FileName, false)[0];
                        ChangedRace_addi01.SubItems[1].Text = "Nicht ausgewertet";
                        ChangedRace_addi01.SubItems[1].BackColor = Color.FromArgb(192, 0, 0);
                        ChangedRace_addi01.SubItems[2].Text = System.IO.File.GetLastWriteTime(e.FullPath).ToShortDateString() +
                                                             " " + System.IO.File.GetLastWriteTime(e.FullPath)
                                                                 .ToShortTimeString();
                    }

                    break;

                case WatcherChangeTypes.Deleted:
                    if (System.Text.RegularExpressions.Regex.IsMatch(e.FullPath, @".*\.evt"))
                    {
                        ListViewItem ChangedRace_rmevt = RaceListView.Items.Find(FileName, false)[0];
                        ChangedRace_rmevt.Remove();
                    }

                    if (System.Text.RegularExpressions.Regex.IsMatch(e.FullPath, @".*\.i01"))
                    {
                        ListViewItem ChangedRace_rmi01 = RaceListView.Items.Find(FileName, false)[0];
                        ChangedRace_rmi01.SubItems[1].Text = "Neu (Single User)";
                        ChangedRace_rmi01.SubItems[1].BackColor = Color.Yellow;
                        ChangedRace_rmi01.SubItems[2].Text = System.IO.File.GetLastWriteTime(e.FullPath).ToShortDateString() +
                                                       " " + System.IO.File.GetLastWriteTime(e.FullPath)
                                                           .ToShortTimeString();
                    }
                    break;

                case WatcherChangeTypes.Changed:
                    ListViewItem ChangedRace_ch = RaceListView.Items.Find(FileName, false)[0];
                    ChangedRace_ch.SubItems[2].Text = System.IO.File.GetLastWriteTime(e.FullPath).ToShortDateString() +
                                                   " " + System.IO.File.GetLastWriteTime(e.FullPath)
                                                       .ToShortTimeString();

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
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
                    ListViewItem ChangedRace_addlif = RaceListView.Items.Find(FileName, false)[0];
                    ChangedRace_addlif.SubItems[1].Text = "Ausgewertet";
                    ChangedRace_addlif.SubItems[1].BackColor = Color.Lime;
                    ChangedRace_addlif.SubItems[2].Text = System.IO.File.GetLastWriteTime(e.FullPath).ToShortDateString() +
                                                         " " + System.IO.File.GetLastWriteTime(e.FullPath)
                                                             .ToShortTimeString();
                    break;

                case WatcherChangeTypes.Changed:
                    ListViewItem ChangedRace_chlif = RaceListView.Items.Find(FileName, false)[0];
                    ChangedRace_chlif.SubItems[2].Text = System.IO.File.GetLastWriteTime(e.FullPath).ToShortDateString() +
                                                         " " + System.IO.File.GetLastWriteTime(e.FullPath)
                                                             .ToShortTimeString();
                    break;
                case WatcherChangeTypes.Deleted:
                    ListViewItem ChangedRace_rmlif = RaceListView.Items.Find(FileName, false)[0];
                    ChangedRace_rmlif.SubItems[1].Text = "Nicht ausgewertet";
                    ChangedRace_rmlif.SubItems[1].BackColor = Color.FromArgb(192, 0, 0);
                    ChangedRace_rmlif.SubItems[2].Text = System.IO.File.GetLastWriteTime(e.FullPath).ToShortDateString() +
                                                          " " + System.IO.File.GetLastWriteTime(e.FullPath)
                                                              .ToShortTimeString();
                    break;

                default:
                    break;
            }
            //Parse Results
        }
    }
}

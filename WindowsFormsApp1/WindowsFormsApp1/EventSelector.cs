using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class EventSelector : Form
    {
        public EventSelector()
        {
            InitializeComponent();
        }

        private void EventSelector_Load(object sender, EventArgs e)
        {
            
            Settings.Default.Eventpath = Settings.Default.EventBasePath;
            Settings.Default.EventName = "Unbekannt";

            Settings.Default.ExistingEventPath = "";
            if(System.IO.Directory.Exists(Settings.Default.EventBasePath))
            {
                var EventList = System.IO.Directory.GetDirectories(Settings.Default.EventBasePath);
                foreach (var Event in EventList)
                {
                    var EventCreation = System.IO.Directory.GetCreationTime(Event);
                    if (EventCreation.Day == DateTime.Today.Day && EventCreation.Month == DateTime.Today.Month && EventCreation.Year == DateTime.Today.Year)
                    {
                        Settings.Default.ExistingEventPath = Event;
                    }
                }
            }

            string[] TempalteStrings = {"{Tag}", "{Monat}", "{Jahr}"};
            string[] TemplateReplace =
                {DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString()};
            Settings.Default.DateSetTemplate = Settings.Default.EventPathTemplate;
            for (int i = 0; i < TempalteStrings.Count(); i++)
            {
                Settings.Default.DateSetTemplate = Settings.Default.DateSetTemplate.Replace(TempalteStrings[i], TemplateReplace[i]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrowsePath.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BrowsePath.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Settings.Default.ExistingEventPath = BrowsePath.SelectedPath;
        }

        private void BrowseBasePath_HelpRequest(object sender, EventArgs e)
        {

        }

        private void SelectNewEventPath_Click(object sender, EventArgs e)
        {
            if (BrowsePath.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Settings.Default.Eventpath = BrowsePath.SelectedPath;
            Settings.Default.FullEventPath = Path.Combine(Settings.Default.Eventpath, Settings.Default.DateSetTemplate.Replace("{Eventname}", EventNameBox.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox ChangedBox = (TextBox) sender;
            Settings.Default.EventName = ChangedBox.Text;
            Settings.Default.FullEventPath = Path.Combine(Settings.Default.Eventpath, Settings.Default.DateSetTemplate.Replace("{Eventname}", ChangedBox.Text));
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (SelectNewEvent.Checked)
            {
                Settings.Default.ActiveEventPath = Settings.Default.FullEventPath;

                try{ System.IO.Directory.CreateDirectory(Settings.Default.ActiveEventPath);} catch (ArgumentException ex) { }
            } 
            if (SelectExistingEvent.Checked)
            {
                Settings.Default.ActiveEventPath = Settings.Default.ExistingEventPath;
                try { System.IO.Directory.CreateDirectory(Settings.Default.ActiveEventPath); }catch(ArgumentException ex) { }
            }
            if (SelectNoEvent.Checked)
            {
                Settings.Default.ActiveEventPath = "";
                this.Close();
            }

            if (Settings.Default.SetLynxSettings)
            {
                var RegUser = Microsoft.Win32.Registry.Users;
                Microsoft.Win32.RegistryKey LynxKey = null;
               
                foreach(var UserSubKey in RegUser.GetSubKeyNames()){
                    try { var SubKey = RegUser.OpenSubKey(UserSubKey); } catch(System.Security.SecurityException ex) { continue; }
                    LynxKey = RegUser.OpenSubKey(UserSubKey+ @"\Software\Lynx System Developers, Inc.\FinishLynx");
                    if (LynxKey != null) {
                        break;
                    }
                }
                if (LynxKey == null)
                {
                    MessageBox.Show("Lynx-Installation konnte nicht gefunden werden. Konfiguraton konnte nicht angepasst werden.", "Fehler: Lynx-Installation nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var LynxVersions = LynxKey.GetSubKeyNames();
                string LynxPath = "";
                foreach (var LynxVersion in LynxVersions)
                {
                    if (!LynxVersion.Equals(Settings.Default.SelectedLynxVersion))
                    {
                        continue;
                    }
                    var VersionSubkey = LynxKey.OpenSubKey(LynxVersion);
                    LynxPath = (string) VersionSubkey.GetValue("Install_Dir");
                }
                var LynxSplit = LynxPath.Split('\\');
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    @"VirtualStore\Program Files", LynxSplit[LynxSplit.Count() - 1], @"Lynx.cfg");
                try { System.IO.File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"VirtualStore\Program Files", LynxSplit[LynxSplit.Count() - 1], @"Lynx.cfg"), Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"VirtualStore\Program Files", LynxSplit[LynxSplit.Count() - 1], @"Lynxbak.cfg"),true); }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Lynx-Konfiguration konnte nicht gefunden Werden. Datei "+ Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+@"\VirtualStore\Program Files\" + LynxSplit[LynxSplit.Count() - 1] + @"\Lynx.cfg nicht gefunden", "Fehler: Lynx-Konfiguration nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var ReadConfig = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"VirtualStore\Program Files", LynxSplit[LynxSplit.Count() - 1], @"Lynx.cfg"));
                string[] ReplaceLines = new string[] 
                {
                    @"(\\Competition\\Name:String,1=)(.*)",
                    @"(\\Event\\Directory:String,1=)(.*)",
                    @"(\\Event\\BackupDir:String,1=)(.*)",
                    @"(\\Database\\File\\DataInDir:String,1=)(.*)",
                    @"(\\Database\\File\\DataOutDir:String,1=)(.*)"
                };
                string[] Replacements = new string[]
                {
                    "$1" + Settings.Default.EventName,
                    "$1" + Settings.Default.ActiveEventPath,
                    "$1" + Settings.Default.BackupPath,
                    "$1" + Settings.Default.SeltecPath,
                    "$1" + Settings.Default.ResultPath
                };

                for (int i = 0; i < ReplaceLines.Count(); i++)
                {
                    ReadConfig = System.Text.RegularExpressions.Regex.Replace(ReadConfig, ReplaceLines[i], Replacements[i]);
                }
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"VirtualStore\Program Files", LynxSplit[LynxSplit.Count() - 1], @"Lynx.cfg"), ReadConfig);
                
            }

            if (Settings.Default.StartLynx)
            {
                var RegUser = Microsoft.Win32.Registry.Users;
                Microsoft.Win32.RegistryKey LynxKey = null;

                foreach (var UserSubKey in RegUser.GetSubKeyNames())
                {
                    try { var SubKey = RegUser.OpenSubKey(UserSubKey); } catch (System.Security.SecurityException ex) { continue; }
                    LynxKey = RegUser.OpenSubKey(UserSubKey + @"\Software\Lynx System Developers, Inc.\FinishLynx");
                    if (LynxKey != null)
                    {
                        break;
                    }
                }
                if (LynxKey == null)
                {
                    MessageBox.Show("Lynx-Installation konnte nicht gefunden werden. Konfiguraton konnte nicht angepasst werden.", "Fehler: Lynx-Installation nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var LynxVersions = LynxKey.GetSubKeyNames();
                string LynxPath = "";
                foreach (var LynxVersion in LynxVersions)
                {
                    if (!LynxVersion.Equals(Settings.Default.SelectedLynxVersion))
                    {
                        continue;
                    }
                    var VersionSubkey = LynxKey.OpenSubKey(LynxVersion);
                    LynxPath = (string)VersionSubkey.GetValue("Install_Dir");
                }

                System.Diagnostics.Process.Start(Path.Combine(LynxPath, "Lynx.exe"));
            }

            this.Close();
        }

        private void SelectNewEvent_CheckedChanged(object sender, EventArgs e)
        {
            EventNameBox.Enabled = SelectNewEvent.Checked;
            EventPathBox.Enabled = SelectNewEvent.Checked;
            EventFullPathBox.Enabled = SelectNewEvent.Checked;
            SelectNewEventPath.Enabled = SelectNewEvent.Checked;
        }

        private void SelectExistingEvent_CheckedChanged(object sender, EventArgs e)
        {
            SelectedEventBox.Enabled = SelectExistingEvent.Checked;
            SelectExistingEventPath.Enabled = SelectExistingEvent.Checked;
        }

        private void SelectNoEvent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventPathBox_TextChanged(object sender, EventArgs e)
        {
            TextBox ChangedObject = (TextBox) sender;
            Settings.Default.Eventpath = ChangedObject.Text;
            Settings.Default.FullEventPath = Path.Combine(Settings.Default.Eventpath, Settings.Default.DateSetTemplate.Replace("{Eventname}", EventNameBox.Text));
        }

        private void SelectedEventBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

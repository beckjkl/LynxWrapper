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
            Settings.Default.ExistingEventName = "";

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

            string[] TemplateStrings = {"{Tag}", "{Monat}", "{Jahr}"};
            string[] TemplateReplace =
                {DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Year.ToString()};
            Settings.Default.DateSetTemplate = Settings.Default.EventPathTemplate;
            for (int i = 0; i < TemplateStrings.Count(); i++)
            {
                Settings.Default.DateSetTemplate = Settings.Default.DateSetTemplate.Replace(TemplateStrings[i], TemplateReplace[i]);
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
            if (Settings.Default.SetBackupPath)
            {
                Settings.Default.BackupPath = Path.Combine(Settings.Default.BackupBasePath, Settings.Default.DateSetTemplate.Replace("{Eventname}", EventNameBox.Text));
                return;
            }
            Settings.Default.BackupPath = Settings.Default.FullEventPath;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox ChangedBox = (TextBox) sender;
            Settings.Default.EventName = ChangedBox.Text;
            Settings.Default.FullEventPath = Path.Combine(Settings.Default.Eventpath, Settings.Default.DateSetTemplate.Replace("{Eventname}", ChangedBox.Text));
            if (Settings.Default.SetBackupPath)
            {
                Settings.Default.BackupPath = Path.Combine(Settings.Default.BackupBasePath, Settings.Default.DateSetTemplate.Replace("{Eventname}", EventNameBox.Text));
                return;
            }
            Settings.Default.BackupPath = Settings.Default.FullEventPath;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (SelectNewEvent.Checked)
            {
                if (!System.IO.Path.IsPathRooted(Settings.Default.FullEventPath))
                {
                    MessageBox.Show("Basispfad is kein valider Pfad. Bitte anpassen.", "Fehler: Ungültiger Basispfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (System.IO.Directory.Exists(Settings.Default.FullEventPath))
                {
                    MessageBox.Show("Event existiert bereits. Bitte anderes Event auswählen oder \"Bestehendes Event öffnen\" benutzen", "Fehler: Event existiert bereits", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Settings.Default.ActiveEventPath = Settings.Default.FullEventPath;
                System.IO.Directory.CreateDirectory(Settings.Default.ActiveEventPath);
            } 

            if (SelectExistingEvent.Checked)
            {
                if (Settings.Default.ExistingEventName.Equals(""))
                {
                    MessageBox.Show("Name des bestehenden Events konnte nicht erkannt werden. Bitte ergänzen.", "Fehler: Eventname nicht erkannt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!System.IO.Path.IsPathRooted(Settings.Default.ExistingEventPath))
                {
                    MessageBox.Show("Der Pfad zum bestehenden Event is kein valider Pfad. Bitte korrigieren.", "Fehler: Ungültiger Pfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!System.IO.Directory.Exists(Settings.Default.ExistingEventPath))
                {
                    MessageBox.Show("Der Ordner des bestehenden Event existiert nicht. Bitte einen existierenden Ordner auswählen oder \"Neues Event anlegen\" benutzen.", "Fehler: Eventname nicht erkannt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Settings.Default.ActiveEventPath = Settings.Default.ExistingEventPath;
            }
            if (SelectNoEvent.Checked)
            {
                Settings.Default.ActiveEventPath = "";
                this.Close();
            }

            if (!Settings.Default.ChangeResultPath)
            {
                Settings.Default.ResultPath = Settings.Default.ActiveEventPath;
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
                string ConfigPath = Path.Combine(LynxPath, "Lynx.cfg");
                if (!System.IO.File.Exists(ConfigPath) || (System.IO.File.Exists(ConfigPath) && new System.IO.FileInfo(ConfigPath).Length < (long)1024))
                {
                    var LynxSplit = LynxPath.Split('\\');
                    ConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"VirtualStore\Program Files", LynxSplit[LynxSplit.Count() - 1], @"Lynx.cfg");
                    if (!System.IO.File.Exists(ConfigPath))
                    {
                        MessageBox.Show("Lynx-Konfiguration konnte nicht gefunden werden und wird nicht angepasst.", "Fehler: Lynx-Konfiguration nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                System.IO.File.Copy(ConfigPath, ConfigPath.Replace("Lynx.cfg", "Lynxbak.cfg"), true);
                var ReadConfig = File.ReadAllText(ConfigPath);
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
                File.WriteAllText(ConfigPath, ReadConfig);
                
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
            if (Settings.Default.SetBackupPath)
            {
                Settings.Default.BackupPath = Path.Combine(Settings.Default.BackupBasePath, Settings.Default.DateSetTemplate.Replace("{Eventname}", EventNameBox.Text));
                return;
            }
            Settings.Default.BackupPath = Settings.Default.FullEventPath;
        }

        private void SelectedEventBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

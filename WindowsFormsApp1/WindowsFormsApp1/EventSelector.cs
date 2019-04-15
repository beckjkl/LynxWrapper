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

            Settings.Default.ExistingEventPath = "";
            try
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
            catch(ArgumentException ex)
            {

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

            Settings.Default.ExistingEventPath = BrowsePath.SelectedPath.ToString();
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

            Settings.Default.Eventpath=BrowsePath.SelectedPath.ToString();
            Settings.Default.FullEventPath = Path.Combine(Settings.Default.Eventpath, Settings.Default.EventName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.EventName=EventNameBox.Text;
            Settings.Default.FullEventPath = Path.Combine(Settings.Default.Eventpath, Settings.Default.EventName);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (SelectNewEvent.Enabled)
            {
                Settings.Default.ActiveEventPath = Settings.Default.FullEventPath;

                try{ System.IO.Directory.CreateDirectory(Settings.Default.ActiveEventPath);} catch (ArgumentException ex) { }
            } 
            if (SelectExistingEvent.Enabled)
            {
                Settings.Default.ActiveEventPath = Settings.Default.ExistingEventPath;
                try { System.IO.Directory.CreateDirectory(Settings.Default.ActiveEventPath); }catch(ArgumentException ex) { }
            }
            if (SelectNoEvent.Enabled)
            {
                Settings.Default.ActiveEventPath = "";
            }

            if (Settings.Default.SetLynxSettings)
            {
                var RegUser = Microsoft.Win32.Registry.Users;
                Microsoft.Win32.RegistryKey LynxKey = null;
               
                foreach(var UserSubKey in RegUser.GetSubKeyNames()){
                    try { var SubKey = RegUser.OpenSubKey(UserSubKey); } catch(System.Security.SecurityException ex) { continue; }
                    LynxKey = RegUser.OpenSubKey(UserSubKey+ "\\Software\\Lynx System Developers, Inc.\\FinishLynx");
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
                String LynxPath = "";
                foreach (var LynxVersion in LynxVersions)
                {
                    if (!LynxVersion.Equals(Settings.Default.SelectedLynxVersion))
                    {
                        continue;
                    }
                    var VersionSubkey = LynxKey.OpenSubKey(LynxVersion);
                    LynxPath = (String) VersionSubkey.GetValue("Install_Dir");
                }
                var LynxSplit = LynxPath.Split('\\');
                try { System.IO.File.Copy("%appdata%\\Local\\VirtualStore\\Program Files\\" + LynxSplit[LynxSplit.Count() - 1] + "\\Lynx.cfg", "%appdata%\\Local\\VirtualStore\\Program Files\\" + LynxSplit[LynxSplit.Count() - 1] + "\\Lynxbak.cfg"); }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Lynx-Konfiguration konnte nicht gefunden Werden. Datei %appdata%\\Local\\VirtualStore\\Program Files\\" + LynxSplit[LynxSplit.Count() - 1] + "\\Lynx.cfg nicht gefunden", "Fehler: Lynx-Konfiguration nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var ReadConfig = File.ReadAllText("%appdata%\\Local\\VirtualStore\\Program Files\\" + LynxSplit[LynxSplit.Count() - 1] + "\\Lynx.cfg");
                String[] ReplaceLines = new String[] 
                {
                    "(\\\\Competition\\\\Name:String,1=)(.*)",
                    "(\\\\Event\\\\Directory:String,1=)(.*)",
                    "(\\\\Event\\\\BackupDir:String,1=)(.*)",
                    "(\\\\Database\\\\File\\\\DataInDir:String,1=)(.*)",
                    "(\\\\Database\\\\File\\\\DataOutDir:String,1=)(.*)"
                };
                String[] Replacements = new String[]
                {
                    "$1" + Settings.Default.EventName,
                    "$1" + Settings.Default.ActiveEventPath,
                    "$1" + "$2", //Not yet Implemented in Settings
                    "$1" + Settings.Default.SeltecPath,
                    "$1" + Settings.Default.ResultPath
                };
                
                
                
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
    }
}

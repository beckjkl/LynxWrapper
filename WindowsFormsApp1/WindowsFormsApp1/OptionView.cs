using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class OptionsView : Form
    {
        public OptionsView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox SenderBox = (TextBox)sender;
            if (!Settings.Default.TempChangeResultPath)
            {
                Settings.Default.TempResultPath = SenderBox.Text;
            }
        }

        private void SelectBasePath_Click(object sender, EventArgs e)
        {
            if (BrowsePath.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Settings.Default.TempEventBasePath = BrowsePath.SelectedPath.ToString();
        }

        private void TestTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ResultPathBox.Enabled = ChangeResultPathCheck.Checked;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OptionsView_Load(object sender, EventArgs e)
        {
            Settings.Default.TempEventBasePath = Settings.Default.EventBasePath;
            Settings.Default.TempEventPathTemplate = Settings.Default.EventPathTemplate;
            Settings.Default.TempSeltecPath = Settings.Default.SeltecPath;
            Settings.Default.TempActivateSeltecRead = Settings.Default.ActivateSeltecRead;
            Settings.Default.TempResultPath = Settings.Default.ResultPath;
            Settings.Default.TempChangeResultPath = Settings.Default.ChangeResultPath;
            Settings.Default.TempSetLynxSettings = Settings.Default.SetLynxSettings;
            Settings.Default.TempStartLynx = Settings.Default.StartLynx;
            Settings.Default.TempIsValidnameTemplate = Settings.Default.IsValidNameTemplate;
            InvalidTemplateSign.Visible = !Settings.Default.TempIsValidnameTemplate;
            Settings.Default.InitialSettingsDone = true;

            var RegUser = Microsoft.Win32.Registry.Users;
            Microsoft.Win32.RegistryKey LynxKey = null;
            foreach (var UserSubKey in RegUser.GetSubKeyNames())
            {
                try { var SubKey = RegUser.OpenSubKey(UserSubKey); } catch (System.Security.SecurityException ex) { continue; }
                LynxKey = RegUser.OpenSubKey(UserSubKey + "\\Software\\Lynx System Developers, Inc.\\FinishLynx");
                if (LynxKey != null)
                {
                    break;
                }
            }
            if (LynxKey == null)
            {
                MessageBox.Show("Lynx-Installation konnte nicht gefunden werden. Bitte erst FinishLynx installieren!", "Fehler: Invalider Basispfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var LynxVersions = LynxKey.GetSubKeyNames();
            foreach(var LynxVersion in LynxVersions)
            {
                LynxVersionBox.Items.Add(LynxVersion);
            }
            if (Settings.Default.SelectedLynxVersion == "")
            {
                Settings.Default.SelectedLynxVersion = LynxVersionBox.Items[LynxVersionBox.Items.Count - 1].ToString();
            }
            foreach(var Item in LynxVersionBox.Items)
            {
                if (Item.ToString().Equals(Settings.Default.SelectedLynxVersion))
                {
                    LynxVersionBox.SelectedIndex = LynxVersionBox.Items.IndexOf(Item);
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!System.IO.Path.IsPathRooted(Settings.Default.TempEventBasePath))
            {
                MessageBox.Show("Basisordner ist kein valider Pfad. Bitte korrigieren", "Fehler: Invalider Basispfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Settings.Default.TempIsValidnameTemplate)
            {
                MessageBox.Show("Namensvorlage kann nicht verarbeitet werden. Bitte korrigieren", "Fehler: Invalide Namesvorlage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  

            if (!System.IO.Path.IsPathRooted(Settings.Default.TempSeltecPath))
            {
                MessageBox.Show("Pfad zur Seltec-Laufvorlage ist kein valider Pfad. Bitte korrigieren", "Fehler: Invalide Laufvorlagen-Pfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Settings.Default.TempChangeResultPath && !System.IO.Path.IsPathRooted(Settings.Default.TempResultPath))
            {
                MessageBox.Show("Pfad für Ergebnisse ist kein valider Pfad. Bitte korrigieren", "Fehler: Invalide Ergebnispfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{System.IO.Directory.CreateDirectory(Settings.Default.TempEventBasePath);} catch (ArgumentException) { }
            try{System.IO.Directory.CreateDirectory(Settings.Default.TempSeltecPath);}catch (ArgumentException) { }
            try{System.IO.Directory.CreateDirectory(Settings.Default.TempSeltecPath);}catch (ArgumentException) { }

            Settings.Default.EventBasePath = Settings.Default.TempEventBasePath;
            Settings.Default.EventPathTemplate = Settings.Default.TempEventPathTemplate;
            Settings.Default.IsValidNameTemplate = Settings.Default.TempIsValidnameTemplate;
            Settings.Default.SeltecPath = Settings.Default.TempSeltecPath;
            Settings.Default.ActivateSeltecRead = Settings.Default.TempActivateSeltecRead;
            Settings.Default.SeltecPath = Settings.Default.TempSeltecPath;
            Settings.Default.ResultPath = Settings.Default.TempResultPath;
            Settings.Default.ChangeResultPath = Settings.Default.TempChangeResultPath;
            Settings.Default.SetLynxSettings = Settings.Default.TempSetLynxSettings;
            Settings.Default.StartLynx = Settings.Default.TempStartLynx;

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TemplatePathBox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderbox = (TextBox)sender;
            String TempalteRegex = "^((\\w|\\s)*(\\{(Jahr|Tag|Monat|Eventname)\\})?\\\\?)*$";
            Settings.Default.TempIsValidnameTemplate = System.Text.RegularExpressions.Regex.IsMatch(senderbox.Text, TempalteRegex);
            InvalidTemplateSign.Visible = !Settings.Default.TempIsValidnameTemplate;
            InvalidTemplateSign.Refresh();
        }

        private void SelectSeltecPathButton_Click(object sender, EventArgs e)
        {
            if (BrowsePath.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Settings.Default.TempSeltecPath = BrowsePath.SelectedPath.ToString();
        }

        private void SelectResultPathButton_Click(object sender, EventArgs e)
        {
            if (BrowsePath.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Settings.Default.TempResultPath = BrowsePath.SelectedPath.ToString();
        }
    }
}

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

        }

        private void SelectBasePath_Click(object sender, EventArgs e)
        {

        }

        private void TestTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
        }
    }
}

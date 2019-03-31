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
    }
}

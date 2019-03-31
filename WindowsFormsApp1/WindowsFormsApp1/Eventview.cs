using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        }

        private void Options_Click(object sender, EventArgs e)
        {
            var optionViewer = new OptionView();
            optionViewer.ShowDialog();
        }
    }
}

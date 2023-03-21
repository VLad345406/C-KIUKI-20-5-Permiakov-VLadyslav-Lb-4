using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class EditTrack : Form
    {
        internal String trackName = String.Empty;
        internal DateTime trackLenth;

        internal EditTrack(String trackName, DateTime trackLenth)
        {
            InitializeComponent();
            textBoxTrackName.Text = trackName;
            timePickerTrackLenth.Value = trackLenth;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            trackName = textBoxTrackName.Text;
            trackLenth = timePickerTrackLenth.Value;
            this.Close();
        }
    }
}

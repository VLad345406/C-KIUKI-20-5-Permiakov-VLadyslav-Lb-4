using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_Lb4
{
    public partial class RemoveTrack : Form
    {
        List<Artist> artists = new List<Artist>();
        Functions functions = new Functions();
        internal RemoveTrack(List<Artist> mainArtists)
        {
            InitializeComponent();

            artists = mainArtists;
            functions.addInfoToComboBox(comboBoxAuthor, artists);
        }

        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (artists[comboBoxAuthor.SelectedIndex].albums.Count == 0)
                MessageBox.Show("В цього виконвця відсутні альбоми!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                comboBoxAlbumName.Items.Clear();
                comboBoxAlbumName.Text = String.Empty;
                comboBoxTrackName.Items.Clear();
                comboBoxTrackName.Text = String.Empty;
                for (int i = 0; i < artists[comboBoxAuthor.SelectedIndex].albums.Count; i++)
                    comboBoxAlbumName.Items.Add(artists[comboBoxAuthor.SelectedIndex].albums[i].albumName);
            }
        }

        private void comboBoxAlbumName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTrackName.Items.Clear();
            comboBoxTrackName.Text = String.Empty;
            for (int i = 0; i < artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks.Count; i++)
                comboBoxTrackName.Items.Add(artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks[i].trackName);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (comboBoxAuthor.Text == String.Empty || comboBoxAlbumName.Text == String.Empty || comboBoxTrackName.Text == String.Empty)
                MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цей трек?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    if (artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks.Count == 1)
                        artists[comboBoxAuthor.SelectedIndex].albums.RemoveAt(comboBoxAlbumName.SelectedIndex);
                    else
                        artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks.RemoveAt(comboBoxTrackName.SelectedIndex);
                    this.Close();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class RemoveTrack : Form
    {
        List<Artist> artists = new List<Artist>();
        Functions functions = new Functions();
        internal RemoveTrack(List<Artist> mainArtists, String title, bool showAlbumName, bool showTrackName)
        {
            InitializeComponent();

            label2.Visible = showAlbumName;
            comboBoxAlbumName.Visible = showAlbumName;
            label3.Visible = showTrackName;
            comboBoxTrackName.Visible = showTrackName;

            this.Text = title;

            artists = mainArtists;
            functions.addInfoToComboBox(comboBoxAuthor, artists);
        }

        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (artists[comboBoxAuthor.SelectedIndex].albums.Count == 0 && comboBoxAlbumName.Visible == true)
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
            if (this.Text == "Remove Track" || this.Text == "Edit Track")
            {
                if (comboBoxAuthor.Text == String.Empty || comboBoxAlbumName.Text == String.Empty || comboBoxTrackName.Text == String.Empty)
                    MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (this.Text == "Remove Track")
                    {
                        DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цей трек?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mb == DialogResult.Yes)
                        {
                            if (artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks.Count == 1)
                                artists[comboBoxAuthor.SelectedIndex].albums.RemoveAt(comboBoxAlbumName.SelectedIndex);
                            else
                            {
                                artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks.RemoveAt(comboBoxTrackName.SelectedIndex);
                                artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].countTracks--;
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        EditTrack editTrack = new EditTrack(artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks[comboBoxTrackName.SelectedIndex].trackName,
                            artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks[comboBoxTrackName.SelectedIndex].trackLenth);
                        this.Hide();
                        editTrack.ShowDialog();
                        if (editTrack.trackName == String.Empty)
                        {
                            DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цей трек?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (mb == DialogResult.Yes)
                            {
                                if (artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks.Count == 1)
                                    artists[comboBoxAuthor.SelectedIndex].albums.RemoveAt(comboBoxAlbumName.SelectedIndex);
                                else
                                {
                                    artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks.RemoveAt(comboBoxTrackName.SelectedIndex);
                                    artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].countTracks--;
                                }
                            }
                        }
                        else
                        {
                            artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks[comboBoxTrackName.SelectedIndex].trackName = editTrack.trackName;
                            artists[comboBoxAuthor.SelectedIndex].albums[comboBoxAlbumName.SelectedIndex].tracks[comboBoxTrackName.SelectedIndex].trackLenth = editTrack.trackLenth;
                        }
                        this.Close();
                    }
                }
            }

            else if (this.Text == "Remove Album")
            {
                if (comboBoxAuthor.Text == String.Empty || comboBoxAlbumName.Text == String.Empty)
                    MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цей альбом?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mb == DialogResult.Yes)
                    {
                        artists[comboBoxAuthor.SelectedIndex].albums.RemoveAt(comboBoxAlbumName.SelectedIndex);
                        this.Close();
                    }
                }
            }

            else
            {
                if (comboBoxAuthor.Text == String.Empty)
                    MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цього виконавця?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mb == DialogResult.Yes)
                    {
                        artists.RemoveAt(comboBoxAuthor.SelectedIndex);
                        this.Close();
                    }
                }
            }
        }
    }
}

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
    public partial class AlbumAdd : Form
    {
        internal Album album = new Album();
        internal String artistName = string.Empty;
        bool artistSaved = false;
        List <Artist> artistList;
        internal AlbumAdd(List<Artist> mainArtistList)
        {
            InitializeComponent();
            dataGridViewAdd1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdd1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            artistList = mainArtistList;
            Functions functions = new Functions();
            functions.addInfoToComboBox(comboBoxAuthor, artistList);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            if (comboBoxAuthor.Text == String.Empty && artistName == String.Empty)
                MessageBox.Show("Введіть ім'я автора!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBoxAlbumName.Text == String.Empty)
                MessageBox.Show("Введіть назву альбома!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (functions.checkAlbumRepeat(textBoxAlbumName.Text, artistName, artistList))
                MessageBox.Show("В цього виконавця вже існує алюбом с такою назвою!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numericUpDownCountTracks.Value == 0)
                MessageBox.Show("Кількість треків не може бути нульовою!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            { 
                if (!artistSaved)
                {
                    bool somethingCheck = false;
                    foreach (CheckBox c in groupBoxGenres.Controls.OfType<CheckBox>())
                    {
                        if (c.Checked)
                        {
                            somethingCheck = true;
                            break;
                        }
                    }
                    if (!somethingCheck)
                        MessageBox.Show("Оберіть жанр!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        artistName = comboBoxAuthor.Text;
                        album.albumName = textBoxAlbumName.Text;
                        album.year = dateTimePickerYear.Value.Year;
                        album.countTracks = ((int)numericUpDownCountTracks.Value);
                        foreach (CheckBox c in groupBoxGenres.Controls.OfType<CheckBox>())
                        {
                            if (c.Checked)
                                album.genres.Add(c.Text);
                        }
                        artistSaved = true;
                    }
                }
                if (artistSaved)
                {
                    if (textBoxTrackName.Text == String.Empty)
                        MessageBox.Show("Введіть назву треку", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (timePickerTrackLenth.Value.Minute == 0 && timePickerTrackLenth.Value.Second == 0)
                        MessageBox.Show("Введіть довжину треку", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //add to song array
                    else
                    {
                        //check on repeat
                        if (functions.checkTrackRepeat(textBoxTrackName.Text, album.tracks))
                            MessageBox.Show("Такий трек вже збережений!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            Track newTrack = new Track();
                            newTrack.trackName = textBoxTrackName.Text;
                            newTrack.trackLenth = timePickerTrackLenth.Value;

                            album.tracks.Add(newTrack);
                            dataGridViewAdd1.Rows.Add(album.tracks.Count, newTrack.trackName, newTrack.trackLenth.TimeOfDay);
                            comboBoxAuthor.Enabled = false;
                            textBoxAlbumName.Enabled = false;
                            dateTimePickerYear.Enabled = false;
                            numericUpDownCountTracks.Enabled = false;
                            groupBoxGenres.Enabled = false;
                            textBoxTrackName.Text = String.Empty;
                            timePickerTrackLenth.Value = new DateTime(2001, 10, 20);

                            //this.Controls.IndexOf(textBoxTrackName);

                            if (album.tracks.Count == album.countTracks)
                                buttonAdd.Enabled = false;
                        }
                    }
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (comboBoxAuthor.Text == String.Empty && comboBoxAuthor.Enabled == true)
                this.Close();
            else if (album.tracks.Count != album.countTracks)
            {
                DialogResult mb = MessageBox.Show("Ви точно бажаете зберегти не повністю заповнений альбом?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (mb == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }
    }
}

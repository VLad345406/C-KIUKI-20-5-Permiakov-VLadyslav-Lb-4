﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CSharp_Lb4
{
    public partial class SongsLibrary : Form
    {
        internal List<Artist> artists;

        Functions functions = new Functions();

        //initialize main form
        public SongsLibrary()
        {
            InitializeComponent();
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            artists = functions.readData();
            functions.updateDataGridView(dataGridView1, artists);
            functions.updateComboBoxAuthors(comboBoxAuthors, artists);
        }

        //start AlbumAdd form
        private void addAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlbumAdd albumAdd = new AlbumAdd(artists);

            albumAdd.ShowDialog();
            
            int indexArtist = functions.findArtist(albumAdd.artistName, artists);
            if (indexArtist == -1 && albumAdd.artistName != String.Empty)
            {
                Artist newArtist = new Artist();
                newArtist.artistName = albumAdd.artistName;
                newArtist.albums.Add(albumAdd.album);
                artists.Add(newArtist);
                indexArtist = artists.Count - 1;
            }
            else if (indexArtist != -1 && albumAdd.artistName != String.Empty)
                artists[indexArtist].albums.Add(albumAdd.album);
            functions.updateDataGridView(dataGridView1, artists);
            functions.updateComboBoxAuthors(comboBoxAuthors, artists);
        }

        //start RemoveTrack form special for remove track
        private void removeTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (artists.Count == 0)
                MessageBox.Show("В програмі відсутні записи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RemoveTrack removeTrack = new RemoveTrack(artists, "Remove Track", true, true);
                removeTrack.ShowDialog();
                functions.updateDataGridView(dataGridView1, artists);
            }
        }

        //start RemoveTrack form special for edit track
        private void editTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (artists.Count == 0)
                MessageBox.Show("В програмі відсутні записи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RemoveTrack removeTrack = new RemoveTrack(artists, "Edit Track", true, true);
                removeTrack.ShowDialog();
                functions.updateDataGridView(dataGridView1, artists);
            }
        }

        //start RemoveTrack form special for delete album
        private void deleteAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (artists.Count == 0)
                MessageBox.Show("В програмі відсутні записи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RemoveTrack removeTrack = new RemoveTrack(artists, "Remove Album", true, false);
                removeTrack.ShowDialog();
                functions.updateDataGridView(dataGridView1, artists);
            }
        }

        //start RemoveTrack form special for remove executor
        private void removeExecutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (artists.Count == 0)
                MessageBox.Show("В програмі відсутні записи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RemoveTrack removeTrack = new RemoveTrack(artists, "Remove Executor", false, false);
                removeTrack.ShowDialog();
                functions.updateDataGridView(dataGridView1, artists);
            }
            functions.updateComboBoxAuthors(comboBoxAuthors, artists);
        }

        //make action when in comboBoxGenres change select item
        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAuthors.SelectedIndex = 0;
            functions.updateDataGridViewOfGenres(dataGridView1, artists, comboBoxGenres.Text);
        }
        
        //make action when in comboBoxAuthors change select item
        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGenres.SelectedIndex = 0;
            if (comboBoxAuthors.SelectedIndex == 0)
                functions.updateDataGridView(dataGridView1, artists);
            else
                functions.updateDataGridViewAuthors(dataGridView1, artists, comboBoxAuthors.Text);
        }

        //action, when user close program
        private void SongsLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви дійсно бажаєте завершити роботу?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                functions.saveData(artists);
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}

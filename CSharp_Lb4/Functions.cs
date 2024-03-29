﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    class Functions
    {
        //check album name repeat in necessary artist list
        public bool checkAlbumRepeat(string albumName, string artist, List<Artist> artists)
        {
            bool result = false;
            
            if (artists.Count > 0)
            {
                Artist findArtist = artists.Find(x => x.artistName.Equals(artist));
                if (findArtist != null)
                {
                    Album findAlbum = findArtist.albums.Find(x => x.albumName.Equals(albumName));
                    if (findAlbum != null)
                        result = true;
                }
            }

            return result;
        }

        //check track name repeat in necessary album list
        public bool checkTrackRepeat(string trackName, List<Track> listTracks)
        {
            bool result = false;

            if (listTracks.Count > 0)
            {
                Track findTrack = listTracks.Find(x => x.Equals(trackName));
                if (findTrack != null)
                    result = true;
            }
            return result;
        }

        //add artist name to combobox
        public void addInfoToComboBox(ComboBox comboBox, List<Artist> artists)
        {
            if (artists.Count > 0)
            {
                for (int i = 0; i < artists.Count; i++)
                    comboBox.Items.Add(artists[i].artistName);
            }
        }

        //find artist in array
        public int findArtist(string artistName, List<Artist> artists)
        {
            int result = -1;

            if (artists.Count > 0)
            {
                Artist findArtist = artists.Find(x => x.Equals(artistName));
                if (findArtist != null)
                    result = artists.FindIndex(x => x.Equals(artistName));
            }

            return result;
        }

        //show all albums and tracks
        public void updateDataGridView(DataGridView dataGridView, List<Artist> artists)
        {
            dataGridView.Rows.Clear();
            if (artists.Count > 0)
            {
                int count = 1;
                for (int i = 0; i < artists.Count; i++)
                {
                    for (int j = 0; j < artists[i].albums.Count; j++)
                    {
                        String genres = artists[i].albums[j].genres.Aggregate((current, next) => current + " " + next);

                        for (int k = 0; k < artists[i].albums[j].tracks.Count; k++)
                        {
                            dataGridView.Rows.Add(count, k + 1, artists[i].albums[j].tracks[k].trackName, artists[i].artistName, genres, artists[i].albums[j].albumName, artists[i].albums[j].tracks[k].trackLenth.TimeOfDay);
                            count++;
                        }
                        dataGridView.Rows.Add();
                    }
                }
            }
        }
        
        //find and show albums in necessary artist
        public void updateDataGridViewAuthors(DataGridView dataGridView, List<Artist> artists, String artist)
        {
            dataGridView.Rows.Clear();
            int count = 1;
            for (int i = 0; i < artists.Count; i++)
            {
                if (artists[i].artistName == artist)
                {
                    for (int j = 0; j < artists[i].albums.Count; j++)
                    {
                        String genres = artists[i].albums[j].genres.Aggregate((current, next) => current + " " + next);

                        for (int k = 0; k < artists[i].albums[j].tracks.Count; k++)
                        {
                            dataGridView.Rows.Add(count, k + 1, artists[i].albums[j].tracks[k].trackName, artists[i].artistName, genres, artists[i].albums[j].albumName, artists[i].albums[j].tracks[k].trackLenth.TimeOfDay);
                            count++;
                        }
                        dataGridView.Rows.Add();
                    }
                }
            }
        }

        //find and show albums in necessary genre
        public void updateDataGridViewOfGenres(DataGridView dataGridView, List<Artist> artists, String genre)
        {
            if (genre == String.Empty)
                updateDataGridView(dataGridView, artists);
            else
            {
                dataGridView.Rows.Clear();
                int count = 1;
                for (int i = 0; i < artists.Count; i++)
                {
                    for (int j = 0; j < artists[i].albums.Count; j++)
                    {
                        String findGenres = artists[i].albums[j].genres.Find(g => g.Equals(genre));

                        if (findGenres != null)
                        {
                            String genres = artists[i].albums[j].genres.Aggregate((current, next) => current + " " + next);

                            for (int k = 0; k < artists[i].albums[j].tracks.Count; k++)
                            {
                                dataGridView.Rows.Add(count, k + 1, artists[i].albums[j].tracks[k].trackName, artists[i].artistName, genres, artists[i].albums[j].albumName, artists[i].albums[j].tracks[k].trackLenth.TimeOfDay);
                                count++;
                            }
                            dataGridView.Rows.Add();
                        }
                    }
                }
            }
        }

        //update combobox item authors
        public void updateComboBoxAuthors(ComboBox comboBox, List<Artist> artists)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(String.Empty);
            for (int i = 0; i < artists.Count; i++)
                comboBox.Items.Add(artists[i].artistName);
        }

        //save data to file using json
        public void saveData(List<Artist> artists)
        {
            string objectSerialized = JsonSerializer.Serialize(artists);
            File.WriteAllText("data.json", objectSerialized);
        }

        //read data using json
        public List<Artist> readData()
        {
            List<Artist> artists = new List<Artist>();
            if (File.Exists("data.json"))
            {
                string objectJsonFile = File.ReadAllText("data.json");
                artists = JsonSerializer.Deserialize<List<Artist>>(objectJsonFile);
            }
            return artists;
        }
    }
}

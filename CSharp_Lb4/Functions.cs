using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    class Functions
    {
        public bool checkAlbumRepeat(string albumName, string artist, List<Artist> artists)
        {
            bool result = false;

            if (artists.Count > 0)
            {
                bool findArtist = false;
                int artistIndex = 0;

                for (int i = 0; i < artists.Count; i++)
                {
                    if (artists[i].artistName == artist)
                    {
                        findArtist = true;
                        artistIndex = i;
                        break;
                    }
                }

                if (findArtist)
                {
                    if (artists[artistIndex].albums.Count > 0)
                    {
                        for (int i = 0; i < artists[artistIndex].albums.Count; i++)
                        {
                            if (artists[artistIndex].albums[i].albumName == albumName)
                            {
                                result = true;
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }

        public bool checkTrackRepeat(string trackName, List<Track> listTracks)
        {
            bool result = false;

            if (listTracks.Count > 0)
            {
                for (int i = 0; i < listTracks.Count; i++)
                {
                    if (listTracks[i].trackName == trackName)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public void addInfoToComboBox(ComboBox comboBox, List<Artist> artists)
        {
            if (artists.Count > 0)
            {
                for (int i = 0; i < artists.Count; i++)
                    comboBox.Items.Add(artists[i].artistName);
            }
        }

        public int findArtist(string artistName, List<Artist> artists)
        {
            int result = -1;

            if (artists.Count > 0)
            {
                for (int i = 0; i < artists.Count; i++)
                {
                    if (artists[i].artistName == artistName)
                    {
                        result = i;
                        break;
                    }
                }
            }

            return result;
        }

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
                        String genres = String.Empty;
                        for (int k = 0; k < artists[i].albums[j].genres.Count; k++)
                            genres += artists[i].albums[j].genres[k] + " ";
                        for (int k = 0; k < artists[i].albums[j].tracks.Count; k++)
                        {
                            dataGridView.Rows.Add(count, k + 1, artists[i].albums[j].tracks[k].trackName, artists[i].artistName, genres, artists[i].albums[j].albumName);
                            count++;
                        }
                        dataGridView.Rows.Add();
                    }
                }
            }
        }
        
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
                        String genres = String.Empty;
                        for (int k = 0; k < artists[i].albums[j].genres.Count; k++)
                            genres += artists[i].albums[j].genres[k] + " ";
                        for (int k = 0; k < artists[i].albums[j].tracks.Count; k++)
                        {
                            dataGridView.Rows.Add(count, k + 1, artists[i].albums[j].tracks[k].trackName, artists[i].artistName, genres, artists[i].albums[j].albumName);
                            count++;
                        }
                        dataGridView.Rows.Add();
                    }
                }
            }
        }

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
                        bool findGenres = false;
                        for (int k = 0; k < artists[i].albums[j].genres.Count; k++)
                        {
                            if (artists[i].albums[j].genres[k] == genre)
                            {
                                findGenres = true;
                                break;
                            }
                        }
                        if (findGenres)
                        {
                            String genres = String.Empty;
                            for (int k = 0; k < artists[i].albums[j].genres.Count; k++)
                                genres += artists[i].albums[j].genres[k] + " ";

                            for (int k = 0; k < artists[i].albums[j].tracks.Count; k++)
                            {
                                dataGridView.Rows.Add(count, k + 1, artists[i].albums[j].tracks[k].trackName, artists[i].artistName, genres, artists[i].albums[j].albumName);
                                count++;
                            }
                            dataGridView.Rows.Add();
                        }
                    }
                }
            }
        }

        public void updateComboBoxAuthors(ComboBox comboBox, List<Artist> artists)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(String.Empty);
            for (int i = 0; i < artists.Count; i++)
                comboBox.Items.Add(artists[i].artistName);
        }

        public void saveData(List<Artist> artists)
        {
            string objectSerialized = JsonSerializer.Serialize(artists);
            File.WriteAllText("data.json", objectSerialized);
        }

        public List<Artist> readData()
        {
            string objectJsonFile = File.ReadAllText("data.json");
            List<Artist> artists = JsonSerializer.Deserialize<List<Artist>>(objectJsonFile);

            return artists;
        }
    }
}

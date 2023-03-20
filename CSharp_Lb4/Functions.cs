using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    }
                }
            }
        }
    }
}

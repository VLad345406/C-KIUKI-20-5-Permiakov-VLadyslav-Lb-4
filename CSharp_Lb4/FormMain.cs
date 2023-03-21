using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CSharp_Lb4
{
    public partial class SongsLibrary : Form
    {
        internal List<Artist> artists = new List<Artist>();

        Functions functions = new Functions();

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Times new roman", 50F, GraphicsUnit.Pixel);
            }
        }

        public SongsLibrary()
        {
            /*Form formGenres = new AddGenres(1);
            
            formGenres.ShowDialog();*/

            InitializeComponent();
            //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        
        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formGenres = new AddGenres();
            formGenres.ShowDialog();
            //List <String> getListGenres = formGenres.GetSetGenres;
        }

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
        }

        private void removeTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (artists.Count == 0)
                MessageBox.Show("В програмі відсутні записи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RemoveTrack removeTrack = new RemoveTrack(artists);
                removeTrack.ShowDialog();
                functions.updateDataGridView(dataGridView1, artists);
            }
        }
    }
}

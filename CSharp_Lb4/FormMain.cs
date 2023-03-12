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
    public partial class SongsLibrary : Form
    {
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
            Form formGenres = new AddGenres(1);
            
            formGenres.ShowDialog();

            InitializeComponent();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
    }
}

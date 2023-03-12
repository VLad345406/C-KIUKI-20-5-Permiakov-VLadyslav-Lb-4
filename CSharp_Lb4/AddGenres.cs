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
    public partial class AddGenres : Form
    {
        private List <String> genres = new List <String> ();
        private int _mode;
        public List <String> GetSetGenres
        {
            get { return genres; }
            set { genres = value; }
        }
        public AddGenres()
        {
            this.ControlBox = false;
            InitializeComponent();
        }
        public AddGenres(int mode)
        {
            _mode = mode;
            this.ControlBox = false;
            InitializeComponent();
        }

        private void buttonCompleteAdd_Click(object sender, EventArgs e)
        {
            if (_mode == 1)
            {
                if (genres.Count < 5)
                    MessageBox.Show("Ви не додали достатню кількість жанрів! Залишилось " + (5 - genres.Count), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    this.Close();
            }
            else
                this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
                MessageBox.Show("Неможливо додати порожне поле як жанр", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                genres.Add(textBox1.Text);
                textBox1.Text = String.Empty;
            }
        }
    }
}

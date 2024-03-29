﻿namespace CSharp_Lb4
{
    partial class SongsLibrary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeExecutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberInAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackLenth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.NumberInAlbum,
            this.songName,
            this.artistName,
            this.genre,
            this.albumName,
            this.TrackLenth});
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAlbumToolStripMenuItem,
            this.deleteAlbumToolStripMenuItem,
            this.removeExecutorToolStripMenuItem,
            this.removeTrackToolStripMenuItem,
            this.editTrackToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // addAlbumToolStripMenuItem
            // 
            this.addAlbumToolStripMenuItem.Name = "addAlbumToolStripMenuItem";
            this.addAlbumToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addAlbumToolStripMenuItem.Text = "Додати альбом";
            this.addAlbumToolStripMenuItem.Click += new System.EventHandler(this.addAlbumToolStripMenuItem_Click);
            // 
            // deleteAlbumToolStripMenuItem
            // 
            this.deleteAlbumToolStripMenuItem.Name = "deleteAlbumToolStripMenuItem";
            this.deleteAlbumToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteAlbumToolStripMenuItem.Text = "Видалення альбому";
            this.deleteAlbumToolStripMenuItem.Click += new System.EventHandler(this.deleteAlbumToolStripMenuItem_Click);
            // 
            // removeExecutorToolStripMenuItem
            // 
            this.removeExecutorToolStripMenuItem.Name = "removeExecutorToolStripMenuItem";
            this.removeExecutorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.removeExecutorToolStripMenuItem.Text = "Видалення виконавця";
            this.removeExecutorToolStripMenuItem.Click += new System.EventHandler(this.removeExecutorToolStripMenuItem_Click);
            // 
            // removeTrackToolStripMenuItem
            // 
            this.removeTrackToolStripMenuItem.Name = "removeTrackToolStripMenuItem";
            this.removeTrackToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.removeTrackToolStripMenuItem.Text = "Видалення треку";
            this.removeTrackToolStripMenuItem.Click += new System.EventHandler(this.removeTrackToolStripMenuItem_Click);
            // 
            // editTrackToolStripMenuItem
            // 
            this.editTrackToolStripMenuItem.Name = "editTrackToolStripMenuItem";
            this.editTrackToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editTrackToolStripMenuItem.Text = "Редагування треку";
            this.editTrackToolStripMenuItem.Click += new System.EventHandler(this.editTrackToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сортування за жанрами:";
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Items.AddRange(new object[] {
            "",
            "Фолк-музика",
            "Кантрі",
            "Блюз",
            "Джаз",
            "Шансон",
            "Електро",
            "Рок",
            "Хіп-хоп",
            "Реп",
            "Репкор",
            "Діско",
            "Поп"});
            this.comboBoxGenres.Location = new System.Drawing.Point(340, 54);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(243, 21);
            this.comboBoxGenres.TabIndex = 3;
            this.comboBoxGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сортування за автором:";
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(340, 27);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(243, 21);
            this.comboBoxAuthors.TabIndex = 5;
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthors_SelectedIndexChanged);
            // 
            // Num
            // 
            this.Num.HeaderText = "№";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Num.Width = 30;
            // 
            // NumberInAlbum
            // 
            this.NumberInAlbum.HeaderText = "№(альбом)";
            this.NumberInAlbum.Name = "NumberInAlbum";
            this.NumberInAlbum.ReadOnly = true;
            this.NumberInAlbum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumberInAlbum.Width = 70;
            // 
            // songName
            // 
            this.songName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.songName.HeaderText = "Назва треку";
            this.songName.Name = "songName";
            this.songName.ReadOnly = true;
            this.songName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.songName.Width = 95;
            // 
            // artistName
            // 
            this.artistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.artistName.HeaderText = "Ім\'я виконавця";
            this.artistName.Name = "artistName";
            this.artistName.ReadOnly = true;
            this.artistName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.artistName.Width = 99;
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.genre.HeaderText = "Жанр";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.genre.Width = 61;
            // 
            // albumName
            // 
            this.albumName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.albumName.HeaderText = "Назва альбому";
            this.albumName.Name = "albumName";
            this.albumName.ReadOnly = true;
            this.albumName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.albumName.Width = 101;
            // 
            // TrackLenth
            // 
            this.TrackLenth.HeaderText = "Довжина треку";
            this.TrackLenth.Name = "TrackLenth";
            this.TrackLenth.ReadOnly = true;
            this.TrackLenth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SongsLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGenres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SongsLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аудіо-бібліотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SongsLibrary_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeExecutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTrackToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGenres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberInAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn songName;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackLenth;
    }
}


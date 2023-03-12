namespace CSharp_Lb4
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
            this.songName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeExecutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.songName,
            this.artistName,
            this.genre,
            this.albumName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // songName
            // 
            this.songName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.songName.HeaderText = "Назва треку";
            this.songName.Name = "songName";
            this.songName.Width = 88;
            // 
            // artistName
            // 
            this.artistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.artistName.HeaderText = "Ім\'я виконавця";
            this.artistName.Name = "artistName";
            this.artistName.Width = 99;
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.genre.HeaderText = "Жанр";
            this.genre.Name = "genre";
            this.genre.Width = 61;
            // 
            // albumName
            // 
            this.albumName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.albumName.HeaderText = "Назва альбому";
            this.albumName.Name = "albumName";
            this.albumName.Width = 101;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.спискиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGenreToolStripMenuItem,
            this.addAlbumToolStripMenuItem,
            this.deleteAlbumToolStripMenuItem,
            this.removeExecutorToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // addGenreToolStripMenuItem
            // 
            this.addGenreToolStripMenuItem.Name = "addGenreToolStripMenuItem";
            this.addGenreToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addGenreToolStripMenuItem.Text = "Додати жанр";
            this.addGenreToolStripMenuItem.Click += new System.EventHandler(this.addGenreToolStripMenuItem_Click);
            // 
            // addAlbumToolStripMenuItem
            // 
            this.addAlbumToolStripMenuItem.Name = "addAlbumToolStripMenuItem";
            this.addAlbumToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addAlbumToolStripMenuItem.Text = "Додати альбом";
            // 
            // deleteAlbumToolStripMenuItem
            // 
            this.deleteAlbumToolStripMenuItem.Name = "deleteAlbumToolStripMenuItem";
            this.deleteAlbumToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteAlbumToolStripMenuItem.Text = "Видалення альбому";
            // 
            // removeExecutorToolStripMenuItem
            // 
            this.removeExecutorToolStripMenuItem.Name = "removeExecutorToolStripMenuItem";
            this.removeExecutorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.removeExecutorToolStripMenuItem.Text = "Видалення виконавця";
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executorsToolStripMenuItem,
            this.genresToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // executorsToolStripMenuItem
            // 
            this.executorsToolStripMenuItem.Name = "executorsToolStripMenuItem";
            this.executorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.executorsToolStripMenuItem.Text = "Список виконавців";
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genresToolStripMenuItem.Text = "Список жанрів";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
            // 
            // SongsLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SongsLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аудіо-бібліотека";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songName;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeExecutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
    }
}


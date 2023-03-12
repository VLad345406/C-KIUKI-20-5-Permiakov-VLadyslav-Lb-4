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
            this.додатиЖанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиАльбомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видаленняАльбомуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видаленняВиконавцяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВиконавцівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЖанрівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.додатиЖанрToolStripMenuItem,
            this.додатиАльбомToolStripMenuItem,
            this.видаленняАльбомуToolStripMenuItem,
            this.видаленняВиконавцяToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // додатиЖанрToolStripMenuItem
            // 
            this.додатиЖанрToolStripMenuItem.Name = "додатиЖанрToolStripMenuItem";
            this.додатиЖанрToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.додатиЖанрToolStripMenuItem.Text = "Додати жанр";
            // 
            // додатиАльбомToolStripMenuItem
            // 
            this.додатиАльбомToolStripMenuItem.Name = "додатиАльбомToolStripMenuItem";
            this.додатиАльбомToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.додатиАльбомToolStripMenuItem.Text = "Додати альбом";
            // 
            // видаленняАльбомуToolStripMenuItem
            // 
            this.видаленняАльбомуToolStripMenuItem.Name = "видаленняАльбомуToolStripMenuItem";
            this.видаленняАльбомуToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.видаленняАльбомуToolStripMenuItem.Text = "Видалення альбому";
            // 
            // видаленняВиконавцяToolStripMenuItem
            // 
            this.видаленняВиконавцяToolStripMenuItem.Name = "видаленняВиконавцяToolStripMenuItem";
            this.видаленняВиконавцяToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.видаленняВиконавцяToolStripMenuItem.Text = "Видалення виконавця";
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокВиконавцівToolStripMenuItem,
            this.списокЖанрівToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // списокВиконавцівToolStripMenuItem
            // 
            this.списокВиконавцівToolStripMenuItem.Name = "списокВиконавцівToolStripMenuItem";
            this.списокВиконавцівToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.списокВиконавцівToolStripMenuItem.Text = "Список виконавців";
            // 
            // списокЖанрівToolStripMenuItem
            // 
            this.списокЖанрівToolStripMenuItem.Name = "списокЖанрівToolStripMenuItem";
            this.списокЖанрівToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.списокЖанрівToolStripMenuItem.Text = "Список жанрів";
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
        private System.Windows.Forms.ToolStripMenuItem додатиЖанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиАльбомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видаленняАльбомуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видаленняВиконавцяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВиконавцівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЖанрівToolStripMenuItem;
    }
}


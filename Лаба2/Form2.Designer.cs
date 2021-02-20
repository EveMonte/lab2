namespace Лаба2
{
    partial class SearchResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоДиапазонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоДиапазонуИСимволуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоЛекторуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоСеместруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоКурсуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСпециальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоДиапазонуToolStripMenuItem,
            this.поискПоДиапазонуИСимволуToolStripMenuItem,
            this.поискПоЛекторуToolStripMenuItem,
            this.поискПоСеместруToolStripMenuItem,
            this.поискПоКурсуToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискПоДиапазонуToolStripMenuItem
            // 
            this.поискПоДиапазонуToolStripMenuItem.Name = "поискПоДиапазонуToolStripMenuItem";
            this.поискПоДиапазонуToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоДиапазонуToolStripMenuItem.Text = "Поиск по диапазону";
            // 
            // поискПоДиапазонуИСимволуToolStripMenuItem
            // 
            this.поискПоДиапазонуИСимволуToolStripMenuItem.Name = "поискПоДиапазонуИСимволуToolStripMenuItem";
            this.поискПоДиапазонуИСимволуToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоДиапазонуИСимволуToolStripMenuItem.Text = "Поиск по диапазону и символу";
            // 
            // поискПоЛекторуToolStripMenuItem
            // 
            this.поискПоЛекторуToolStripMenuItem.Name = "поискПоЛекторуToolStripMenuItem";
            this.поискПоЛекторуToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоЛекторуToolStripMenuItem.Text = "Поиск по лектору";
            // 
            // поискПоСеместруToolStripMenuItem
            // 
            this.поискПоСеместруToolStripMenuItem.Name = "поискПоСеместруToolStripMenuItem";
            this.поискПоСеместруToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоСеместруToolStripMenuItem.Text = "Поиск по семестру";
            // 
            // поискПоКурсуToolStripMenuItem
            // 
            this.поискПоКурсуToolStripMenuItem.Name = "поискПоКурсуToolStripMenuItem";
            this.поискПоКурсуToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоКурсуToolStripMenuItem.Text = "Поиск по курсу";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФамилииToolStripMenuItem,
            this.поГодуToolStripMenuItem,
            this.поСпециальностиToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поФамилииToolStripMenuItem
            // 
            this.поФамилииToolStripMenuItem.Name = "поФамилииToolStripMenuItem";
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поФамилииToolStripMenuItem.Text = "По фамилии";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.поФамилииToolStripMenuItem_Click);
            // 
            // поГодуToolStripMenuItem
            // 
            this.поГодуToolStripMenuItem.Name = "поГодуToolStripMenuItem";
            this.поГодуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поГодуToolStripMenuItem.Text = "По году";
            this.поГодуToolStripMenuItem.Click += new System.EventHandler(this.поГодуToolStripMenuItem_Click);
            // 
            // поСпециальностиToolStripMenuItem
            // 
            this.поСпециальностиToolStripMenuItem.Name = "поСпециальностиToolStripMenuItem";
            this.поСпециальностиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поСпециальностиToolStripMenuItem.Text = "По специальности";
            this.поСпециальностиToolStripMenuItem.Click += new System.EventHandler(this.поСпециальностиToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusStrip1.Location = new System.Drawing.Point(776, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(24, 426);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchResult";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоДиапазонуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоДиапазонуИСимволуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поГодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСпециальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискПоЛекторуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоСеместруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоКурсуToolStripMenuItem;
    }
}
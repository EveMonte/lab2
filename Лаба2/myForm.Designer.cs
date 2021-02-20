namespace Лаба2
{
    partial class myForm
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
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.symbolCount = new System.Windows.Forms.Label();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelDiapazon = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.semestrSearch = new System.Windows.Forms.Label();
            this.lecturerSearch = new System.Windows.Forms.Label();
            this.Search3 = new System.Windows.Forms.Button();
            this.Search2 = new System.Windows.Forms.Button();
            this.Search1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоДиапазонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоДиапазонуИСимволуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоЛекторуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоГодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоСпециальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСпециальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelShow = new System.Windows.Forms.Label();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.button4);
            this.Menu.Controls.Add(this.symbolCount);
            this.Menu.Controls.Add(this.labelSymbol);
            this.Menu.Controls.Add(this.labelDiapazon);
            this.Menu.Controls.Add(this.textBox6);
            this.Menu.Controls.Add(this.button3);
            this.Menu.Controls.Add(this.button2);
            this.Menu.Controls.Add(this.textBox5);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.textBox4);
            this.Menu.Controls.Add(this.Year);
            this.Menu.Controls.Add(this.semestrSearch);
            this.Menu.Controls.Add(this.lecturerSearch);
            this.Menu.Controls.Add(this.Search3);
            this.Menu.Controls.Add(this.Search2);
            this.Menu.Controls.Add(this.Search1);
            this.Menu.Controls.Add(this.textBox3);
            this.Menu.Controls.Add(this.textBox2);
            this.Menu.Controls.Add(this.textBox1);
            this.Menu.Location = new System.Drawing.Point(13, 315);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(776, 100);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Text = "Меню";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(683, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 73);
            this.button4.TabIndex = 18;
            this.button4.Text = "Поиск по диапазону и символу и его поизции";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // symbolCount
            // 
            this.symbolCount.AutoSize = true;
            this.symbolCount.Location = new System.Drawing.Point(273, 78);
            this.symbolCount.Name = "symbolCount";
            this.symbolCount.Size = new System.Drawing.Size(158, 13);
            this.symbolCount.TabIndex = 17;
            this.symbolCount.Text = "Подсчет повторений символа";
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Location = new System.Drawing.Point(270, 51);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(174, 13);
            this.labelSymbol.TabIndex = 16;
            this.labelSymbol.Text = "Поиск по символу и его позиции";
            // 
            // labelDiapazon
            // 
            this.labelDiapazon.AutoSize = true;
            this.labelDiapazon.Location = new System.Drawing.Point(267, 20);
            this.labelDiapazon.Name = "labelDiapazon";
            this.labelDiapazon.Size = new System.Drawing.Size(110, 13);
            this.labelDiapazon.TabIndex = 15;
            this.labelDiapazon.Text = "Поиск по диапазону";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(453, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(587, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Подсчет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(453, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(453, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(10, 72);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(31, 13);
            this.Year.TabIndex = 8;
            this.Year.Text = "Курс";
            // 
            // semestrSearch
            // 
            this.semestrSearch.AutoSize = true;
            this.semestrSearch.Location = new System.Drawing.Point(10, 51);
            this.semestrSearch.Name = "semestrSearch";
            this.semestrSearch.Size = new System.Drawing.Size(51, 13);
            this.semestrSearch.TabIndex = 7;
            this.semestrSearch.Text = "Семестр";
            // 
            // lecturerSearch
            // 
            this.lecturerSearch.AutoSize = true;
            this.lecturerSearch.Location = new System.Drawing.Point(7, 24);
            this.lecturerSearch.Name = "lecturerSearch";
            this.lecturerSearch.Size = new System.Drawing.Size(44, 13);
            this.lecturerSearch.TabIndex = 6;
            this.lecturerSearch.Text = "Лектор";
            // 
            // Search3
            // 
            this.Search3.Location = new System.Drawing.Point(186, 72);
            this.Search3.Name = "Search3";
            this.Search3.Size = new System.Drawing.Size(75, 20);
            this.Search3.TabIndex = 5;
            this.Search3.Text = "Поиск";
            this.Search3.UseVisualStyleBackColor = true;
            this.Search3.Click += new System.EventHandler(this.Search3_Click);
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(186, 44);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(75, 20);
            this.Search2.TabIndex = 4;
            this.Search2.Text = "Поиск";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Click += new System.EventHandler(this.Search2_Click);
            // 
            // Search1
            // 
            this.Search1.Location = new System.Drawing.Point(186, 17);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(75, 20);
            this.Search1.TabIndex = 3;
            this.Search1.Text = "Поиск";
            this.Search1.UseVisualStyleBackColor = true;
            this.Search1.Click += new System.EventHandler(this.Search1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(199, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Сортировка по фамилии";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(384, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 31);
            this.button6.TabIndex = 2;
            this.button6.Text = "Сортировка по году";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(539, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(185, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Сортировка по специальности";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(26, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "О программе";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.впередToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоДиапазонуToolStripMenuItem,
            this.поискПоДиапазонуИСимволуToolStripMenuItem,
            this.поискПоЛекторуToolStripMenuItem,
            this.поискПоГодуToolStripMenuItem,
            this.поискПоСпециальностиToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискПоДиапазонуToolStripMenuItem
            // 
            this.поискПоДиапазонуToolStripMenuItem.Name = "поискПоДиапазонуToolStripMenuItem";
            this.поискПоДиапазонуToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоДиапазонуToolStripMenuItem.Text = "Поиск по диапазону";
            this.поискПоДиапазонуToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // поискПоДиапазонуИСимволуToolStripMenuItem
            // 
            this.поискПоДиапазонуИСимволуToolStripMenuItem.Name = "поискПоДиапазонуИСимволуToolStripMenuItem";
            this.поискПоДиапазонуИСимволуToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоДиапазонуИСимволуToolStripMenuItem.Text = "Поиск по диапазону и символу";
            this.поискПоДиапазонуИСимволуToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // поискПоЛекторуToolStripMenuItem
            // 
            this.поискПоЛекторуToolStripMenuItem.Name = "поискПоЛекторуToolStripMenuItem";
            this.поискПоЛекторуToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоЛекторуToolStripMenuItem.Text = "Поиск по лектору";
            this.поискПоЛекторуToolStripMenuItem.Click += new System.EventHandler(this.Search1_Click);
            // 
            // поискПоГодуToolStripMenuItem
            // 
            this.поискПоГодуToolStripMenuItem.Name = "поискПоГодуToolStripMenuItem";
            this.поискПоГодуToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоГодуToolStripMenuItem.Text = "Поиск по году";
            this.поискПоГодуToolStripMenuItem.Click += new System.EventHandler(this.Search2_Click);
            // 
            // поискПоСпециальностиToolStripMenuItem
            // 
            this.поискПоСпециальностиToolStripMenuItem.Name = "поискПоСпециальностиToolStripMenuItem";
            this.поискПоСпециальностиToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.поискПоСпециальностиToolStripMenuItem.Text = "Поиск по специальности";
            this.поискПоСпециальностиToolStripMenuItem.Click += new System.EventHandler(this.Search3_Click);
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
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поФамилииToolStripMenuItem.Text = "По фамилии";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
            // 
            // поГодуToolStripMenuItem
            // 
            this.поГодуToolStripMenuItem.Name = "поГодуToolStripMenuItem";
            this.поГодуToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поГодуToolStripMenuItem.Text = "По году";
            this.поГодуToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // поСпециальностиToolStripMenuItem
            // 
            this.поСпециальностиToolStripMenuItem.Name = "поСпециальностиToolStripMenuItem";
            this.поСпециальностиToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.поСпециальностиToolStripMenuItem.Text = "По специальности";
            this.поСпециальностиToolStripMenuItem.Click += new System.EventHandler(this.button7_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(146, 17);
            this.toolStripStatusLabel1.Text = "Количество элементов: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel4.Text = "Скрыть";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(7, 415);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 13);
            this.labelShow.TabIndex = 7;
            this.labelShow.Click += new System.EventHandler(this.labelShow_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 17);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // впередToolStripMenuItem
            // 
            this.впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            this.впередToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.впередToolStripMenuItem.Text = "Вперед";
            this.впередToolStripMenuItem.Click += new System.EventHandler(this.впередToolStripMenuItem_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Menu);
            this.Name = "myForm";
            this.Text = "myForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button Search3;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.Button Search1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label semestrSearch;
        private System.Windows.Forms.Label lecturerSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelDiapazon;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label symbolCount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
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
        private System.Windows.Forms.ToolStripMenuItem поискПоЛекторуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоГодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоСпециальностиToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem;
    }
}
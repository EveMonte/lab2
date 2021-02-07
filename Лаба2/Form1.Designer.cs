namespace Лаба2
{
    partial class Form1
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
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.DisciplineName = new System.Windows.Forms.TextBox();
            this.NumberOfLections = new System.Windows.Forms.TextBox();
            this.NumberOfLaboratories = new System.Windows.Forms.TextBox();
            this.Auditory = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Exam = new System.Windows.Forms.RadioButton();
            this.Offset = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Speciality = new System.Windows.Forms.ListBox();
            this.Semestr = new System.Windows.Forms.ComboBox();
            this.SendAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NameOfLecturer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Chair = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.NameOfBook = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(135, 91);
            this.Year.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(128, 20);
            this.Year.TabIndex = 0;
            this.Year.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DisciplineName
            // 
            this.DisciplineName.Location = new System.Drawing.Point(135, 31);
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(128, 20);
            this.DisciplineName.TabIndex = 1;
            // 
            // NumberOfLections
            // 
            this.NumberOfLections.Location = new System.Drawing.Point(135, 161);
            this.NumberOfLections.Name = "NumberOfLections";
            this.NumberOfLections.Size = new System.Drawing.Size(128, 20);
            this.NumberOfLections.TabIndex = 2;
            // 
            // NumberOfLaboratories
            // 
            this.NumberOfLaboratories.Location = new System.Drawing.Point(135, 191);
            this.NumberOfLaboratories.Name = "NumberOfLaboratories";
            this.NumberOfLaboratories.Size = new System.Drawing.Size(128, 20);
            this.NumberOfLaboratories.TabIndex = 3;
            // 
            // Auditory
            // 
            this.Auditory.Location = new System.Drawing.Point(499, 152);
            this.Auditory.Name = "Auditory";
            this.Auditory.Size = new System.Drawing.Size(100, 20);
            this.Auditory.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 291);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Exam
            // 
            this.Exam.AutoSize = true;
            this.Exam.Location = new System.Drawing.Point(194, 221);
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(69, 17);
            this.Exam.TabIndex = 7;
            this.Exam.TabStop = true;
            this.Exam.Text = "экзамен";
            this.Exam.UseVisualStyleBackColor = true;
            // 
            // Offset
            // 
            this.Offset.AutoSize = true;
            this.Offset.Location = new System.Drawing.Point(135, 221);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(53, 17);
            this.Offset.TabIndex = 9;
            this.Offset.TabStop = true;
            this.Offset.Text = "зачет";
            this.Offset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название дисциплины";
            // 
            // Speciality
            // 
            this.Speciality.FormattingEnabled = true;
            this.Speciality.Items.AddRange(new object[] {
            "ИСиТ",
            "ПОИТ",
            "ПОИБМС",
            "ДЭиВИ"});
            this.Speciality.Location = new System.Drawing.Point(135, 121);
            this.Speciality.Name = "Speciality";
            this.Speciality.Size = new System.Drawing.Size(128, 30);
            this.Speciality.TabIndex = 12;
            // 
            // Semestr
            // 
            this.Semestr.FormattingEnabled = true;
            this.Semestr.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Semestr.Location = new System.Drawing.Point(135, 61);
            this.Semestr.Name = "Semestr";
            this.Semestr.Size = new System.Drawing.Size(128, 21);
            this.Semestr.TabIndex = 13;
            // 
            // SendAll
            // 
            this.SendAll.Location = new System.Drawing.Point(62, 307);
            this.SendAll.Name = "SendAll";
            this.SendAll.Size = new System.Drawing.Size(201, 46);
            this.SendAll.TabIndex = 14;
            this.SendAll.Text = "Отправить";
            this.SendAll.UseVisualStyleBackColor = true;
            this.SendAll.Click += new System.EventHandler(this.SendAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Номер семестра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Курс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Специальность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Количество лекций\r\nв семестре";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Количество\r\nлабораторных";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Вид контроля";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Лектор";
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(499, 36);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(100, 20);
            this.SecondName.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Имя";
            // 
            // NameOfLecturer
            // 
            this.NameOfLecturer.Location = new System.Drawing.Point(499, 63);
            this.NameOfLecturer.Name = "NameOfLecturer";
            this.NameOfLecturer.Size = new System.Drawing.Size(100, 20);
            this.NameOfLecturer.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Отчество";
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(499, 92);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(100, 20);
            this.Patronymic.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(380, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Кафедра";
            // 
            // Chair
            // 
            this.Chair.Location = new System.Drawing.Point(499, 121);
            this.Chair.Name = "Chair";
            this.Chair.Size = new System.Drawing.Size(100, 20);
            this.Chair.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Аудитория";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(101, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Дисциплина";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(447, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Список литературы";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(377, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Название";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(377, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Автор";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(381, 297);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Год";
            // 
            // NameOfBook
            // 
            this.NameOfBook.Location = new System.Drawing.Point(499, 223);
            this.NameOfBook.Name = "NameOfBook";
            this.NameOfBook.Size = new System.Drawing.Size(100, 20);
            this.NameOfBook.TabIndex = 37;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(499, 258);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(100, 20);
            this.Author.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.NameOfBook);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Chair);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NameOfLecturer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendAll);
            this.Controls.Add(this.Semestr);
            this.Controls.Add(this.Speciality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.Exam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Auditory);
            this.Controls.Add(this.NumberOfLaboratories);
            this.Controls.Add(this.NumberOfLections);
            this.Controls.Add(this.DisciplineName);
            this.Controls.Add(this.Year);
            this.Name = "Form1";
            this.Text = "A lot of management elements";
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.TextBox DisciplineName;
        private System.Windows.Forms.TextBox NumberOfLections;
        private System.Windows.Forms.TextBox NumberOfLaboratories;
        private System.Windows.Forms.TextBox Auditory;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton Exam;
        private System.Windows.Forms.RadioButton Offset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Speciality;
        private System.Windows.Forms.ComboBox Semestr;
        private System.Windows.Forms.Button SendAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NameOfLecturer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Chair;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox NameOfBook;
        private System.Windows.Forms.TextBox Author;
    }
}


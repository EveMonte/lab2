using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;

namespace Лаба2
{
    public partial class SearchResult : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage;
        public SearchResult(string name)
        {
            Tabs(name);
            InitializeComponent();
        }
        public SearchResult(int semestr)
        {
            Tabs(semestr);
            InitializeComponent();
        }
        public SearchResult(int year, bool i)
        {
            Tabs(year, i);
            InitializeComponent();
        }
        public SearchResult(string diapazon, bool b)
        {
            Tabs(diapazon, b);
            InitializeComponent();
        }

        public SearchResult(char ch, int pos)
        {
            Tabs(ch, pos);
            InitializeComponent();
        }
        public SearchResult(bool b, char ch)
        {
            Tabs(b, ch);
            /*string str = "Привет омтцоик пока";
            Match match = new Regex("Привет {.*?} пока").Match(str);
            Group group = match.Groups[1];
            MessageBox.Show(group.Value.ToString());*/
            InitializeComponent();
        }
        public TabPage CreateTabPage(Discipline dis, int i)
        {
            tabPage = new TabPage();
            tabPage.Text = "Page" + i;
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Label label4 = new Label();
            Label label5 = new Label();
            Label label6 = new Label();
            Label label7 = new Label();
            Label label8 = new Label();
            Label label9 = new Label();
            Label label10 = new Label();
            Label label11 = new Label();
            Label label12 = new Label();
            Label label13 = new Label();
            Label label14 = new Label();
            Label label15 = new Label();
            Label label16 = new Label();
            tabPage.Controls.AddRange(new Control[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14 });

            label1.Text = "Дисциплина: " + dis.Name.ToString();
            label1.AutoSize = true;
            label1.Location = new Point(26, 18);

            label2.Text = "Семестр: " + dis.Semestr.ToString();
            label2.AutoSize = true;
            label2.Location = new Point(26, 47);

            label3.Text = "Курс: " + dis.Year.ToString();
            label3.AutoSize = true;
            label3.Location = new Point(26, 77);

            label4.Text = "Кол-во лекций: " + dis.NumberOfLections.ToString();
            label4.AutoSize = true;
            label4.Location = new Point(26, 105);

            label5.Text = "Кол-во лабораторных: " + dis.NumberOfLaboratories.ToString();
            label5.AutoSize = true;
            label5.Location = new Point(26, 134);

            label6.Text = "Тип контроля: " + dis.TypeOfControl;
            label6.Location = new Point(26, 161);

            label7.Text = "Фамилия: " + dis.lecturer.SecondName;
            label7.Location = new Point(230, 18);

            label8.Text = "Имя: " + dis.lecturer.Name;
            label8.Location = new Point(230, 47);

            label9.Text = "Отчество: " + dis.lecturer.Patronymic;
            label9.Location = new Point(230, 77);

            label10.Text = "Кафедра: " + dis.lecturer.Chair;
            label10.Location = new Point(230, 105);


            /*label12.Text = dis.Speciality;
            label12.Location = new Point(420, 18);*/

            label11.Text = "Аудитория: " + dis.lecturer.Auditory;
            label11.Location = new Point(230, 134);

            label12.Text = "Название книги: " + dis.listOfLiterature.Name;
            label12.Location = new Point(420, 18);

            label13.Text = "Дата написания: " + dis.listOfLiterature.date.ToString();
            label13.Location = new Point(420, 47);

            label14.Text = "Автор: " + dis.listOfLiterature.Author;
            label14.Location = new Point(230, 77);
            foreach (Label lab in tabPage.Controls)
            {
                lab.AutoSize = true;
                lab.TabIndex = i;
            }
            return tabPage;
        }
        private void Tabs(string name)
        {

            int i = 0;
            int count = 0;
            tabControl1 = new TabControl();
            tabControl1.Size = new Size(800, 400);
            tabControl1.Location = new Point(1, 1);

            //tabPage.Text = "Page";
            XmlSerializer xser = new XmlSerializer(typeof(List<Discipline>));
            using (FileStream fileStream = new FileStream("Forms.xml", FileMode.OpenOrCreate))
            {
                List<Discipline> newListOfDisciplines = (List<Discipline>)xser.Deserialize(fileStream);
                foreach (Discipline dis in newListOfDisciplines)
                {
                    if (dis.lecturer.SecondName == name)
                    {
                        count++;
                    }
                }
                Control[] tabPages = new Control[count];

                foreach (Discipline dis in newListOfDisciplines)
                {
                    if (dis.lecturer.SecondName.Trim() == name.Trim())
                    {
                        tabPages[i] = CreateTabPage(dis, i);
                        i++;
                    }
                }
                if (count != 0)
                {
                    tabControl1.Controls.AddRange(tabPages);

                    this.Controls.AddRange(new Control[] {
    this.tabControl1});
                }
                else
                    MessageBox.Show("Поиск не дал результатов, проверьте свой поисковый запрос!");
            }
        }
        private void Tabs(int semestr)
        {

            int i = 0;
            int count = 0;
            tabControl1 = new TabControl();
            tabControl1.Size = new Size(800, 400);
            tabControl1.Location = new Point(1, 1);

            //tabPage.Text = "Page";
            XmlSerializer xser = new XmlSerializer(typeof(List<Discipline>));
            using (FileStream fileStream = new FileStream("Forms.xml", FileMode.OpenOrCreate))
            {
                List<Discipline> newListOfDisciplines = (List<Discipline>)xser.Deserialize(fileStream);
                foreach (Discipline dis in newListOfDisciplines)
                {
                    if (dis.Semestr == semestr)
                    {
                        count++;
                    }
                }
                Control[] tabPages = new Control[count];

                foreach (Discipline dis in newListOfDisciplines)
                {
                    if (dis.Semestr == semestr)
                    {
                        tabPages[i] = CreateTabPage(dis, i);
                        i++;
                    }
                }
                if (count != 0)
                {
                    tabControl1.Controls.AddRange(tabPages);

                    this.Controls.AddRange(new Control[] {
    this.tabControl1});
                }
                else
                    MessageBox.Show("Поиск не дал результатов, проверьте свой поисковый запрос!");
            }
        }
        private void Tabs(int year, bool b)
        {

            int i = 0;
            int count = 0;
            tabControl1 = new TabControl();
            tabControl1.Size = new Size(800, 400);
            tabControl1.Location = new Point(1, 1);

            //tabPage.Text = "Page";
            XmlSerializer xser = new XmlSerializer(typeof(List<Discipline>));
            using (FileStream fileStream = new FileStream("Forms.xml", FileMode.OpenOrCreate))
            {
                List<Discipline> newListOfDisciplines = (List<Discipline>)xser.Deserialize(fileStream);
                foreach (Discipline dis in newListOfDisciplines)
                {
                    if (dis.Year == year)
                    {
                        count++;
                    }
                }
                Control[] tabPages = new Control[count];

                foreach (Discipline dis in newListOfDisciplines)
                {
                    if (dis.Year == year)
                    {
                        tabPages[i] = CreateTabPage(dis, i);
                        i++;
                    }
                }
                if (count != 0)
                {
                    tabControl1.Controls.AddRange(tabPages);

                    this.Controls.AddRange(new Control[] {
    this.tabControl1});
                }
                else
                    MessageBox.Show("Поиск не дал результатов, проверьте свой поисковый запрос!");
            }
        }
        private void Tabs(bool b, char ch)
        {
            Regex r = new Regex(ch.ToString(), RegexOptions.IgnoreCase);
            //MatchCollection coll;
            int i = 0;
            int count = 0;
            tabControl1 = new TabControl();
            tabControl1.Size = new Size(800, 400);
            tabControl1.Location = new Point(1, 1);

            //tabPage.Text = "Page";
            XmlSerializer xser = new XmlSerializer(typeof(List<Discipline>));
            using (FileStream fileStream = new FileStream("Forms.xml", FileMode.OpenOrCreate))
            {
                List<Discipline> newListOfDisciplines = (List<Discipline>)xser.Deserialize(fileStream);
                foreach (Discipline dis in newListOfDisciplines)
                {
                    //if (reg.IsMatch(dis.Year.ToString()))
                    if (r.IsMatch(dis.Name))
                    {
                        MatchCollection match = new Regex(ch.ToString()).Matches(dis.Name);

                        count += match.Count;
                    }
                }
                MessageBox.Show(count.ToString());
                
                
            }
        }
        private void Tabs(char ch, int pos)
        {
            Regex reg = new Regex(@"\w{" + pos +@"}[" + ch + @"]");
            Regex r = new Regex(@"\w[г]*");
            //MatchCollection coll;
            int i = 0;
            int count = 0;
            tabControl1 = new TabControl();
            tabControl1.Size = new Size(800, 400);
            tabControl1.Location = new Point(1, 1);

            //tabPage.Text = "Page";
            XmlSerializer xser = new XmlSerializer(typeof(List<Discipline>));
            using (FileStream fileStream = new FileStream("Forms.xml", FileMode.OpenOrCreate))
            {
                List<Discipline> newListOfDisciplines = (List<Discipline>)xser.Deserialize(fileStream);
                foreach (Discipline dis in newListOfDisciplines)
                {
                    //if (reg.IsMatch(dis.Year.ToString()))
                    if (reg.IsMatch(dis.Name))
                    {
                        count++;
                    }
                }
                Control[] tabPages = new Control[count];

                foreach (Discipline dis in newListOfDisciplines)
                {
                    //if (reg.IsMatch(dis.Year.ToString()))
                    if (reg.IsMatch(dis.Name))
                    {
                        tabPages[i] = CreateTabPage(dis, i);
                        i++;
                    }
                }
                if (count != 0)
                {
                    tabControl1.Controls.AddRange(tabPages);

                    this.Controls.AddRange(new Control[] {
    this.tabControl1});
                }
                else
                    MessageBox.Show("Поиск не дал результатов, проверьте свой поисковый запрос!");
            }
        }
        private void Tabs(string diapazon, bool b)
        {
            Regex reg = new Regex(@"["+diapazon+@"]{1}");
            //Regex r = new Regex(@"\w{2}[и]");
            //MatchCollection coll;
            int i = 0;
            int count = 0;
            tabControl1 = new TabControl();
            tabControl1.Size = new Size(800, 400);
            tabControl1.Location = new Point(1, 1);

            //tabPage.Text = "Page";
            XmlSerializer xser = new XmlSerializer(typeof(List<Discipline>));
            using (FileStream fileStream = new FileStream("Forms.xml", FileMode.OpenOrCreate))
            {
                List<Discipline> newListOfDisciplines = (List<Discipline>)xser.Deserialize(fileStream);
                foreach (Discipline dis in newListOfDisciplines)
                {
                    if (reg.IsMatch(dis.Year.ToString()))
                    //if (r.IsMatch(dis.Name))
                    {
                        count++;
                    }
                }
                Control[] tabPages = new Control[count];

                foreach (Discipline dis in newListOfDisciplines)
                {
                    if (reg.IsMatch(dis.Year.ToString()))
                    //if (r.IsMatch(dis.Name))
                    {
                        tabPages[i] = CreateTabPage(dis, i);
                        i++;
                    }
                }
                if (count != 0)
                {
                    tabControl1.Controls.AddRange(tabPages);

                    this.Controls.AddRange(new Control[] {
    this.tabControl1});
                }
                else
                    MessageBox.Show("Поиск не дал результатов, проверьте свой поисковый запрос!");
            }
        }
    }
}


    

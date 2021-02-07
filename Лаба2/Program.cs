using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба2
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime date { get; set; }
    }
    public class Lecturer
    {
        public string Chair { get; set; }//such an interesting translation by Google Translator
        public string SecondName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Auditory { get; set; }
    }
    public class Discipline
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int semestr;
        public int Semestr
        {
            get { return semestr; }
            set { semestr = value; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string speciality;
        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }
        private int numberOfLections;
        public int NumberOfLections
        {
            get { return numberOfLections; }
            set { numberOfLections = value; }
        }
        public int NumberOfLaboratories { get; set; }
        public string TypeOfControl { get; set; }

        public Lecturer lecturer;
        public List<Book> listOfLiterature = new List<Book>();

    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

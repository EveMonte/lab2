using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Лаба2
{
    public class SemestrAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if ((int)value < 1 || (int)value > 2)
            {
                this.ErrorMessage = "Wrong semestr!";
                return false;
            }
            else return true;
        }
    }

    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime date { get; set; }
    }
    [Serializable]
    public class Lecturer
    {
        [Required]
        public string Chair { get; set; }//such an interesting translation by Google Translator
        [Required]
        [Range(2, 20)]
        public string SecondName { get; set; }
        [Required]
        [Range(2, 20)]
        public string Name { get; set; }
        [Required]
        [Range(2, 20)]
        public string Patronymic { get; set; }
        [Required]
        [RegularExpression(@"^[0-5][0-6][0-9]$", ErrorMessage = "Wrong format!")]
        public string Auditory { get; set; }
    }
    [Serializable]
    public class Discipline
    {
        [Required]
        [Range(2, 15)]
        public string Name
        {
            get;
            set;
        }
        [Semestr]
        public int Semestr
        {
            get;
            set;
        }
        [Required]
        public int Year
        {
            get;
            set;
        }
        [Required]
        public string Speciality
        {
            get;
            set;
        }
        [Required]
        public int NumberOfLections
        {
            get;
            set;
        }
        [Required]
        public int NumberOfLaboratories { get; set; }
        [Required]
        public string TypeOfControl { get; set; }
        [Required]
        public Lecturer lecturer = new Lecturer();
        [Required]
        public Book listOfLiterature = new Book();

    }
    static class Program
    {
        public static string Info = "";
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

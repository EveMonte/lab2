using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendAll_Click(object sender, EventArgs e)
        {

            Discipline discipline = new Discipline();
            #region Discipline form
            try
            {
                if (DisciplineName.Text != "")
                {
                    DisciplineName.BackColor = Color.White;
                    discipline.Name = DisciplineName.Text;

                }
                else
                {
                    DisciplineName.BackColor = Color.Salmon;
                    throw new Exception("Please enter Name!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int numberForTryParse;
            try
            {
                if (int.TryParse(NumberOfLaboratories.Text, out numberForTryParse))
                {
                    discipline.NumberOfLaboratories = numberForTryParse;
                    NumberOfLaboratories.BackColor = Color.White;
                }
                else
                {
                    NumberOfLaboratories.BackColor = Color.Salmon;
                    throw new Exception("Invalid number or empty field!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
            {
                if (int.TryParse(NumberOfLections.Text, out numberForTryParse))
                {
                    NumberOfLaboratories.BackColor = Color.White;
                    discipline.NumberOfLections = numberForTryParse;
                }
                else
                {
                    NumberOfLections.BackColor = Color.Salmon;
                    throw new Exception("Invalid number or empty field!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            discipline.Semestr = Semestr.SelectedIndex;
            discipline.Year = (int)Year.Value;

            try
            {
                if (Offset.Checked && !Exam.Checked)
                {
                    discipline.TypeOfControl = Offset.Text;

                }
                else if (!Offset.Checked && Exam.Checked)
                {
                    discipline.TypeOfControl = Exam.Text;

                }
                else if (!Offset.Checked && !Exam.Checked)
                {
                    throw new Exception("Please click on radio-button!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region Lecturer form
            try
            {
                if (SecondName.Text != "")
                {
                    discipline.lecturer.SecondName = SecondName.Text;
                    SecondName.BackColor = Color.White;
                }
                else
                {
                    SecondName.BackColor = Color.Salmon;
                    throw new Exception("Fill the text box!");
                }
            }
            catch(Exception ex)
            {

            }
            try
            {
                if (NameOfLecturer.Text != "")
                {
                    discipline.lecturer.Name = NameOfLecturer.Text;
                    NameOfLecturer.BackColor = Color.White;
                }
                else
                {
                    NameOfLecturer.BackColor = Color.Salmon;
                    throw new Exception("Fill the text box!");
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (NameOfLecturer.Text != "")
                {
                    discipline.lecturer.Patronymic = Patronymic.Text;
                    Patronymic.BackColor = Color.White;
                }
                else
                {
                    Patronymic.BackColor = Color.Salmon;
                    throw new Exception("Fill the text box!");
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (Chair.Text != "")
                {
                    discipline.lecturer.Chair = Chair.Text;
                    Chair.BackColor = Color.White;
                }
                else
                {
                    Chair.BackColor = Color.Salmon;
                    throw new Exception("Fill the text box!");
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                if (Auditory.Text != "")
                {
                    discipline.lecturer.Auditory = Auditory.Text;
                    Auditory.BackColor = Color.White;
                }
                else
                {
                    Auditory.BackColor = Color.Salmon;
                    throw new Exception("Fill the text box!");
                }
            }
            catch (Exception ex)
            {

            }
            #endregion

            #region List of literature form
            Book book = new Book();

            try
            {
                if (NameOfBook.Text != "")
                {
                    book.Name = NameOfBook.Text;
                    NameOfBook.BackColor = Color.White;
                }
                else
                {
                    NameOfBook.BackColor = Color.Salmon;
                    throw new Exception("Fill the text box!");
                }
            }
            catch (Exception ex)
            {

            }
            try
            {
                if (NameOfBook.Text != "")
                {
                    book.Author = Author.Text;
                    Author.BackColor = Color.White;
                }
                else
                {
                    Author.BackColor = Color.Salmon;
                    throw new Exception("Fill the text box!");
                }
            }
            catch (Exception ex)
            {

            }
            try
            {
                if (dateTimePicker1 != null)
                {
                    book.date = dateTimePicker1.Value;
                    //NameOfBook.BackColor = Color.White;
                }
                else
                {
                    //NameOfBook.BackColor = Color.Salmon;
                    throw new Exception("Fill the text box!");
                }
            }
            catch (Exception ex)
            {

            }
            discipline.listOfLiterature.Add(book);

            #endregion
        }
    }
}

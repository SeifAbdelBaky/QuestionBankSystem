using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form2 : Form
    {
        private List<Question> questions = new List<Question>();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the question.");
                txtQuestion.Focus();
                return;
            }

            if (txtOption1.Text.Trim() == "" ||
                txtOption2.Text.Trim() == "" ||
                txtOption3.Text.Trim() == "" ||
                txtOption4.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all four options.");
                return;
            }

            if (cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            if (cmbDifficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select difficulty.");
                return;
            }

            if (cmbCorrectAnswer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the correct answer.");
                return;
            }

            Question newQuestion = new Question();

            newQuestion.QuestionText = txtQuestion.Text;
            newQuestion.Option1 = txtOption1.Text;
            newQuestion.Option2 = txtOption2.Text;
            newQuestion.Option3 = txtOption3.Text;
            newQuestion.Option4 = txtOption4.Text;
            newQuestion.Subject = cmbSubject.Text;
            newQuestion.Difficulty = cmbDifficulty.Text;
            newQuestion.CorrectAnswer = cmbCorrectAnswer.Text;

            questions.Add(newQuestion);

            MessageBox.Show("Question added successfully.");

            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();

            cmbSubject.SelectedIndex = -1;
            cmbDifficulty.SelectedIndex = -1;
            cmbCorrectAnswer.SelectedIndex = -1;
        }

       
    }
}

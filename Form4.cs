using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form4 : Form
    {
        private List<Question> questions = new List<Question>();

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            // Check subject and difficulty selection
            if (cmbSubject.SelectedIndex == -1 ||
                cmbDifficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select subject and difficulty.");
                return;
            }

            // Create a list for quiz questions
            List<Question> quizQuestions = new List<Question>();

            // Find questions matching the selected subject and difficulty
            foreach (Question question in questions)
            {
                if (question.Subject.Trim() == cmbSubject.Text.Trim() &&
                    question.Difficulty.Trim() == cmbDifficulty.Text.Trim())
                {
                    quizQuestions.Add(question);
                }
            }

            // Check if matching questions exist
            if (quizQuestions.Count == 0)
            {
                MessageBox.Show(
                    "No questions available for the selected subject and difficulty."
                );
                return;
            }

            // Open Form5 and pass the matching questions
            Form5 form = new Form5(quizQuestions);
            form.ShowDialog();
        }
    }
}
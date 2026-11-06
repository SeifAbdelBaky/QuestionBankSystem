using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form5 : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int score = 0;
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

       
        private void Form5_Load(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            score = 0;

            lblQuestion.Text = questions[currentQuestionIndex].QuestionText;

            rdoOption1.Text = questions[currentQuestionIndex].Option1;
            rdoOption2.Text = questions[currentQuestionIndex].Option2;
            rdoOption3.Text = questions[currentQuestionIndex].Option3;
            rdoOption4.Text = questions[currentQuestionIndex].Option4;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check if the user selected an answer
            if (rdoOption1.Checked == false &&
                rdoOption2.Checked == false &&
                rdoOption3.Checked == false &&
                rdoOption4.Checked == false)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            // Get the selected answer
            string selectedAnswer = "";

            if (rdoOption1.Checked == true)
            {
                selectedAnswer = "Option 1";
            }
            else if (rdoOption2.Checked == true)
            {
                selectedAnswer = "Option 2";
            }
            else if (rdoOption3.Checked == true)
            {
                selectedAnswer = "Option 3";
            }
            else if (rdoOption4.Checked == true)
            {
                selectedAnswer = "Option 4";
            }

            // Check the correct answer
            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
            {
                score++;
            }

            // Move to the next question
            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;

                lblQuestion.Text = questions[currentQuestionIndex].QuestionText;

                rdoOption1.Text = questions[currentQuestionIndex].Option1;
                rdoOption2.Text = questions[currentQuestionIndex].Option2;
                rdoOption3.Text = questions[currentQuestionIndex].Option3;
                rdoOption4.Text = questions[currentQuestionIndex].Option4;

                // Clear previous selection
                rdoOption1.Checked = false;
                rdoOption2.Checked = false;
                rdoOption3.Checked = false;
                rdoOption4.Checked = false;
            }
            else
            {
                // Display final result
                MessageBox.Show(
                    "Quiz Finished!\nYour Score: " +
                    score + " / " + questions.Count
                );

                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

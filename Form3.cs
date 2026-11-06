using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form3 : Form
    {
        private List<Question> questions = new List<Question>();

        private Form1? mainForm;

        public Form3()
        {
            InitializeComponent();
        }


        public Form3(List<Question> questions, Form1 mainForm)
        {
            InitializeComponent();
            this.questions = questions;
            this.mainForm = mainForm;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            lstQuestions.Items.Clear();

            foreach (Question question in questions)
            {
                lstQuestions.Items.Add(question.QuestionText);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a question.");
            }
            else
            {
                bool found = false;

                foreach (Question question in questions)
                {
                    if (question.QuestionText.Trim() == txtSearch.Text.Trim())
                    {
                        found = true;
                    }
                }

                if (found == true)
                {
                    MessageBox.Show("Question found.");
                }
                else
                {
                    MessageBox.Show("Question not found.");
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lstQuestions.Items.Clear();

            foreach (Question question in questions)
            {
                lstQuestions.Items.Add(question.QuestionText);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || cmbDifficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select subject and difficulty.");
                return;
            }

            lstQuestions.Items.Clear();

            foreach (Question question in questions)
            {
                if (question.Subject == cmbSubject.Text &&
                    question.Difficulty == cmbDifficulty.Text)
                {
                    lstQuestions.Items.Add(question.QuestionText);
                }
            }

            if (lstQuestions.Items.Count == 0)
            {
                MessageBox.Show("No questions found.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Show();
            }

            this.Close();
        }
    }
}

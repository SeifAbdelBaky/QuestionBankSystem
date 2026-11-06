using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisplayQuestions_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(questions, this);
            form.Show();
            this.Hide();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(questions);
            form.ShowDialog();
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(questions);
            form.ShowDialog();
        }
    }
}

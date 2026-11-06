namespace QuestionBankSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnAddQuestion = new Button();
            btnDisplayQuestions = new Button();
            btnExit = new Button();
            btnTakeQuiz = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(291, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(301, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Question Bank System";
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.DarkSlateGray;
            btnAddQuestion.FlatStyle = FlatStyle.Flat;
            btnAddQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.Location = new Point(265, 182);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(350, 50);
            btnAddQuestion.TabIndex = 1;
            btnAddQuestion.Text = "Add Question";
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnDisplayQuestions
            // 
            btnDisplayQuestions.BackColor = Color.DarkSlateGray;
            btnDisplayQuestions.FlatStyle = FlatStyle.Flat;
            btnDisplayQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplayQuestions.ForeColor = Color.White;
            btnDisplayQuestions.Location = new Point(265, 264);
            btnDisplayQuestions.Name = "btnDisplayQuestions";
            btnDisplayQuestions.Size = new Size(350, 50);
            btnDisplayQuestions.TabIndex = 2;
            btnDisplayQuestions.Text = "Display Questions";
            btnDisplayQuestions.UseVisualStyleBackColor = false;
            btnDisplayQuestions.Click += btnDisplayQuestions_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSlateGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(265, 419);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(350, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnTakeQuiz
            // 
            btnTakeQuiz.BackColor = Color.DarkSlateGray;
            btnTakeQuiz.FlatStyle = FlatStyle.Flat;
            btnTakeQuiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTakeQuiz.ForeColor = Color.White;
            btnTakeQuiz.Location = new Point(265, 342);
            btnTakeQuiz.Name = "btnTakeQuiz";
            btnTakeQuiz.Size = new Size(350, 50);
            btnTakeQuiz.TabIndex = 4;
            btnTakeQuiz.Text = "Take a Quiz";
            btnTakeQuiz.UseVisualStyleBackColor = false;
            btnTakeQuiz.Click += btnTakeQuiz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(884, 561);
            Controls.Add(btnTakeQuiz);
            Controls.Add(btnExit);
            Controls.Add(btnDisplayQuestions);
            Controls.Add(btnAddQuestion);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question Bank System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAddQuestion;
        private Button btnDisplayQuestions;
        private Button btnExit;
        private Button btnTakeQuiz;
    }
}
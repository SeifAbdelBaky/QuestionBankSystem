namespace QuestionBankSystem
{
    partial class Form2
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
            lblQuestion = new Label();
            txtQuestion = new TextBox();
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            lblDifficulty = new Label();
            cmbDifficulty = new ComboBox();
            btnSave = new Button();
            btnBack = new Button();
            lblOption1 = new Label();
            lblOption2 = new Label();
            lblOption3 = new Label();
            lblOption4 = new Label();
            lblCorrectAnswer = new Label();
            txtOption1 = new TextBox();
            txtOption2 = new TextBox();
            txtOption3 = new TextBox();
            txtOption4 = new TextBox();
            cmbCorrectAnswer = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(329, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Question";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(71, 131);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(106, 20);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question Text";
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestion.Location = new Point(220, 128);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(486, 80);
            txtQuestion.TabIndex = 2;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(220, 317);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(60, 20);
            lblSubject.TabIndex = 3;
            lblSubject.Text = "Subject";
            // 
            // cmbSubject
            // 
            cmbSubject.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Computer Science", "Programming", "Database" });
            cmbSubject.Location = new Point(296, 314);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(142, 28);
            cmbSubject.TabIndex = 4;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(484, 317);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(74, 20);
            lblDifficulty.TabIndex = 5;
            lblDifficulty.Text = "Difficulty";
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.Location = new Point(574, 314);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(132, 28);
            cmbDifficulty.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(484, 473);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(222, 45);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Question";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(220, 473);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(222, 45);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblOption1
            // 
            lblOption1.AutoSize = true;
            lblOption1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption1.Location = new Point(220, 231);
            lblOption1.Name = "lblOption1";
            lblOption1.Size = new Size(70, 20);
            lblOption1.TabIndex = 9;
            lblOption1.Text = "Option 1";
            // 
            // lblOption2
            // 
            lblOption2.AutoSize = true;
            lblOption2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption2.Location = new Point(484, 231);
            lblOption2.Name = "lblOption2";
            lblOption2.Size = new Size(70, 20);
            lblOption2.TabIndex = 10;
            lblOption2.Text = "Option 2";
            // 
            // lblOption3
            // 
            lblOption3.AutoSize = true;
            lblOption3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption3.Location = new Point(220, 267);
            lblOption3.Name = "lblOption3";
            lblOption3.Size = new Size(70, 20);
            lblOption3.TabIndex = 11;
            lblOption3.Text = "Option 3";
            // 
            // lblOption4
            // 
            lblOption4.AutoSize = true;
            lblOption4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption4.Location = new Point(484, 267);
            lblOption4.Name = "lblOption4";
            lblOption4.Size = new Size(70, 20);
            lblOption4.TabIndex = 12;
            lblOption4.Text = "Option 4";
            // 
            // lblCorrectAnswer
            // 
            lblCorrectAnswer.AutoSize = true;
            lblCorrectAnswer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorrectAnswer.Location = new Point(220, 367);
            lblCorrectAnswer.Name = "lblCorrectAnswer";
            lblCorrectAnswer.Size = new Size(117, 20);
            lblCorrectAnswer.TabIndex = 13;
            lblCorrectAnswer.Text = "Correct Answer";
            // 
            // txtOption1
            // 
            txtOption1.Location = new Point(296, 232);
            txtOption1.Name = "txtOption1";
            txtOption1.Size = new Size(142, 23);
            txtOption1.TabIndex = 14;
            // 
            // txtOption2
            // 
            txtOption2.Location = new Point(574, 232);
            txtOption2.Name = "txtOption2";
            txtOption2.Size = new Size(132, 23);
            txtOption2.TabIndex = 15;
            // 
            // txtOption3
            // 
            txtOption3.Location = new Point(296, 267);
            txtOption3.Name = "txtOption3";
            txtOption3.Size = new Size(142, 23);
            txtOption3.TabIndex = 16;
            // 
            // txtOption4
            // 
            txtOption4.Location = new Point(574, 267);
            txtOption4.Name = "txtOption4";
            txtOption4.Size = new Size(132, 23);
            txtOption4.TabIndex = 17;
            // 
            // cmbCorrectAnswer
            // 
            cmbCorrectAnswer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCorrectAnswer.FormattingEnabled = true;
            cmbCorrectAnswer.Items.AddRange(new object[] { "Option 1", "Option 2", "Option 3", "Option 4" });
            cmbCorrectAnswer.Location = new Point(343, 368);
            cmbCorrectAnswer.Name = "cmbCorrectAnswer";
            cmbCorrectAnswer.Size = new Size(95, 23);
            cmbCorrectAnswer.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(884, 561);
            Controls.Add(cmbCorrectAnswer);
            Controls.Add(txtOption4);
            Controls.Add(txtOption3);
            Controls.Add(txtOption2);
            Controls.Add(txtOption1);
            Controls.Add(lblCorrectAnswer);
            Controls.Add(lblOption4);
            Controls.Add(lblOption3);
            Controls.Add(lblOption2);
            Controls.Add(lblOption1);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(cmbDifficulty);
            Controls.Add(lblDifficulty);
            Controls.Add(cmbSubject);
            Controls.Add(lblSubject);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestion);
            Controls.Add(lblTitle);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Question";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuestion;
        private TextBox txtQuestion;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblDifficulty;
        private ComboBox cmbDifficulty;
        private Button btnSave;
        private Button btnBack;
        private Label lblOption1;
        private Label lblOption2;
        private Label lblOption3;
        private Label lblOption4;
        private Label lblCorrectAnswer;
        private TextBox txtOption1;
        private TextBox txtOption2;
        private TextBox txtOption3;
        private TextBox txtOption4;
        private ComboBox cmbCorrectAnswer;
    }
}
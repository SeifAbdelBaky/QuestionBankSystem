namespace QuestionBankSystem
{
    partial class Form4
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
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            lblDifficulty = new Label();
            cmbDifficulty = new ComboBox();
            btnStartQuiz = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(330, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Take a Quiz";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(92, 191);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(60, 20);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Subject";
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Computer Science", "Programming", "Database" });
            cmbSubject.Location = new Point(174, 188);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(180, 23);
            cmbSubject.TabIndex = 2;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(418, 187);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(74, 20);
            lblDifficulty.TabIndex = 3;
            lblDifficulty.Text = "Difficulty";
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.Location = new Point(513, 184);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(180, 23);
            cmbDifficulty.TabIndex = 4;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.BackColor = Color.DarkSlateGray;
            btnStartQuiz.FlatStyle = FlatStyle.Flat;
            btnStartQuiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQuiz.ForeColor = Color.White;
            btnStartQuiz.Location = new Point(321, 347);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(180, 45);
            btnStartQuiz.TabIndex = 5;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = false;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(884, 561);
            Controls.Add(btnStartQuiz);
            Controls.Add(cmbDifficulty);
            Controls.Add(lblDifficulty);
            Controls.Add(cmbSubject);
            Controls.Add(lblSubject);
            Controls.Add(lblTitle);
            Name = "Form4";
            Text = "Take a Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblDifficulty;
        private ComboBox cmbDifficulty;
        private Button btnStartQuiz;
    }
}
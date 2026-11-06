namespace QuestionBankSystem
{
    partial class Form5
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
            rdoOption1 = new RadioButton();
            rdoOption2 = new RadioButton();
            rdoOption3 = new RadioButton();
            rdoOption4 = new RadioButton();
            btnNext = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(329, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quiz Questions";
            // 
            // lblQuestion
            // 
            lblQuestion.BorderStyle = BorderStyle.FixedSingle;
            lblQuestion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(83, 121);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(700, 80);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question will appear here";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdoOption1
            // 
            rdoOption1.AutoSize = true;
            rdoOption1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoOption1.Location = new Point(235, 240);
            rdoOption1.Name = "rdoOption1";
            rdoOption1.Size = new Size(89, 25);
            rdoOption1.TabIndex = 2;
            rdoOption1.TabStop = true;
            rdoOption1.Text = "Option 1";
            rdoOption1.UseVisualStyleBackColor = true;
            // 
            // rdoOption2
            // 
            rdoOption2.AutoSize = true;
            rdoOption2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoOption2.Location = new Point(510, 240);
            rdoOption2.Name = "rdoOption2";
            rdoOption2.Size = new Size(89, 25);
            rdoOption2.TabIndex = 3;
            rdoOption2.TabStop = true;
            rdoOption2.Text = "Option 2";
            rdoOption2.UseVisualStyleBackColor = true;
            // 
            // rdoOption3
            // 
            rdoOption3.AutoSize = true;
            rdoOption3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoOption3.Location = new Point(235, 290);
            rdoOption3.Name = "rdoOption3";
            rdoOption3.Size = new Size(89, 25);
            rdoOption3.TabIndex = 4;
            rdoOption3.TabStop = true;
            rdoOption3.Text = "Option 3";
            rdoOption3.UseVisualStyleBackColor = true;
            // 
            // rdoOption4
            // 
            rdoOption4.AutoSize = true;
            rdoOption4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoOption4.Location = new Point(510, 290);
            rdoOption4.Name = "rdoOption4";
            rdoOption4.Size = new Size(89, 25);
            rdoOption4.TabIndex = 5;
            rdoOption4.TabStop = true;
            rdoOption4.Text = "Option 4";
            rdoOption4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DarkSlateGray;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(432, 416);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(138, 45);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkSlateGray;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(267, 416);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 45);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(884, 561);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(rdoOption4);
            Controls.Add(rdoOption3);
            Controls.Add(rdoOption2);
            Controls.Add(rdoOption1);
            Controls.Add(lblQuestion);
            Controls.Add(lblTitle);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz Questions";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuestion;
        private RadioButton rdoOption1;
        private RadioButton rdoOption2;
        private RadioButton rdoOption3;
        private RadioButton rdoOption4;
        private Button btnNext;
        private Button btnBack;
    }
}
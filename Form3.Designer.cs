namespace QuestionBankSystem
{
    partial class Form3
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            lblDifficulty = new Label();
            cmbDifficulty = new ComboBox();
            lstQuestions = new ListBox();
            btnShowAll = new Button();
            btnBack = new Button();
            btnFilter = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(52, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Question Bank";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(52, 113);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(122, 20);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Question";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(215, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(627, 110);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 27);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(52, 166);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(60, 20);
            lblSubject.TabIndex = 4;
            lblSubject.Text = "Subject";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Computer Science", "Programming", "Database" });
            cmbSubject.Location = new Point(215, 163);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 5;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(52, 212);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(74, 20);
            lblDifficulty.TabIndex = 6;
            lblDifficulty.Text = "Difficulty";
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.Location = new Point(215, 209);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(121, 23);
            cmbDifficulty.TabIndex = 7;
            // 
            // lstQuestions
            // 
            lstQuestions.FormattingEnabled = true;
            lstQuestions.Location = new Point(52, 260);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(650, 244);
            lstQuestions.TabIndex = 8;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(627, 522);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 27);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(52, 522);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 27);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(627, 205);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 27);
            btnFilter.TabIndex = 11;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(btnFilter);
            Controls.Add(btnBack);
            Controls.Add(btnShowAll);
            Controls.Add(lstQuestions);
            Controls.Add(cmbDifficulty);
            Controls.Add(lblDifficulty);
            Controls.Add(cmbSubject);
            Controls.Add(lblSubject);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblTitle);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question Bank";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblDifficulty;
        private ComboBox cmbDifficulty;
        private ListBox lstQuestions;
        private Button btnShowAll;
        private Button btnBack;
        private Button btnFilter;
    }
}
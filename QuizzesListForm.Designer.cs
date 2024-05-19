namespace proiect_ip
{
    partial class QuizzesListForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.listViewQuizes = new System.Windows.Forms.ListView();
            this.labelQuizTitle = new System.Windows.Forms.Label();
            this.labelQuizQuestions = new System.Windows.Forms.Label();
            this.labelQuizDuration = new System.Windows.Forms.Label();
            this.buttonOpenQuiz = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(353, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(366, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Selectează un Quiz";
            // 
            // listViewQuizes
            // 
            this.listViewQuizes.HideSelection = false;
            this.listViewQuizes.Location = new System.Drawing.Point(35, 143);
            this.listViewQuizes.Name = "listViewQuizes";
            this.listViewQuizes.Size = new System.Drawing.Size(1073, 384);
            this.listViewQuizes.TabIndex = 1;
            this.listViewQuizes.UseCompatibleStateImageBehavior = false;
            // 
            // labelQuizTitle
            // 
            this.labelQuizTitle.AutoSize = true;
            this.labelQuizTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizTitle.Location = new System.Drawing.Point(30, 550);
            this.labelQuizTitle.Name = "labelQuizTitle";
            this.labelQuizTitle.Size = new System.Drawing.Size(107, 25);
            this.labelQuizTitle.TabIndex = 2;
            this.labelQuizTitle.Text = "Quiz: {title}";
            // 
            // labelQuizQuestions
            // 
            this.labelQuizQuestions.AutoSize = true;
            this.labelQuizQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizQuestions.Location = new System.Drawing.Point(30, 593);
            this.labelQuizQuestions.Name = "labelQuizQuestions";
            this.labelQuizQuestions.Size = new System.Drawing.Size(302, 25);
            this.labelQuizQuestions.TabIndex = 3;
            this.labelQuizQuestions.Text = "Questions: {numberOfQuestions}";
            // 
            // labelQuizDuration
            // 
            this.labelQuizDuration.AutoSize = true;
            this.labelQuizDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizDuration.Location = new System.Drawing.Point(30, 634);
            this.labelQuizDuration.Name = "labelQuizDuration";
            this.labelQuizDuration.Size = new System.Drawing.Size(160, 25);
            this.labelQuizDuration.TabIndex = 4;
            this.labelQuizDuration.Text = "Duration: {x} : {y}";
            // 
            // buttonOpenQuiz
            // 
            this.buttonOpenQuiz.Location = new System.Drawing.Point(967, 593);
            this.buttonOpenQuiz.Name = "buttonOpenQuiz";
            this.buttonOpenQuiz.Size = new System.Drawing.Size(141, 48);
            this.buttonOpenQuiz.TabIndex = 5;
            this.buttonOpenQuiz.Text = "Open";
            this.buttonOpenQuiz.UseVisualStyleBackColor = true;
            this.buttonOpenQuiz.Click += new System.EventHandler(this.buttonOpenQuiz_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(797, 593);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 48);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // QuizesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 694);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOpenQuiz);
            this.Controls.Add(this.labelQuizDuration);
            this.Controls.Add(this.labelQuizQuestions);
            this.Controls.Add(this.labelQuizTitle);
            this.Controls.Add(this.listViewQuizes);
            this.Controls.Add(this.labelTitle);
            this.Name = "QuizesListForm";
            this.Text = "QuizesListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listViewQuizes;
        private System.Windows.Forms.Label labelQuizTitle;
        private System.Windows.Forms.Label labelQuizQuestions;
        private System.Windows.Forms.Label labelQuizDuration;
        private System.Windows.Forms.Button buttonOpenQuiz;
        private System.Windows.Forms.Button buttonBack;
    }
}
﻿namespace proiect_ip
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelCurrentQuestion = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.groupBoxAnswers = new System.Windows.Forms.GroupBox();
            this.buttonAnswer4 = new System.Windows.Forms.Button();
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuizTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxQuestion.SuspendLayout();
            this.groupBoxAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSubmit);
            this.groupBox1.Controls.Add(this.labelCurrentQuestion);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.buttonBack);
            this.groupBox1.Controls.Add(this.groupBoxQuestion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelQuizTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1241, 900);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(1053, 798);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(171, 48);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelCurrentQuestion
            // 
            this.labelCurrentQuestion.AutoSize = true;
            this.labelCurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentQuestion.Location = new System.Drawing.Point(15, 814);
            this.labelCurrentQuestion.Name = "labelCurrentQuestion";
            this.labelCurrentQuestion.Size = new System.Drawing.Size(230, 32);
            this.labelCurrentQuestion.TabIndex = 5;
            this.labelCurrentQuestion.Text = "Question: {x} / {y}";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(605, 798);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(171, 48);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(412, 798);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(171, 48);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Previous";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.AutoSize = true;
            this.groupBoxQuestion.Controls.Add(this.groupBoxAnswers);
            this.groupBoxQuestion.Controls.Add(this.textBoxQuestion);
            this.groupBoxQuestion.Location = new System.Drawing.Point(12, 80);
            this.groupBoxQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxQuestion.Size = new System.Drawing.Size(1220, 710);
            this.groupBoxQuestion.TabIndex = 2;
            this.groupBoxQuestion.TabStop = false;
            // 
            // groupBoxAnswers
            // 
            this.groupBoxAnswers.Controls.Add(this.buttonAnswer4);
            this.groupBoxAnswers.Controls.Add(this.buttonAnswer3);
            this.groupBoxAnswers.Controls.Add(this.buttonAnswer2);
            this.groupBoxAnswers.Controls.Add(this.buttonAnswer1);
            this.groupBoxAnswers.Location = new System.Drawing.Point(5, 428);
            this.groupBoxAnswers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAnswers.Name = "groupBoxAnswers";
            this.groupBoxAnswers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAnswers.Size = new System.Drawing.Size(1208, 258);
            this.groupBoxAnswers.TabIndex = 1;
            this.groupBoxAnswers.TabStop = false;
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAnswer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer4.ForeColor = System.Drawing.Color.White;
            this.buttonAnswer4.Location = new System.Drawing.Point(3, 197);
            this.buttonAnswer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(1202, 60);
            this.buttonAnswer4.TabIndex = 3;
            this.buttonAnswer4.Text = "D) Answer 4";
            this.buttonAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswer4.UseVisualStyleBackColor = false;
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAnswer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer3.ForeColor = System.Drawing.Color.White;
            this.buttonAnswer3.Location = new System.Drawing.Point(3, 137);
            this.buttonAnswer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(1202, 60);
            this.buttonAnswer3.TabIndex = 2;
            this.buttonAnswer3.Text = "C) Answer 3";
            this.buttonAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswer3.UseVisualStyleBackColor = false;
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAnswer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer2.ForeColor = System.Drawing.Color.White;
            this.buttonAnswer2.Location = new System.Drawing.Point(3, 77);
            this.buttonAnswer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(1202, 60);
            this.buttonAnswer2.TabIndex = 1;
            this.buttonAnswer2.Text = "B) Answer 2";
            this.buttonAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswer2.UseVisualStyleBackColor = false;
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAnswer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer1.ForeColor = System.Drawing.Color.White;
            this.buttonAnswer1.Location = new System.Drawing.Point(3, 17);
            this.buttonAnswer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(1202, 60);
            this.buttonAnswer1.TabIndex = 0;
            this.buttonAnswer1.Text = "A) Answer 1";
            this.buttonAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswer1.UseVisualStyleBackColor = false;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxQuestion.HideSelection = false;
            this.textBoxQuestion.Location = new System.Drawing.Point(3, 17);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(1214, 404);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.Text = resources.GetString("textBoxQuestion.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(950, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Left: {x}:{y}";
            // 
            // labelQuizTitle
            // 
            this.labelQuizTitle.AutoSize = true;
            this.labelQuizTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelQuizTitle.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelQuizTitle.Location = new System.Drawing.Point(3, 17);
            this.labelQuizTitle.Name = "labelQuizTitle";
            this.labelQuizTitle.Size = new System.Drawing.Size(334, 59);
            this.labelQuizTitle.TabIndex = 0;
            this.labelQuizTitle.Text = "Quiz Application";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1241, 856);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuizForm";
            this.Text = "QuizForm-App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            this.groupBoxAnswers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label labelQuizTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        public System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.GroupBox groupBoxAnswers;
        public System.Windows.Forms.Button buttonAnswer4;
        public System.Windows.Forms.Button buttonAnswer3;
        public System.Windows.Forms.Button buttonAnswer2;
        public System.Windows.Forms.Button buttonAnswer1;
        public System.Windows.Forms.Button buttonSubmit;
        public System.Windows.Forms.Label labelCurrentQuestion;
        public System.Windows.Forms.Button buttonNext;
        public System.Windows.Forms.Button buttonBack;
    }
}

namespace proiect_ip
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.listViewQuizes = new System.Windows.Forms.ListView();
            this.listViewQuestions = new System.Windows.Forms.ListView();
            this.textBoxIntrebare = new System.Windows.Forms.TextBox();
            this.textBoxRaspuns1 = new System.Windows.Forms.TextBox();
            this.textBoxRaspuns2 = new System.Windows.Forms.TextBox();
            this.textBoxRaspuns3 = new System.Windows.Forms.TextBox();
            this.textBoxRaspuns4 = new System.Windows.Forms.TextBox();
            this.EditQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StergeIntrebareaButton = new System.Windows.Forms.Button();
            this.textBoxTitluQuizz = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRaspuns4 = new System.Windows.Forms.CheckBox();
            this.checkBoxRaspuns3 = new System.Windows.Forms.CheckBox();
            this.checkBoxRaspuns2 = new System.Windows.Forms.CheckBox();
            this.checkBoxRaspuns1 = new System.Windows.Forms.CheckBox();
            this.buttonAdaugaIntrebare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteQuizButton = new System.Windows.Forms.Button();
            this.buttonAdaugaQuizz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewQuizes
            // 
            this.listViewQuizes.HideSelection = false;
            this.listViewQuizes.Location = new System.Drawing.Point(41, 48);
            this.listViewQuizes.Name = "listViewQuizes";
            this.listViewQuizes.Size = new System.Drawing.Size(284, 199);
            this.listViewQuizes.TabIndex = 1;
            this.listViewQuizes.UseCompatibleStateImageBehavior = false;
            this.listViewQuizes.SelectedIndexChanged += new System.EventHandler(this.listViewQuizes_SelectedIndexChanged);
            // 
            // listViewQuestions
            // 
            this.listViewQuestions.HideSelection = false;
            this.listViewQuestions.Location = new System.Drawing.Point(512, 48);
            this.listViewQuestions.Name = "listViewQuestions";
            this.listViewQuestions.Size = new System.Drawing.Size(270, 199);
            this.listViewQuestions.TabIndex = 2;
            this.listViewQuestions.UseCompatibleStateImageBehavior = false;
            this.listViewQuestions.SelectedIndexChanged += new System.EventHandler(this.listViewQuestions_SelectedIndexChanged);
            // 
            // textBoxIntrebare
            // 
            this.textBoxIntrebare.Location = new System.Drawing.Point(595, 293);
            this.textBoxIntrebare.Name = "textBoxIntrebare";
            this.textBoxIntrebare.Size = new System.Drawing.Size(187, 20);
            this.textBoxIntrebare.TabIndex = 3;
            // 
            // textBoxRaspuns1
            // 
            this.textBoxRaspuns1.Location = new System.Drawing.Point(595, 346);
            this.textBoxRaspuns1.Name = "textBoxRaspuns1";
            this.textBoxRaspuns1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaspuns1.TabIndex = 4;
            // 
            // textBoxRaspuns2
            // 
            this.textBoxRaspuns2.Location = new System.Drawing.Point(595, 397);
            this.textBoxRaspuns2.Name = "textBoxRaspuns2";
            this.textBoxRaspuns2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaspuns2.TabIndex = 5;
            // 
            // textBoxRaspuns3
            // 
            this.textBoxRaspuns3.Location = new System.Drawing.Point(595, 445);
            this.textBoxRaspuns3.Name = "textBoxRaspuns3";
            this.textBoxRaspuns3.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaspuns3.TabIndex = 6;
            // 
            // textBoxRaspuns4
            // 
            this.textBoxRaspuns4.Location = new System.Drawing.Point(595, 488);
            this.textBoxRaspuns4.Name = "textBoxRaspuns4";
            this.textBoxRaspuns4.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaspuns4.TabIndex = 7;
            // 
            // EditQuestion
            // 
            this.EditQuestion.Location = new System.Drawing.Point(273, 63);
            this.EditQuestion.Name = "EditQuestion";
            this.EditQuestion.Size = new System.Drawing.Size(75, 42);
            this.EditQuestion.TabIndex = 8;
            this.EditQuestion.Text = "Modifica intrebarea";
            this.EditQuestion.UseVisualStyleBackColor = true;
            this.EditQuestion.Click += new System.EventHandler(this.EditQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Intrebare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Raspuns 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Raspuns 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Raspuns 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Raspuns 4:";
            // 
            // StergeIntrebareaButton
            // 
            this.StergeIntrebareaButton.Location = new System.Drawing.Point(273, 129);
            this.StergeIntrebareaButton.Name = "StergeIntrebareaButton";
            this.StergeIntrebareaButton.Size = new System.Drawing.Size(75, 49);
            this.StergeIntrebareaButton.TabIndex = 14;
            this.StergeIntrebareaButton.Text = "Sterge intrebarea selectata";
            this.StergeIntrebareaButton.UseVisualStyleBackColor = true;
            this.StergeIntrebareaButton.Click += new System.EventHandler(this.StergeIntrebareaButton_Click);
            // 
            // textBoxTitluQuizz
            // 
            this.textBoxTitluQuizz.Location = new System.Drawing.Point(68, 36);
            this.textBoxTitluQuizz.Name = "textBoxTitluQuizz";
            this.textBoxTitluQuizz.Size = new System.Drawing.Size(116, 20);
            this.textBoxTitluQuizz.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRaspuns4);
            this.groupBox1.Controls.Add(this.checkBoxRaspuns3);
            this.groupBox1.Controls.Add(this.checkBoxRaspuns2);
            this.groupBox1.Controls.Add(this.checkBoxRaspuns1);
            this.groupBox1.Controls.Add(this.buttonAdaugaIntrebare);
            this.groupBox1.Controls.Add(this.StergeIntrebareaButton);
            this.groupBox1.Controls.Add(this.EditQuestion);
            this.groupBox1.Location = new System.Drawing.Point(503, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 273);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intrebari";
            // 
            // checkBoxRaspuns4
            // 
            this.checkBoxRaspuns4.AutoSize = true;
            this.checkBoxRaspuns4.Location = new System.Drawing.Point(199, 220);
            this.checkBoxRaspuns4.Name = "checkBoxRaspuns4";
            this.checkBoxRaspuns4.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRaspuns4.TabIndex = 22;
            this.checkBoxRaspuns4.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaspuns3
            // 
            this.checkBoxRaspuns3.AutoSize = true;
            this.checkBoxRaspuns3.Location = new System.Drawing.Point(199, 177);
            this.checkBoxRaspuns3.Name = "checkBoxRaspuns3";
            this.checkBoxRaspuns3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRaspuns3.TabIndex = 21;
            this.checkBoxRaspuns3.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaspuns2
            // 
            this.checkBoxRaspuns2.AutoSize = true;
            this.checkBoxRaspuns2.Location = new System.Drawing.Point(199, 129);
            this.checkBoxRaspuns2.Name = "checkBoxRaspuns2";
            this.checkBoxRaspuns2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRaspuns2.TabIndex = 20;
            this.checkBoxRaspuns2.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaspuns1
            // 
            this.checkBoxRaspuns1.AutoSize = true;
            this.checkBoxRaspuns1.Location = new System.Drawing.Point(199, 78);
            this.checkBoxRaspuns1.Name = "checkBoxRaspuns1";
            this.checkBoxRaspuns1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRaspuns1.TabIndex = 19;
            this.checkBoxRaspuns1.UseVisualStyleBackColor = true;
            // 
            // buttonAdaugaIntrebare
            // 
            this.buttonAdaugaIntrebare.Location = new System.Drawing.Point(273, 203);
            this.buttonAdaugaIntrebare.Name = "buttonAdaugaIntrebare";
            this.buttonAdaugaIntrebare.Size = new System.Drawing.Size(75, 46);
            this.buttonAdaugaIntrebare.TabIndex = 18;
            this.buttonAdaugaIntrebare.Text = "Adauga intrebarea";
            this.buttonAdaugaIntrebare.UseVisualStyleBackColor = true;
            this.buttonAdaugaIntrebare.Click += new System.EventHandler(this.buttonAdaugaIntrebare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteQuizButton);
            this.groupBox2.Controls.Add(this.buttonAdaugaQuizz);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxTitluQuizz);
            this.groupBox2.Location = new System.Drawing.Point(41, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 135);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quizz";
            // 
            // DeleteQuizButton
            // 
            this.DeleteQuizButton.Location = new System.Drawing.Point(96, 101);
            this.DeleteQuizButton.Name = "DeleteQuizButton";
            this.DeleteQuizButton.Size = new System.Drawing.Size(88, 28);
            this.DeleteQuizButton.TabIndex = 18;
            this.DeleteQuizButton.Text = "Sterge";
            this.DeleteQuizButton.UseVisualStyleBackColor = true;
            this.DeleteQuizButton.Click += new System.EventHandler(this.DeleteQuizButton_Click);
            // 
            // buttonAdaugaQuizz
            // 
            this.buttonAdaugaQuizz.Location = new System.Drawing.Point(96, 67);
            this.buttonAdaugaQuizz.Name = "buttonAdaugaQuizz";
            this.buttonAdaugaQuizz.Size = new System.Drawing.Size(88, 28);
            this.buttonAdaugaQuizz.TabIndex = 17;
            this.buttonAdaugaQuizz.Text = "Adauga";
            this.buttonAdaugaQuizz.UseVisualStyleBackColor = true;
            this.buttonAdaugaQuizz.Click += new System.EventHandler(this.buttonAdaugaQuizz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Titlu:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRaspuns4);
            this.Controls.Add(this.textBoxRaspuns3);
            this.Controls.Add(this.textBoxRaspuns2);
            this.Controls.Add(this.textBoxRaspuns1);
            this.Controls.Add(this.textBoxIntrebare);
            this.Controls.Add(this.listViewQuestions);
            this.Controls.Add(this.listViewQuizes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panou admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewQuizes;
        private System.Windows.Forms.ListView listViewQuestions;
        private System.Windows.Forms.TextBox textBoxIntrebare;
        private System.Windows.Forms.TextBox textBoxRaspuns1;
        private System.Windows.Forms.TextBox textBoxRaspuns2;
        private System.Windows.Forms.TextBox textBoxRaspuns3;
        private System.Windows.Forms.TextBox textBoxRaspuns4;
        private System.Windows.Forms.Button EditQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StergeIntrebareaButton;
        private System.Windows.Forms.TextBox textBoxTitluQuizz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAdaugaQuizz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdaugaIntrebare;
        private System.Windows.Forms.CheckBox checkBoxRaspuns4;
        private System.Windows.Forms.CheckBox checkBoxRaspuns3;
        private System.Windows.Forms.CheckBox checkBoxRaspuns2;
        private System.Windows.Forms.CheckBox checkBoxRaspuns1;
        private System.Windows.Forms.Button DeleteQuizButton;
    }
}
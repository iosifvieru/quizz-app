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
            this.textBoxIntrebare.Location = new System.Drawing.Point(547, 290);
            this.textBoxIntrebare.Name = "textBoxIntrebare";
            this.textBoxIntrebare.Size = new System.Drawing.Size(187, 20);
            this.textBoxIntrebare.TabIndex = 3;
            // 
            // textBoxRaspuns1
            // 
            this.textBoxRaspuns1.Location = new System.Drawing.Point(547, 350);
            this.textBoxRaspuns1.Name = "textBoxRaspuns1";
            this.textBoxRaspuns1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaspuns1.TabIndex = 4;
            // 
            // textBoxRaspuns2
            // 
            this.textBoxRaspuns2.Location = new System.Drawing.Point(547, 397);
            this.textBoxRaspuns2.Name = "textBoxRaspuns2";
            this.textBoxRaspuns2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaspuns2.TabIndex = 5;
            // 
            // textBoxRaspuns3
            // 
            this.textBoxRaspuns3.Location = new System.Drawing.Point(547, 445);
            this.textBoxRaspuns3.Name = "textBoxRaspuns3";
            this.textBoxRaspuns3.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaspuns3.TabIndex = 6;
            // 
            // textBoxRaspuns4
            // 
            this.textBoxRaspuns4.Location = new System.Drawing.Point(547, 488);
            this.textBoxRaspuns4.Name = "textBoxRaspuns4";
            this.textBoxRaspuns4.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaspuns4.TabIndex = 7;
            // 
            // EditQuestion
            // 
            this.EditQuestion.Location = new System.Drawing.Point(707, 353);
            this.EditQuestion.Name = "EditQuestion";
            this.EditQuestion.Size = new System.Drawing.Size(75, 53);
            this.EditQuestion.TabIndex = 8;
            this.EditQuestion.Text = "Modifica intrebarea";
            this.EditQuestion.UseVisualStyleBackColor = true;
            this.EditQuestion.Click += new System.EventHandler(this.EditQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Intrebare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Raspuns 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Raspuns 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Raspuns 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Raspuns 4:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 571);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditQuestion);
            this.Controls.Add(this.textBoxRaspuns4);
            this.Controls.Add(this.textBoxRaspuns3);
            this.Controls.Add(this.textBoxRaspuns2);
            this.Controls.Add(this.textBoxRaspuns1);
            this.Controls.Add(this.textBoxIntrebare);
            this.Controls.Add(this.listViewQuestions);
            this.Controls.Add(this.listViewQuizes);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
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
    }
}
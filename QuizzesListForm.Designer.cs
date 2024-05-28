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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizzesListForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.buttonAdmin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.labelQuizStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelQuizQuestions = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelQuizTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.listViewQuizes = new System.Windows.Forms.ListView();
            this.labelTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.buttonBack = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.buttonOpenQuiz = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(634, 48);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(318, 47);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Selectează un quiz";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(78, 30);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(92, 25);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Quiz: {title}";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(78, 70);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(275, 25);
            this.bunifuLabel3.TabIndex = 3;
            this.bunifuLabel3.Text = "Questions: {numberOfQuestions}";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(78, 109);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(139, 25);
            this.bunifuLabel4.TabIndex = 4;
            this.bunifuLabel4.Text = "Duration: {x} : {y}";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.buttonAdmin);
            this.bunifuPanel1.Controls.Add(this.labelQuizStatus);
            this.bunifuPanel1.Controls.Add(this.labelQuizQuestions);
            this.bunifuPanel1.Controls.Add(this.labelQuizTitle);
            this.bunifuPanel1.Controls.Add(this.listViewQuizes);
            this.bunifuPanel1.Controls.Add(this.labelTitle);
            this.bunifuPanel1.Controls.Add(this.buttonBack);
            this.bunifuPanel1.Controls.Add(this.buttonOpenQuiz);
            this.bunifuPanel1.Location = new System.Drawing.Point(-8, -4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(933, 700);
            this.bunifuPanel1.TabIndex = 8;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.AllowAnimations = true;
            this.buttonAdmin.AllowMouseEffects = true;
            this.buttonAdmin.AllowToggling = false;
            this.buttonAdmin.AnimationSpeed = 200;
            this.buttonAdmin.AutoGenerateColors = false;
            this.buttonAdmin.AutoRoundBorders = false;
            this.buttonAdmin.AutoSizeLeftIcon = true;
            this.buttonAdmin.AutoSizeRightIcon = true;
            this.buttonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdmin.BackColor1 = System.Drawing.Color.Crimson;
            this.buttonAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.BackgroundImage")));
            this.buttonAdmin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAdmin.ButtonText = "Panou admin";
            this.buttonAdmin.ButtonTextMarginLeft = 0;
            this.buttonAdmin.ColorContrastOnClick = 45;
            this.buttonAdmin.ColorContrastOnHover = 45;
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonAdmin.CustomizableEdges = borderEdges1;
            this.buttonAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonAdmin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonAdmin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonAdmin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonAdmin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonAdmin.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdmin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonAdmin.IconMarginLeft = 11;
            this.buttonAdmin.IconPadding = 10;
            this.buttonAdmin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdmin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdmin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonAdmin.IconSize = 25;
            this.buttonAdmin.IdleBorderColor = System.Drawing.Color.White;
            this.buttonAdmin.IdleBorderRadius = 20;
            this.buttonAdmin.IdleBorderThickness = 1;
            this.buttonAdmin.IdleFillColor = System.Drawing.Color.Crimson;
            this.buttonAdmin.IdleIconLeftImage = null;
            this.buttonAdmin.IdleIconRightImage = null;
            this.buttonAdmin.IndicateFocus = false;
            this.buttonAdmin.Location = new System.Drawing.Point(21, 610);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonAdmin.OnDisabledState.BorderRadius = 20;
            this.buttonAdmin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAdmin.OnDisabledState.BorderThickness = 1;
            this.buttonAdmin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonAdmin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonAdmin.OnDisabledState.IconLeftImage = null;
            this.buttonAdmin.OnDisabledState.IconRightImage = null;
            this.buttonAdmin.onHoverState.BorderColor = System.Drawing.Color.Crimson;
            this.buttonAdmin.onHoverState.BorderRadius = 20;
            this.buttonAdmin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAdmin.onHoverState.BorderThickness = 1;
            this.buttonAdmin.onHoverState.FillColor = System.Drawing.Color.White;
            this.buttonAdmin.onHoverState.ForeColor = System.Drawing.Color.Crimson;
            this.buttonAdmin.onHoverState.IconLeftImage = null;
            this.buttonAdmin.onHoverState.IconRightImage = null;
            this.buttonAdmin.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.buttonAdmin.OnIdleState.BorderRadius = 20;
            this.buttonAdmin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAdmin.OnIdleState.BorderThickness = 1;
            this.buttonAdmin.OnIdleState.FillColor = System.Drawing.Color.Crimson;
            this.buttonAdmin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.OnIdleState.IconLeftImage = null;
            this.buttonAdmin.OnIdleState.IconRightImage = null;
            this.buttonAdmin.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.buttonAdmin.OnPressedState.BorderRadius = 20;
            this.buttonAdmin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonAdmin.OnPressedState.BorderThickness = 1;
            this.buttonAdmin.OnPressedState.FillColor = System.Drawing.Color.Crimson;
            this.buttonAdmin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.OnPressedState.IconLeftImage = null;
            this.buttonAdmin.OnPressedState.IconRightImage = null;
            this.buttonAdmin.Size = new System.Drawing.Size(150, 39);
            this.buttonAdmin.TabIndex = 14;
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdmin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonAdmin.TextMarginLeft = 0;
            this.buttonAdmin.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonAdmin.UseDefaultRadiusAndThickness = true;
            this.buttonAdmin.Click += new System.EventHandler(this.butonAdmin_Click);
            // 
            // labelQuizStatus
            // 
            this.labelQuizStatus.AllowParentOverrides = false;
            this.labelQuizStatus.AutoEllipsis = false;
            this.labelQuizStatus.CursorType = null;
            this.labelQuizStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizStatus.ForeColor = System.Drawing.Color.White;
            this.labelQuizStatus.Location = new System.Drawing.Point(138, 515);
            this.labelQuizStatus.Name = "labelQuizStatus";
            this.labelQuizStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelQuizStatus.Size = new System.Drawing.Size(188, 30);
            this.labelQuizStatus.TabIndex = 12;
            this.labelQuizStatus.Text = "Status: Not Started";
            this.labelQuizStatus.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelQuizStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelQuizQuestions
            // 
            this.labelQuizQuestions.AllowParentOverrides = false;
            this.labelQuizQuestions.AutoEllipsis = false;
            this.labelQuizQuestions.CursorType = null;
            this.labelQuizQuestions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizQuestions.ForeColor = System.Drawing.Color.White;
            this.labelQuizQuestions.Location = new System.Drawing.Point(138, 482);
            this.labelQuizQuestions.Name = "labelQuizQuestions";
            this.labelQuizQuestions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelQuizQuestions.Size = new System.Drawing.Size(325, 30);
            this.labelQuizQuestions.TabIndex = 11;
            this.labelQuizQuestions.Text = "Questions: {numberOfQuestions}";
            this.labelQuizQuestions.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelQuizQuestions.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelQuizTitle
            // 
            this.labelQuizTitle.AllowParentOverrides = false;
            this.labelQuizTitle.AutoEllipsis = false;
            this.labelQuizTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelQuizTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelQuizTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizTitle.ForeColor = System.Drawing.Color.White;
            this.labelQuizTitle.Location = new System.Drawing.Point(138, 442);
            this.labelQuizTitle.Name = "labelQuizTitle";
            this.labelQuizTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelQuizTitle.Size = new System.Drawing.Size(112, 30);
            this.labelQuizTitle.TabIndex = 10;
            this.labelQuizTitle.Text = "Quiz: {title}";
            this.labelQuizTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelQuizTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // listViewQuizes
            // 
            this.listViewQuizes.HideSelection = false;
            this.listViewQuizes.Location = new System.Drawing.Point(138, 115);
            this.listViewQuizes.Margin = new System.Windows.Forms.Padding(2);
            this.listViewQuizes.Name = "listViewQuizes";
            this.listViewQuizes.Scrollable = false;
            this.listViewQuizes.Size = new System.Drawing.Size(650, 300);
            this.listViewQuizes.TabIndex = 9;
            this.listViewQuizes.UseCompatibleStateImageBehavior = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AllowParentOverrides = false;
            this.labelTitle.AutoEllipsis = false;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(307, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitle.Size = new System.Drawing.Size(318, 47);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Selectează un quiz";
            this.labelTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // buttonBack
            // 
            this.buttonBack.AllowAnimations = true;
            this.buttonBack.AllowMouseEffects = true;
            this.buttonBack.AllowToggling = false;
            this.buttonBack.AnimationSpeed = 200;
            this.buttonBack.AutoGenerateColors = false;
            this.buttonBack.AutoRoundBorders = false;
            this.buttonBack.AutoSizeLeftIcon = true;
            this.buttonBack.AutoSizeRightIcon = true;
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackColor1 = System.Drawing.Color.Navy;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonBack.ButtonText = "Înapoi";
            this.buttonBack.ButtonTextMarginLeft = 0;
            this.buttonBack.ColorContrastOnClick = 45;
            this.buttonBack.ColorContrastOnHover = 45;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonBack.CustomizableEdges = borderEdges2;
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonBack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonBack.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonBack.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonBack.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonBack.IconMarginLeft = 11;
            this.buttonBack.IconPadding = 10;
            this.buttonBack.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonBack.IconSize = 25;
            this.buttonBack.IdleBorderColor = System.Drawing.Color.White;
            this.buttonBack.IdleBorderRadius = 20;
            this.buttonBack.IdleBorderThickness = 1;
            this.buttonBack.IdleFillColor = System.Drawing.Color.Navy;
            this.buttonBack.IdleIconLeftImage = null;
            this.buttonBack.IdleIconRightImage = null;
            this.buttonBack.IndicateFocus = false;
            this.buttonBack.Location = new System.Drawing.Point(599, 610);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonBack.OnDisabledState.BorderRadius = 20;
            this.buttonBack.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonBack.OnDisabledState.BorderThickness = 1;
            this.buttonBack.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonBack.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonBack.OnDisabledState.IconLeftImage = null;
            this.buttonBack.OnDisabledState.IconRightImage = null;
            this.buttonBack.onHoverState.BorderColor = System.Drawing.Color.Navy;
            this.buttonBack.onHoverState.BorderRadius = 20;
            this.buttonBack.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonBack.onHoverState.BorderThickness = 1;
            this.buttonBack.onHoverState.FillColor = System.Drawing.Color.White;
            this.buttonBack.onHoverState.ForeColor = System.Drawing.Color.Navy;
            this.buttonBack.onHoverState.IconLeftImage = null;
            this.buttonBack.onHoverState.IconRightImage = null;
            this.buttonBack.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.buttonBack.OnIdleState.BorderRadius = 20;
            this.buttonBack.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonBack.OnIdleState.BorderThickness = 1;
            this.buttonBack.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.buttonBack.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonBack.OnIdleState.IconLeftImage = null;
            this.buttonBack.OnIdleState.IconRightImage = null;
            this.buttonBack.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.buttonBack.OnPressedState.BorderRadius = 20;
            this.buttonBack.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonBack.OnPressedState.BorderThickness = 1;
            this.buttonBack.OnPressedState.FillColor = System.Drawing.Color.Navy;
            this.buttonBack.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonBack.OnPressedState.IconLeftImage = null;
            this.buttonBack.OnPressedState.IconRightImage = null;
            this.buttonBack.Size = new System.Drawing.Size(150, 39);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonBack.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonBack.TextMarginLeft = 0;
            this.buttonBack.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonBack.UseDefaultRadiusAndThickness = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOpenQuiz
            // 
            this.buttonOpenQuiz.AllowAnimations = true;
            this.buttonOpenQuiz.AllowMouseEffects = true;
            this.buttonOpenQuiz.AllowToggling = false;
            this.buttonOpenQuiz.AnimationSpeed = 200;
            this.buttonOpenQuiz.AutoGenerateColors = false;
            this.buttonOpenQuiz.AutoRoundBorders = false;
            this.buttonOpenQuiz.AutoSizeLeftIcon = true;
            this.buttonOpenQuiz.AutoSizeRightIcon = true;
            this.buttonOpenQuiz.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenQuiz.BackColor1 = System.Drawing.Color.Navy;
            this.buttonOpenQuiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenQuiz.BackgroundImage")));
            this.buttonOpenQuiz.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonOpenQuiz.ButtonText = "Deschide";
            this.buttonOpenQuiz.ButtonTextMarginLeft = 0;
            this.buttonOpenQuiz.ColorContrastOnClick = 45;
            this.buttonOpenQuiz.ColorContrastOnHover = 45;
            this.buttonOpenQuiz.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.buttonOpenQuiz.CustomizableEdges = borderEdges3;
            this.buttonOpenQuiz.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonOpenQuiz.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonOpenQuiz.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonOpenQuiz.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonOpenQuiz.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonOpenQuiz.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenQuiz.ForeColor = System.Drawing.Color.White;
            this.buttonOpenQuiz.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenQuiz.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenQuiz.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonOpenQuiz.IconMarginLeft = 11;
            this.buttonOpenQuiz.IconPadding = 10;
            this.buttonOpenQuiz.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenQuiz.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenQuiz.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonOpenQuiz.IconSize = 25;
            this.buttonOpenQuiz.IdleBorderColor = System.Drawing.Color.White;
            this.buttonOpenQuiz.IdleBorderRadius = 20;
            this.buttonOpenQuiz.IdleBorderThickness = 1;
            this.buttonOpenQuiz.IdleFillColor = System.Drawing.Color.Navy;
            this.buttonOpenQuiz.IdleIconLeftImage = null;
            this.buttonOpenQuiz.IdleIconRightImage = null;
            this.buttonOpenQuiz.IndicateFocus = false;
            this.buttonOpenQuiz.Location = new System.Drawing.Point(755, 610);
            this.buttonOpenQuiz.Name = "buttonOpenQuiz";
            this.buttonOpenQuiz.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonOpenQuiz.OnDisabledState.BorderRadius = 20;
            this.buttonOpenQuiz.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonOpenQuiz.OnDisabledState.BorderThickness = 1;
            this.buttonOpenQuiz.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonOpenQuiz.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonOpenQuiz.OnDisabledState.IconLeftImage = null;
            this.buttonOpenQuiz.OnDisabledState.IconRightImage = null;
            this.buttonOpenQuiz.onHoverState.BorderColor = System.Drawing.Color.Navy;
            this.buttonOpenQuiz.onHoverState.BorderRadius = 20;
            this.buttonOpenQuiz.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonOpenQuiz.onHoverState.BorderThickness = 1;
            this.buttonOpenQuiz.onHoverState.FillColor = System.Drawing.Color.White;
            this.buttonOpenQuiz.onHoverState.ForeColor = System.Drawing.Color.Navy;
            this.buttonOpenQuiz.onHoverState.IconLeftImage = null;
            this.buttonOpenQuiz.onHoverState.IconRightImage = null;
            this.buttonOpenQuiz.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.buttonOpenQuiz.OnIdleState.BorderRadius = 20;
            this.buttonOpenQuiz.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonOpenQuiz.OnIdleState.BorderThickness = 1;
            this.buttonOpenQuiz.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.buttonOpenQuiz.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonOpenQuiz.OnIdleState.IconLeftImage = null;
            this.buttonOpenQuiz.OnIdleState.IconRightImage = null;
            this.buttonOpenQuiz.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.buttonOpenQuiz.OnPressedState.BorderRadius = 20;
            this.buttonOpenQuiz.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonOpenQuiz.OnPressedState.BorderThickness = 1;
            this.buttonOpenQuiz.OnPressedState.FillColor = System.Drawing.Color.Navy;
            this.buttonOpenQuiz.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonOpenQuiz.OnPressedState.IconLeftImage = null;
            this.buttonOpenQuiz.OnPressedState.IconRightImage = null;
            this.buttonOpenQuiz.Size = new System.Drawing.Size(150, 39);
            this.buttonOpenQuiz.TabIndex = 7;
            this.buttonOpenQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOpenQuiz.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonOpenQuiz.TextMarginLeft = 0;
            this.buttonOpenQuiz.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonOpenQuiz.UseDefaultRadiusAndThickness = true;
            this.buttonOpenQuiz.Click += new System.EventHandler(this.buttonOpenQuiz_Click);
            // 
            // QuizzesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.bunifuPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "QuizzesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista quiz-uri";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonOpenQuiz;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonBack;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel labelTitle;
        private System.Windows.Forms.ListView listViewQuizes;
        private Bunifu.UI.WinForms.BunifuLabel labelQuizStatus;
        private Bunifu.UI.WinForms.BunifuLabel labelQuizQuestions;
        private Bunifu.UI.WinForms.BunifuLabel labelQuizTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonAdmin;
    }
}
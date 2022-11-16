namespace MilionerzyGUI
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.goToNamePanel = new Guna.UI2.WinForms.Guna2Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exitGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.goToSettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.goToLastResultButton = new Guna.UI2.WinForms.Guna2Button();
            this.roundPanel = new System.Windows.Forms.Panel();
            this.answerDButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.answerCButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.answerBButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.answerAButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.questionPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.prizesListView = new System.Windows.Forms.ListView();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.namePanel = new System.Windows.Forms.Panel();
            this.goToGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuPanel.SuspendLayout();
            this.roundPanel.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // goToNamePanel
            // 
            this.goToNamePanel.BackColor = System.Drawing.Color.Transparent;
            this.goToNamePanel.BorderColor = System.Drawing.Color.IndianRed;
            this.goToNamePanel.BorderRadius = 25;
            this.goToNamePanel.BorderThickness = 3;
            this.goToNamePanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToNamePanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToNamePanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToNamePanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToNamePanel.FillColor = System.Drawing.Color.DarkBlue;
            this.goToNamePanel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.goToNamePanel.ForeColor = System.Drawing.Color.White;
            this.goToNamePanel.Location = new System.Drawing.Point(441, 78);
            this.goToNamePanel.Name = "goToNamePanel";
            this.goToNamePanel.Size = new System.Drawing.Size(167, 65);
            this.goToNamePanel.TabIndex = 5;
            this.goToNamePanel.Text = "Rozpocznij grę";
            this.goToNamePanel.UseTransparentBackground = true;
            this.goToNamePanel.Click += new System.EventHandler(this.goToNamePanel_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPanel.BackgroundImage")));
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.exitGameButton);
            this.menuPanel.Controls.Add(this.goToSettingsButton);
            this.menuPanel.Controls.Add(this.goToLastResultButton);
            this.menuPanel.Controls.Add(this.goToNamePanel);
            this.menuPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.menuPanel.Location = new System.Drawing.Point(22, 620);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1024, 600);
            this.menuPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(399, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "Milionerzy";
            // 
            // exitGameButton
            // 
            this.exitGameButton.BackColor = System.Drawing.Color.Transparent;
            this.exitGameButton.BorderColor = System.Drawing.Color.IndianRed;
            this.exitGameButton.BorderRadius = 25;
            this.exitGameButton.BorderThickness = 3;
            this.exitGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitGameButton.FillColor = System.Drawing.Color.DarkBlue;
            this.exitGameButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.exitGameButton.ForeColor = System.Drawing.Color.White;
            this.exitGameButton.Location = new System.Drawing.Point(441, 501);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(167, 65);
            this.exitGameButton.TabIndex = 8;
            this.exitGameButton.Text = "Zakończ grę";
            this.exitGameButton.UseTransparentBackground = true;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // goToSettingsButton
            // 
            this.goToSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.goToSettingsButton.BorderColor = System.Drawing.Color.IndianRed;
            this.goToSettingsButton.BorderRadius = 25;
            this.goToSettingsButton.BorderThickness = 3;
            this.goToSettingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToSettingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToSettingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToSettingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToSettingsButton.FillColor = System.Drawing.Color.DarkBlue;
            this.goToSettingsButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.goToSettingsButton.ForeColor = System.Drawing.Color.White;
            this.goToSettingsButton.Location = new System.Drawing.Point(441, 167);
            this.goToSettingsButton.Name = "goToSettingsButton";
            this.goToSettingsButton.Size = new System.Drawing.Size(167, 65);
            this.goToSettingsButton.TabIndex = 7;
            this.goToSettingsButton.Text = "Ustawienia";
            this.goToSettingsButton.UseTransparentBackground = true;
            // 
            // goToLastResultButton
            // 
            this.goToLastResultButton.BackColor = System.Drawing.Color.Transparent;
            this.goToLastResultButton.BorderColor = System.Drawing.Color.IndianRed;
            this.goToLastResultButton.BorderRadius = 25;
            this.goToLastResultButton.BorderThickness = 3;
            this.goToLastResultButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToLastResultButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToLastResultButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToLastResultButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToLastResultButton.FillColor = System.Drawing.Color.DarkBlue;
            this.goToLastResultButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.goToLastResultButton.ForeColor = System.Drawing.Color.White;
            this.goToLastResultButton.Location = new System.Drawing.Point(443, 248);
            this.goToLastResultButton.Name = "goToLastResultButton";
            this.goToLastResultButton.Size = new System.Drawing.Size(167, 65);
            this.goToLastResultButton.TabIndex = 6;
            this.goToLastResultButton.Text = "Ostatnie wyniki";
            this.goToLastResultButton.UseTransparentBackground = true;
            // 
            // roundPanel
            // 
            this.roundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundPanel.BackgroundImage")));
            this.roundPanel.Controls.Add(this.answerDButton);
            this.roundPanel.Controls.Add(this.answerCButton);
            this.roundPanel.Controls.Add(this.answerBButton);
            this.roundPanel.Controls.Add(this.answerAButton);
            this.roundPanel.Controls.Add(this.questionPanel);
            this.roundPanel.Controls.Add(this.groupBox1);
            this.roundPanel.Location = new System.Drawing.Point(22, 2);
            this.roundPanel.Name = "roundPanel";
            this.roundPanel.Size = new System.Drawing.Size(1024, 600);
            this.roundPanel.TabIndex = 7;
            // 
            // answerDButton
            // 
            this.answerDButton.BackColor = System.Drawing.Color.Transparent;
            this.answerDButton.BorderRadius = 30;
            this.answerDButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.answerDButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.answerDButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.answerDButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.answerDButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.answerDButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.answerDButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.answerDButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answerDButton.ForeColor = System.Drawing.Color.Yellow;
            this.answerDButton.Location = new System.Drawing.Point(492, 488);
            this.answerDButton.Name = "answerDButton";
            this.answerDButton.Size = new System.Drawing.Size(187, 65);
            this.answerDButton.TabIndex = 8;
            this.answerDButton.Click += new System.EventHandler(this.answerDButton_Click);
            // 
            // answerCButton
            // 
            this.answerCButton.BackColor = System.Drawing.Color.Transparent;
            this.answerCButton.BorderRadius = 30;
            this.answerCButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.answerCButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.answerCButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.answerCButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.answerCButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.answerCButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.answerCButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.answerCButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answerCButton.ForeColor = System.Drawing.Color.Yellow;
            this.answerCButton.Location = new System.Drawing.Point(234, 488);
            this.answerCButton.Name = "answerCButton";
            this.answerCButton.Size = new System.Drawing.Size(187, 65);
            this.answerCButton.TabIndex = 7;
            this.answerCButton.Click += new System.EventHandler(this.answerCButton_Click);
            // 
            // answerBButton
            // 
            this.answerBButton.BackColor = System.Drawing.Color.Transparent;
            this.answerBButton.BorderRadius = 30;
            this.answerBButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.answerBButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.answerBButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.answerBButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.answerBButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.answerBButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.answerBButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.answerBButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answerBButton.ForeColor = System.Drawing.Color.Yellow;
            this.answerBButton.Location = new System.Drawing.Point(492, 397);
            this.answerBButton.Name = "answerBButton";
            this.answerBButton.Size = new System.Drawing.Size(187, 65);
            this.answerBButton.TabIndex = 6;
            this.answerBButton.Click += new System.EventHandler(this.answerBButton_Click);
            // 
            // answerAButton
            // 
            this.answerAButton.BackColor = System.Drawing.Color.Transparent;
            this.answerAButton.BorderRadius = 30;
            this.answerAButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.answerAButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.answerAButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.answerAButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.answerAButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.answerAButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.answerAButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.answerAButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answerAButton.ForeColor = System.Drawing.Color.Yellow;
            this.answerAButton.Location = new System.Drawing.Point(234, 397);
            this.answerAButton.Name = "answerAButton";
            this.answerAButton.Size = new System.Drawing.Size(187, 65);
            this.answerAButton.TabIndex = 5;
            this.answerAButton.Click += new System.EventHandler(this.answerAButton_Click);
            // 
            // questionPanel
            // 
            this.questionPanel.BackColor = System.Drawing.Color.Transparent;
            this.questionPanel.BorderColor = System.Drawing.Color.White;
            this.questionPanel.BorderRadius = 70;
            this.questionPanel.Controls.Add(this.questionLabel);
            this.questionPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.questionPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.questionPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.questionPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.questionPanel.Location = new System.Drawing.Point(234, 184);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(445, 121);
            this.questionPanel.TabIndex = 3;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.ForeColor = System.Drawing.Color.Yellow;
            this.questionLabel.Location = new System.Drawing.Point(28, 15);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(379, 90);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Controls.Add(this.guna2CircleButton3);
            this.groupBox1.Controls.Add(this.guna2CircleButton2);
            this.groupBox1.Controls.Add(this.guna2GradientButton1);
            this.groupBox1.Controls.Add(this.prizesListView);
            this.groupBox1.Controls.Add(this.guna2CircleButton1);
            this.groupBox1.Location = new System.Drawing.Point(785, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 600);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton3.Image")));
            this.guna2CircleButton3.ImageSize = new System.Drawing.Size(113, 106);
            this.guna2CircleButton3.Location = new System.Drawing.Point(167, 19);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.Size = new System.Drawing.Size(69, 67);
            this.guna2CircleButton3.TabIndex = 12;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(113, 106);
            this.guna2CircleButton2.Location = new System.Drawing.Point(90, 19);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(69, 67);
            this.guna2CircleButton2.TabIndex = 11;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 30;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Yellow;
            this.guna2GradientButton1.Location = new System.Drawing.Point(33, 131);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(164, 38);
            this.guna2GradientButton1.TabIndex = 10;
            this.guna2GradientButton1.Text = "Zakończ grę";
            // 
            // prizesListView
            // 
            this.prizesListView.BackColor = System.Drawing.Color.DarkBlue;
            this.prizesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesListView.ForeColor = System.Drawing.Color.Yellow;
            this.prizesListView.HideSelection = false;
            this.prizesListView.Location = new System.Drawing.Point(0, 198);
            this.prizesListView.Margin = new System.Windows.Forms.Padding(0);
            this.prizesListView.Name = "prizesListView";
            this.prizesListView.Scrollable = false;
            this.prizesListView.Size = new System.Drawing.Size(236, 399);
            this.prizesListView.TabIndex = 3;
            this.prizesListView.UseCompatibleStateImageBehavior = false;
            this.prizesListView.View = System.Windows.Forms.View.List;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(113, 106);
            this.guna2CircleButton1.Location = new System.Drawing.Point(6, 19);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(69, 67);
            this.guna2CircleButton1.TabIndex = 0;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // namePanel
            // 
            this.namePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("namePanel.BackgroundImage")));
            this.namePanel.Controls.Add(this.goToGameButton);
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Controls.Add(this.guna2HtmlLabel1);
            this.namePanel.Location = new System.Drawing.Point(1062, 2);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(1024, 600);
            this.namePanel.TabIndex = 6;
            this.namePanel.Visible = false;
            // 
            // goToGameButton
            // 
            this.goToGameButton.BackColor = System.Drawing.Color.Transparent;
            this.goToGameButton.BorderColor = System.Drawing.Color.IndianRed;
            this.goToGameButton.BorderRadius = 25;
            this.goToGameButton.BorderThickness = 3;
            this.goToGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToGameButton.FillColor = System.Drawing.Color.DarkBlue;
            this.goToGameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goToGameButton.ForeColor = System.Drawing.Color.White;
            this.goToGameButton.Location = new System.Drawing.Point(418, 228);
            this.goToGameButton.Name = "goToGameButton";
            this.goToGameButton.Size = new System.Drawing.Size(206, 65);
            this.goToGameButton.TabIndex = 6;
            this.goToGameButton.Text = "Kontynuuj";
            this.goToGameButton.UseTransparentBackground = true;
            this.goToGameButton.Click += new System.EventHandler(this.goToGameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.BorderRadius = 23;
            this.nameTextBox.BorderThickness = 3;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Location = new System.Drawing.Point(418, 159);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Podaj nick";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(206, 53);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Tag = "Podaj swój nick";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(452, 228);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = null;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 832);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.roundPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "Milionerzy";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.roundPanel.ResumeLayout(false);
            this.questionPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button goToNamePanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel roundPanel;
        private System.Windows.Forms.Panel namePanel;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button exitGameButton;
        private Guna.UI2.WinForms.Guna2Button goToSettingsButton;
        private Guna.UI2.WinForms.Guna2Button goToLastResultButton;
        private Guna.UI2.WinForms.Guna2Button goToGameButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView prizesListView;
        private Guna.UI2.WinForms.Guna2GradientButton answerAButton;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel questionPanel;
        private Guna.UI2.WinForms.Guna2GradientButton answerDButton;
        private Guna.UI2.WinForms.Guna2GradientButton answerCButton;
        private Guna.UI2.WinForms.Guna2GradientButton answerBButton;
        private System.Windows.Forms.Label questionLabel;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}


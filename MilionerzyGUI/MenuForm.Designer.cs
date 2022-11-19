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
            this.rightToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.askAudienceButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.swapQuestionButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.fiftyButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.endGameButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.prizesListView = new System.Windows.Forms.ListView();
            this.namePanel = new System.Windows.Forms.Panel();
            this.goToGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuPanel.SuspendLayout();
            this.roundPanel.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.rightToolsGroupBox.SuspendLayout();
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
            this.roundPanel.Controls.Add(this.rightToolsGroupBox);
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
            this.answerDButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.answerDButton.ForeColor = System.Drawing.Color.Yellow;
            this.answerDButton.Location = new System.Drawing.Point(492, 488);
            this.answerDButton.Name = "answerDButton";
            this.answerDButton.Size = new System.Drawing.Size(187, 65);
            this.answerDButton.TabIndex = 8;
            this.answerDButton.Click += new System.EventHandler(this.checkAnswerEvent);
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
            this.answerCButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.answerCButton.ForeColor = System.Drawing.Color.Yellow;
            this.answerCButton.Location = new System.Drawing.Point(234, 488);
            this.answerCButton.Name = "answerCButton";
            this.answerCButton.Size = new System.Drawing.Size(187, 65);
            this.answerCButton.TabIndex = 7;
            this.answerCButton.Click += new System.EventHandler(this.checkAnswerEvent);
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
            this.answerBButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.answerBButton.ForeColor = System.Drawing.Color.Yellow;
            this.answerBButton.Location = new System.Drawing.Point(492, 397);
            this.answerBButton.Name = "answerBButton";
            this.answerBButton.Size = new System.Drawing.Size(187, 65);
            this.answerBButton.TabIndex = 6;
            this.answerBButton.Click += new System.EventHandler(this.checkAnswerEvent);
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
            this.answerAButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.answerAButton.ForeColor = System.Drawing.Color.Yellow;
            this.answerAButton.Location = new System.Drawing.Point(234, 397);
            this.answerAButton.Name = "answerAButton";
            this.answerAButton.Size = new System.Drawing.Size(187, 65);
            this.answerAButton.TabIndex = 5;
            this.answerAButton.Click += new System.EventHandler(this.checkAnswerEvent);
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
            this.questionPanel.Location = new System.Drawing.Point(234, 182);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(445, 121);
            this.questionPanel.TabIndex = 3;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.ForeColor = System.Drawing.Color.Yellow;
            this.questionLabel.Location = new System.Drawing.Point(35, 15);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(379, 90);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightToolsGroupBox
            // 
            this.rightToolsGroupBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.rightToolsGroupBox.Controls.Add(this.askAudienceButton);
            this.rightToolsGroupBox.Controls.Add(this.swapQuestionButton);
            this.rightToolsGroupBox.Controls.Add(this.fiftyButton);
            this.rightToolsGroupBox.Controls.Add(this.endGameButton);
            this.rightToolsGroupBox.Controls.Add(this.prizesListView);
            this.rightToolsGroupBox.Location = new System.Drawing.Point(785, 0);
            this.rightToolsGroupBox.Name = "rightToolsGroupBox";
            this.rightToolsGroupBox.Size = new System.Drawing.Size(239, 600);
            this.rightToolsGroupBox.TabIndex = 2;
            this.rightToolsGroupBox.TabStop = false;
            // 
            // askAudienceButton
            // 
            this.askAudienceButton.AutoRoundedCorners = true;
            this.askAudienceButton.BackColor = System.Drawing.Color.Transparent;
            this.askAudienceButton.BorderRadius = 39;
            this.askAudienceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.askAudienceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.askAudienceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.askAudienceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.askAudienceButton.FillColor = System.Drawing.Color.Transparent;
            this.askAudienceButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.askAudienceButton.ForeColor = System.Drawing.Color.White;
            this.askAudienceButton.Image = ((System.Drawing.Image)(resources.GetObject("askAudienceButton.Image")));
            this.askAudienceButton.ImageSize = new System.Drawing.Size(80, 80);
            this.askAudienceButton.Location = new System.Drawing.Point(153, 10);
            this.askAudienceButton.Name = "askAudienceButton";
            this.askAudienceButton.Size = new System.Drawing.Size(83, 80);
            this.askAudienceButton.TabIndex = 12;
            this.askAudienceButton.Tag = "ask";
            this.askAudienceButton.Click += new System.EventHandler(this.helpButtonsEvent);
            // 
            // swapQuestionButton
            // 
            this.swapQuestionButton.AutoRoundedCorners = true;
            this.swapQuestionButton.BackColor = System.Drawing.Color.Transparent;
            this.swapQuestionButton.BorderRadius = 39;
            this.swapQuestionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.swapQuestionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.swapQuestionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.swapQuestionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.swapQuestionButton.FillColor = System.Drawing.Color.Transparent;
            this.swapQuestionButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swapQuestionButton.ForeColor = System.Drawing.Color.White;
            this.swapQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("swapQuestionButton.Image")));
            this.swapQuestionButton.ImageSize = new System.Drawing.Size(80, 80);
            this.swapQuestionButton.Location = new System.Drawing.Point(77, 10);
            this.swapQuestionButton.Name = "swapQuestionButton";
            this.swapQuestionButton.Size = new System.Drawing.Size(83, 80);
            this.swapQuestionButton.TabIndex = 11;
            this.swapQuestionButton.Tag = "swap";
            this.swapQuestionButton.Click += new System.EventHandler(this.helpButtonsEvent);
            // 
            // fiftyButton
            // 
            this.fiftyButton.AutoRoundedCorners = true;
            this.fiftyButton.BackColor = System.Drawing.Color.Transparent;
            this.fiftyButton.BorderRadius = 39;
            this.fiftyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fiftyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fiftyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fiftyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fiftyButton.FillColor = System.Drawing.Color.Transparent;
            this.fiftyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fiftyButton.ForeColor = System.Drawing.Color.White;
            this.fiftyButton.Image = ((System.Drawing.Image)(resources.GetObject("fiftyButton.Image")));
            this.fiftyButton.ImageSize = new System.Drawing.Size(80, 80);
            this.fiftyButton.IndicateFocus = true;
            this.fiftyButton.Location = new System.Drawing.Point(0, 10);
            this.fiftyButton.Name = "fiftyButton";
            this.fiftyButton.Size = new System.Drawing.Size(83, 80);
            this.fiftyButton.TabIndex = 9;
            this.fiftyButton.Tag = "50";
            this.fiftyButton.Click += new System.EventHandler(this.helpButtonsEvent);
            // 
            // endGameButton
            // 
            this.endGameButton.BackColor = System.Drawing.Color.Transparent;
            this.endGameButton.BorderRadius = 30;
            this.endGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.endGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.endGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.endGameButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.endGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.endGameButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.endGameButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.endGameButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.endGameButton.ForeColor = System.Drawing.Color.Yellow;
            this.endGameButton.Location = new System.Drawing.Point(35, 145);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(164, 38);
            this.endGameButton.TabIndex = 10;
            this.endGameButton.Text = "Zakończ grę";
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // prizesListView
            // 
            this.prizesListView.BackColor = System.Drawing.Color.MidnightBlue;
            this.prizesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesListView.ForeColor = System.Drawing.Color.White;
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
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(25, 15);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "xdxd";
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
            this.rightToolsGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox rightToolsGroupBox;
        private System.Windows.Forms.ListView prizesListView;
        private Guna.UI2.WinForms.Guna2GradientButton answerAButton;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel questionPanel;
        private Guna.UI2.WinForms.Guna2GradientButton answerDButton;
        private Guna.UI2.WinForms.Guna2GradientButton answerCButton;
        private Guna.UI2.WinForms.Guna2GradientButton answerBButton;
        private System.Windows.Forms.Label questionLabel;
        private Guna.UI2.WinForms.Guna2GradientButton endGameButton;
        private Guna.UI2.WinForms.Guna2TileButton fiftyButton;
        private Guna.UI2.WinForms.Guna2TileButton askAudienceButton;
        private Guna.UI2.WinForms.Guna2TileButton swapQuestionButton;
    }
}


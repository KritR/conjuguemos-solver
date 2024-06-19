namespace spanishsolver
{
    partial class spanishsolverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spanishsolverForm));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.BeginScript = new System.Windows.Forms.Button();
            this.pointsAmmount = new System.Windows.Forms.TextBox();
            this.labelAmmountPoints = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.userUserName = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.tabHack = new System.Windows.Forms.TabControl();
            this.tabTimeHack = new System.Windows.Forms.TabPage();
            this.checkBoxShowAnswers = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.buttonHelp2 = new System.Windows.Forms.Button();
            this.tabFillBlankHack = new System.Windows.Forms.TabPage();
            this.buttonBeginFillBlank = new System.Windows.Forms.Button();
            this.buttonHelp3 = new System.Windows.Forms.Button();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.buttonInjectScript = new System.Windows.Forms.Button();
            this.buttonViewHTML = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxIncorrect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.tabHack.SuspendLayout();
            this.tabTimeHack.SuspendLayout();
            this.tabFillBlankHack.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(1264, 609);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://conjuguemos.com/", System.UriKind.Absolute);
            this.webBrowser.Visible = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // BeginScript
            // 
            this.BeginScript.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BeginScript.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginScript.Location = new System.Drawing.Point(1124, 6);
            this.BeginScript.Name = "BeginScript";
            this.BeginScript.Size = new System.Drawing.Size(129, 29);
            this.BeginScript.TabIndex = 1;
            this.BeginScript.Text = "Begin";
            this.BeginScript.UseVisualStyleBackColor = true;
            this.BeginScript.Visible = false;
            this.BeginScript.Click += new System.EventHandler(this.BeginScript_Click);
            // 
            // pointsAmmount
            // 
            this.pointsAmmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsAmmount.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsAmmount.Location = new System.Drawing.Point(385, 11);
            this.pointsAmmount.MaxLength = 10;
            this.pointsAmmount.Name = "pointsAmmount";
            this.pointsAmmount.Size = new System.Drawing.Size(56, 23);
            this.pointsAmmount.TabIndex = 2;
            this.pointsAmmount.Visible = false;
            this.pointsAmmount.TextChanged += new System.EventHandler(this.pointsAmmount_TextChanged);
            // 
            // labelAmmountPoints
            // 
            this.labelAmmountPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAmmountPoints.AutoSize = true;
            this.labelAmmountPoints.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmmountPoints.Location = new System.Drawing.Point(447, 11);
            this.labelAmmountPoints.Name = "labelAmmountPoints";
            this.labelAmmountPoints.Size = new System.Drawing.Size(301, 19);
            this.labelAmmountPoints.TabIndex = 4;
            this.labelAmmountPoints.Text = "Amount of points you would like (Max of 40)";
            this.labelAmmountPoints.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(782, 11);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(208, 19);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "ERROR: Numbers 1-40 ONLY";
            this.errorLabel.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(12, 64);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(186, 29);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // userUserName
            // 
            this.userUserName.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUserName.Location = new System.Drawing.Point(12, 12);
            this.userUserName.Name = "userUserName";
            this.userUserName.Size = new System.Drawing.Size(104, 24);
            this.userUserName.TabIndex = 7;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(12, 38);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(104, 24);
            this.userPassword.TabIndex = 8;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(12, 99);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(49, 29);
            this.buttonHelp.TabIndex = 11;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(11, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(50, 30);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "<-";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForward.Location = new System.Drawing.Point(67, 2);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(50, 30);
            this.buttonForward.TabIndex = 13;
            this.buttonForward.Text = "->";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Visible = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // rememberMe
            // 
            this.rememberMe.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.rememberMe.AutoSize = true;
            this.rememberMe.Location = new System.Drawing.Point(99, 107);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(95, 17);
            this.rememberMe.TabIndex = 14;
            this.rememberMe.Text = "Remember Me";
            this.rememberMe.UseVisualStyleBackColor = true;
            this.rememberMe.CheckedChanged += new System.EventHandler(this.rememberMe_CheckedChanged);
            // 
            // tabHack
            // 
            this.tabHack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabHack.Controls.Add(this.tabTimeHack);
            this.tabHack.Controls.Add(this.tabFillBlankHack);
            this.tabHack.Controls.Add(this.tabAdvanced);
            this.tabHack.Controls.Add(this.tabPage1);
            this.tabHack.Location = new System.Drawing.Point(0, 615);
            this.tabHack.Name = "tabHack";
            this.tabHack.SelectedIndex = 0;
            this.tabHack.Size = new System.Drawing.Size(1264, 72);
            this.tabHack.TabIndex = 15;
            this.tabHack.Visible = false;
            // 
            // tabTimeHack
            // 
            this.tabTimeHack.Controls.Add(this.checkBoxShowAnswers);
            this.tabTimeHack.Controls.Add(this.label5);
            this.tabTimeHack.Controls.Add(this.label4);
            this.tabTimeHack.Controls.Add(this.comboBoxTime);
            this.tabTimeHack.Controls.Add(this.buttonHelp2);
            this.tabTimeHack.Controls.Add(this.errorLabel);
            this.tabTimeHack.Controls.Add(this.BeginScript);
            this.tabTimeHack.Controls.Add(this.labelAmmountPoints);
            this.tabTimeHack.Controls.Add(this.pointsAmmount);
            this.tabTimeHack.Location = new System.Drawing.Point(4, 22);
            this.tabTimeHack.Name = "tabTimeHack";
            this.tabTimeHack.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeHack.Size = new System.Drawing.Size(1256, 46);
            this.tabTimeHack.TabIndex = 0;
            this.tabTimeHack.Text = "Timed Hack";
            this.tabTimeHack.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowAnswers
            // 
            this.checkBoxShowAnswers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxShowAnswers.AutoSize = true;
            this.checkBoxShowAnswers.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowAnswers.Location = new System.Drawing.Point(996, 10);
            this.checkBoxShowAnswers.Name = "checkBoxShowAnswers";
            this.checkBoxShowAnswers.Size = new System.Drawing.Size(122, 23);
            this.checkBoxShowAnswers.TabIndex = 20;
            this.checkBoxShowAnswers.Text = "Show Answers";
            this.checkBoxShowAnswers.UseVisualStyleBackColor = true;
            this.checkBoxShowAnswers.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Minutes";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount of time:";
            this.label4.Visible = false;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTime.Items.AddRange(new object[] {
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00"});
            this.comboBoxTime.Location = new System.Drawing.Point(190, 8);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 27);
            this.comboBoxTime.TabIndex = 17;
            this.comboBoxTime.Visible = false;
            this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxTime_SelectedIndexChanged);
            // 
            // buttonHelp2
            // 
            this.buttonHelp2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHelp2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp2.Location = new System.Drawing.Point(8, 6);
            this.buttonHelp2.Name = "buttonHelp2";
            this.buttonHelp2.Size = new System.Drawing.Size(49, 29);
            this.buttonHelp2.TabIndex = 16;
            this.buttonHelp2.Text = "Help";
            this.buttonHelp2.UseVisualStyleBackColor = true;
            this.buttonHelp2.Visible = false;
            this.buttonHelp2.Click += new System.EventHandler(this.buttonHelp2_Click);
            // 
            // tabFillBlankHack
            // 
            this.tabFillBlankHack.Controls.Add(this.buttonBeginFillBlank);
            this.tabFillBlankHack.Controls.Add(this.buttonHelp3);
            this.tabFillBlankHack.Location = new System.Drawing.Point(4, 22);
            this.tabFillBlankHack.Name = "tabFillBlankHack";
            this.tabFillBlankHack.Padding = new System.Windows.Forms.Padding(3);
            this.tabFillBlankHack.Size = new System.Drawing.Size(1256, 46);
            this.tabFillBlankHack.TabIndex = 1;
            this.tabFillBlankHack.Text = "Fill in the Blank Hack";
            this.tabFillBlankHack.UseVisualStyleBackColor = true;
            // 
            // buttonBeginFillBlank
            // 
            this.buttonBeginFillBlank.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonBeginFillBlank.Font = new System.Drawing.Font("Corbel", 12F);
            this.buttonBeginFillBlank.Location = new System.Drawing.Point(1118, 6);
            this.buttonBeginFillBlank.Name = "buttonBeginFillBlank";
            this.buttonBeginFillBlank.Size = new System.Drawing.Size(130, 29);
            this.buttonBeginFillBlank.TabIndex = 18;
            this.buttonBeginFillBlank.Text = "Begin";
            this.buttonBeginFillBlank.UseVisualStyleBackColor = true;
            this.buttonBeginFillBlank.Click += new System.EventHandler(this.buttonBeginFillBlank_Click);
            // 
            // buttonHelp3
            // 
            this.buttonHelp3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHelp3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp3.Location = new System.Drawing.Point(8, 6);
            this.buttonHelp3.Name = "buttonHelp3";
            this.buttonHelp3.Size = new System.Drawing.Size(49, 29);
            this.buttonHelp3.TabIndex = 17;
            this.buttonHelp3.Text = "Help";
            this.buttonHelp3.UseVisualStyleBackColor = true;
            this.buttonHelp3.Click += new System.EventHandler(this.buttonHelp3_Click);
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.buttonInjectScript);
            this.tabAdvanced.Controls.Add(this.buttonViewHTML);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Size = new System.Drawing.Size(1256, 46);
            this.tabAdvanced.TabIndex = 2;
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // buttonInjectScript
            // 
            this.buttonInjectScript.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonInjectScript.Font = new System.Drawing.Font("Corbel", 12F);
            this.buttonInjectScript.Location = new System.Drawing.Point(196, 9);
            this.buttonInjectScript.Name = "buttonInjectScript";
            this.buttonInjectScript.Size = new System.Drawing.Size(172, 29);
            this.buttonInjectScript.TabIndex = 20;
            this.buttonInjectScript.Text = "Inject Script Into Page";
            this.buttonInjectScript.UseVisualStyleBackColor = true;
            this.buttonInjectScript.Click += new System.EventHandler(this.buttonInjectScript_Click);
            // 
            // buttonViewHTML
            // 
            this.buttonViewHTML.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonViewHTML.Font = new System.Drawing.Font("Corbel", 12F);
            this.buttonViewHTML.Location = new System.Drawing.Point(3, 9);
            this.buttonViewHTML.Name = "buttonViewHTML";
            this.buttonViewHTML.Size = new System.Drawing.Size(187, 29);
            this.buttonViewHTML.TabIndex = 19;
            this.buttonViewHTML.Text = "View current Page HTML";
            this.buttonViewHTML.UseVisualStyleBackColor = true;
            this.buttonViewHTML.Click += new System.EventHandler(this.buttonViewHTML_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxIncorrect);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1256, 46);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Extra";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxIncorrect
            // 
            this.comboBoxIncorrect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxIncorrect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncorrect.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIncorrect.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxIncorrect.Location = new System.Drawing.Point(3, 10);
            this.comboBoxIncorrect.Name = "comboBoxIncorrect";
            this.comboBoxIncorrect.Size = new System.Drawing.Size(121, 27);
            this.comboBoxIncorrect.TabIndex = 18;
            this.comboBoxIncorrect.SelectedIndexChanged += new System.EventHandler(this.comboBoxIncorrect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ammount of points you would like to be marked incorrect";
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(2, 2);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(245, 55);
            this.labelLoading.TabIndex = 16;
            this.labelLoading.Text = "Loading...";
            // 
            // spanishsolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 688);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.tabHack);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userUserName);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 726);
            this.Name = "spanishsolverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Conjuguemos Solver 2.3.2.1 ";
            this.Load += new System.EventHandler(this.spanishsolverForm_Load);
            this.tabHack.ResumeLayout(false);
            this.tabTimeHack.ResumeLayout(false);
            this.tabTimeHack.PerformLayout();
            this.tabFillBlankHack.ResumeLayout(false);
            this.tabAdvanced.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BeginScript;
        private System.Windows.Forms.TextBox pointsAmmount;
        private System.Windows.Forms.Label labelAmmountPoints;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox userUserName;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.CheckBox rememberMe;
        private System.Windows.Forms.TabControl tabHack;
        private System.Windows.Forms.TabPage tabTimeHack;
        private System.Windows.Forms.TabPage tabFillBlankHack;
        private System.Windows.Forms.Button buttonHelp2;
        private System.Windows.Forms.Button buttonHelp3;
        private System.Windows.Forms.Button buttonBeginFillBlank;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxShowAnswers;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.Button buttonViewHTML;
        private System.Windows.Forms.Button buttonInjectScript;
        public System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxIncorrect;
        private System.Windows.Forms.Label label2;
    }
}


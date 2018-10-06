namespace BasicPureCloudInWindowsForm
{
    partial class LoginForm
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.urlHashTextbox = new System.Windows.Forms.TextBox();
            this.getAccessTokenButton = new System.Windows.Forms.Button();
            this.processURLAboveButton = new System.Windows.Forms.Button();
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.accessTokenTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.popUpLoginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(22, 106);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(486, 406);
            this.webBrowser1.TabIndex = 0;
            // 
            // urlHashTextbox
            // 
            this.urlHashTextbox.Location = new System.Drawing.Point(536, 106);
            this.urlHashTextbox.Multiline = true;
            this.urlHashTextbox.Name = "urlHashTextbox";
            this.urlHashTextbox.Size = new System.Drawing.Size(154, 134);
            this.urlHashTextbox.TabIndex = 1;
            // 
            // getAccessTokenButton
            // 
            this.getAccessTokenButton.Location = new System.Drawing.Point(360, 61);
            this.getAccessTokenButton.Name = "getAccessTokenButton";
            this.getAccessTokenButton.Size = new System.Drawing.Size(146, 23);
            this.getAccessTokenButton.TabIndex = 3;
            this.getAccessTokenButton.Text = "2. Extract Token from Hash";
            this.getAccessTokenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getAccessTokenButton.UseVisualStyleBackColor = true;
            this.getAccessTokenButton.Click += new System.EventHandler(this.getAccessTokenButton_Click_1);
            // 
            // processURLAboveButton
            // 
            this.processURLAboveButton.Location = new System.Drawing.Point(360, 32);
            this.processURLAboveButton.Name = "processURLAboveButton";
            this.processURLAboveButton.Size = new System.Drawing.Size(146, 23);
            this.processURLAboveButton.TabIndex = 5;
            this.processURLAboveButton.Text = "1. Browse URL";
            this.processURLAboveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processURLAboveButton.UseVisualStyleBackColor = true;
            this.processURLAboveButton.Click += new System.EventHandler(this.processURLAboveButton_Click);
            // 
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(22, 30);
            this.URLTextbox.Multiline = true;
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(332, 60);
            this.URLTextbox.TabIndex = 6;
            // 
            // accessTokenTextbox
            // 
            this.accessTokenTextbox.Location = new System.Drawing.Point(536, 274);
            this.accessTokenTextbox.Multiline = true;
            this.accessTokenTextbox.Name = "accessTokenTextbox";
            this.accessTokenTextbox.Size = new System.Drawing.Size(154, 136);
            this.accessTokenTextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Access Token :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "URL Hash : ";
            // 
            // popUpLoginButton
            // 
            this.popUpLoginButton.Location = new System.Drawing.Point(549, 34);
            this.popUpLoginButton.Name = "popUpLoginButton";
            this.popUpLoginButton.Size = new System.Drawing.Size(137, 47);
            this.popUpLoginButton.TabIndex = 11;
            this.popUpLoginButton.Text = "[PopUp Login]";
            this.popUpLoginButton.UseVisualStyleBackColor = true;
            this.popUpLoginButton.Click += new System.EventHandler(this.popUpLoginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "OAuth URL :";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(544, 435);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(130, 46);
            this.menuButton.TabIndex = 13;
            this.menuButton.Text = "Go to Menu >>";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Or";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(544, 488);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(130, 46);
            this.logoutButton.TabIndex = 19;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 546);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.popUpLoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accessTokenTextbox);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.processURLAboveButton);
            this.Controls.Add(this.getAccessTokenButton);
            this.Controls.Add(this.urlHashTextbox);
            this.Controls.Add(this.webBrowser1);
            this.Name = "LoginForm";
            this.Text = "Get Access Token";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox urlHashTextbox;
        private System.Windows.Forms.Button getAccessTokenButton;
        private System.Windows.Forms.Button processURLAboveButton;
        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.TextBox accessTokenTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button popUpLoginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logoutButton;
    }
}


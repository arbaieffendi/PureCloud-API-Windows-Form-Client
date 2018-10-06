namespace BasicPureCloudInWindowsForm
{
    partial class PureCloudMenu
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
            this.accessTokenLabel = new System.Windows.Forms.Label();
            this.accessTokenTextBox = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CallButton = new System.Windows.Forms.Button();
            this.HangUpButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.conversationIdTextBox = new System.Windows.Forms.Label();
            this.participantIdLabel = new System.Windows.Forms.Label();
            this.participantIdTextbox = new System.Windows.Forms.TextBox();
            this.getUserDetailsButton = new System.Windows.Forms.Button();
            this.userResultTextbox = new System.Windows.Forms.TextBox();
            this.callResultTexbox = new System.Windows.Forms.TextBox();
            this.hangUpResultTextbox = new System.Windows.Forms.TextBox();
            this.IVRButton = new System.Windows.Forms.Button();
            this.userIdTextbox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userNameTextbox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.subscibeButton = new System.Windows.Forms.Button();
            this.TopicRichTextbox = new System.Windows.Forms.RichTextBox();
            this.subscribeResultTextbox = new System.Windows.Forms.TextBox();
            this.ivrRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IVRResultTextbox = new System.Windows.Forms.TextBox();
            this.endCallButton = new System.Windows.Forms.Button();
            this.endCallResultTextbox = new System.Windows.Forms.TextBox();
            this.TopicEventLabel = new System.Windows.Forms.Label();
            this.IVREventLabel = new System.Windows.Forms.Label();
            this.getStationButton = new System.Windows.Forms.Button();
            this.stationIdLabel = new System.Windows.Forms.Label();
            this.stationIdTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FQDNTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accessTokenLabel
            // 
            this.accessTokenLabel.AutoSize = true;
            this.accessTokenLabel.Location = new System.Drawing.Point(13, 13);
            this.accessTokenLabel.Name = "accessTokenLabel";
            this.accessTokenLabel.Size = new System.Drawing.Size(76, 13);
            this.accessTokenLabel.TabIndex = 0;
            this.accessTokenLabel.Text = "Access Token";
            // 
            // accessTokenTextBox
            // 
            this.accessTokenTextBox.Location = new System.Drawing.Point(94, 13);
            this.accessTokenTextBox.Multiline = true;
            this.accessTokenTextBox.Name = "accessTokenTextBox";
            this.accessTokenTextBox.ReadOnly = true;
            this.accessTokenTextBox.Size = new System.Drawing.Size(432, 53);
            this.accessTokenTextBox.TabIndex = 1;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(729, 11);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CallButton
            // 
            this.CallButton.Location = new System.Drawing.Point(12, 160);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(75, 23);
            this.CallButton.TabIndex = 3;
            this.CallButton.Text = "Call";
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // HangUpButton
            // 
            this.HangUpButton.Location = new System.Drawing.Point(13, 308);
            this.HangUpButton.Name = "HangUpButton";
            this.HangUpButton.Size = new System.Drawing.Size(75, 23);
            this.HangUpButton.TabIndex = 4;
            this.HangUpButton.Text = "Hang Up";
            this.HangUpButton.UseVisualStyleBackColor = true;
            this.HangUpButton.Click += new System.EventHandler(this.HangUpButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 5;
            // 
            // conversationIdTextBox
            // 
            this.conversationIdTextBox.AutoSize = true;
            this.conversationIdTextBox.Location = new System.Drawing.Point(548, 165);
            this.conversationIdTextBox.Name = "conversationIdTextBox";
            this.conversationIdTextBox.Size = new System.Drawing.Size(78, 13);
            this.conversationIdTextBox.TabIndex = 6;
            this.conversationIdTextBox.Text = "ConversationId";
            // 
            // participantIdLabel
            // 
            this.participantIdLabel.AutoSize = true;
            this.participantIdLabel.Location = new System.Drawing.Point(548, 211);
            this.participantIdLabel.Name = "participantIdLabel";
            this.participantIdLabel.Size = new System.Drawing.Size(66, 13);
            this.participantIdLabel.TabIndex = 8;
            this.participantIdLabel.Text = "ParticipantId";
            // 
            // participantIdTextbox
            // 
            this.participantIdTextbox.Location = new System.Drawing.Point(548, 230);
            this.participantIdTextbox.Name = "participantIdTextbox";
            this.participantIdTextbox.Size = new System.Drawing.Size(251, 20);
            this.participantIdTextbox.TabIndex = 7;
            // 
            // getUserDetailsButton
            // 
            this.getUserDetailsButton.Location = new System.Drawing.Point(12, 74);
            this.getUserDetailsButton.Name = "getUserDetailsButton";
            this.getUserDetailsButton.Size = new System.Drawing.Size(76, 23);
            this.getUserDetailsButton.TabIndex = 9;
            this.getUserDetailsButton.Text = "Get User";
            this.getUserDetailsButton.UseVisualStyleBackColor = true;
            this.getUserDetailsButton.Click += new System.EventHandler(this.getUserDetailsButton_Click);
            // 
            // userResultTextbox
            // 
            this.userResultTextbox.Location = new System.Drawing.Point(94, 76);
            this.userResultTextbox.Multiline = true;
            this.userResultTextbox.Name = "userResultTextbox";
            this.userResultTextbox.Size = new System.Drawing.Size(432, 78);
            this.userResultTextbox.TabIndex = 10;
            // 
            // callResultTexbox
            // 
            this.callResultTexbox.Location = new System.Drawing.Point(94, 160);
            this.callResultTexbox.Multiline = true;
            this.callResultTexbox.Name = "callResultTexbox";
            this.callResultTexbox.Size = new System.Drawing.Size(432, 67);
            this.callResultTexbox.TabIndex = 12;
            // 
            // hangUpResultTextbox
            // 
            this.hangUpResultTextbox.Location = new System.Drawing.Point(94, 308);
            this.hangUpResultTextbox.Multiline = true;
            this.hangUpResultTextbox.Name = "hangUpResultTextbox";
            this.hangUpResultTextbox.Size = new System.Drawing.Size(432, 67);
            this.hangUpResultTextbox.TabIndex = 13;
            // 
            // IVRButton
            // 
            this.IVRButton.Location = new System.Drawing.Point(12, 527);
            this.IVRButton.Name = "IVRButton";
            this.IVRButton.Size = new System.Drawing.Size(75, 23);
            this.IVRButton.TabIndex = 15;
            this.IVRButton.Text = "IVR";
            this.IVRButton.UseVisualStyleBackColor = true;
            this.IVRButton.Click += new System.EventHandler(this.IVRButton_Click);
            // 
            // userIdTextbox
            // 
            this.userIdTextbox.Location = new System.Drawing.Point(548, 93);
            this.userIdTextbox.Name = "userIdTextbox";
            this.userIdTextbox.Size = new System.Drawing.Size(251, 20);
            this.userIdTextbox.TabIndex = 17;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(545, 77);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(38, 13);
            this.userIdLabel.TabIndex = 18;
            this.userIdLabel.Text = "UserId";
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.Location = new System.Drawing.Point(548, 137);
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.Size = new System.Drawing.Size(251, 20);
            this.userNameTextbox.TabIndex = 19;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(545, 121);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(35, 13);
            this.userNameLabel.TabIndex = 20;
            this.userNameLabel.Text = "Name";
            // 
            // subscibeButton
            // 
            this.subscibeButton.Location = new System.Drawing.Point(12, 381);
            this.subscibeButton.Name = "subscibeButton";
            this.subscibeButton.Size = new System.Drawing.Size(75, 43);
            this.subscibeButton.TabIndex = 21;
            this.subscibeButton.Text = "Subscribe Topic";
            this.subscibeButton.UseVisualStyleBackColor = true;
            this.subscibeButton.Click += new System.EventHandler(this.subscibeButton_Click);
            // 
            // TopicRichTextbox
            // 
            this.TopicRichTextbox.Location = new System.Drawing.Point(548, 380);
            this.TopicRichTextbox.Name = "TopicRichTextbox";
            this.TopicRichTextbox.Size = new System.Drawing.Size(332, 124);
            this.TopicRichTextbox.TabIndex = 22;
            this.TopicRichTextbox.Text = "";
            // 
            // subscribeResultTextbox
            // 
            this.subscribeResultTextbox.Location = new System.Drawing.Point(94, 381);
            this.subscribeResultTextbox.Multiline = true;
            this.subscribeResultTextbox.Name = "subscribeResultTextbox";
            this.subscribeResultTextbox.Size = new System.Drawing.Size(432, 67);
            this.subscribeResultTextbox.TabIndex = 23;
            // 
            // ivrRichTextBox
            // 
            this.ivrRichTextBox.Location = new System.Drawing.Point(548, 529);
            this.ivrRichTextBox.Name = "ivrRichTextBox";
            this.ivrRichTextBox.Size = new System.Drawing.Size(332, 124);
            this.ivrRichTextBox.TabIndex = 24;
            this.ivrRichTextBox.Text = "";
            // 
            // IVRResultTextbox
            // 
            this.IVRResultTextbox.Location = new System.Drawing.Point(94, 529);
            this.IVRResultTextbox.Multiline = true;
            this.IVRResultTextbox.Name = "IVRResultTextbox";
            this.IVRResultTextbox.Size = new System.Drawing.Size(432, 67);
            this.IVRResultTextbox.TabIndex = 16;
            // 
            // endCallButton
            // 
            this.endCallButton.Location = new System.Drawing.Point(14, 233);
            this.endCallButton.Name = "endCallButton";
            this.endCallButton.Size = new System.Drawing.Size(75, 23);
            this.endCallButton.TabIndex = 25;
            this.endCallButton.Text = "End Call";
            this.endCallButton.UseVisualStyleBackColor = true;
            // 
            // endCallResultTextbox
            // 
            this.endCallResultTextbox.Location = new System.Drawing.Point(94, 233);
            this.endCallResultTextbox.Multiline = true;
            this.endCallResultTextbox.Name = "endCallResultTextbox";
            this.endCallResultTextbox.Size = new System.Drawing.Size(432, 67);
            this.endCallResultTextbox.TabIndex = 26;
            // 
            // TopicEventLabel
            // 
            this.TopicEventLabel.AutoSize = true;
            this.TopicEventLabel.Location = new System.Drawing.Point(548, 362);
            this.TopicEventLabel.Name = "TopicEventLabel";
            this.TopicEventLabel.Size = new System.Drawing.Size(65, 13);
            this.TopicEventLabel.TabIndex = 27;
            this.TopicEventLabel.Text = "Topic Event";
            // 
            // IVREventLabel
            // 
            this.IVREventLabel.AutoSize = true;
            this.IVREventLabel.Location = new System.Drawing.Point(548, 513);
            this.IVREventLabel.Name = "IVREventLabel";
            this.IVREventLabel.Size = new System.Drawing.Size(56, 13);
            this.IVREventLabel.TabIndex = 28;
            this.IVREventLabel.Text = "IVR Event";
            // 
            // getStationButton
            // 
            this.getStationButton.Location = new System.Drawing.Point(805, 278);
            this.getStationButton.Name = "getStationButton";
            this.getStationButton.Size = new System.Drawing.Size(129, 23);
            this.getStationButton.TabIndex = 29;
            this.getStationButton.Text = "Get Station By FQDN";
            this.getStationButton.UseVisualStyleBackColor = true;
            // 
            // stationIdLabel
            // 
            this.stationIdLabel.AutoSize = true;
            this.stationIdLabel.Location = new System.Drawing.Point(548, 307);
            this.stationIdLabel.Name = "stationIdLabel";
            this.stationIdLabel.Size = new System.Drawing.Size(49, 13);
            this.stationIdLabel.TabIndex = 33;
            this.stationIdLabel.Text = "StationId";
            // 
            // stationIdTextbox
            // 
            this.stationIdTextbox.Location = new System.Drawing.Point(548, 326);
            this.stationIdTextbox.Name = "stationIdTextbox";
            this.stationIdTextbox.Size = new System.Drawing.Size(251, 20);
            this.stationIdTextbox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "FQDN";
            // 
            // FQDNTextbox
            // 
            this.FQDNTextbox.Location = new System.Drawing.Point(548, 280);
            this.FQDNTextbox.Name = "FQDNTextbox";
            this.FQDNTextbox.Size = new System.Drawing.Size(251, 20);
            this.FQDNTextbox.TabIndex = 30;
            // 
            // PureCloudMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 674);
            this.Controls.Add(this.stationIdLabel);
            this.Controls.Add(this.stationIdTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FQDNTextbox);
            this.Controls.Add(this.getStationButton);
            this.Controls.Add(this.IVREventLabel);
            this.Controls.Add(this.TopicEventLabel);
            this.Controls.Add(this.endCallResultTextbox);
            this.Controls.Add(this.endCallButton);
            this.Controls.Add(this.ivrRichTextBox);
            this.Controls.Add(this.subscribeResultTextbox);
            this.Controls.Add(this.TopicRichTextbox);
            this.Controls.Add(this.subscibeButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextbox);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.userIdTextbox);
            this.Controls.Add(this.IVRResultTextbox);
            this.Controls.Add(this.IVRButton);
            this.Controls.Add(this.hangUpResultTextbox);
            this.Controls.Add(this.callResultTexbox);
            this.Controls.Add(this.userResultTextbox);
            this.Controls.Add(this.getUserDetailsButton);
            this.Controls.Add(this.participantIdLabel);
            this.Controls.Add(this.participantIdTextbox);
            this.Controls.Add(this.conversationIdTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HangUpButton);
            this.Controls.Add(this.CallButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.accessTokenTextBox);
            this.Controls.Add(this.accessTokenLabel);
            this.Name = "PureCloudMenu";
            this.Text = "Pure Cloud Testing Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accessTokenLabel;
        private System.Windows.Forms.TextBox accessTokenTextBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.Button HangUpButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label conversationIdTextBox;
        private System.Windows.Forms.Label participantIdLabel;
        private System.Windows.Forms.TextBox participantIdTextbox;
        private System.Windows.Forms.Button getUserDetailsButton;
        private System.Windows.Forms.TextBox userResultTextbox;
        private System.Windows.Forms.TextBox callResultTexbox;
        private System.Windows.Forms.TextBox hangUpResultTextbox;
        private System.Windows.Forms.Button IVRButton;
        private System.Windows.Forms.TextBox userIdTextbox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox userNameTextbox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button subscibeButton;
        private System.Windows.Forms.RichTextBox TopicRichTextbox;
        private System.Windows.Forms.TextBox subscribeResultTextbox;
        private System.Windows.Forms.RichTextBox ivrRichTextBox;
        private System.Windows.Forms.TextBox IVRResultTextbox;
        private System.Windows.Forms.Button endCallButton;
        private System.Windows.Forms.TextBox endCallResultTextbox;
        private System.Windows.Forms.Label TopicEventLabel;
        private System.Windows.Forms.Label IVREventLabel;
        private System.Windows.Forms.Button getStationButton;
        private System.Windows.Forms.Label stationIdLabel;
        private System.Windows.Forms.TextBox stationIdTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FQDNTextbox;
    }
}
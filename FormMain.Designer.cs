using System;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.feedListBox = new System.Windows.Forms.ListBox();
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.likedPagesListBox = new System.Windows.Forms.ListBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.mainLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.albumsLabel = new System.Windows.Forms.Label();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.likedPagesLabel = new System.Windows.Forms.Label();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.feedPictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.FriendsListLabel = new System.Windows.Forms.Label();
            this.subjectPictureBox = new System.Windows.Forms.PictureBox();
            this.quizButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedPictureBoxPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Location = new System.Drawing.Point(12, 41);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(10, 93);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(179, 205);
            this.profilePictureBox.TabIndex = 53;
            this.profilePictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 308);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 54;
            this.nameLabel.Text = "Full Name: ";
            this.nameLabel.Visible = false;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(10, 325);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(51, 13);
            this.birthDateLabel.TabIndex = 55;
            this.birthDateLabel.Text = "Birthday: ";
            this.birthDateLabel.Visible = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(10, 342);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 13);
            this.genderLabel.TabIndex = 56;
            this.genderLabel.Text = "Gender: ";
            this.genderLabel.Visible = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(10, 359);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(54, 13);
            this.locationLabel.TabIndex = 57;
            this.locationLabel.Text = "Location: ";
            this.locationLabel.Visible = false;
            // 
            // feedListBox
            // 
            this.feedListBox.FormattingEnabled = true;
            this.feedListBox.Location = new System.Drawing.Point(345, 329);
            this.feedListBox.Name = "feedListBox";
            this.feedListBox.Size = new System.Drawing.Size(423, 199);
            this.feedListBox.TabIndex = 58;
            this.feedListBox.Visible = false;
            this.feedListBox.SelectedIndexChanged += new System.EventHandler(this.FeedListBox_SelectedIndexChanged);
            // 
            // albumsListBox
            // 
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.Location = new System.Drawing.Point(994, 176);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(138, 134);
            this.albumsListBox.TabIndex = 59;
            this.albumsListBox.Visible = false;
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(837, 515);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(132, 134);
            this.eventsListBox.TabIndex = 60;
            this.eventsListBox.Visible = false;
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(994, 338);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(138, 147);
            this.groupsListBox.TabIndex = 61;
            this.groupsListBox.Visible = false;
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // likedPagesListBox
            // 
            this.likedPagesListBox.FormattingEnabled = true;
            this.likedPagesListBox.Location = new System.Drawing.Point(994, 515);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(138, 134);
            this.likedPagesListBox.TabIndex = 62;
            this.likedPagesListBox.Visible = false;
            this.likedPagesListBox.SelectedIndexChanged += new System.EventHandler(this.likedPagesListBox_SelectedIndexChanged);
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(837, 337);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(139, 147);
            this.friendsListBox.TabIndex = 63;
            this.friendsListBox.Visible = false;
            // 
            // mainLogoPictureBox
            // 
            this.mainLogoPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo;
            this.mainLogoPictureBox.Location = new System.Drawing.Point(287, 12);
            this.mainLogoPictureBox.Name = "mainLogoPictureBox";
            this.mainLogoPictureBox.Size = new System.Drawing.Size(467, 75);
            this.mainLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogoPictureBox.TabIndex = 64;
            this.mainLogoPictureBox.TabStop = false;
            // 
            // albumsLabel
            // 
            this.albumsLabel.AutoSize = true;
            this.albumsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsLabel.Location = new System.Drawing.Point(1029, 149);
            this.albumsLabel.Name = "albumsLabel";
            this.albumsLabel.Size = new System.Drawing.Size(74, 24);
            this.albumsLabel.TabIndex = 66;
            this.albumsLabel.Text = "Albums";
            this.albumsLabel.Visible = false;
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsLabel.Location = new System.Drawing.Point(1031, 312);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(72, 24);
            this.groupsLabel.TabIndex = 67;
            this.groupsLabel.Text = "Groups";
            this.groupsLabel.Visible = false;
            // 
            // likedPagesLabel
            // 
            this.likedPagesLabel.AutoSize = true;
            this.likedPagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPagesLabel.Location = new System.Drawing.Point(1016, 489);
            this.likedPagesLabel.Name = "likedPagesLabel";
            this.likedPagesLabel.Size = new System.Drawing.Size(113, 24);
            this.likedPagesLabel.TabIndex = 68;
            this.likedPagesLabel.Text = "Liked Pages";
            this.likedPagesLabel.Visible = false;
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsLabel.Location = new System.Drawing.Point(874, 489);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(67, 24);
            this.eventsLabel.TabIndex = 69;
            this.eventsLabel.Text = "Events";
            this.eventsLabel.Visible = false;
            // 
            // feedPictureBoxPosts
            // 
            this.feedPictureBoxPosts.Location = new System.Drawing.Point(183, 328);
            this.feedPictureBoxPosts.Name = "feedPictureBoxPosts";
            this.feedPictureBoxPosts.Size = new System.Drawing.Size(156, 199);
            this.feedPictureBoxPosts.TabIndex = 70;
            this.feedPictureBoxPosts.TabStop = false;
            this.feedPictureBoxPosts.Visible = false;
            // 
            // commentsListBox
            // 
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.Location = new System.Drawing.Point(183, 561);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(585, 82);
            this.commentsListBox.TabIndex = 71;
            this.commentsListBox.Visible = false;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(179, 535);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(101, 24);
            this.commentsLabel.TabIndex = 72;
            this.commentsLabel.Text = "Comments";
            this.commentsLabel.Visible = false;
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(287, 115);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(468, 88);
            this.postTextBox.TabIndex = 73;
            this.postTextBox.Visible = false;
            this.postTextBox.TextChanged += new System.EventHandler(this.postTextBox_TextChanged);
            this.postTextBox.Leave += new System.EventHandler(this.postTextBox_Leave);
            // 
            // postButton
            // 
            this.postButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.postButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.postButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postButton.Enabled = false;
            this.postButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.postButton.Location = new System.Drawing.Point(405, 204);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(226, 23);
            this.postButton.TabIndex = 74;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Visible = false;
            this.postButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // FriendsListLabel
            // 
            this.FriendsListLabel.AutoSize = true;
            this.FriendsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsListLabel.Location = new System.Drawing.Point(860, 311);
            this.FriendsListLabel.Name = "FriendsListLabel";
            this.FriendsListLabel.Size = new System.Drawing.Size(106, 24);
            this.FriendsListLabel.TabIndex = 75;
            this.FriendsListLabel.Text = "Friends List";
            this.FriendsListLabel.Visible = false;
            // 
            // subjectPictureBox
            // 
            this.subjectPictureBox.Location = new System.Drawing.Point(837, 176);
            this.subjectPictureBox.Name = "subjectPictureBox";
            this.subjectPictureBox.Size = new System.Drawing.Size(138, 133);
            this.subjectPictureBox.TabIndex = 76;
            this.subjectPictureBox.TabStop = false;
            this.subjectPictureBox.Visible = false;
            // 
            // quizButton
            // 
            this.quizButton.Location = new System.Drawing.Point(837, 15);
            this.quizButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(138, 72);
            this.quizButton.TabIndex = 77;
            this.quizButton.Text = "Quiz !";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Visible = false;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(994, 16);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 71);
            this.searchButton.TabIndex = 78;
            this.searchButton.Text = "Search !";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 652);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.quizButton);
            this.Controls.Add(this.subjectPictureBox);
            this.Controls.Add(this.FriendsListLabel);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsListBox);
            this.Controls.Add(this.feedPictureBoxPosts);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.likedPagesLabel);
            this.Controls.Add(this.groupsLabel);
            this.Controls.Add(this.albumsLabel);
            this.Controls.Add(this.mainLogoPictureBox);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.likedPagesListBox);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.albumsListBox);
            this.Controls.Add(this.feedListBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedPictureBoxPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ListBox feedListBox;
        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.ListBox likedPagesListBox;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.PictureBox mainLogoPictureBox;
        private System.Windows.Forms.Label albumsLabel;
        private System.Windows.Forms.Label groupsLabel;
        private System.Windows.Forms.Label likedPagesLabel;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.PictureBox feedPictureBoxPosts;
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Label FriendsListLabel;
        private System.Windows.Forms.PictureBox subjectPictureBox;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button searchButton;
    }
}
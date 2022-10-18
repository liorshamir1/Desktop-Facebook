using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public partial class FormMain : Form
    {
        private FacebookData m_FacebookData = new FacebookData();
        private ListBox m_SearchListBoxToPass = new ListBox();

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        public string AccesToken { get; private set; }

        private User LoggedInUser { get; set; }

        private LoginResult LoginResult { get; set; }

        public void LoginToFacebook()
        {
            LoginResult = FacebookService.Login(
                "743579109959282",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");
            SetAccesTokenAndLoggedInUser();
        }

        private void SetAccesTokenAndLoggedInUser()
        {
            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
                AccesToken = LoginResult.AccessToken;
                FetchUserInfo();
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void FetchUserInfo()
        {
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            VisibleAllTrue();
            profilePictureBox.LoadAsync(LoggedInUser.PictureLargeURL);
            nameLabel.Text = string.Format("Full Name: {0}", LoggedInUser.Name);
            birthDateLabel.Text = string.Format("Birthday: {0}", LoggedInUser.Birthday);
            genderLabel.Text = string.Format("Gender: {0}", LoggedInUser.Gender);
            locationLabel.Text = string.Format("Location: {0}", LoggedInUser.Location.Name);
            buttonLogin.Text = string.Format("Logged in as {0} {1}", LoggedInUser.FirstName, LoggedInUser.LastName);
            m_FacebookData.FetchFeed(feedListBox, LoggedInUser, m_SearchListBoxToPass);
            m_FacebookData.FetchAlbums(albumsListBox, LoggedInUser, m_SearchListBoxToPass);
            m_FacebookData.FetchEvents(eventsListBox, LoggedInUser, m_SearchListBoxToPass);
            m_FacebookData.FetchGroups(groupsListBox, LoggedInUser, m_SearchListBoxToPass);
            m_FacebookData.FetchLikedPages(likedPagesListBox, LoggedInUser, m_SearchListBoxToPass);
            m_FacebookData.FetchFriends(friendsListBox, LoggedInUser, m_SearchListBoxToPass);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("alex.savvateev@gmail.com");
            LoginToFacebook();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            LogoutFromUser();
        }

        private void LogoutFromUser()
        {
            VisibleAllFalse();
            commentsListBox.Items.Clear();
            profilePictureBox.Image = null;
            feedPictureBoxPosts.Image = null;
            LoginResult = null;
            LoggedInUser = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            buttonLogin.Text = "Login";
        }

        public void VisibleAllTrue()
        {
            eventsListBox.Visible = true;
            commentsListBox.Visible = true;
            feedListBox.Visible = true;
            friendsListBox.Visible = true;
            groupsListBox.Visible = true;
            likedPagesListBox.Visible = true;
            albumsListBox.Visible = true;
            feedPictureBoxPosts.Visible = true;
            albumsLabel.Visible = true;
            commentsLabel.Visible = true;
            eventsLabel.Visible = true;
            FriendsListLabel.Visible = true;
            likedPagesLabel.Visible = true;
            locationLabel.Visible = true;
            genderLabel.Visible = true;
            groupsLabel.Visible = true;
            birthDateLabel.Visible = true;
            nameLabel.Visible = true;
            postButton.Visible = true;
            postTextBox.Visible = true;
            searchButton.Visible = true;
            quizButton.Visible = true;
        }

        public void VisibleAllFalse()
        {
            eventsListBox.Visible = false;
            commentsListBox.Visible = false;
            feedListBox.Visible = false;
            friendsListBox.Visible = false;
            groupsListBox.Visible = false;
            likedPagesListBox.Visible = false;
            albumsListBox.Visible = false;
            feedPictureBoxPosts.Visible = false;
            birthDateLabel.Visible = false;
            albumsLabel.Visible = false;
            commentsLabel.Visible = false;
            eventsLabel.Visible = false;
            FriendsListLabel.Visible = false;
            likedPagesLabel.Visible = false;
            locationLabel.Visible = false;
            genderLabel.Visible = false;
            groupsLabel.Visible = false;
            nameLabel.Visible = false;
            postButton.Visible = false;
            postTextBox.Visible = false;
            searchButton.Visible = false;
            quizButton.Visible = false;
        }

        private void FeedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedPostFromFeed();
            Post selectedPost = LoggedInUser.Posts[feedListBox.SelectedIndex];
            commentsListBox.DisplayMember = "Message";
            commentsListBox.DataSource = selectedPost.Comments;
        }

        private void DisplaySelectedPostFromFeed()
        {
            if (feedListBox.SelectedItems.Count == 1)
            {
                Post selectedPost = LoggedInUser.Posts[feedListBox.SelectedIndex];
                if (selectedPost.PictureURL != null)
                {
                    feedPictureBoxPosts.Visible = true;
                    feedPictureBoxPosts.LoadAsync(selectedPost.PictureURL);
                    feedPictureBoxPosts.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    feedPictureBoxPosts.Visible = false;
                }
            }
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = LoggedInUser.PostStatus(postTextBox.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (albumsListBox.SelectedItems.Count == 1)
            {
                Album selectedAlbum = LoggedInUser.Albums[albumsListBox.SelectedIndex];
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    subjectPictureBox.Visible = true;
                    subjectPictureBox.LoadAsync(selectedAlbum.PictureAlbumURL);
                    subjectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    subjectPictureBox.Visible = false;
                }
            }
        }

        private void groupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupsListBox.SelectedItems.Count == 1)
            {
                Group selectedGroup = LoggedInUser.Groups[groupsListBox.SelectedIndex];
                if (selectedGroup.PictureNormalURL != null)
                {
                    subjectPictureBox.Visible = true;
                    subjectPictureBox.LoadAsync(selectedGroup.PictureNormalURL);
                    subjectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    subjectPictureBox.Visible = false;
                }
            }
        }

        private void likedPagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (likedPagesListBox.SelectedItems.Count == 1)
            {
                Page selectedLikedPage = LoggedInUser.LikedPages[likedPagesListBox.SelectedIndex];
                if (selectedLikedPage.PictureURL != null)
                {
                    subjectPictureBox.Visible = true;
                    subjectPictureBox.LoadAsync(selectedLikedPage.PictureURL);
                    subjectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    subjectPictureBox.Visible = false;
                }
            }
        }

        protected void postTextBox_Focus(object sender, EventArgs e)
        {
            postTextBox.Text = string.Empty;
            postTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void postTextBox_Leave(object sender, EventArgs e)
        {
            if (postTextBox.Text.Trim() == string.Empty)
            {
                postTextBox.Text = "What do you want to share?";
                postTextBox.ForeColor = System.Drawing.Color.LightGray;
                postButton.Enabled = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            postTextBox.GotFocus += new EventHandler(postTextBox_Focus);
            postTextBox.ForeColor = System.Drawing.Color.LightGray;
            postTextBox.Text = "What do you want to share?";
        }

        private void postTextBox_TextChanged(object sender, EventArgs e)
        {
            postButton.Enabled = true;
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            FormQuiz fromQuiz = new FormQuiz(LoggedInUser);
            fromQuiz.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(m_SearchListBoxToPass.Items);
            formSearch.ShowDialog();
        }
    }
}
